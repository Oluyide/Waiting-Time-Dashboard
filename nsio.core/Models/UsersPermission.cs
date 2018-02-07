using System;
using System.Collections.Generic;

namespace DUCore.Models
{
    public partial class UsersPermission
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int PermissionsId { get; set; }
        public virtual UsersPermission UsersPermission1 { get; set; }
        public virtual UsersPermission UsersPermission2 { get; set; }
    }
}
