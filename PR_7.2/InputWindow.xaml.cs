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

namespace PR_7._2
{
    /// <summary>
    /// Логика взаимодействия для InputWindow.xaml
    /// </summary>
    public partial class InputWindow : Window
    {
        public double Radius{ get; set; }
        public double Height{ get; set; }
        public double Density { get; set; }
        public bool Volume { get; set; }
        public bool Mass { get; set; }
        public InputWindow()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (Double.TryParse(RadiusTextBox.Text, out double radius) && Double.TryParse(HeightTextBox.Text, out double height) && Double.TryParse(DensityTextBox.Text, out double density))
            {
                Radius = radius;
                Height = height;
                Density = density;
                if (radius <= 0 || height <= 0 || density <= 0)
                {
                    MessageBox.Show("The radius, height, and density must not be negative or equal to zero.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    RadiusTextBox.Clear();
                    HeightTextBox.Clear();
                    DensityTextBox.Clear();
                    VolumeCheckBox.IsChecked = false;
                    MassCheckBox.IsChecked = false;
                }
            }
            else 
            { 
                MessageBox.Show("Invalid input values", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                RadiusTextBox.Clear();
                HeightTextBox.Clear();
                DensityTextBox.Clear();
                VolumeCheckBox.IsChecked = false;
                MassCheckBox.IsChecked = false;
            }

        }

        private void Calculator_Click_1(object sender, RoutedEventArgs e)
        {
            Volume = VolumeCheckBox.IsChecked ?? false;
            Mass = MassCheckBox.IsChecked ?? false;

            DialogResult = true;
        }
    }
}
