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

        public int Id { get { return id; } set { id = value; } }
        public List<UserStory> UserStories { get { return userStories; } set { userStories = value; } }
        public void AddUserStory(UserStory userStory)
        {
            userStories.Add(userStory);
        }
        // TODO: code dupliquer à revoir 
        public void RemoveUserStory(int commentId)
        {
            int userStoryIndexToDelete = 0;
            bool found = false;

            for (int i = 0; i < userStories.Count; i++)
            {
                if (commentId == userStories[i].Id)
                {
                    found = true;
                    userStoryIndexToDelete = i;
                }
            }
            if (found)
            {
                userStories.RemoveAt(userStoryIndexToDelete);
            }
            else
            {
                // TODO: add err
            }
        }
    }
}
