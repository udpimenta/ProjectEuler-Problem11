using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Problem11.UI.WebApplicationMVC.Controllers
{
    public class CalcOpentextController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcOpenText(string Grid)
        {
            if (string.IsNullOrEmpty(Grid))
            {
                TempData["ErrorMessage2"] = "Insira um valor na grid";
                return RedirectToAction("Index");
            }

            try
            {
                var result = new EulerBusiness.Problem11().Calc(Grid);
                TempData["Result2"] = string.Format("O maior resultado com 4 entradas é {0}", result);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage2"] = string.Format("Ocorreu um erro ao calcular resultado: {0}" + ex.Message);
            }

            return RedirectToAction("Index");
        }
	}
}