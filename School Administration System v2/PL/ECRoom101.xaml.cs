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
    /// Interaction logic for ECRoom101.xaml
    /// </summary>
    public partial class ECRoom101 : MetroWindow
    {
        public ECRoom101()
        {
            InitializeComponent();
            DataClassesLinqDataContext db = new DataClassesLinqDataContext(DataAccessClassLinq.connectionStringLinq);
            DAL.Admission_Student admissionstudent = new DAL.Admission_Student();
            DAL.Teacher teach = new DAL.Teacher();

            List<string> objList = new List<string>();
            List<string> objList2 = new List<string>();

            var a = from e in db.Admission_Students
                    select e;

            var b = from e in db.Teachers
                    select e;

            foreach (DAL.Admission_Student st in a)
            {
                objList.Add(st.Admission_Student_ID);
            }

            foreach (DAL.Teacher t in b)
            {
                objList2.Add(t.Full_Name);
            }

            _1.ItemsSource = objList;
            _2.ItemsSource = objList;
            _3.ItemsSource = objList;
            _4.ItemsSource = objList;
            _5.ItemsSource = objList;
            _6.ItemsSource = objList;
            _7.ItemsSource = objList;
            _8.ItemsSource = objList;
            _9.ItemsSource = objList;
            _10.ItemsSource = objList;
            _11.ItemsSource = objList;
            _12.ItemsSource = objList;
            _13.ItemsSource = objList;
            _14.ItemsSource = objList;
            _15.ItemsSource = objList;
            _16.ItemsSource = objList;
            _17.ItemsSource = objList;
            _18.ItemsSource = objList;
            _19.ItemsSource = objList;
            _20.ItemsSource = objList;
            _21.ItemsSource = objList;
            _22.ItemsSource = objList;
            _23.ItemsSource = objList;
            _24.ItemsSource = objList;

            Invi1.ItemsSource = objList2;
            Invi2.ItemsSource = objList2;
            // _1.Content = objList.First();


        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Seat_Plan sp = new Seat_Plan();
            sp.Show();
            this.Close();
        }

        private void Button_Done(object sender, RoutedEventArgs e)
        {

        }

    }
}
