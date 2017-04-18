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
    /// Interaction logic for Academics.xaml
    /// </summary>
    public partial class Academics : MetroWindow
    {
        public Academics()
        {
            InitializeComponent();
        }

        private void Button_Classes(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Subjects(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Department(object sender, RoutedEventArgs e)
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
