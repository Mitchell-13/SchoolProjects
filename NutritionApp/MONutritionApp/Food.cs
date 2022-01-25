using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MONutritionApp
{
    public class Food
    {
        public string foodName { get; set; }
        public string calcium { get ; set;}
        public string servingSize { get ; set;}
        public string weight { get ; set;}
        public string percentWater { get ; set;}
        public string calories { get ; set;}
        public string protein { get ; set;}
        public string carbs { get ; set;}
        public string fiber { get ; set;}
        public string cholesterol { get ; set;}
        public string totalFat { get ; set;}
        public string satFat { get ; set;}
        public string monoSatFat { get ; set;}
        public string polyFat { get ; set;}
        public string iron { get ; set;}
        public string mag { get ; set;}
        public string sodium { get ; set;}
        public string phos { get ; set;}
        public string cap { get ; set;}
        public string pot { get ; set;}
        public string zinc { get ; set;}
        public string niacin { get ; set;}
        public string thiamin { get ; set;}
        public string riboflavin { get ; set;}
        public string va { get ; set;}
        public string vb6 { get ; set;}
        public string vc { get ; set;}
        public string foodType { get ; set;}

        public Food(string[] currentFood)
        {
            foodName = currentFood[0];
            calcium = currentFood[1];
            servingSize = currentFood[2];
            weight = currentFood [3];
            percentWater = currentFood [4];
            calories = currentFood [5];
            protein = currentFood [6];
            carbs = currentFood [7];
            fiber = currentFood [8];
            cholesterol = currentFood [9];
            totalFat = currentFood [10];
            satFat = currentFood [11];
            monoSatFat = currentFood [12];
            polyFat = currentFood [13];
            iron = currentFood [14];
            mag = currentFood [15];
            sodium = currentFood [16];
            phos = currentFood [17];
            cap = currentFood [18];
            pot = currentFood [19];
            zinc = currentFood [20];
            niacin = currentFood [21];
            thiamin = currentFood [22];
            riboflavin = currentFood [23];
            va = currentFood [24];
            vb6 = currentFood [25];
            vc = currentFood [26];
            foodType = currentFood [27];
                
        }
    }
}
