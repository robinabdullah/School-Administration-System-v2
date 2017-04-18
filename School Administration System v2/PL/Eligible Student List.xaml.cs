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
    /// Interaction logic for Eligible_Student_List.xaml
    /// </summary>
    public partial class Eligible_Student_List : MahApps.Metro.Controls.MetroWindow
    {
        public Eligible_Student_List()
        {
            InitializeComponent();

            DataClassesLinqDataContext db = new DataClassesLinqDataContext(DataAccessClassLinq.connectionStringLinq);

            List<EligibleStudentListDG> list = new List<EligibleStudentListDG>();
            //List<DAL.Admission_Student> list = new List<DAL.Admission_Student>();

            var a = from e in db.Admission_Students
                    select e;


            EligibleStudentListDG el;

            
            foreach (DAL.Admission_Student aStd in a)
            {
                el = new EligibleStudentListDG();
                var b = from e in db.Admission_Exam_Results
                        where e.Admission_Student_ID == aStd.Admission_Student_ID
                        select e;

                foreach (Admission_Exam_Result aStdRes in b)
                {
                    el.Id = aStd.Admission_Student_ID;
                    el.Name = aStd.Full_Name;
                    el.Mobile = aStd.Mobile;
                    el.Grade = aStd.Interested_Grade;
                    el.Gender = aStd.Gender;
                    el.Group = aStd.Group;                    

                    el.Viva = aStdRes.Viva_Exam_Mark;
                    el.Written = aStdRes.Writtern_Exam_Mark;

                    double total = Double.Parse(aStdRes.Writtern_Exam_Mark) + Double.Parse(aStdRes.Viva_Exam_Mark);

                    el.Total = total.ToString();

                    BusinessRules rule = new BusinessRules();
                    bool test = rule.checkEligibility(aStdRes.Writtern_Exam_Mark, aStdRes.Viva_Exam_Mark);

                    if (test == true)
                        el.Eligibility = "Yes";
                    else
                        el.Eligibility = "No";
                }

                list.Add(el); 
            }
            dataGrid.IsReadOnly = true;
            dataGrid.DataContext = list;
            


        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Admission ad = new Admission();
            ad.Show();
            this.Close();
        }
    }
}
