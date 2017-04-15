using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.User
{
    public class UserEducation
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public string Title { get; set; }
        public string Institution { get; set; }
        public int PassingYear { get; set; }
        public string Grade { get; set; }
        public string Board { get; set; }
    }
}
