using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RideWizz.Utilities {
    public static class VeryComplexMathEngine {

        public static int Clamp(int i, int min, int max) {
            return i < min ? 0 : i > max ? max : i;
        }

        public static int RoundToNearestThousand (int i) {
            // make sure i is between 0 and the highest thousand value possible
            i = Clamp(i, 0, (int.MaxValue / 1000) * 1000);
            
            // round to nearest thousand... doesn't work due to "round to even"
            //i = (int)(Math.Round((double)i / 1000) * 1000);
            
            // so let's do our own rounding
            var thousands = (double)i / 1000;
            var fractionOfThousands = thousands % 1.0;
            var roundedThousands = fractionOfThousands >= 0.5 ? Math.Ceiling(thousands) : Math.Floor(thousands);
            i = (int)roundedThousands * 1000;
            return i;
        }
    }
}