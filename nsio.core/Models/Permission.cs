using System;
using System.Collections.Generic;

namespace DUCore.Models
{
    public partial class Permission
    {
        public Permission()
        {
            this.AspNetRoles = new List<GRole>();
        }

        public int Id { get; set; }
        public string Permissions { get; set; }
        public string PermissionsName { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<GRole> AspNetRoles { get; set; }
    }
}
