using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOAnimalApp
{
    class Cow : Animal
    {
        //override and abstract go together just like override and virtual
        public override string Pet()
        {
            return "Cows are not very soft, nothing happens";
        }
        public Cow(string paramFood, string paramSkin) : base(paramFood, paramSkin)
        {
            SkinType = paramSkin;
            FoodType = paramFood;
        }
        public override string sound()
        {
            return "Mooooo";
        }
    }
}
