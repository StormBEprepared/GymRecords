using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace GymRecords.MVVM.view
{
    /// <summary>
    /// Interaction logic for LearnYourselfView.xaml
    /// </summary>
    public partial class LearnYourselfView : UserControl
    {
        public LearnYourselfView()
        {
            InitializeComponent();
            string url = "http://leonidstefanelpintea.freecluster.eu/#portfolio";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });

            //FrameWithinGrid.Navigate(new System.Uri("http://leonidstefanelpintea.freecluster.eu/?i=1", UriKind.RelativeOrAbsolute));
        }

    }
}
