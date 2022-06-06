using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace pr74_scrum_app.Model
{
    public class Project
    {
        private int id;
        private string name;     
        private string description;
        private bool is_archived;
        private List<Member> members;
        private List<Sprint> sprints;
        private ProductBacklog backlog;

        public Project(int id, string name)
        {
            members = new List<Member>();
            this.id = id;
            this.name = name;
        }
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }   
        public string Description { get { return description; } set { description = value; } }
        public bool IsArchived { get { return is_archived; } set { is_archived = value; } }
        public List<Member> Members { get { return members; } set { members = value; } }
        public List<Sprint> Sprints { get { return sprints; } set { sprints = value; } }
        public ProductBacklog Backlog { get { return backlog; } set { backlog = value; } }
        public void AddMember(Member member)
        {
            members.Add(member);
        }
        // TODO: code dupliquer à revoir 
        public void RemoveMember(int memberId)
        {
            int memberIndexToDelete = 0;
            bool found = false;
            for (int i = 0; i < members.Count; i++)
            {
                if(memberId == members[i].Id)
                {
                    found = true;
                    memberIndexToDelete = i;
                }
            }
            if (found)
            {
                members.RemoveAt(memberIndexToDelete);
            }
            else
            {
                // TODO: add err
            }
        }

        public void AddSprint(Sprint sprint)
        {
            sprints.Add(sprint);
        }
        // TODO: code dupliquer à revoir 
        public void RemoveSprint(int Id)
        {
            int indexToDelete = 0;
            bool found = false;
            for (int i = 0; i < sprints.Count; i++)
            {
                if (Id == sprints[i].Id)
                {
                    found = true;
                    indexToDelete = i;
                }
            }
            if (found)
            {
                sprints.RemoveAt(indexToDelete);
            }
            else
            {
                // TODO: add err
            }
        }
    }
}
