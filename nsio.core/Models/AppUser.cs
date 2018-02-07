using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DUCore.Models
{
    [Table("AspNetUsers")]
    public class AppUser : IdentityUser
    {
       
        public AppUser()
        {
            this.AspNetUserClaims = new List<UserClaim>();
            this.AspNetUserLogins = new List<AspNetUserLogin>();
            this.AspNetRoles = new List<GRole>();
        }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        //public string Id { get; set; }
        //public string Email { get; set; }
        //public bool EmailConfirmed { get; set; }
        //public string PasswordHash { get; set; }
        //public string SecurityStamp { get; set; }
        //public string PhoneNumber { get; set; }
        //public bool PhoneNumberConfirmed { get; set; }
        //public bool TwoFactorEnabled { get; set; }
        //public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        //public bool LockoutEnabled { get; set; }
        //public int AccessFailedCount { get; set; }
        //public string UserName { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Gender { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                var UserName = LastName + " " + FirstName;
                return UserName;
            }
        }


        public DateTime DateCreated { get; set; }
        public virtual string UserCreatedBy { get; set; }
        public virtual DateTime DateModified { get; set; }

        public virtual bool IsActive { get; set; }

        public virtual ICollection<UserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<GRole> AspNetRoles { get; set; }
    }
}
