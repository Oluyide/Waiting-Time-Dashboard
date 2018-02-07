using FormCore.Models;
using FormCore.Services;
using HappinessForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HappinessForm.Controllers
{


    //[Authorize]
    public class HomeController : Controller
    {
        private readonly HappinessFormContext _db = new HappinessFormContext();

        [HttpGet]
        public ActionResult Switching()
        {
            SwitchingModel model = new SwitchingModel();

            model.AvailableForms.Add(new SelectListItem { Text = "Select Form", Value = "0" });
            model.AvailableForms.Add(new SelectListItem { Text = "Out Patients", Value = "1" });
            model.AvailableForms.Add(new SelectListItem { Text = "In Patients", Value = "2" });
            model.AvailableForms.Add(new SelectListItem { Text = "Clinics Dashboard Settings", Value = "3" });

            return View(model);
        }


        public ActionResult Navigation()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Switching(SwitchingModel model)
        {
          var patient = "";
          if(model!=null)
            {
                if(model.Forms==1)
                {
                    patient = "Index";
                }

                if (model.Forms == 2)
                {
                    patient = "InPat";
                }
                if (model.Forms == 3)
                {
                    patient = "ManageAppointment";
                }
                else if(model.Forms==0)
                {
                    patient = "Switching";
                    TempData["Pat"] = "Please Select the patient's visit Type";
                }
            }
            
            return RedirectToAction(patient);
        }

        [HttpGet]
        public ActionResult Index()
        {
            PatientResponseModel model =new  PatientResponseModel();
            model.DateOfVisit = DateTime.Today;


            model.RecommendList.Add(new SelectListItem { Text = "Please-Rate", Value = "-1" });
            model.RecommendList.Add(new SelectListItem { Text = "Yes", Value = "1" });
            model.RecommendList.Add(new SelectListItem { Text = "No", Value = "0" });

            model.AppointAbilityList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AppointAbilityList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AppointAbilityList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AppointAbilityList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AppointAbilityList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AppointAbilityList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.AppointConvenienceList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AppointConvenienceList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AppointConvenienceList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AppointConvenienceList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AppointConvenienceList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AppointConvenienceList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.AppointCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AppointCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AppointCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AppointCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AppointCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AppointCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.BillAbiltiyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.BillAbiltiyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.BillAbiltiyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.BillAbiltiyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.BillAbiltiyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.BillAbiltiyList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.BillCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.BillCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.BillCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.BillCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.BillCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.BillCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.BillTimeList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.BillTimeList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.BillTimeList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.BillTimeList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.BillTimeList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.BillTimeList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.DocCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DocCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DocCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DocCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DocCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DocCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.DocExplanationList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DocExplanationList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DocExplanationList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DocExplanationList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DocExplanationList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DocExplanationList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.DocResponseList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DocResponseList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DocResponseList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DocResponseList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DocResponseList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DocResponseList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.DocWaitingList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DocWaitingList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DocWaitingList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DocWaitingList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DocWaitingList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DocWaitingList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.LabAbilityList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.LabAbilityList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.LabAbilityList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.LabAbilityList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.LabAbilityList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.LabAbilityList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.LabCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.LabCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.LabCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.LabCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.LabCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.LabCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.LabWaitingList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.LabWaitingList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.LabWaitingList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.LabWaitingList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.LabWaitingList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.LabWaitingList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.OverallEaseList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.OverallHowList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OverallHowList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OverallHowList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OverallHowList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OverallHowList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OverallHowList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.OverallWereList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OverallWereList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OverallWereList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OverallWereList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OverallWereList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OverallWereList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.pharmAvailList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.pharmAvailList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.pharmAvailList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.pharmAvailList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.pharmAvailList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.pharmAvailList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.PharmCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.PharmCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.PharmCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.PharmCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.PharmCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.PharmCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.PharmWaitingList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.PharmWaitingList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.PharmWaitingList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.PharmWaitingList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.PharmWaitingList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.PharmWaitingList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.RadCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.RadCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.RadCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.RadCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.RadCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.RadCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.RadExplanationList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.RadExplanationList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.RadExplanationList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.RadExplanationList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.RadExplanationList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.RadExplanationList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.RadInfoList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.RadInfoList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.RadInfoList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.RadInfoList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.RadInfoList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.RadInfoList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.RadTimelinessList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.RadTimelinessList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.RadTimelinessList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.RadTimelinessList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.RadTimelinessList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.RadTimelinessList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.RadWaitingList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.RadWaitingList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.RadWaitingList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.RadWaitingList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.RadWaitingList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.RadWaitingList.Add(new SelectListItem { Text = "Poor", Value = "1" });



            return View(model);
        }

        

        [HttpPost]
        public ActionResult Index(PatientResponseModel model)
        {

            Happiness form = new Happiness();
            if (model != null)
            {
                form.AppointAbility = model.AppointAbility;
                form.AppointConvenience = model.AppointConvenience;
                form.AppointCourtesy = model.AppointCourtesy;
                form.BestStaff = model.BestStaff;
                form.BillAbiltiy = model.BillAbiltiy;
                form.BillCourtesy = model.BillCourtesy;
                form.BillTime = model.BillTime;
                form.Comment = model.Comment;
                form.ContactNumber = model.ContactNumber;
                form.DataCollectionDate = DateTime.Now;
                form.DateOfVisit = model.DateOfVisit;
                form.DocCourtesy = model.DocCourtesy;
                form.DocExplanation = model.DocExplanation;
                form.DocResponse = model.DocResponse;
                form.DocWaiting = model.DocWaiting;
                form.LabAbility = model.LabAbility;
                form.LabCourtesy = model.LabCourtesy;
                form.LabWaiting = model.LabWaiting;
                form.Name = model.Name;
                form.OverallEase = model.OverallEase;
                form.OverallHow = model.OverallHow;
                form.OverallWere = model.OverallWere;
                form.pharmAvail = model.pharmAvail;
                form.PharmCourtesy = model.PharmCourtesy;
                form.PharmWaiting = model.PharmWaiting;
                form.RadCourtesy = model.RadCourtesy;
                form.RadExplanation = model.RadExplanation;
                form.RadInfo = model.RadInfo;
                form.RadTimeliness = model.RadTimeliness;
                form.RadWaiting = model.RadWaiting;
                form.FormTypeID = 1;
                _db.Happinesses.Add(form);
                _db.SaveChanges();

            }


            model.AppointAbilityList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AppointAbilityList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AppointAbilityList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AppointAbilityList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AppointAbilityList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AppointAbilityList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.AppointConvenienceList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AppointConvenienceList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AppointConvenienceList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AppointConvenienceList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AppointConvenienceList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AppointConvenienceList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.AppointCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AppointCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AppointCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AppointCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AppointCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AppointCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.BillAbiltiyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.BillAbiltiyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.BillAbiltiyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.BillAbiltiyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.BillAbiltiyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.BillAbiltiyList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.BillCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.BillCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.BillCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.BillCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.BillCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.BillCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.BillTimeList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.BillTimeList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.BillTimeList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.BillTimeList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.BillTimeList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.BillTimeList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.DocCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DocCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DocCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DocCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DocCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DocCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.DocExplanationList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DocExplanationList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DocExplanationList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DocExplanationList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DocExplanationList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DocExplanationList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.DocResponseList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DocResponseList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DocResponseList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DocResponseList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DocResponseList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DocResponseList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.DocWaitingList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DocWaitingList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DocWaitingList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DocWaitingList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DocWaitingList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DocWaitingList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.LabAbilityList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.LabAbilityList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.LabAbilityList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.LabAbilityList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.LabAbilityList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.LabAbilityList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.LabCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.LabCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.LabCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.LabCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.LabCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.LabCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.LabWaitingList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.LabWaitingList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.LabWaitingList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.LabWaitingList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.LabWaitingList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.LabWaitingList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.OverallEaseList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.OverallHowList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OverallHowList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OverallHowList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OverallHowList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OverallHowList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OverallHowList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.OverallWereList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OverallWereList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OverallWereList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OverallWereList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OverallWereList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OverallWereList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.pharmAvailList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.pharmAvailList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.pharmAvailList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.pharmAvailList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.pharmAvailList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.pharmAvailList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.PharmCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.PharmCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.PharmCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.PharmCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.PharmCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.PharmCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.PharmWaitingList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.PharmWaitingList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.PharmWaitingList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.PharmWaitingList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.PharmWaitingList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.PharmWaitingList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.RadCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.RadCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.RadCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.RadCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.RadCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.RadCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.RadExplanationList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.RadExplanationList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.RadExplanationList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.RadExplanationList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.RadExplanationList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.RadExplanationList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.RadInfoList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.RadInfoList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.RadInfoList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.RadInfoList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.RadInfoList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.RadInfoList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.RadTimelinessList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.RadTimelinessList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.RadTimelinessList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.RadTimelinessList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.RadTimelinessList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.RadTimelinessList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.RadWaitingList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.RadWaitingList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.RadWaitingList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.RadWaitingList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.RadWaitingList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.RadWaitingList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            return View(model);

        }



        [HttpGet]
        public ActionResult InPat()
        {
            PatientResponseModel model = new PatientResponseModel();
            model.DateOfVisit = DateTime.Today;


            model.EmergencyContactList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.EmergencyContactList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.EmergencyContactList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.EmergencyContactList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.EmergencyContactList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.EmergencyContactList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.EmergencyImmediateList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.EmergencyImmediateList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.EmergencyImmediateList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.EmergencyImmediateList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.EmergencyImmediateList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.EmergencyImmediateList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.EmergencyOverallList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.EmergencyOverallList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.EmergencyOverallList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.EmergencyOverallList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.EmergencyOverallList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.EmergencyOverallList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.EmergencyLagoonList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.EmergencyLagoonList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.EmergencyLagoonList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.EmergencyLagoonList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.EmergencyLagoonList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.EmergencyLagoonList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.AdmissionExplanationList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AdmissionExplanationList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AdmissionExplanationList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AdmissionExplanationList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AdmissionExplanationList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AdmissionExplanationList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.AdmissionQualityList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AdmissionQualityList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AdmissionQualityList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AdmissionQualityList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AdmissionQualityList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AdmissionQualityList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.AdmissionCounsellingList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AdmissionCounsellingList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AdmissionCounsellingList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AdmissionCounsellingList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AdmissionCounsellingList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AdmissionCounsellingList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.AdmissionCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AdmissionCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AdmissionCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AdmissionCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AdmissionCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AdmissionCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.DischargeEODList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DischargeEODList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DischargeEODList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DischargeEODList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DischargeEODList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DischargeEODList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.DischargeETDList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DischargeETDList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DischargeETDList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DischargeETDList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DischargeETDList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DischargeETDList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.DischargeTimeTPAList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DischargeTimeTPAList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DischargeTimeTPAList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DischargeTimeTPAList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DischargeTimeTPAList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DischargeTimeTPAList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.DsichargeTimelinessList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DsichargeTimelinessList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DsichargeTimelinessList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DsichargeTimelinessList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DsichargeTimelinessList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DsichargeTimelinessList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.InPatDocAttentivenessList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.InPatDocAttentivenessList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.InPatDocAttentivenessList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.InPatDocAttentivenessList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.InPatDocAttentivenessList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.InPatDocAttentivenessList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.InPatInvolmentList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.InPatInvolmentList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.InPatInvolmentList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.InPatInvolmentList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.InPatInvolmentList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.InPatInvolmentList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.InPatDocExplanationList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.InPatDocExplanationList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.InPatDocExplanationList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.InPatDocExplanationList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.InPatDocExplanationList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.InPatDocExplanationList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.InPatDocRegVisitList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.InPatDocRegVisitList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.InPatDocRegVisitList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.InPatDocRegVisitList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.InPatDocRegVisitList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.InPatDocRegVisitList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.InPatDocCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.InPatDocCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.InPatDocCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.InPatDocCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.InPatDocCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.InPatDocCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.NursingTimelinessList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.NursingTimelinessList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.NursingTimelinessList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.NursingTimelinessList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.NursingTimelinessList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.NursingTimelinessList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.NursingInfoList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.NursingInfoList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.NursingInfoList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.NursingInfoList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.NursingInfoList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.NursingInfoList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.NursingQualityList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.NursingQualityList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.NursingQualityList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.NursingQualityList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.NursingQualityList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.NursingQualityList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.NursingCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.NursingCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.NursingCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.NursingCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.NursingCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.NursingCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });



            model.AccoCleaninessList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AccoCleaninessList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AccoCleaninessList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AccoCleaninessList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AccoCleaninessList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AccoCleaninessList.Add(new SelectListItem { Text = "Poor", Value = "1" });



            model.AccoBehaviourList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AccoBehaviourList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AccoBehaviourList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AccoBehaviourList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AccoBehaviourList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AccoBehaviourList.Add(new SelectListItem { Text = "Poor", Value = "1" });




            model.OpPunctualityList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OpPunctualityList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OpPunctualityList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OpPunctualityList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OpPunctualityList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OpPunctualityList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.OpTimelinessList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OpTimelinessList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OpTimelinessList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OpTimelinessList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OpTimelinessList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OpTimelinessList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.OpCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OpCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OpCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OpCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OpCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OpCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.ICUAttentiveList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.ICUAttentiveList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.ICUAttentiveList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.ICUAttentiveList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.ICUAttentiveList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.ICUAttentiveList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.ICUTimelinessList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.ICUTimelinessList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.ICUTimelinessList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.ICUTimelinessList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.ICUTimelinessList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.ICUTimelinessList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.ICUExpalnationList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.ICUExpalnationList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.ICUExpalnationList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.ICUExpalnationList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.ICUExpalnationList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.ICUExpalnationList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.OverallEaseList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.OverallHowList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OverallHowList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OverallHowList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OverallHowList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OverallHowList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OverallHowList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.OverallWereList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OverallWereList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OverallWereList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OverallWereList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OverallWereList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OverallWereList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.RecommendList.Add(new SelectListItem { Text = "Please-Rate", Value = "-1" });
            model.RecommendList.Add(new SelectListItem { Text = "Yes", Value = "1" });
            model.RecommendList.Add(new SelectListItem { Text = "No", Value = "0" });

            return View(model);
        }



        [HttpPost]
        public ActionResult InPat(PatientResponseModel model)
        {

            Happiness form = new Happiness();
            if (model != null)
            {
                form.AccoBehaviour = model.AccoBehaviour;
                form.AccoCleaniness = model.AccoCleaniness;
                form.AdmissionCounselling = model.AdmissionCounselling;
                form.AdmissionCourtesy = model.AdmissionCourtesy;
                form.AdmissionExplanation = model.AdmissionExplanation;
                form.AdmissionQuality = model.AdmissionQuality;
                form.AdmittingDoctor = model.AdmittingDoctor;
                form.DataCollectionDate = DateTime.Now;
                form.Comment = model.Comment;
                form.ContactNumber = model.ContactNumber;
                form.DateOfVisit = model.DateOfVisit;
                form.DischargeEOD = model.DischargeEOD;
                form.DischargeETD = model.DischargeETD;
                form.DischargeTimeTPA = model.DischargeTimeTPA;
                form.DsichargeTimeliness = model.DsichargeTimeliness;
                form.FormTypeID = 2;
                form.ICUAttentive = model.ICUAttentive;
                form.ICUExpalnation = model.ICUExpalnation;
                form.ICUTimeliness = model.ICUTimeliness;
                form.InPatDocAttentiveness = model.InPatDocAttentiveness;
                form.InPatDocCourtesy = model.InPatDocCourtesy;
                form.InPatDocExplanation = model.InPatDocExplanation;
                form.InPatDocRegVisit = model.InPatDocRegVisit;
                form.InPatInvolment = model.InPatInvolment;
                form.IsRecommend = model.Recommend;
                form.NursingCourtesy = model.NursingCourtesy;
                form.NursingInfo = model.NursingInfo;
                form.NursingQuality = model.NursingQuality;
                form.NursingTimeliness = model.NursingTimeliness;
                form.OpCourtesy = model.OpCourtesy;
                form.OpPunctuality = model.OpPunctuality;
                form.OpTimeliness = model.OpTimeliness;
                form.RoomNumber = model.RoomNumber;
               
                form.Name = model.Name;
                form.OverallEase = model.OverallEase;
                form.OverallHow = model.OverallHow;
                form.OverallWere = model.OverallWere;
                

                _db.Happinesses.Add(form);
                _db.SaveChanges();

            }

            model.DateOfVisit = DateTime.Today;


            model.EmergencyContactList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.EmergencyContactList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.EmergencyContactList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.EmergencyContactList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.EmergencyContactList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.EmergencyContactList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.EmergencyImmediateList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.EmergencyImmediateList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.EmergencyImmediateList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.EmergencyImmediateList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.EmergencyImmediateList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.EmergencyImmediateList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.EmergencyOverallList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.EmergencyOverallList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.EmergencyOverallList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.EmergencyOverallList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.EmergencyOverallList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.EmergencyOverallList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.EmergencyLagoonList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.EmergencyLagoonList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.EmergencyLagoonList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.EmergencyLagoonList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.EmergencyLagoonList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.EmergencyLagoonList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.AdmissionExplanationList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AdmissionExplanationList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AdmissionExplanationList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AdmissionExplanationList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AdmissionExplanationList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AdmissionExplanationList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.AdmissionQualityList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AdmissionQualityList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AdmissionQualityList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AdmissionQualityList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AdmissionQualityList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AdmissionQualityList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.AdmissionCounsellingList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AdmissionCounsellingList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AdmissionCounsellingList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AdmissionCounsellingList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AdmissionCounsellingList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AdmissionCounsellingList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.AdmissionCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AdmissionCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AdmissionCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AdmissionCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AdmissionCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AdmissionCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.DischargeEODList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DischargeEODList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DischargeEODList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DischargeEODList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DischargeEODList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DischargeEODList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.DischargeETDList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DischargeETDList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DischargeETDList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DischargeETDList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DischargeETDList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DischargeETDList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.DischargeTimeTPAList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DischargeTimeTPAList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DischargeTimeTPAList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DischargeTimeTPAList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DischargeTimeTPAList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DischargeTimeTPAList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.DsichargeTimelinessList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.DsichargeTimelinessList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.DsichargeTimelinessList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.DsichargeTimelinessList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.DsichargeTimelinessList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.DsichargeTimelinessList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.InPatDocAttentivenessList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.InPatDocAttentivenessList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.InPatDocAttentivenessList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.InPatDocAttentivenessList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.InPatDocAttentivenessList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.InPatDocAttentivenessList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.InPatInvolmentList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.InPatInvolmentList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.InPatInvolmentList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.InPatInvolmentList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.InPatInvolmentList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.InPatInvolmentList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.InPatDocExplanationList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.InPatDocExplanationList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.InPatDocExplanationList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.InPatDocExplanationList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.InPatDocExplanationList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.InPatDocExplanationList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.InPatDocRegVisitList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.InPatDocRegVisitList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.InPatDocRegVisitList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.InPatDocRegVisitList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.InPatDocRegVisitList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.InPatDocRegVisitList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.InPatDocCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.InPatDocCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.InPatDocCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.InPatDocCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.InPatDocCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.InPatDocCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.NursingTimelinessList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.NursingTimelinessList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.NursingTimelinessList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.NursingTimelinessList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.NursingTimelinessList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.NursingTimelinessList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.NursingInfoList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.NursingInfoList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.NursingInfoList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.NursingInfoList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.NursingInfoList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.NursingInfoList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.NursingQualityList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.NursingQualityList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.NursingQualityList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.NursingQualityList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.NursingQualityList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.NursingQualityList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.NursingCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.NursingCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.NursingCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.NursingCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.NursingCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.NursingCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });



            model.AccoCleaninessList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AccoCleaninessList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AccoCleaninessList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AccoCleaninessList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AccoCleaninessList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AccoCleaninessList.Add(new SelectListItem { Text = "Poor", Value = "1" });



            model.AccoBehaviourList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.AccoBehaviourList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.AccoBehaviourList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.AccoBehaviourList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.AccoBehaviourList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.AccoBehaviourList.Add(new SelectListItem { Text = "Poor", Value = "1" });




            model.OpPunctualityList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OpPunctualityList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OpPunctualityList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OpPunctualityList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OpPunctualityList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OpPunctualityList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.OpTimelinessList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OpTimelinessList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OpTimelinessList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OpTimelinessList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OpTimelinessList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OpTimelinessList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.OpCourtesyList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OpCourtesyList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OpCourtesyList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OpCourtesyList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OpCourtesyList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OpCourtesyList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.ICUAttentiveList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.ICUAttentiveList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.ICUAttentiveList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.ICUAttentiveList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.ICUAttentiveList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.ICUAttentiveList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.ICUTimelinessList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.ICUTimelinessList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.ICUTimelinessList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.ICUTimelinessList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.ICUTimelinessList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.ICUTimelinessList.Add(new SelectListItem { Text = "Poor", Value = "1" });


            model.ICUExpalnationList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.ICUExpalnationList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.ICUExpalnationList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.ICUExpalnationList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.ICUExpalnationList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.ICUExpalnationList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.OverallEaseList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OverallEaseList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.OverallHowList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OverallHowList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OverallHowList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OverallHowList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OverallHowList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OverallHowList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.OverallWereList.Add(new SelectListItem { Text = "Please-Rate", Value = "0" });
            model.OverallWereList.Add(new SelectListItem { Text = "Excellent", Value = "5" });
            model.OverallWereList.Add(new SelectListItem { Text = "Very Good", Value = "4" });
            model.OverallWereList.Add(new SelectListItem { Text = "Good", Value = "3" });
            model.OverallWereList.Add(new SelectListItem { Text = "Fair", Value = "2" });
            model.OverallWereList.Add(new SelectListItem { Text = "Poor", Value = "1" });

            model.RecommendList.Add(new SelectListItem { Text = "Please-Rate", Value = "-1" });
            model.RecommendList.Add(new SelectListItem { Text = "Yes", Value = "1" });
            model.RecommendList.Add(new SelectListItem { Text = "No", Value = "0" });



            return View(model);

        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult ManageAppointment()
        {
         
            List<SelectListItem> listSelectListItems = new List<SelectListItem>();
            List<SelectListItem> listDays = new List<SelectListItem>();

            foreach (var clinic in _db.Specializations)
            {
                SelectListItem selectList = new SelectListItem()
                {
                    Text = clinic.Name,
                    Value = clinic.ID.ToString(),
                    //Selected = clinic.IsSelected
                };
                listSelectListItems.Add(selectList);
            }

            foreach(var days in _db.Days)
            {
                SelectListItem selectList = new SelectListItem()
                {
                    Text = days.Days,
                    Value = days.Id.ToString(),
                    //Selected = clinic.IsSelected
                };
                listDays.Add(selectList);
            }

            ManageModel ViewModel = new ManageModel()
            {
                Specializations = listSelectListItems,
                Days= listDays
            };

            return View(ViewModel);
        }

        [HttpPost]
        public ActionResult ManageAppointment(ManageModel model)
        {
            DisplayAppointment appoint = new DisplayAppointment();
            try
            {
                foreach (var item in model.Specialization)
                {

                    appoint.ClinicId = int.Parse(item);
                    appoint.DayID = int.Parse(model.Day);
                    appoint.DoctorID = 1;
                    appoint.EndAppointmentDate = model.EndTime;
                    appoint.StartAppointmentTime = model.StartTime;
                    _db.DisplayAppointments.Add(appoint);
                    _db.SaveChanges();
                }
                TempData["tr"] = "Successfull Saved";
            }
            catch
            {

            }


            List<SelectListItem> listSelectListItems = new List<SelectListItem>();
            List<SelectListItem> listDays = new List<SelectListItem>();

            foreach (var clinic in _db.Specializations)
            {
                SelectListItem selectList = new SelectListItem()
                {
                    Text = clinic.Name,
                    Value = clinic.ID.ToString(),
                    //Selected = clinic.IsSelected
                };
                listSelectListItems.Add(selectList);
            }

            foreach (var days in _db.Days)
            {
                SelectListItem selectList = new SelectListItem()
                {
                    Text = days.Days,
                    Value = days.Id.ToString(),
                    //Selected = clinic.IsSelected
                };
                listDays.Add(selectList);
            }

            ManageModel ViewModel = new ManageModel()
            {
                Specializations = listSelectListItems,
                Days = listDays
            };




            return View(ViewModel);
        }


        public ActionResult AppointmentTable()
        {

            return View();
        }
       
        
    }




}