using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCore.Models
{
     public class ProjectClusterType
    {

        public ProjectClusterType()
        {
            this.ProjectCluster = new List<ProjectCluster>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProjectCluster> ProjectCluster { get; set; }
       

    }
}
