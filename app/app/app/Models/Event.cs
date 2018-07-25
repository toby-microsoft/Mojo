using System;
using System.Collections.Generic;
using System.Text;

namespace app.Models
{
    class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }

        public Event() { }
        public Event(string Title, string Details)
        {
            this.Title = Title;
            this.Details = Details;
        }
    }
}
