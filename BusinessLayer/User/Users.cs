using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.User
{
    public class Users
    {
        //Personal Details
        [Required]
        public Guid ID { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Mobile { get; set; }
        public string GuardianMobile { get; set; }
        //Family details
        public string FatherName { get; set; }
        public string FatherProfession { get; set; }
        public string FatherContact { get; set; }
        public string MotherName { get; set; }
        public string MotherProfession { get; set; }
        public string MotherContact { get; set; }
        //About
        [Required]
        public string Height { get; set; }
        public string About { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        //Address
        public string PermanentDistrict { get; set; }
        public string PermanentAddress { get; set; }
        public string PresentDistrict { get; set; }
        public string PresentAddress { get; set; }
        //Account details
        [Required]
        public UserStatus Status { get; set; }
        [Required]
        public UserType Type { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public UserRole Role { get; set; }

        public List<UserEducation> Education { get; set; }
    }
}
