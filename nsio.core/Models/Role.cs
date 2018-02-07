using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DUCore.Models
{
    //public partial class AspNetUser: ide
    [Table("AspNetRoles")]
    public partial class GRole : IdentityRole
    {
        public GRole()
        {
            this.AspNetUsers = new List<AppUser>();
            this.Permissions = new List<Permission>();
        }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string RoleDescription { get; set; }
        public string Discriminator { get; set; }
        
        public bool IsActive { get; set; }
        public virtual ProjectCluster ProjectCluster { get; set; }

        public virtual ICollection<AppUser> AspNetUsers { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
