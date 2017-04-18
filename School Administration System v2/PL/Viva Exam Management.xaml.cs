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
using School_Administration_System_v2.BL;
using School_Administration_System_v2.DAL;

namespace School_Administration_System_v2.PL
{
    /// <summary>
    /// Interaction logic for Written_Exam_Management.xaml
    /// </summary>
    public partial class Viva_Exam_Management : MetroWindow
    {
        public Viva_Exam_Management()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

            Admission a = new Admission();
            a.Show();
        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext
                (DataAccessClassLinq.connectionStringLinq);

            AdmissionStudentIntImplementation a = new AdmissionStudentIntImplementation();

            DAL.Admission_Student st = a.getAdmissionStudent(id.Text);
            

            if (st == null)
            {
                MessageBox.Show("Student Not Found");
            }
            else
            {
                Admission_Exam_Result stResult = db.Admission_Exam_Results.FirstOrDefault(ee => ee.Admission_Student_ID.Equals(st.Admission_Student_ID));

                fullName.Text = st.Full_Name;
                admissionSession.Text = st.Admission_Session;
                group.Text = st.Group;
                Total_mark.Text = "100";
                if(stResult == null)
                    achievedMark.Text = "";
                else
                    achievedMark.Text = stResult.Viva_Exam_Mark;


            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AdmissionStudentIntImplementation a = new AdmissionStudentIntImplementation();
            a.setVivaResult(achievedMark.Text, Login.getID(), id.Text);

            Admission admission = new Admission();
            admission.Show();
            this.Close();
        }
    }
}
