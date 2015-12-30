using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Data.Repositories;
using RideWizz.Models;
using RideWizz.Utilities;

namespace RideWizz.Controllers {
    public class CarsController : Controller {

        readonly ICarRepository carRepository;

        public CarsController(ICarRepository carRepository) {
            this.carRepository = carRepository;
        }

        public ActionResult Index() {
            var allCars = carRepository.GetAll();
            var allCarsRoundedMileage = allCars.Select(car => {
                car.Mileage = VeryComplexMathEngine.RoundToNearestThousand(car.Mileage);
                return car;
            });
            var model = new CarsOutputModel {
                AllCars = allCarsRoundedMileage
            };
            return View(model);
        }
    }
}