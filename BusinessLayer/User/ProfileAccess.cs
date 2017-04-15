using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.User
{
    public class ProfileAccess
    {
        [Required]
        public Guid ID { get; set; }
        [Required]
        public AccessType Type { get; set; }
        [Required]
        public Guid RequestByID { get; set; }
        [Required]
        public Guid RequestToID { get; set; }
        [Required]
        public AccessStatus Status { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public DateTime ApprovedOn { get; set; }
    }
}
