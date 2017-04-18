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


namespace School_Administration_System_v2.PL
{
    /// <summary>
    /// Interaction logic for Edit_Profile.xaml
    /// </summary>
    public partial class Edit_Profile : MetroWindow
    {
        public Edit_Profile()
        {
            InitializeComponent();
        }

        private void Button_DELETE(object sender, RoutedEventArgs e)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext(DataAccessClassLinq.connectionStringLinq);

            Teacher deleteTeacher = db.Teachers.FirstOrDefault(ex => ex.Teacher_ID.Equals(ID.Text));
            db.Teachers.DeleteOnSubmit(deleteTeacher);
            db.SubmitChanges();
        }

        private void Button_DONE(object sender, RoutedEventArgs e)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext(DataAccessClassLinq.connectionStringLinq);

            var s = from a in db.Students
                    where a.Student_ID == ID.Text
                    select a;

            var t = from a in db.Teachers
                    where a.Teacher_ID == ID.Text
                    select a;



            //teach.DOB = DateTime.Now;
            //teach.Joined_Date = DateTime.Now;
            //teach.Status = "Active";

            //teach.Mobile = Mobile.Text;
            //teach.Designation = Designation.Text;
            //teach.Address = Address.Text;
            //teach.Email = Email.Text;
            bool flag = false;
            foreach (Teacher obj in t)
            {
                if (obj.Teacher_ID.Equals(ID.Text))
                {
                    flag = true;
                    First.Text = obj.First_Name;
                    Last.Text = obj.Last_Name;
                    Father.Text = obj.Fathers_Name;
                    Mother.Text = obj.Mothers_Name;
                    Gender.Text = obj.Gender;
                    Blood.Text = obj.Blood_Group;
                    DateOfBirth.Text = obj.DOB.ToString();
                    Marital.Text = obj.Marital_Status;
                    Designation.Text = obj.Designation;
                    Address.Text = obj.Address;
                    Email.Text = obj.Email;
                    Mobile.Text = obj.Mobile;

                }
            }
            if (flag == false)
            {
                MessageBox.Show("ID not found!");
                First.Text = "";
                Last.Text = "";
                Father.Text = "";
                Mother.Text = "";
                Gender.Text = "";
                Blood.Text = "";
                DateOfBirth.Text = "";
                Marital.Text = "";
                Designation.Text = "";
                Address.Text = "";
                Email.Text = "";
                Mobile.Text = "";
            }

            //if (Married.IsChecked == true)
            //{
            //    teach.Marital_Status = "Married";
            //}
            //else
            //{
            //    teach.Marital_Status = "UnMarried";
            //}

            //teach.DOB = DateTime.Now;
            //teach.Joined_Date = DateTime.Now;
            //teach.Status = "Active";

            //teach.Mobile = Mobile.Text;
            //teach.Designation = Designation.Text;
            //teach.Address = Address.Text;
            //teach.Email = Email.Text;
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            HR hr = new HR();
            hr.Show();
            this.Close();
        }

    }
}
