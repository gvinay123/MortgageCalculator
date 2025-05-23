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
        public JsonResult CalculateMortgage(MortgageCalculationRequest request)
        {

            var calculatedResult = _service.CalculateMortgage(request);


            return Json(new
            {
                MonthlyPayment = calculatedResult.MonthlyPayment.ToString(),
                TotalRepayment = calculatedResult.TotalRepayment.ToString(),
                TotalInterest = calculatedResult.TotalInterest.ToString()
            });




        }

    }

}