using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MOAnimalApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Animal animal;

        public MainWindow()
        {
            InitializeComponent();

            RdBtnCow.IsChecked = true;
        }
        /// <summary>
        /// change image to cow and show message at bottom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdBtnCow_Checked(object sender, RoutedEventArgs e)
        {
            ImgAnimal.Source = new BitmapImage(new Uri("images/cow.png", UriKind.Relative));
            animal = new Cow("Grass", "Hair");
            LblResults.Content = "Moo! Got Milk?";
        }
        /// <summary>
        /// change image to sheep and show message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdBtnSheep_Checked(object sender, RoutedEventArgs e)
        {
            ImgAnimal.Source = new BitmapImage(new Uri("images/sheep.png", UriKind.Relative));
            animal = new Sheep("Grass", "Wool");
            LblResults.Content = "Baa. Have you any wool?";
        }
        /// <summary>
        /// change image to duck and show message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdBtnDuck_Checked(object sender, RoutedEventArgs e)
        {
            ImgAnimal.Source = new BitmapImage(new Uri("images/duck.png", UriKind.Relative));
            animal = new Duck("Grains", "Feathers");
            LblResults.Content = "Got any grapes?";
        }
        //show food type for selected animal
        private void BtnFoodType_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = animal.FoodType;
        }
        //show skin type for selected animal
        private void BtnSkinType_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = animal.SkinType;
        }
        // show selected animal's sound
        private void BtnSound_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = animal.sound();
        }
        //pet current animal
        private void BtnPet_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = animal.Pet();
        }
        //show what happens when selected animal eats
        private void BtnEat_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = animal.Eat();
        }
        // show how current animal moves
        private void BtnMove_Click(object sender, RoutedEventArgs e)
        {
            LblResults.Content = animal.Move();
        }
    }
}
