using System;
using System.Collections.Generic;
using System.Text;

namespace app.Models
{
    class Group
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public List<User> Members { get; set; }

        public Group() { }
        public Group(string Title, string Details, List<User> Members)
        {
            this.Title = Title;
            this.Details = Details;
            this.Members = Members;
        }

        public void AddMember(User user)
        {
            this.Members.Add(user);
        }
    }
}
