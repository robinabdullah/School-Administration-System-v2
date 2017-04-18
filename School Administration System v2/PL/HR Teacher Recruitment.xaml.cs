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
    /// Interaction logic for HR_Teacher_Recruitment.xaml
    /// </summary>
    public partial class HR_Teacher_Recruitment : MetroWindow
    {
        public HR_Teacher_Recruitment()
        {
            InitializeComponent();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            HR hr = new HR();
            hr.Show();
            this.Close();
        }

        private void Button_DONE(object sender, RoutedEventArgs e)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext(DataAccessClassLinq.connectionStringLinq);

            Teacher teach = new Teacher();

            teach.First_Name = First.Text;
            teach.Last_Name = Last.Text;
            teach.Full_Name = First.Text + " " + Last.Text;
            teach.Fathers_Name = Father.Text;
            teach.Mothers_Name = Mother.Text;
            teach.Gender = Gender.Text;
            teach.Blood_Group = Blood.Text;

            if (Married.IsChecked == true)
            {
                teach.Marital_Status = "Married";
            }
            else 
            {
                teach.Marital_Status = "UnMarried";
            }

            teach.DOB = DateTime.Now;
            teach.Joined_Date = DateTime.Now;
            teach.Status = "Active";

            teach.Mobile = Mobile.Text;
            teach.Designation = Designation.Text;
            teach.Address = Address.Text;
            teach.Email = Email.Text;

            
            var max = db.Teachers.OrderByDescending(i => i.Teacher_ID).FirstOrDefault();

            string id = "";
            foreach (char a in max.Teacher_ID)
            {
                int val = (int)Char.GetNumericValue(a);
                id = (val + 1).ToString();
            }

            teach.Teacher_ID = id;
            //MessageBox.Show(id);
            db.Teachers.InsertOnSubmit(teach);
            db.SubmitChanges(); //eita main mama

            HR hr = new HR();
            hr.Show();
            this.Close();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void UnMarried_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
