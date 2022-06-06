using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr74_scrum_app.Model
{
    public class ProductBacklog : Backlog
    {
        private Project project;
        public ProductBacklog(int id, Project project) : base(id)
        {
            this.project = project;
        }
        public Project Project { get { return project; } }
    }
}
