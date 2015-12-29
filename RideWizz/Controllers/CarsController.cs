using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Repositories;

namespace RideWizz.Controllers {
    public class CarsController : Controller {

        public ActionResult Index() {
            var cars = new CarRepository().GetAll();
            return View();
        }
    }
}