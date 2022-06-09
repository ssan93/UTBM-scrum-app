using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr74_scrum_app.Model
{
    public class UserStory : IEquatable<UserStory>
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
        public bool Equals(UserStory other)
        {
            return id == other.id;
        }

        public void RemoveComment(Comment comment)
        {
            comments.Remove(comment);
        }
        public void RemoveCommentById(int id)
        {
            comments.Remove(new Comment(id, "", null));
        }
    }
}
