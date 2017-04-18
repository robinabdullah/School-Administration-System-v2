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
using MahApps.Metro.Controls.Dialogs;

namespace School_Administration_System_v2.PL
{
    /// <summary>
    /// Interaction logic for Admit_Student.xaml
    /// </summary>
    public partial class Admit_Student : MetroWindow
    {
        public Admit_Student()
        {
            InitializeComponent();
            Add_Student.IsEnabled = false;
        }

        private async void search_Button_Click(object sender, RoutedEventArgs e)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext
               (DataAccessClassLinq.connectionStringLinq);

            AdmissionStudentIntImplementation a = new AdmissionStudentIntImplementation();
            StudentIntImplementation b = new StudentIntImplementation();

            DAL.Admission_Student admissionStudent = a.getAdmissionStudent(id.Text);

            var checkStudent = from f in db.Students
                               where f.Admissin_Student_ID.Equals(admissionStudent.Admission_Student_ID)
                               select f;
            bool checkStd = false;
            foreach (DAL.Student std in checkStudent)
                checkStd = true;


            if (admissionStudent == null)
            {
                fullName.Clear();
                addmissionSession.Clear();
                group.Clear();
                interestedGrade.Clear();
                gender.Clear();
                group.Clear();
                eligibleMarks.Content = "Written :     Viva : ";
                teacherIDs.Content = "Written :    Viva : ";
                written_mark.Clear();
                vivaMark.Clear();
                Total.Clear();
                Eligibility.Content = "Unknown";
                MessageBox.Show("Student Not Found");

            }
            else if (checkStd.Equals(true))
            {
                fullName.Clear();
                addmissionSession.Clear();
                group.Clear();
                interestedGrade.Clear();
                gender.Clear();
                group.Clear();
                eligibleMarks.Content = "Written :     Viva : ";
                teacherIDs.Content = "Written :    Viva : ";
                written_mark.Clear();
                vivaMark.Clear();
                Total.Clear();
                Eligibility.Content = "Unknown";
                await this.ShowMessageAsync("Error", "Student Already Registered");
            }
            else
            {
                Admission_Exam_Result stResult = db.Admission_Exam_Results.FirstOrDefault(ee => ee.Admission_Student_ID.Equals(admissionStudent.Admission_Student_ID));

                fullName.Text = admissionStudent.Full_Name;
                addmissionSession.Text = admissionStudent.Admission_Session;
                group.Text = admissionStudent.Group;
                interestedGrade.Text = admissionStudent.Interested_Grade;
                gender.Text = admissionStudent.Gender;
                group.Text = admissionStudent.Group;
                eligibleMarks.Content = "Written : " + stResult.Writtern_Exam_Mark + "   Viva : " + stResult.Viva_Exam_Mark;
                teacherIDs.Content = "Written : " + stResult.Written_Examiner_ID + "   Viva : " + stResult.Viva_Examiner_ID;

                written_mark.Text = stResult.Writtern_Exam_Mark;
                vivaMark.Text = stResult.Viva_Exam_Mark;

                double total = Double.Parse(stResult.Writtern_Exam_Mark) + Double.Parse(stResult.Viva_Exam_Mark);

                Total.Text = total.ToString();

                BusinessRules r = new BusinessRules();
                bool test = r.checkEligibility(stResult.Writtern_Exam_Mark, stResult.Viva_Exam_Mark);

                if (test == true)
                {
                    Eligibility.Content = "Yes";
                    Add_Student.IsEnabled = true;
                }

                else
                    Eligibility.Content = "No";


            }
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            Admission ad = new Admission();
            ad.Show();
            this.Close();
        }

        private async void Add_Student_Click(object sender, RoutedEventArgs e)
        {
            MahApps.Metro.Controls.Dialogs.MessageDialogResult result = await this.ShowMessageAsync("Confirmtion!", "Do You Want To Register This Student", MessageDialogStyle.AffirmativeAndNegative);

            StudentIntImplementation a = new StudentIntImplementation();

            if (a.addStudent(id.Text).Equals(true))
            {
                await this.ShowMessageAsync("Registration", "Student Added " + result);
            }



        }
    }
}
