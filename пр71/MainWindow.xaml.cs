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

namespace пр71
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Красный свет", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Stop);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Content.ToString() == "Влево")
            Cursor = Cursors.Hand;  // курсок ввиде руки (ладони)
            else if (radioButton.Content.ToString() == "Вправо")
                Cursor = Cursors.SizeWE; //меняет размер
            else if (radioButton.Content.ToString() == "Стоп")
                Cursor = Cursors.Pen; // ввиде пера
            else if (radioButton.Content.ToString() == "Движение")
                Cursor = Cursors.None; // специальный невидимый курсор
        }
    }
}
