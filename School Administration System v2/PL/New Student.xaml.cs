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
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class New_Student : MetroWindow
    {
        public New_Student()
        {                       
            InitializeComponent();
            List<string> objList = new List<string>();

            objList.Add("Islam");
            objList.Add("Hindu");
            religionList.ItemsSource = objList;
            religionList.Content = "Islam";
            
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Admission admission = new Admission();
            admission.Show();
            this.Close();
        }

        private void Button_DONE(object sender, RoutedEventArgs e)
        {                        
            AdmissionStudentIntImplementation a = new AdmissionStudentIntImplementation();            
            DAL.Admission_Student std = new DAL.Admission_Student();

            std.First_Name = fistName.Text;
            std.Last_Name = lastName.Text;
            std.Full_Name = fullName.Text;
            std.Fathers_Name = fathersName.Text;
            std.Mothers_Name = mothersName.Text;             
            std.Gender = gender.Text;
            std.Blood_Group = bloodGroup.Text;
            std.DOB = DateTime.Parse(dobDatePicker.ToString());
            std.Religion = religionList.Items.GetItemAt(0).ToString();
            std.Admission_Session = admissionSession.Text;
            std.Group = group.Text;
            std.Mobile = guardianNumber.Text;
            std.Current_School = currentSchool.Text;
            std.Current_Grade = currentGrade.Text;
            std.Interested_Grade = registeredGrade.Text;
            std.Address = address.Text;
            std.Country = country.Text;

            a.addAdmissionStudent(std);

            Admission admission = new Admission();
            admission.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_6(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_7(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_8(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_9(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_10(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_11(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_12(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_13(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_14(object sender, TextChangedEventArgs e)
        {

        }
    }
}
