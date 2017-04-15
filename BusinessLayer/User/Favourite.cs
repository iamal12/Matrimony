using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.User
{
    public class Favourite
    {
        [Required]
        public Guid ID { get; set; }
        [Required]
        public Guid UserID { get; set; }
        [Required]
        public Guid FavouriteID { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
