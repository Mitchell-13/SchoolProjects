using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MONutritionApp
{
    /// <summary>
    /// Interaction logic for FoodDetails.xaml
    /// </summary>
    public partial class FoodDetails : Window
    {
        public FoodDetails(Food tempFood)
        {
            InitializeComponent();
            lblCalcium.Content = tempFood.calcium;
            lblCalories.Content = tempFood.calories;
            lblFood.Content = tempFood.foodName;
            lblServingSize.Content = tempFood.servingSize;
            lblWeight.Content = tempFood.weight;
            lblPercentWater.Content = tempFood.percentWater;
            lblProtein.Content = tempFood.protein;
            lblCarb.Content = tempFood.carbs;
            lblFiber.Content = tempFood.fiber;
            lblCholesterol.Content = tempFood.cholesterol;
            lblTotalFat.Content = tempFood.totalFat;
            lblSatFat.Content = tempFood.satFat;
            lblMonoSatFat.Content = tempFood.monoSatFat;
            lblPolyUnsatFat.Content = tempFood.polyFat;
            lblIron.Content = tempFood.iron;
            lblMag.Content = tempFood.mag;
            lblSodium.Content = tempFood.sodium;
            lblPhos.Content = tempFood.phos;
            lblCap.Content = tempFood.cap;
            lblPot.Content = tempFood.pot;
            lblZinc.Content = tempFood.zinc;
            lblNiacin.Content = tempFood.niacin;
            lblThiamin.Content = tempFood.thiamin;
            lblRibo.Content = tempFood.riboflavin;
            lblVA.Content = tempFood.va;
            lblVB6.Content = tempFood.vb6;
            lblVC.Content = tempFood.vc;
            lblFoodType.Content = tempFood.foodType;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
