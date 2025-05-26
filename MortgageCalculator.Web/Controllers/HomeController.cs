using MortgageCalculator.Dto;
using MortgageCalculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MortgageCalculator.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMortgageService _service;
        

        public HomeController(IMortgageService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {

            var mortgages = _service.GetActiveMortgages();
            var mortgageTypes = _service.GetMortgageTypes();
            ViewBag.MortgageTypes = new SelectList(mortgageTypes);
            return View(mortgages);
        }

        public ActionResult MortgageCalculator()
        {

            var mortgages = _service.GetActiveMortgages();
            var mortgageTypes = _service.GetMortgageTypes();
            var repaymentTypes = _service.GetRepaymentTypes();
            ViewBag.MortgageTypes = new SelectList(mortgageTypes);
            ViewBag.RepaymentTypes = new SelectList(repaymentTypes);
            return View(mortgages);
        }


        //get mortgage values by its type
        public JsonResult GetMortgagesByType(string mortgageType)
        {
            var mortgages = _service.GetActiveMortgagesByType(mortgageType);

            return Json(mortgages, JsonRequestBehavior.AllowGet);
        }

        //get the interestrate by name and type
        public ActionResult GetInterestRateByNameAndType(int mortgageId, string mortgageType)
        {
            var rate = _service.GetInterestRateByNameAndType(mortgageId,mortgageType); 
            return Json(rate, JsonRequestBehavior.AllowGet);
        }


        //calculate the mortgage value
        [HttpPost]
        public JsonResult CalculateMortgage(Mortgage request)
        {

            var calculatedResult = _service.CalculateMortgage(request);


            return Json(new
            {
                MonthlyPayment = calculatedResult.MonthlyPayment.ToString(),
                TotalRepayment = calculatedResult.TotalRepayment.ToString(),
                TotalInterest = calculatedResult.TotalInterest.ToString()
            });
        }

        //calculate the mortgage value
        [HttpPost]
        public string MonthWiseEMICalculator(Mortgage request)
        {

            var calculatedResult = _service.MonthWiseEMICalculator(request);
            return calculatedResult.ToString();
        }

        //get the emi split by id
        public JsonResult GetMonthlyEmiDetailsById(int mortgageId)
        {
            var monthlyemilist = _service.GetMonthlyEmiDetailsById(mortgageId);
            return Json(monthlyemilist, JsonRequestBehavior.AllowGet);
        }
        



    }

}