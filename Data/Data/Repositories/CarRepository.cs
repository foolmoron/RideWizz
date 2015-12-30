﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.Models;

namespace Data.Repositories {
    public interface ICarRepository {
        IEnumerable<Car> GetAll();
    }
    public class CarRepository : ICarRepository {

        static readonly int YEAR_MIN = 1950;
        static readonly int YEAR_MAX = 2016;
        static readonly string[] MAKES = { "Toyota", "Honda", "Fiat", "Volkswagen", "Tesla", "Ford" };
        static readonly string[] MODELS = { "Super", "Crazy", "Regular", "Black", "Potato", "Whatever" };
        static readonly int PRICE_MIN = 10000;
        static readonly int PRICE_MAX = 100000;
        static readonly int MILEAGE_MIN = 100;
        static readonly int MILEAGE_MAX = 999999999;

        public IEnumerable<Car> GetAll() {
            // could read from a file
            // or query a database
            // or make a web request

            // but we'll just generate some random data for now
            const int COUNT = 30;
            var r = new Random();
            for (var i = 0; i < COUNT; i++) {
                yield return new Car {
                    Year = r.Next(YEAR_MIN, YEAR_MAX),
                    Make = MAKES[r.Next(MAKES.Length - 1)],
                    Model = MODELS[r.Next(MODELS.Length - 1)],
                    Price = r.Next(PRICE_MIN, PRICE_MAX),
                    Mileage = r.Next(MILEAGE_MIN, MILEAGE_MAX),
                };
            }
        }
    }
}