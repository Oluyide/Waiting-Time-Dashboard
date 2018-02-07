using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCore.Models
{
    public class BaseEntity
    {

        public DateTime DateCreated { get; set; }
        public virtual string SubmittedBy { get; set; }
        public virtual DateTime DateModified { get; set; }

        public virtual string ModifiedBy { get; set; }

    }
        
}
