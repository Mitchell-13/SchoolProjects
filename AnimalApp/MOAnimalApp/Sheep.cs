using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOAnimalApp
{
    class Sheep : Animal
    {
        public override string sound()
        {
            return "Baaaa";
        }
        public override string Pet()
        {
            return "Very soft, time for a new blanket?";
        }
        public Sheep(string food, string skin) : base(food,skin)
        {
            FoodType = food;
            SkinType = skin;
        }
    }
}
