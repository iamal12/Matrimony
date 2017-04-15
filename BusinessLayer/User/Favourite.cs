using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.User
{
    public class Favourite
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public Guid FavouriteID { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
