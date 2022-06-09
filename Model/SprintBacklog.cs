using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr74_scrum_app.Model
{
    public class SprintBacklog : Backlog
    {
        private Sprint sprint;
        public SprintBacklog(int id, Sprint sprint) : base(id)
        {
            this.sprint = sprint;
        }
        public Sprint Sprint { get { return sprint; } }
    }
}
