using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DUCore.Models
{
    public partial class ClusterProcessReportFieldType
    {
        public ClusterProcessReportFieldType()
        {
            this.ClusterProcessReportEntries = new List<ClusterProcessReportEntry>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Fieldlabel { get; set; }
        public string Hook { get; set; }
        public string dataType { get; set; }
        public int OrderNumber { get; set; }
        public bool Required { get; set; }
        public virtual DataTypeTable DataTypeTable { get; set; }
        
        public virtual ClusterProcessReportType ClusterProcessReportType { get; set; }
        public virtual ICollection<ClusterProcessReportEntry> ClusterProcessReportEntries { get; set; }
        public virtual ClusterReportFieldCategory ClusterReportFieldCategory { get; set; }
    }
}
