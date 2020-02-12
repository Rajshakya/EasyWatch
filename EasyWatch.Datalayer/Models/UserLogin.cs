using System;
using System.Collections.Generic;

namespace EasyWatch.Datalayer.Models
{
    public partial class UserLogin
    {
        public long UserLoginId { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? CreatedBy { get; set; }
        public long? ModifiedBy { get; set; }
    }
}
