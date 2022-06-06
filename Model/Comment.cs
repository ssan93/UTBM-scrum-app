using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr74_scrum_app.Model
{
    public class Comment
    {
        private int id;
        private string content;
        private DateTime date;
        private Member member;
        private UserStory userStory;

        public Comment(int id, string content,Member member, UserStory userStory ) {
            this.id = id;
            this.content = content;
            this.member = member;
            this.userStory = userStory;
            date = DateTime.Now;
        
        }
        public int Id { get { return id; } set { id = value; } }
        public string Content { get { return content; } set { content = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        public Member ByMember { get { return member; } set { member = value; } }
        public UserStory UserStory { get { return userStory; } set { userStory = value; } }
    }
}
