
using DUCore.Models;
using nsio.core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DUCore.Entities;
using AWSWrapper.Services;
using AWSWrapper;
using System.Web;
using OfficeOpenXml;

namespace nsio.core.Repository
{
    public class DashboardServices: IDashboardServices
    {
        NSIOContext context = new NSIOContext();
        public const string  bookId= "58ad88a636442c0300371836";
        public const string apiurl = "https://api.fieldbook.com/v1/";

        public string APIResponse(string sheetname)
        {
            var baseUrl = apiurl + bookId;
            var _resultUrl = string.Format(baseUrl + "/{0}", sheetname);
            var client = new HttpClient { BaseAddress = new Uri(_resultUrl) };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync(_resultUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            else throw new Exception(response.ReasonPhrase);
        }

        public void ClearGroupRoles(string roleId)
        {
            GRole group = context.AspNetRoles.Find(roleId);
            group.Permissions.Clear();
            context.SaveChanges();


            //IQueryable<AspNetUser> groupUsers = context.AspNetUsers.Where(u => u.AspNetRoles.Any(g => g.Id == group.Id));
            //foreach (var perm in group.Permissions)
            //{
            //    int currentPermId = perm.Id;
            //    foreach (ApplicationUser user in groupUsers)
            //    {
            //        // Is the user a member of any other groups with this role?
            //        int groupsWithRole = user.Groups.Count(g => g.Group.Roles.Any(r => r.RoleId == currentRoleId));

            //        // This will be 1 if the current group is the only one:
            //        if (groupsWithRole == 1)
            //        {
            //            RemFromRole(user.Id, role.Role.Name);
            //        }
            //    }
            //}

        }



        public void ClearRolesProjects(string roleId)
        {
            GRole group = context.AspNetRoles.Find(roleId);
            group.Permissions.Clear();
            context.SaveChanges();


            //IQueryable<AspNetUser> groupUsers = context.AspNetUsers.Where(u => u.AspNetRoles.Any(g => g.Id == group.Id));
            //foreach (var perm in group.Permissions)
            //{
            //    int currentPermId = perm.Id;
            //    foreach (ApplicationUser user in groupUsers)
            //    {
            //        // Is the user a member of any other groups with this role?
            //        int groupsWithRole = user.Groups.Count(g => g.Group.Roles.Any(r => r.RoleId == currentRoleId));

            //        // This will be 1 if the current group is the only one:
            //        if (groupsWithRole == 1)
            //        {
            //            RemFromRole(user.Id, role.Role.Name);
            //        }
            //    }
            //}

        }

        public UploadHelper UploadDataFormat(HttpPostedFileBase uploadedFile)
        {
            var uploadHelper = new UploadHelper();
            //Save file to simple storage  service
            IS3Helper _s3Helper = AWSModule.GetInstance().GetIS3HelperService();
            _s3Helper.UploadFileStream(uploadedFile.FileName, uploadedFile.InputStream, uploadedFile.ContentLength, uploadedFile.ContentType);

            return uploadHelper;
        }


        public void downloadFormat (string clusterName)
        {
            var uploadHelper = new UploadHelper();
            IS3Helper _s3Helper = AWSModule.GetInstance().GetIS3HelperService();
            _s3Helper.DownloadFile(clusterName);

        }


        public int[] GetValuedDimension(ExcelWorksheet worksheet)
        {
            var dimension = worksheet.Dimension;
            if (dimension == null) return null;
            var cells = worksheet.Cells[dimension.Address];
            Int32 minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;
            var hasValue = false;
            foreach (var cell in cells.Where(cell => cell.Value != null))
            {
                if (!hasValue)
                {
                    minRow = cell.Start.Row;
                    minCol = cell.Start.Column;
                    maxRow = cell.End.Row;
                    maxCol = cell.End.Column;
                    hasValue = true;
                }
                else
                {
                    if (cell.Start.Column < minCol)
                    {
                        minCol = cell.Start.Column;
                    }
                    if (cell.End.Row > maxRow)
                    {
                        maxRow = cell.End.Row;
                    }
                    if (cell.End.Column > maxCol)
                    {
                        maxCol = cell.End.Column;
                    }
                }
            }
            return hasValue ? new int [4] { minRow, minCol, maxRow, maxCol } : null;
        }
        //public string GetUserRoles()
        //{

        //    return GetUserRoles;
        //}
        //public IList<Projects> GetAllCategoriesByProductId(int productId)
        //{
        //    var query = from category in context.Categories
        //                where category.PoductId == productId
        //                select category;
        //    var content = query.ToList<Category>();
        //    return content;
        //}

        //private IEnumerable<SelectListItem> Products(ProductsetupModel model)
        //{

        //    List<Product> products = new List<Product>();
        //    products = context.Products.ToList();
        //    var list = from s in products
        //               select new SelectListItem
        //               {
        //                   Selected = s.Id.ToString() == model.ProductId.ToString(),
        //                   Text = s.PoductName,
        //                   Value = s.Id.ToString()
        //               };

        //    return list;
        //}

    }

    
}
