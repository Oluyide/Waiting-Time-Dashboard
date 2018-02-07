using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCore.Entities
{
    public class UploadHelper
    {
       
            public int SuccessfulUploads { get; set; }
            public int FailedUploads { get; set; }
            public int UpdatedUploads { get; set; }
            public List<string> ErrorMsgs { get; set; }
       
    }
}
