using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DUCore.Models
{
    public partial class ClusterProcessReportEntry
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual ClusterProcessReport ClusterProcessReport { get; set; }
      
        public virtual ClusterProcessReportFieldType ClusterProcessReportFieldType { get; set; }
        public virtual string FieldValue { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual DateTime? DateModified { get; set; }
       
    }
}
