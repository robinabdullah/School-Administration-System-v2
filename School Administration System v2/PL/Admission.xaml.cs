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
using School_Administration_System_v2.DAL;
using School_Administration_System_v2.BL;

namespace School_Administration_System_v2.PL
{
    /// <summary>
    /// Interaction logic for Admission.xaml
    /// </summary>
    public partial class Admission : MetroWindow
    {
        public Admission()
        {
            InitializeComponent();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Home_Screen home = new Home_Screen();
            home.Show();
            this.Close();
        }

        private void Button_Student_Admission(object sender, RoutedEventArgs e)
        {
            New_Student student = new New_Student();
            student.Show();
            this.Close();
        }

        private void Button_Written_Exam_Management(object sender, RoutedEventArgs e)
        {
            Written_Exam_Management w = new Written_Exam_Management();

            w.Show();
            this.Hide();
        }

        private void Button_Viva_Exam_Management(object sender, RoutedEventArgs e)
        {
            Viva_Exam_Management v = new Viva_Exam_Management();
            v.Show();
            this.Hide();
        }

        private void Button_Result_Management(object sender, RoutedEventArgs e)
        {
            Admission_Eligibility ab = new Admission_Eligibility();
            ab.Show();
            this.Close();
        }

        private void Button_Fees_Book_Generation(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Form_Creation(object sender, RoutedEventArgs e)
        {

        }

        private void Eligible_Student_List(object sender, RoutedEventArgs e)
        {
            Eligible_Student_List a = new Eligible_Student_List();

            a.Show();
            this.Close();
        }

        private void Admit_New_Student(object sender, RoutedEventArgs e)
        {
            Admit_Student std = new Admit_Student();
            std.Show();
            this.Close();
        }
    }
}
