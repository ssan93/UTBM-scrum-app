using MySql.Data.MySqlClient;
using pr74_scrum_app.Model;
using System;

namespace pr74_scrum_app.Controller
{
    class SprintController : Controller
    {
        public SprintController() : base() {}
        public Sprint FetchSprintById(int id)
        {
            Sprint sprint = null;
            MySqlDataReader dr = db.ExecutQuery($"select * from sprint where id={id}");
            if (dr.HasRows){
                while (dr.Read())
                {
                    string name = (string)dr["name"];
                    DateTime startDate = (DateTime)dr["startDate"];
                    DateTime endDate = (DateTime)dr["endDate"];
                    sprint = new Sprint(id, name, startDate, endDate);
                }
            }
            dr.Close();

            if(sprint != null)
                sprint.Backlog = FetchSprintBacklogById(id);

            return sprint;
        }
        public SprintBacklog FetchSprintBacklogById(int sprintId)
        {
            SprintBacklog sprintBacklog = new SprintBacklog();
            UserStoryController usc = new UserStoryController();
            sprintBacklog.UserStories=usc.FetchUserStoriesBySprintId(sprintId);

            return sprintBacklog;
        }
        public bool PersistSprint(Sprint sprint, int projectId)
        {
            // TODO initiat transaction [Begin, Commit, Rollback]

            // persister les informations de base du sprint 
            string sql = $"" +
                $"INSERT INTO userstory " +
                $"VALUES ({sprint.Id}, '{sprint.Name}', '{sprint.StartingDate}',{sprint.EndingDate},{projectId}) " +
                $"ON DUPLICATE KEY " +
                $"UPDATE name = '{sprint.Name}', startDate = '{sprint.StartingDate}', endDate = {sprint.EndingDate} ; ";
            MySqlDataReader dr = db.ExecutQuery(sql);
            if (dr.RecordsAffected < 0)
            {
                dr.Close();
                return false; // TODO replace by rollback
            }

            dr.Close();

            UserStoryController usc = new UserStoryController();
            // persister les userStories
            foreach (UserStory userStory in sprint.Backlog.UserStories)
            {
                bool ok = usc.PersistUserStoryWithSprintId(userStory, sprint.Id, projectId);
                if (!ok) return false;// TODO replace by rollback
            }
                
            return true;
        }

    }
}
