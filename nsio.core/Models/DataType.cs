using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCore.Models
{
    public class DataTypeTable
    {

        public DataTypeTable()
        {
            this.ClusterProcessReportFieldTypes = new List<ClusterProcessReportFieldType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ClusterProcessReportFieldType> ClusterProcessReportFieldTypes { get; set; }
      
    }
}
