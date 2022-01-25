using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOAnimalApp
{
    class Duck : Animal
    {
        public override string sound()
        {
            return base.sound();
        }
        public override string Pet()
        {
            return "Not sure why you would pet a duck";
        }
        public Duck(string food, string skin) : base(food, skin)
        {
            FoodType = food;
            SkinType = skin;
        }
    }
}
