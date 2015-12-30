using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Models {
    public class Car {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public int Mileage { get; set; }
        public string Image { get; set; }
        public int HueRotation { get; set; }
    }
}