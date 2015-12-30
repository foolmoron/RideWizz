using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Repositories;
using RideWizz.Models;

namespace RideWizz.Controllers {
    public class CarsController : Controller {

        public ActionResult Index() {
            var model = new CarsOutputModel {
                AllCars = new CarRepository().GetAll()
            };
            return View(model);
        }
    }
}