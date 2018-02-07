using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCore.Models
{
    public class ApplicationPermissionRole
    {
        public virtual string permissionId { get; set; }
        public virtual int RoleId { get; set; }

        public virtual Permission Perm { get; set; }
        public virtual GRole Role { get; set; }
    }


}
