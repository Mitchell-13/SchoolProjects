using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOAnimalApp
{
    public abstract class Animal
    {
        public string SkinType { get; set; }
        public string FoodType { get; set; }
        /// <summary>
        /// constructor for current class
        /// </summary>
        /// <param name="paramFood"></param>
        /// <param name="paramSkin"></param>
        public Animal(string paramFood, string paramSkin)
        {
            FoodType = paramFood;
            SkinType = paramSkin;
        }

        //inheritance, these methods will be passed to derived classes
        public string Eat()
        {
            return "Needs food to survive";
        }
        public string Move()
        {
            return "Can move around";
        }
        public abstract string Pet();

        //polymorphism and inhertiance. will pass to derrived methods but can be overridden 
        public virtual string sound()
        {
            return "Makes a typical animal noise";
        }
    }
}
