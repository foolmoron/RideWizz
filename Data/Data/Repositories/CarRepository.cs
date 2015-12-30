using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Models;

namespace Data.Repositories {
    public interface ICarRepository {
        IEnumerable<Car> GetAll(int count);
    }
    public class CarRepository : ICarRepository {

        static readonly int YEAR_MIN = 1950;
        static readonly int YEAR_MAX = 2016;
        static readonly string[] MAKES = { "Toyota", "Honda", "Fiat", "Volkswagen", "Tesla", "Ford" };
        static readonly string[] MODELS = { "Super", "Crazy", "Regular", "Black", "Potato", "Whatever" };
        static readonly int PRICE_MIN = 10000;
        static readonly int PRICE_MAX = 150000;
        static readonly int MILEAGE_MIN = 100;
        static readonly int MILEAGE_MAX = 1100000;
        static readonly string[] IMAGES = { "car1.jpg", "car2.png", "car3.jpg", "car4.jpg" };

        public IEnumerable<Car> GetAll(int count = 10) {
            // could read from a file
            // or query a database
            // or make a web request

            // but we'll just generate some random data for now
            var r = new Random();
            for (var i = 0; i < count; i++) {
                yield return new Car {
                    Year = r.Next(YEAR_MIN, YEAR_MAX),
                    Make = MAKES[r.Next(MAKES.Length - 1)],
                    Model = MODELS[r.Next(MODELS.Length - 1)],
                    Price = r.Next(PRICE_MIN, PRICE_MAX),
                    Mileage = r.Next(MILEAGE_MIN, MILEAGE_MAX),
                    Image = IMAGES[r.Next(IMAGES.Length - 1)],
                    HueRotation = r.Next(0, 360),
                };
            }
        }
    }
}