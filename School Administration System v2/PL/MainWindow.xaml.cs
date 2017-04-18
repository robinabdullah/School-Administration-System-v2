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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.Data.SqlClient;
using System.Configuration;
using School_Administration_System_v2.DAL;
using School_Administration_System_v2.BL;

namespace School_Administration_System_v2.PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            //DataAccessClass db = new DataAccessClass();
            //DataAccessClass.ExecuteSQL("INSERT INTO Classroom (Classroom_ID, Remarks, Status)  VALUES (2, 'None', 'true')");
            DataClassesLinqDataContext db = new DataClassesLinqDataContext(DataAccessClassLinq.connectionStringLinq);
            var t = from a in db.Admins
                    select a;

            bool b = false;
            try
            {
                foreach (Admin obj in t)
                {

                    if (obj.Admin_ID.Equals(UserName.Text) && obj.Pasword.Equals(UserPass.Password))
                    {
                        b = true;

                        //Login l = new Login(UserName.Text, UserPass.Password);
                        Login.setIDPass(UserName.Text, UserPass.Password);

                        Home_Screen home = new Home_Screen();
                        home.Show();
                        this.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                b = true;
                MessageBox.Show("You forgot to write your name and id!");
            }

            if (b == false)
            {
                MessageBox.Show("Wrong username or password!");                
            }



        }
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
