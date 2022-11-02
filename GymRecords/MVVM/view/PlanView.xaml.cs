using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
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
    /// Interaction logic for PlanView.xaml
    /// </summary>
    public partial class PlanView : UserControl
    {
        public PlanView()
        {
            InitializeComponent();
        }
        
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            Handle(cmb);
        }

        public static Border currentSP;
        public static TextBox currentTB;
        private void Handle(ComboBox cmb)
        {

            if (cmb.Name== "MondayR1C1")
            {
                currentSP = R1C1;
                currentTB = tbR1C1;
            }
            else if (cmb.Name == "MondayR2C1")
            {
                currentSP = R2C1;
                currentTB = tbR2C1;
            }
            else if (cmb.Name == "TuesdayR1C2")
            {
                currentSP = R1C2;
                currentTB = tbR1C2;
            }
            else if (cmb.Name == "TuesdayR2C2")
            {
                currentSP = R2C2;
                currentTB = tbR2C2;
            }
            else if (cmb.Name == "WednesdayR1C3")
            {
                currentSP = R1C3;
                currentTB = tbR1C3;
            }
            else if (cmb.Name == "WednesdayR2C3")
            {
                currentSP = R2C3;
                currentTB = tbR2C3;
            }
            else if (cmb.Name == "ThursdayR1C4")
            {
                currentSP = R1C4;
                currentTB = tbR1C4;
            }
            else if (cmb.Name == "ThursdayR2C4")
            {
                currentSP = R2C4;
                currentTB = tbR2C4;
            }
            else if (cmb.Name == "FridayR1C5")
            {
                currentSP = R1C5;
                currentTB = tbR1C5;
            }
            else if (cmb.Name == "FridayR2C5")
            {
                currentSP = R2C5;
                currentTB = tbR2C5;
            }
            else if (cmb.Name == "SaturdayR1C6")
            {
                currentSP = R1C6;
                currentTB = tbR1C6;
            }
            else if (cmb.Name == "SaturdayR2C6")
            {
                currentSP = R2C6;
                currentTB = tbR2C6;
            }
            else if (cmb.Name == "SundayR1C7")
            {
                currentSP = R1C7;
                currentTB = tbR1C7;
            }
            else if (cmb.Name == "SundayR2C7")
            {
                currentSP = R2C7;
                currentTB = tbR2C7;
            }

            switch (cmb.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last())
            {

                case "Yes":
                    //Handle for the first combobox
                    currentSP.BorderThickness = new Thickness(5, 5, 5, 5);
                    currentSP.BorderBrush = new SolidColorBrush(Colors.LimeGreen);
                    currentTB.Visibility = Visibility.Visible;
                    currentTB = null; currentSP = null;
                    break;
                case "No":
                    //Handle for the second combobox
                    currentSP.BorderThickness = new Thickness(5, 5, 5, 5);
                    currentSP.BorderBrush = new SolidColorBrush(Colors.Red);
                    currentTB.Visibility = Visibility.Hidden;
                    currentTB = null; currentSP = null;
                    break;
                case " ":
                    //Handle for the second combobox
                    currentSP.BorderThickness = new Thickness(1,1,1,1);
                    currentSP.BorderBrush = new SolidColorBrush(Colors.Transparent);
                    currentTB.Visibility = Visibility.Hidden;
                    currentTB = null; currentSP = null;
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveToPng(grid, "Plan.png");
        }












        void SaveToBmp(FrameworkElement visual, string fileName)
        {
            var encoder = new BmpBitmapEncoder();
            SaveUsingEncoder(visual, fileName, encoder);
        }

        void SaveToPng(FrameworkElement visual, string fileName)
        {
            var encoder = new PngBitmapEncoder();
            SaveUsingEncoder(visual, fileName, encoder);
        }

        // and so on for other encoders (if you want)


        void SaveUsingEncoder(FrameworkElement visual, string fileName, BitmapEncoder encoder)
        {
            RenderTargetBitmap bitmap = new RenderTargetBitmap((int)visual.ActualWidth, (int)visual.ActualHeight, 96, 96, PixelFormats.Pbgra32);
            bitmap.Render(visual);
            BitmapFrame frame = BitmapFrame.Create(bitmap);
            encoder.Frames.Add(frame);

            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            using (var stream = File.Create($"{filePath}/" + fileName))
            {
                encoder.Save(stream);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                string Path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Plan.png";

                Process.Start(new ProcessStartInfo { FileName = Path, UseShellExecute = true });
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"Error!");
            }
        }
    }
}
