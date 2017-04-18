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
    /// Interaction logic for Employee_Benefits_Gratuity.xaml
    /// </summary>
    public partial class Employee_Benefits_Gratuity : MetroWindow
    {
        public Employee_Benefits_Gratuity()
        {
            InitializeComponent();
        }

        private void Button_Advanced_Salary(object sender, RoutedEventArgs e)
        {
            Employee_Benefits_Advanced_Salary employee_benefits_advancedSalary = new Employee_Benefits_Advanced_Salary();
            employee_benefits_advancedSalary.Show();
            this.Close();
        }

        private void Button_Gratuity(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Benefits benefits = new Benefits();
            benefits.Show();
            this.Close();
        }

        private void Button_Done(object sender, RoutedEventArgs e)
        {
            Benefits benefits = new Benefits();
            benefits.Show();
            this.Close();
        }

        private void Button_GO(object sender, RoutedEventArgs e)
        {

        }
    }
}
