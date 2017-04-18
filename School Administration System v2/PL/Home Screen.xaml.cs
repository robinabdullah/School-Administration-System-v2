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
using MahApps.Metro.Controls;

namespace School_Administration_System_v2.PL
{
    /// <summary>
    /// Interaction logic for Home_Screen.xaml
    /// </summary>
    public partial class Home_Screen : MetroWindow
    {
        public Home_Screen()
        {
            InitializeComponent();
        }

        private void Button_Academics(object sender, RoutedEventArgs e)
        {
            Academics academics= new Academics();
            academics.Show();
            this.Close();
        }

        private void Button_Accounts(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Admission(object sender, RoutedEventArgs e)
        {
            Admission admission = new Admission();
            admission.Show();
            this.Close();
        }

        private void Button_Attendance(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Benefits(object sender, RoutedEventArgs e)
        {
            Benefits benefits = new Benefits();
            benefits.Show();
            this.Close();
        }

        private void Button_Exam_Control(object sender, RoutedEventArgs e)
        {
            Exam_Control examControl = new Exam_Control();
            examControl.Show();
            this.Close();
        }

        private void Button_HR(object sender, RoutedEventArgs e)
        {
            HR hrWindow = new HR();
            hrWindow.Show();
            this.Close();
        }

        private void Button_Inventory(object sender, RoutedEventArgs e)
        {
            Inventory i = new Inventory();
            i.Show();
            this.Close();
        }

        private void Button_Library(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
