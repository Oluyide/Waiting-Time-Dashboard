using FormCore.Models;
using HappinessForm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HappinessForm.Controllers
{

    [AllowAnonymous]
    public class DisplayController : Controller
    {
        private readonly HappinessFormContext _db = new HappinessFormContext();
        // GET: Display
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Display( )
        {
            Response.AppendHeader("Refresh", "60; URL=Display");
            var currentTime = DateTime.Now;
            var day = DateTime.Now.DayOfWeek.ToString();
            var today = day.Substring(0, 3);
            DataTable ResultTable = new DataTable();
            DataTable ResultTable2 = new DataTable();
            DataTable D = new DataTable();
            DataTable o = new DataTable();
            string cnnString = System.Configuration.ConfigurationManager.ConnectionStrings["DisplayContext"].ConnectionString;
           
                SqlConnection cnn = new SqlConnection(cnnString);
                SqlCommand cmd = new SqlCommand("WatingTimeClinincs", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FaciltyID", 6);
                cmd.CommandTimeout = 120;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ResultTable);


                SqlCommand cmd2 = new SqlCommand("RunningClinics", cnn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@FaciltyID", 6);
                cmd2.Parameters.AddWithValue("@Day", today);
                cmd2.CommandTimeout = 120;
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                adapter2.Fill(ResultTable2);

                List<ClinicsModel> model = new List<ClinicsModel>();
            foreach (DataRow dtRow in ResultTable.Rows)
            {

                var r = dtRow["DocSpecialization"].ToString();
                var t = dtRow["TimDiff"].ToString();
               
                var res = dtRow.Table.AsEnumerable().Where(x => ((string)x["DocSpecialization"]) == r ).FirstOrDefault().ItemArray.ToList();
               
                var avgT = dtRow.Table.AsEnumerable().Where(x => ((string)x["DocSpecialization"]) == r && ((DateTime)x["SeenTime"]) >= currentTime.AddMinutes(-80)).Select(x => int.Parse(x.ItemArray[5].ToString())).DefaultIfEmpty().Average();
                foreach (DataRow dtRow2 in ResultTable2.Rows)
                {
                    var appoint = dtRow2.Table.AsEnumerable().Where(x => ((string)x["Specialization"]) == r).LastOrDefault().ItemArray.ToList(); 
                    var clin = new ClinicsModel {EndTime = DateTime.Parse(appoint[7].ToString()).ToString("h:mm tt"), StartTime = DateTime.Parse(appoint[6].ToString()).ToString("h:mm tt"), ClinicsName = res[8].ToString(), AverageTime= Math.Round(avgT,0) };
                    model.Add(clin);
                }

             var query=   model.GroupBy(test => test.ClinicsName)
                   .Select(grp => grp.First())
                   .ToList();

            }
            return View(model.GroupBy(test => test.ClinicsName)
                   .Select(grp => grp.First())
                   .ToList());
        }


        [AllowAnonymous]
        public ActionResult DisplayApapa()
        {
            Response.AppendHeader("Refresh", "1200; URL=DisplayApapa");
            var currentTime = DateTime.Now;
            var day = DateTime.Now.DayOfWeek.ToString();
            var today = day.Substring(0, 3);
            DataTable ResultTable = new DataTable();
            DataTable ResultTable2 = new DataTable();
            DataTable D = new DataTable();
            DataTable o = new DataTable();
            string cnnString = System.Configuration.ConfigurationManager.ConnectionStrings["DisplayContext"].ConnectionString;

            SqlConnection cnn = new SqlConnection(cnnString);
            SqlCommand cmd = new SqlCommand("WatingTimeClinincs", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FaciltyID", 1);
            cmd.CommandTimeout = 120;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ResultTable);


            SqlCommand cmd2 = new SqlCommand("RunningClinics", cnn);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@FaciltyID", 1);
            cmd2.Parameters.AddWithValue("@Day", today);
            cmd2.CommandTimeout = 120;
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            adapter2.Fill(ResultTable2);

            List<ClinicsModel> model = new List<ClinicsModel>();
            foreach (DataRow dtRow in ResultTable.Rows)
            {

                var r = dtRow["DocSpecialization"].ToString();
                var t = dtRow["TimDiff"].ToString();

                var res = dtRow.Table.AsEnumerable().Where(x => ((string)x["DocSpecialization"]) == r).FirstOrDefault().ItemArray.ToList();

                var avgT = dtRow.Table.AsEnumerable().Where(x => ((string)x["DocSpecialization"]) == r && ((DateTime)x["SeenTime"]) >= currentTime.AddMinutes(-80)).Select(x => int.Parse(x.ItemArray[5].ToString())).DefaultIfEmpty().Average();
                foreach (DataRow dtRow2 in ResultTable2.Rows)
                {
                    var appoint = dtRow2.Table.AsEnumerable().Where(x => ((string)x["Specialization"]) == r).LastOrDefault().ItemArray.ToList();
                    var clin = new ClinicsModel { EndTime = DateTime.Parse(appoint[7].ToString()).ToString("h:mm tt"), StartTime = DateTime.Parse(appoint[6].ToString()).ToString("h:mm tt"), ClinicsName = res[8].ToString(), AverageTime = Math.Round(avgT, 0) };
                    model.Add(clin);
                }

                var query = model.GroupBy(test => test.ClinicsName)
                      .Select(grp => grp.First())
                      .ToList();

            }
            return View(model.GroupBy(test => test.ClinicsName)
                   .Select(grp => grp.First())
                   .ToList());
        }

        [AllowAnonymous]
        public ActionResult DisplayIkeja()
        {
            Response.AppendHeader("Refresh", "1200; URL=DisplayIkeja");
            var currentTime = DateTime.Now;
            var day = DateTime.Now.DayOfWeek.ToString();
            var today = day.Substring(0, 3);
            DataTable ResultTable = new DataTable();
            DataTable ResultTable2 = new DataTable();
            DataTable D = new DataTable();
            DataTable o = new DataTable();
            string cnnString = System.Configuration.ConfigurationManager.ConnectionStrings["DisplayContext"].ConnectionString;

            SqlConnection cnn = new SqlConnection(cnnString);
            SqlCommand cmd = new SqlCommand("WatingTimeClinincs", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FaciltyID", 3);
            cmd.CommandTimeout = 120;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ResultTable);


            SqlCommand cmd2 = new SqlCommand("RunningClinics", cnn);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@FaciltyID", 3);
            cmd2.Parameters.AddWithValue("@Day", today);
            cmd2.CommandTimeout = 120;
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            adapter2.Fill(ResultTable2);

            List<ClinicsModel> model = new List<ClinicsModel>();
            foreach (DataRow dtRow in ResultTable.Rows)
            {

                var r = dtRow["DocSpecialization"].ToString();
                var t = dtRow["TimDiff"].ToString();

                var res = dtRow.Table.AsEnumerable().Where(x => ((string)x["DocSpecialization"]) == r).FirstOrDefault().ItemArray.ToList();

                var avgT = dtRow.Table.AsEnumerable().Where(x => ((string)x["DocSpecialization"]) == r && ((DateTime)x["SeenTime"]) >= currentTime.AddMinutes(-80)).Select(x => int.Parse(x.ItemArray[5].ToString())).DefaultIfEmpty().Average();
                foreach (DataRow dtRow2 in ResultTable2.Rows)
                {
                    var appoint = dtRow2.Table.AsEnumerable().Where(x => ((string)x["Specialization"]) == r).LastOrDefault().ItemArray.ToList();
                    var clin = new ClinicsModel { EndTime = DateTime.Parse(appoint[7].ToString()).ToString("h:mm tt"), StartTime = DateTime.Parse(appoint[6].ToString()).ToString("h:mm tt"), ClinicsName = res[8].ToString(), AverageTime = Math.Round(avgT, 0) };
                    model.Add(clin);
                }

                var query = model.GroupBy(test => test.ClinicsName)
                      .Select(grp => grp.First())
                      .ToList();

            }
            return View(model.GroupBy(test => test.ClinicsName)
                   .Select(grp => grp.First())
                   .ToList());
        }


        [AllowAnonymous]
        public ActionResult DisplayIdejo()
        {
            Response.AppendHeader("Refresh", "1200; URL=DisplayIdejo");
            var currentTime = DateTime.Now;
            var day = DateTime.Now.DayOfWeek.ToString();
            var today = day.Substring(0, 3);
            DataTable ResultTable = new DataTable();
            DataTable ResultTable2 = new DataTable();
            DataTable D = new DataTable();
            DataTable o = new DataTable();
            string cnnString = System.Configuration.ConfigurationManager.ConnectionStrings["DisplayContext"].ConnectionString;

            SqlConnection cnn = new SqlConnection(cnnString);
            SqlCommand cmd = new SqlCommand("WatingTimeClinincs", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FaciltyID", 4);
            cmd.CommandTimeout = 120;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ResultTable);


            SqlCommand cmd2 = new SqlCommand("RunningClinics", cnn);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@FaciltyID", 4);
            cmd2.Parameters.AddWithValue("@Day", today);
            cmd2.CommandTimeout = 120;
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            adapter2.Fill(ResultTable2);

            List<ClinicsModel> model = new List<ClinicsModel>();
            foreach (DataRow dtRow in ResultTable.Rows)
            {

                var r = dtRow["DocSpecialization"].ToString();
                var t = dtRow["TimDiff"].ToString();

                var res = dtRow.Table.AsEnumerable().Where(x => ((string)x["DocSpecialization"]) == r).FirstOrDefault().ItemArray.ToList();

                var avgT = dtRow.Table.AsEnumerable().Where(x => ((string)x["DocSpecialization"]) == r && ((DateTime)x["SeenTime"]) >= currentTime.AddMinutes(-80)).Select(x => int.Parse(x.ItemArray[5].ToString())).DefaultIfEmpty().Average();
                foreach (DataRow dtRow2 in ResultTable2.Rows)
                {
                    var appoint = dtRow2.Table.AsEnumerable().Where(x => ((string)x["Specialization"]) == r).LastOrDefault().ItemArray.ToList();
                    var clin = new ClinicsModel { EndTime = DateTime.Parse(appoint[7].ToString()).ToString("h:mm tt"), StartTime = DateTime.Parse(appoint[6].ToString()).ToString("h:mm tt"), ClinicsName = res[8].ToString(), AverageTime = Math.Round(avgT, 0) };
                    model.Add(clin);
                }

                var query = model.GroupBy(test => test.ClinicsName)
                      .Select(grp => grp.First())
                      .ToList();

            }
            return View(model.GroupBy(test => test.ClinicsName)
                   .Select(grp => grp.First())
                   .ToList());
        }

        [AllowAnonymous]
        public ActionResult DisplayLSS()
        {
            Response.AppendHeader("Refresh", "1200; URL=DisplayLSS");
            var currentTime = DateTime.Now;
            var day = DateTime.Now.DayOfWeek.ToString();
            var today = day.Substring(0, 3);
            DataTable ResultTable = new DataTable();
            DataTable ResultTable2 = new DataTable();
            DataTable D = new DataTable();
            DataTable o = new DataTable();
            string cnnString = System.Configuration.ConfigurationManager.ConnectionStrings["DisplayContext"].ConnectionString;

            SqlConnection cnn = new SqlConnection(cnnString);
            SqlCommand cmd = new SqlCommand("WatingTimeClinincs", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FaciltyID", 5);
            cmd.CommandTimeout = 120;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ResultTable);


            SqlCommand cmd2 = new SqlCommand("RunningClinics", cnn);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@FaciltyID", 5);
            cmd2.Parameters.AddWithValue("@Day", today);
            cmd2.CommandTimeout = 120;
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            adapter2.Fill(ResultTable2);

            List<ClinicsModel> model = new List<ClinicsModel>();
            foreach (DataRow dtRow in ResultTable.Rows)
            {

                var r = dtRow["DocSpecialization"].ToString();
                var t = dtRow["TimDiff"].ToString();

                var res = dtRow.Table.AsEnumerable().Where(x => ((string)x["DocSpecialization"]) == r).FirstOrDefault().ItemArray.ToList();

                var avgT = dtRow.Table.AsEnumerable().Where(x => ((string)x["DocSpecialization"]) == r && ((DateTime)x["SeenTime"]) >= currentTime.AddMinutes(-80)).Select(x => int.Parse(x.ItemArray[5].ToString())).DefaultIfEmpty().Average();
                foreach (DataRow dtRow2 in ResultTable2.Rows)
                {
                    var appoint = dtRow2.Table.AsEnumerable().Where(x => ((string)x["Specialization"]) == r).LastOrDefault().ItemArray.ToList();
                    var clin = new ClinicsModel { EndTime = DateTime.Parse(appoint[7].ToString()).ToString("h:mm tt"), StartTime = DateTime.Parse(appoint[6].ToString()).ToString("h:mm tt"), ClinicsName = res[8].ToString(), AverageTime = Math.Round(avgT, 0) };
                    model.Add(clin);
                }

                var query = model.GroupBy(test => test.ClinicsName)
                      .Select(grp => grp.First())
                      .ToList();

            }
            return View(model.GroupBy(test => test.ClinicsName)
                   .Select(grp => grp.First())
                   .ToList());
        }

        // GET: Display/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Display/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Display/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Display/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Display/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Display/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Display/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
