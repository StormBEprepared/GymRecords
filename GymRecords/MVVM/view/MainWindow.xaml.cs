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

namespace GymRecords
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); Nav.Visibility = Visibility.Collapsed;
        }

        private void HomeButton_Checked(object sender, RoutedEventArgs e)
        {
            Nav.Height = HomeButton.Height;
            Nav.Margin = new Thickness(0,50,0,0);
            Nav.Visibility = Visibility.Visible;
        }

        private void WorkoutButton_Checked(object sender, RoutedEventArgs e)
        {
            Nav.Height = WorkoutButton.Height;
            Nav.Margin = new Thickness(0, 140, 0, 0);
            Nav.Visibility = Visibility.Visible;
        }

        private void RecordsButton_Checked(object sender, RoutedEventArgs e)
        {
            Nav.Height = RecordsButton.Height;
            Nav.Margin = new Thickness(0, 230, 0, 0);
            Nav.Visibility = Visibility.Visible;
        }

        private void PlanButton_Checked(object sender, RoutedEventArgs e)
        {
            Nav.Height = PlanButton.Height;
            Nav.Margin = new Thickness(0, 320, 0, 0);
            Nav.Visibility = Visibility.Visible;
        }
        
        private void LearnYourselfButton_Checked(object sender, RoutedEventArgs e)
        {
            Nav.Height = PlanButton.Height;
            Nav.Margin = new Thickness(0, 410, 0, 0);
            Nav.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Nav.Visibility = Visibility.Collapsed;
        }

        
    }
}
