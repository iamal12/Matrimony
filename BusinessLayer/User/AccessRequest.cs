using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.User
{
    public class AccessRequest
    {
        public Guid ID { get; set; }
        public AccessType Type { get; set; }
        public Guid RequestByID { get; set; }
        public Guid RequestToID { get; set; }
        public AccessRequestStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ApprovedOn { get; set; }
    }
}
