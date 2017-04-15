using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.User
{
    public class Block
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public Guid BlockID { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
