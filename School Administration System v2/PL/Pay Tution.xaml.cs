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
using School_Administration_System_v2.BL;
using School_Administration_System_v2.DAL;

namespace School_Administration_System_v2.PL
{
    /// <summary>
    /// Interaction logic for Pay_Tution.xaml
    /// </summary>
    public partial class Pay_Tution : Window
    {
        public Pay_Tution()
        {
            InitializeComponent();
        }

        private async void button_Click_2(object sender, RoutedEventArgs e)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext
               (DataAccessClassLinq.connectionStringLinq);

            StudentIntImplementation a = new StudentIntImplementation();
            AdmissionStudentIntImplementation b = new AdmissionStudentIntImplementation();

            DAL.Student st = a.getStudent(id.Text);
            DAL.Admission_Student admissionSt = null;

            try
            {
                admissionSt = db.Admission_Students.FirstOrDefault(ee => ee.Admission_Student_ID.Equals(st.Admissin_Student_ID));
            }
            catch
            {
                //do nothing
            }


            if (st == null)
            {
                await this.ShowMessageAsync("Error", "Student not found.");
            }
            else
            {
                DAL.Student_Regular_Fee stReg = db.Student_Regular_Fees.FirstOrDefault(ee => ee.Student_ID.Equals(st.Student_ID));

                fullName.Text = admissionSt.Full_Name;
                grade.Text = admissionSt.Interested_Grade;
                group.Text = admissionSt.Group;
                /*if (stReg == null)
                    mo.Text = "";
                else
                    mark.Text = stResult.Viva_Exam_Mark;*/

            }
        }

        private System.Threading.Tasks.Task ShowMessageAsync(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void fullName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void grade_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void group_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void month_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void taka_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}