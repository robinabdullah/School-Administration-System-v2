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
    /// Interaction logic for Inventory.xaml
    /// </summary>
    public partial class Inventory : MetroWindow
    {

        public Inventory()
        {
            InitializeComponent();

            DataClassesLinqDataContext db = new DataClassesLinqDataContext(DataAccessClassLinq.connectionStringLinq);
            DAL.Inventory iv = db.Inventories.FirstOrDefault(a => a.Inventory_ID.Equals("1"));

            Printer.Text = iv.Printer;
            Computer.Text = iv.Computer;
            Mouse.Text = iv.Mouse;
            Keyboard.Text = iv.Keyboard;
            Projector.Text = iv.Projector;
            Camera.Text = iv.Camera;
            WhiteBoard.Text = iv.Whiteboard;
            Marker.Text = iv.Marker;
            Pencil.Text = iv.Pencil;
            Soap.Text = iv.Clock;
            PaperBundle.Text = iv.Paperbundle;
            Pen.Text = iv.Pen;
            Duster.Text = iv.Duster;
            GeometryBox.Text = iv.Geometrybox;
            Ruler.Text = iv.Ruler;
            Chair.Text = iv.Chair;
            Bench.Text = iv.Bench;
            Table.Text = iv.Table;
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Home_Screen home = new Home_Screen();
            home.Show();
            this.Close();
        }

        private void Button_DONE(object sender, RoutedEventArgs e)
        {
            DataClassesLinqDataContext db = new DataClassesLinqDataContext(DataAccessClassLinq.connectionStringLinq);
            DAL.Inventory iv = db.Inventories.FirstOrDefault(a => a.Inventory_ID.Equals("1"));


            if (Edit.Content.ToString() == "EDIT")
            {
                Edit.Content = "DONE";
                Printer.IsEnabled = true;
                Computer.IsEnabled = true;
                Mouse.IsEnabled = true;
                Keyboard.IsEnabled = true;
                Projector.IsEnabled = true;
                Camera.IsEnabled = true;
                WhiteBoard.IsEnabled = true;
                Marker.IsEnabled = true;
                Pencil.IsEnabled = true;
                Soap.IsEnabled = true;
                PaperBundle.IsEnabled = true;
                Pen.IsEnabled = true;
                Duster.IsEnabled = true;
                GeometryBox.IsEnabled = true;
                Ruler.IsEnabled = true;
                Chair.IsEnabled = true;
                Bench.IsEnabled = true;
                Table.IsEnabled = true;



                /* iv.Printer = Printer.Text;
                 iv.Computer = Computer.Text;
                 iv.Mouse = Mouse.Text;
                 iv.Keyboard = Keyboard.Text;
                 iv.Projector = Projector.Text;
                 iv.Camera = Camera.Text;
                 iv.Whiteboard = WhiteBoard.Text;
                 iv.Marker = Marker.Text;
                 iv.Clock = Soap.Text;
                 iv.Paperbundle = PaperBundle.Text;
                 iv.Pen = Pen.Text;
                 iv.Duster = Duster.Text;
                 iv.Geometrybox = GeometryBox.Text;
                 iv.Ruler = Ruler.Text;
                 iv.Chair = Chair.Text;
                 iv.Bench = Bench.Text;
                 iv.Table = Table.Text;*/

                // db.Inventories.InsertOnSubmit(iv);
                //db.SubmitChanges();

            }
            else
            {
                Edit.Content = "EDIT";
                Printer.IsEnabled = false;
                Computer.IsEnabled = false;
                Mouse.IsEnabled = false;
                Keyboard.IsEnabled = false;
                Projector.IsEnabled = false;
                Camera.IsEnabled = false;
                WhiteBoard.IsEnabled = false;
                Marker.IsEnabled = false;
                Pencil.IsEnabled = false;
                Soap.IsEnabled = false;
                PaperBundle.IsEnabled = false;
                Pen.IsEnabled = false;
                Duster.IsEnabled = false;
                GeometryBox.IsEnabled = false;
                Ruler.IsEnabled = false;
                Chair.IsEnabled = false;
                Bench.IsEnabled = false;
                Table.IsEnabled = false;



                //Printer.Text = iv.Printer;
                //Computer.Text = iv.Computer;
                //Mouse.Text = iv.Mouse;
                //Keyboard.Text = iv.Keyboard;
                //Projector.Text = iv.Projector;
                //Camera.Text = iv.Camera;
                //WhiteBoard.Text = iv.Whiteboard;
                //Marker.Text = iv.Marker;
                //Pencil.Text = iv.Pencil;
                //Soap.Text = iv.Clock;
                //PaperBundle.Text = iv.Paperbundle;
                //Pen.Text = iv.Pen;
                //Duster.Text = iv.Duster;
                //GeometryBox.Text = iv.Geometrybox;
                //Ruler.Text = iv.Ruler;
                //Chair.Text = iv.Chair;
                //Bench.Text = iv.Bench;
                //Table.Text = iv.Table;

                iv.Printer = Printer.Text;
                iv.Computer = Computer.Text;
                iv.Mouse = Mouse.Text;
                iv.Keyboard = Keyboard.Text;
                iv.Projector = Projector.Text;
                iv.Camera = Camera.Text;
                iv.Whiteboard = WhiteBoard.Text;
                iv.Marker = Marker.Text;
                iv.Clock = Soap.Text;
                iv.Paperbundle = PaperBundle.Text;
                iv.Pen = Pen.Text;
                iv.Duster = Duster.Text;
                iv.Geometrybox = GeometryBox.Text;
                iv.Ruler = Ruler.Text;
                iv.Chair = Chair.Text;
                iv.Bench = Bench.Text;
                iv.Table = Table.Text; 

                //db.Inventories.InsertOnSubmit(iv);
                db.SubmitChanges();
            }




        }







    }
}
