using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr74_scrum_app.Model
{
    public class UserStory
    {
        private int id;
        private string name;
        private string description;
        private int complexity;
        private string state;
        private List<Comment> comments;

        public UserStory(int id, string name, string state) 
        {
            comments = new List<Comment>();
            this.id = id;
            this.name = name;
            this.state = state;
        }
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Complexity { get { return complexity; } set { complexity = value; } }
        public string State { get { return state; } set { state = value; } }    
        public string Description { get { return description; } set { description = value; } }
        public List<Comment> Comments { get { return comments; } set { comments = value; } }
        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }
        // TODO: code dupliquer à revoir 
        public void RemoveComment(int commentId)
        {
            int commentIndexToDelete = 0;
            bool found = false;
            for (int i = 0; i < comments.Count; i++)
            {
                if (commentId == comments[i].Id)
                {
                    found = true;
                    commentIndexToDelete = i;
                }
            }
            if (found)
            {
                comments.RemoveAt(commentIndexToDelete);
            }
            else
            {
                // TODO: add err
            }
        }
    }
}
