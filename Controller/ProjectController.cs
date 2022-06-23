using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr74_scrum_app
{
    internal class ProjectController
    {
        private readonly Database db = new Database();

        private void AddMember(int projectId, string userEmail, string role)
        {
            if (userEmail != string.Empty)
            {
                int userId = GetUserIdByEmail(userEmail);

                string sql = $"select * from users where id='" + userId + "'";
                MySqlDataReader dataRequest = db.ExecutQuery(sql);

                if (dataRequest != null && dataRequest.HasRows) 
                {
                    dataRequest.Close();

                    sql = $"insert into Member(Project_id, role, user_id) values ('{projectId}','{role}','{userId}')";

                    dataRequest = db.ExecutQuery(sql);
                    dataRequest.Close();
                }
            }
        }

        private bool emailExists(string email)
        {
            bool exists;

            string sql = $"select * from users where email='" + email +"'"; 
            MySqlDataReader dataRequest = db.ExecutQuery(sql);

            exists = dataRequest != null && dataRequest.HasRows;
            dataRequest.Close();

            return exists;
        }

        private int GetUserIdByEmail(string email)
        {
            int userId = -1;

            string sql = $"select id from users where email='" + email + "'"; 
            MySqlDataReader dataRequest = db.ExecutQuery(sql);
            while (dataRequest.Read())
            {
                userId = (int)dataRequest["id"];
            }
            dataRequest.Close();
            
            return userId;
        }

        private User GetUserById(int userId)
        {
            User user = null;

            string sql = $"select * from users where id='"+ userId + "'";
            MySqlDataReader dataRequest = db.ExecutQuery(sql);

            if (dataRequest.HasRows)
            {
                while (dataRequest.Read())
                {
                    int id = (int)dataRequest["id"];
                    string firstName = (string)dataRequest["id"];
                    string lastName = (string)dataRequest["id"];
                    string email = (string)dataRequest["id"];

                    user = new User(id, firstName, lastName, "", email);
                }
            }
            dataRequest.Close();
            return user;
        }

        private void RemoveMember(Model.Project project, int memberId)
        {
            string sql = $"select id from Member where id='" + memberId + "'";
            MySqlDataReader dataRequest = db.ExecutQuery(sql);

            if (dataRequest.HasRows)
            {
                project.RemoveMemberById(memberId);
                dataRequest.Close();

                sql = $"delete from member where id='" + memberId + "'";
                dataRequest = db.ExecutQuery(sql);
                dataRequest.Close();
            }
            // TODO : commit db changes ?
        }

        private Model.Project GetProjectById(int projectId)
        {
            string sql = $"select * from Project where id='" + projectId + "'";
            MySqlDataReader dataRequest = db.ExecutQuery(sql);

            Model.Project project = null;
            if (dataRequest.HasRows)
            {
                while (dataRequest.Read())
                {
                    int id = (int)dataRequest["id"];
                    string name = (string)dataRequest["name"];
                    string description = (string)dataRequest["description"];
                    bool is_archived = (bool)dataRequest["archived"];

                    project = new Model.Project(id, name, description);
                    project.IsArchived = is_archived;
                }
                dataRequest.Close();

                List<Model.Member> members = GetMembers(projectId);
                List<Model.Sprint> sprints = GetSprints(projectId);
                Model.ProductBacklog productBacklog = GetProductBacklog(projectId);

                project.Members = members;
                project.Sprints = sprints;
                project.Backlog = productBacklog;
            }

            dataRequest.Close();
            return project;
        }

        private Model.ProductBacklog GetProductBacklog(int projectId)
        {
            Model.ProductBacklog backlog = null;
            // TODO copier coller getSprintBacklog de walid
            string sql = $"select * from "; // TODO ???? where is backlog into database scheme ?
            MySqlDataReader dr = db.ExecutQuery(sql);

            return backlog;
        }

        private List<Model.Sprint> GetSprints(int projectId)
        {
            List<Model.Sprint> list = new List<Model.Sprint>();

            string sql = $""; // TODO select des id des sprints du projetID

            MySqlDataReader dr = db.ExecutQuery(sql);
            // TODO se baser sur le sprint controller pour gagner du temps (walid)
            // tant qu'il y a un id de sprint a traiter, sprintController.getSprintByID
                // ajouter sprint dans liste
            return list;
        }
        
        private List<Model.Member> GetMembers(int projectId)           
        {
            List<Model.Member> list = new List<Model.Member>();
            
            string sql = $""; // TODO
            MySqlDataReader dataRequest = db.ExecutQuery(sql); // pour chaque membre, retourner le nom, le role, l'id du membre (pas du user)
            if (dataRequest.HasRows)
            {
                while (dataRequest.Read())
                {
                    int id = (int)dataRequest["id"];
                    string role = (string)dataRequest["role"];
                    int userId = (int)dataRequest["user_id"];
                    User user = GetUserById(userId);

                    Model.Member currentMember = new Model.Member(id, role, user);

                    list.Add(currentMember);
                }
            }
            dataRequest.Close();

            return list;
        }

    }  

}
