using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.User
{
    public class UserEducation
    {
        [Required]
        public Guid ID { get; set; }
        [Required]
        public Guid UserID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Institution { get; set; }
        [Required]
        public int PassingYear { get; set; }
        [Required]
        public string Grade { get; set; }
        [Required]
        string Board { get; set; }
    }
}
