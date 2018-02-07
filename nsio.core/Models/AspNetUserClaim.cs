using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DUCore.Models
{
    [Table("AspNetUserClaim")]
    public partial class UserClaim:IdentityUserClaim
    {
        //public int Id { get; set; }
        //public string UserId { get; set; }
        //public string ClaimType { get; set; }
        //public string ClaimValue { get; set; }
        public virtual AppUser AspNetUser { get; set; }
    }
}
