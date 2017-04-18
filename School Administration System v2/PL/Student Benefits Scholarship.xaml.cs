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
    /// Interaction logic for Student_Benefits_Scholarship.xaml
    /// </summary>
    public partial class Student_Benefits_Scholarship : MetroWindow
    {
        public Student_Benefits_Scholarship()
        {
            InitializeComponent();
        }

        private void Button_Discount(object sender, RoutedEventArgs e)
        {
            Student_Benefits_Discount studentBenefitsDiscount = new Student_Benefits_Discount();
            studentBenefitsDiscount.Show();
            this.Close();
        }

        private void Button_Scholarship(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Back(object sender, RoutedEventArgs e)
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
