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
    /// Interaction logic for Benefits.xaml
    /// </summary>
    public partial class Benefits : MetroWindow
    {
        public Benefits()
        {
            InitializeComponent();
        }

        private void Button_Student_Benefits(object sender, RoutedEventArgs e)
        {
            Student_Benefits std_ben = new Student_Benefits();
            std_ben.Show();
            this.Close();

        }

        private void Button_Employee_Benefits(object sender, RoutedEventArgs e)
        {
            Employee_Benefits empl_benf = new Employee_Benefits();
            empl_benf.Show();
            this.Close();
        }

        private void Button_Provident_Fund(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Insurance(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Gratuity(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Home_Screen home = new Home_Screen();
            home.Show();
            this.Close();
        }
    }
}
