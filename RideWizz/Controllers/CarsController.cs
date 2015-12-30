using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Repositories;
using RideWizz.Models;

namespace RideWizz.Controllers {
    public class CarsController : Controller {

        readonly ICarRepository carRepository;

        public CarsController(ICarRepository carRepository) {
            this.carRepository = carRepository;
        }

        public ActionResult Index() {
            var model = new CarsOutputModel {
                AllCars = carRepository.GetAll()
            };
            return View(model);
        }
    }
}