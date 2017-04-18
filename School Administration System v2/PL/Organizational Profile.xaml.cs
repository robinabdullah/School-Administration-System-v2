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
    /// Interaction logic for Organizational_Profile.xaml
    /// </summary>
    public partial class Organizational_Profile : MetroWindow
    {
        public Organizational_Profile()
        {
            InitializeComponent();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {

            HR hr = new HR();
            hr.Show();
            this.Close();
        }

        private void Button_GO(object sender, RoutedEventArgs e)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext(DataAccessClassLinq.connectionStringLinq);

            var s = from a in db.Students
                    where a.Student_ID == ID.Text
                    select a;

            var t = from a in db.Teachers
                    where a.Teacher_ID == ID.Text
                    select a;

            //var ass = from a in db.Admission_Students
            //        where a.Admission_Student_ID == 
            //        select a;

            bool flag = false;
            foreach (Teacher obj in t)
            {
                if (obj.Teacher_ID.Equals(ID.Text))
                {
                    flag = true;
                    Name.Text = obj.Full_Name;
                    JoinedDate.Text = obj.Joined_Date.ToString();
                    Dept.Text = "Science";
                    MobileNum.Text = obj.Mobile;
                    Email.Text = obj.Email;
                    Designation.Text = obj.Designation;
                    Status.Text = obj.Status;
                } 
            }
            if (flag == false)
            {
                MessageBox.Show("ID not found!");
                Name.Text = "";
                JoinedDate.Text = "";
                Dept.Text = "";
                MobileNum.Text = "";
                Email.Text = "";
                Designation.Text = "";
                Status.Text = "";
            }
        }

        
    }
}
