using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr74_scrum_app.Model
{
    public class Sprint : IEquatable<Sprint>
    {
        private int id;
        private string name;
        private DateTime startingDate;
        private DateTime endingDate;
        private Project project;

        public Sprint(int id, string name, DateTime startingDate, DateTime endingDate, Project project)
        {
            this.id = id;
            this.name = name;
            this.startingDate = startingDate;
            this.endingDate = endingDate;
            this.project = project;
        }
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public DateTime StartingDate { get { return startingDate; } set { startingDate = value; } }
        public DateTime EndingDate { get { return endingDate; } set { endingDate = value; } } 
        public Project Project { get { return project; } }

        public bool Equals(Sprint other)
        {
            return id == other.id;
        }
    }
}
