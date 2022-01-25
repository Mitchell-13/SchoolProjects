//Name: (Mitchell Ogden)
//Class: (INFO 1200)
//Section: (X02)
//Professor: (Crandall)
//Date: (4/28/2021)
//Project #:(9)
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.
using System;
using System.Collections.Generic;
using System.Text;

namespace MOFitnessApp
{
    public class FoodItem
    {
        public string Category { get; set; }
        public string FoodName { get; set; }
        public string Measurement { get; set; }
        public int Calories { get; set; }

        public FoodItem(string[] foodArray)
        {
            Category = foodArray[0];
            FoodName = foodArray[1];
            Measurement = foodArray[2];
            Calories = int.Parse(foodArray[3]);
        }
        public FoodItem()
        {
            Category = "";
            FoodName = "";
            Measurement = "";
            Calories = 0;
        }

    }
}
