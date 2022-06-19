using System;
using System.Collections.Generic;
namespace pr74_scrum_app.Model
{
    public abstract class Backlog
    {
        private int id;
        private List<UserStory> userStories;

        public Backlog(int id)
        {
            userStories = new List<UserStory>();
            this.id = id;
        }
        public Backlog() 
        {
            userStories = new List<UserStory>();
        }

        public int Id { get { return id; } set { id = value; } }
        public List<UserStory> UserStories { get { return userStories; } set { userStories = value; } }
        public void AddUserStory(UserStory userStory)
        {
            userStories.Add(userStory);
        }
        public void RemoveUserStory(UserStory userStory)
        {
            userStories.Remove(userStory);
        }
        public void RemoveUserStoryById(int id)
        {
            userStories.Remove(new UserStory(id, "", ""));
        }
    }
}
