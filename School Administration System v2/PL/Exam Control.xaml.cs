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
    /// Interaction logic for Exam_Control.xaml
    /// </summary>
    public partial class Exam_Control : MetroWindow
    {
        public Exam_Control()
        {
            InitializeComponent();
        }

        private void Button_Accounts(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Benefits(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Inventory(object sender, RoutedEventArgs e)
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
