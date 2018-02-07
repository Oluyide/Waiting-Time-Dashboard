using DUCore.Entities;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace nsio.core.Interface
{
    public interface IDashboardServices
    {
         string APIResponse(string sheetname);
        void ClearGroupRoles(string roleId);
        void ClearRolesProjects(string roleId);
        UploadHelper UploadDataFormat(HttpPostedFileBase uploadedFile);
        void downloadFormat(string clusterName);
        int[] GetValuedDimension(ExcelWorksheet worksheet);
    }
}
