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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR_7._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double radius, height, density;

        private bool volume, mass;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            InputWindow inputWindow = new InputWindow();
            if (inputWindow.ShowDialog() == true)
            {
                radius = inputWindow.Radius;
                height = inputWindow.Height;
                density = inputWindow.Density;
                volume = inputWindow.Volume;
                mass = inputWindow.Mass;
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            if (radius == 0 && height == 0 && density == 0)
            {
                MessageBox.Show("Please enter the radius, height and density of the cone first.");
                return;
            }

            WorkWindow workWindow = new WorkWindow();
            workWindow.VolumetextBox.Text = volume ? Volume().ToString() : "Not calculated";
            workWindow.MasstextBox.Text = mass ? Mass().ToString() : "Not calculated";

            workWindow.ShowDialog();
        }

        /// <summary>
        /// Method Volume() to calculate the volume.
        /// </summary>
        /// <returns></returns>
        private double Volume()
        {
            return Math.Round((Math.PI * Math.Pow(radius, 2) * height) / 3, 3);
        }

        /// <summary>
        /// Method Mass() to calculate the mass.
        /// </summary>
        /// <returns></returns>
        private double Mass()
        {
            double v = Volume() * density;
            return Math.Round(v, 2); 
        }
    }
}
