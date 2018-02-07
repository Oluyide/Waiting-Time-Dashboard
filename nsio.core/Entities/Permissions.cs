using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCore.Entities
{
    public class Permissions
    {
        public enum Permission
        {
            CanCreateUsers,
            CanUploadData,
            CanViewDashboard
        }
    }
}
