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
using MahApps.Metro.Controls.Dialogs;

namespace School_Administration_System_v2.PL
{
    /// <summary>
    /// Interaction logic for Employee_Task_Assignment.xaml
    /// </summary>
    public partial class Employee_Task_Assignment : MetroWindow
    {
        public Employee_Task_Assignment()
        {
            InitializeComponent();
        }

        private async void search_Button_Click(object sender, RoutedEventArgs e)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext(DataAccessClassLinq.connectionStringLinq);


            var t = from a in db.Teachers
                    where a.Teacher_ID == id.Text
                    select a;

            //var ass = from a in db.Admission_Students
            //        where a.Admission_Student_ID == 
            //        select a;

            bool flag = false;
            foreach (DAL.Teacher obj in t)
            {
                if (obj.Teacher_ID.Equals(id.Text))
                {
                    flag = true;
                    Name.Text = obj.Full_Name;
                }
            }
            if (flag == false)
            {
                await this.ShowMessageAsync("Error", "ID not found.");
                Name.Text = "";
            }
        }

        private async void Add_Task_Click(object sender, RoutedEventArgs e)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext(DataAccessClassLinq.connectionStringLinq);

            //getting max id from datebase
            var max = db.Tasks.OrderByDescending(i => i.Task_ID).FirstOrDefault();

            string taskID = "";
            foreach (char a in max.Task_ID)
            {
                int val = (int)Char.GetNumericValue(a);
                taskID = (val + 1).ToString();
            }

            //storing values to task object
            DAL.Task task = new DAL.Task();

            task.Task_ID = taskID;
            task.TaskType = task_type.Text;
            task.Task_Description = Task_Description.Text;
            task.Assigned_Date = DateTime.Now;
            task.Deadline = DateTime.Parse(deadline.Text);

            //storing valurs to teacker_task object
            DAL.Teacher_Task teacher_task = new DAL.Teacher_Task();

            teacher_task.Task_ID = taskID;
            teacher_task.Teacher_ID = Login.getID();

            try
            {
                db.Teacher_Tasks.InsertOnSubmit(teacher_task);
                db.Tasks.InsertOnSubmit(task);
                db.SubmitChanges();

                await this.ShowMessageAsync("Information", "Task assignment successful.");

                HR hr = new HR();
                hr.Show();
                this.Close();
            }
            catch
            {
                await this.ShowMessageAsync("Error", "Task assignment error.");
            }




        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            HR gr = new HR();

            gr.Show();
            this.Close();
        }
    }
}
