using MySql.Data.MySqlClient;
using pr74_scrum_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr74_scrum_app.Controller
{
    class UserStoryController : Controller
    {
        public UserStoryController(): base() {}
        public List<UserStory> FetchUserStoriesBySprintId(int sprintId)
        {
            List<UserStory> userStories = new List<UserStory>();
            // Fetching the userStories basic infos
            MySqlDataReader dr = db.ExecutQuery($"select * from userstory where sprint_id={sprintId}");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int id = (int)dr["id"];
                    string name = (string)dr["name"];
                    string description = (string)dr["description"];
                    int complexity = (int)dr["complexity"];
                    int priotity = (int)dr["priority"];
                    string state = (string)dr["state"];
                    UserStory userStory = new UserStory(id, name, state);
                    userStory.Priority = priotity;
                    userStory.Complexity = complexity;
                    userStory.Description = description;
                    userStories.Add(userStory);
                }
            }
            dr.Close();

            foreach (UserStory userStory in userStories)
            {
                // Fetching userStories comments
                userStory.Comments = FetchUserStoryComments(userStory.Id);

                // Fetching userStories assignees
                userStory.Assignees = FetchUserStoryAssignees(userStory.Id);
            }

            return userStories;
        }
        public List<Comment> FetchUserStoryComments(int userStoryId)
        {
            List<Comment> comments = new List<Comment>();
            string sql = $"" +
                $"SELECT usm.id as comment_id, usm.description, date, m.id as member_id, m.role, users.id as user_id, users.lastname, users.firstname " +
                $"FROM userstorycomment usm, member m, users " +
                $"WHERE userstory_id={userStoryId} and member_id=m.id and users.id = m.user_id;";
            MySqlDataReader dr = db.ExecutQuery(sql);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int memberId = (int)dr["member_id"];
                    int commentId = (int)dr["comment_id"];
                    int userId = (int)dr["user_id"];
                    string description = (string)dr["description"];
                    string role = (string)dr["role"];
                    string lastname = (string)dr["lastname"];
                    string firstname = (string)dr["firstname"];
                    DateTime date = (DateTime)dr["date"];

                    User user = new User(userId);
                    user.FirstName = firstname; user.LastName = lastname;

                    Member member = new Member(memberId, role, user);

                    Comment comment = new Comment(commentId, description, member);
                    comment.Date = date;

                    comments.Add(comment);
                }
            }
            dr.Close();
            return comments;
        }
        public List<Member> FetchUserStoryAssignees(int userStoryId)
        {
            List<Member> assignees = new List<Member>();
            MySqlDataReader dr = db.ExecutQuery($"" +
                $"SELECT member_id, role, user_id, lastname,firstname " +
                $"FROM {ASSIGNEES_TABLE} usm, {MEMBERS_TABLE} m, users " +
                $"WHERE usm.userstory_id={userStoryId} and usm.member_id =m.id and m.user_id= users.id;");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int memberId = (int)dr["member_id"];
                    int userId = (int)dr["user_id"];
                    string role = (string)dr["role"];
                    string lastname = (string)dr["lastname"];
                    string firstname = (string)dr["firstname"];

                    User user = new User(userId);
                    user.FirstName = firstname; user.LastName = lastname;

                    Member member = new Member(memberId, role, user);

                    assignees.Add(member);
                }
            }
            dr.Close();
            return assignees;
        }
        public bool PersistUserStoryWithSprintId(UserStory userStory, int sprintId, int projectId)
        {
            if (userStory.Id < 1)
            {
                userStory.Id = GenerateNewId(USER_STORIES_TABLE);
                if (userStory.Id < 1) return false; // TODO RollBack
            }

            // basics
            string sql = $"" +
                $"INSERT INTO {USER_STORIES_TABLE} " +
                $"VALUES ({userStory.Id}, '{userStory.Name}', '{userStory.Description}',{userStory.Complexity},{userStory.Priority}, {sprintId}, {projectId}) " +
                $"ON DUPLICATE KEY " +
                $"UPDATE description = '{userStory.Description}', name = '{userStory.Name}', complexity = {userStory.Complexity}, priority = {userStory.Priority}, sprint_id={sprintId}, project_id={projectId} ; ";
            MySqlDataReader dr = db.ExecutQuery(sql);
            if (dr.RecordsAffected < 0)
            {
                dr.Close();
                return false; // TODO replace by rollback
            }

            dr.Close();

            // assignements 
            bool ok = PersistAssignees(userStory.Assignees, userStory.Id);
            if (!ok) return false;// TODO replace by rollback

            // comments
            foreach (Comment c in userStory.Comments)
            {
                ok = PersistComment(c, userStory.Id);
                if (!ok) return false;// TODO replace by rollback
            }

            return true;
        }
        public bool PersistComment(Comment comment, int userStoryId)
        {
            if (comment.Id < 1)
            {
                comment.Id = GenerateNewId(COMMENTS_TABLE);
                if (comment.Id < 1) return false; // TODO RollBack
            }

            string sql = $"" +
                $"INSERT INTO {COMMENTS_TABLE} " +
                $"VALUES ({comment.Id}, '{comment.Content}', '{comment.Date}',{comment.ByMember.Id},{userStoryId}) " +
                $"ON DUPLICATE KEY " +
                $"UPDATE description = '{comment.Content}', date = '{comment.Date}';";
            MySqlDataReader dr = db.ExecutQuery(sql);
            if (dr.RecordsAffected < 0) return false; // TODO replace by rollback
            dr.Close();

            return true;
        }
        public bool PersistAssignees(List<Member> members, int userstoryId)
        {
            MySqlDataReader dr = db.ExecutQuery($"DELETE FROM {ASSIGNEES_TABLE} WHERE userstory_id={userstoryId};");
            if (dr.RecordsAffected <= 0)
            {
                dr.Close();
                return false; // TODO replace by rollback
            }
            dr.Close();

            foreach (Member member in members)
            {
                dr = db.ExecutQuery($"INSERT INTO {ASSIGNEES_TABLE} (member_id,userstory_id) VALUES ({member.Id}, {userstoryId});");
                if (dr.RecordsAffected <= 0) return false; // TODO replace by rollback
                dr.Close();
            }

            return true;
        }

        public bool UpdateState(UserStory userStory)
        {
            MySqlDataReader dr = db.ExecutQuery($"UPDATE {USER_STORIES_TABLE} SET state={userStory.State} WHERE id={userStory.Id};");
            dr.Close();
            return (dr.RecordsAffected > 0);
        }
    }
}
