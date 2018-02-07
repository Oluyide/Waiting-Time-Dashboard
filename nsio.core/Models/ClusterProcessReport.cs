using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCore.Models
{
    public class ClusterProcessReport:BaseEntity
    {
        public ClusterProcessReport()
        {
            this.ClusterProcessReportEntries = new List<ClusterProcessReportEntry>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public virtual ClusterProcessReportType ClusterProcessReportType { get; set; }
        public virtual ICollection<ClusterProcessReportEntry> ClusterProcessReportEntries { get; set; }
    }
}
