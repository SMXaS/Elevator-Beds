using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace Lift
{
    public partial class backGround : Form
    {
        // Lifts moving x and y possition 
        // Boolean of going up and going down to disable buttons while moving
        int y_up = 63;
        int y_down = 330;
        bool go_up = false;
        bool go_down = false;

        // Database Initialization

        private DataSet datas = new DataSet();
        private string dataBConnection;
        private string dataBCommand;
        private OleDbConnection conn;
        private OleDbCommand comm;
        private OleDbDataAdapter adapt;
        private OleDbCommandBuilder dbuilder;


        // Applications rounded mode, no sharp edges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int left,
            int top,
            int right,
            int bottom,
            int width,
            int weight);

        public backGround()
        {
            InitializeComponent();

            //Creating round windows,
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void liftClosedDoors_Click(object sender, EventArgs e)
        {

        }

        private void timerLiftUp_Tick(object sender, EventArgs e)
        {
            //Animation where lift moves up
            if (insideLift.Top >= y_up)
            {
                insideLift.Top -= 1;
            }
            // Checks if lift is moving and disables the button of pressing button up
            else
            {
                timerLiftUp.Enabled = false;

                insideLift.Image = global::Lift.Properties.Resources.Inside_Lift;
                go_up = false;
            }
        }

        private void timerLiftDown_Tick_1(object sender, EventArgs e)
        {
            //Animation where lift moves down
            if (insideLift.Top <= y_down)
            {
                insideLift.Top += 1;
            }
            else
            // Checks if lift is moving and disables the button of pressing button down
            {
                timerLiftDown.Enabled = false;

                insideLift.Image = global::Lift.Properties.Resources.Inside_Lift;
                go_down = false;
            }
        }

        //Animation Timer for doors opening down
        private void door_open_down()
        {

            timerLiftDownDoorsClosed.Enabled = false;
            timerLiftDownDoorsOpen.Enabled = true;
        }

        //Animation Timer for doors closing down
        private void door_close_down()
        {

            timerLiftDownDoorsClosed.Enabled = true;
            timerLiftDownDoorsOpen.Enabled = false;
        }

        //Animation Timer for doors opening up
        private void door_open_up()
        {

            timerLiftUpDoorsOpen.Enabled = false;
            timerLiftUpDoorsClosed.Enabled = true;
        }

        //Animation Timer for doors closing up
        private void door_close_up()
        {

            timerLiftUpDoorsClosed.Enabled = true;
            timerLiftUpDoorsOpen.Enabled = false;
        }

        private void timerLiftUpDoorsOpen_Tick(object sender, EventArgs e)
        {

        }

        private void timerLiftUpDoorsClosed_Tick(object sender, EventArgs e)
        {

        }

        private void timerLiftDownDoorsOpen_Tick(object sender, EventArgs e)
        {

        }

        private void timerLiftDownDoorsClosed_Tick(object sender, EventArgs e)
        {

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (go_down)
            {
                return;
            }
            
            timerLiftUp.Start();
            insertData("Lift Going Up");
            go_up = true;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (go_up)
            {
                return;
            }

            timerLiftDown.Start();
            insertData("Lift Going Down");
            go_down = true;
        }

        private void dataBaseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backGround_Load(object sender, EventArgs e)
        {
            // DataBase Connection 

            /* Getting connection from the directory where is the database file. Source code is been written to get access 2002 working
             * Command, selecting ID, Date, Time, floorNumber from the table
             * Setting variable shortcut names with connections 
             */
            dataBConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\SMXaS\Desktop\C# Elevator app\Lift\Lift\bin\Debug\ElevatorDatabase2.mdb;User Id=admin;
Password=;";
            dataBCommand = "Select ID, Date, Time, floorNumber from ActionsTable;";
            conn = new OleDbConnection(dataBConnection);
            comm = new OleDbCommand(dataBCommand, conn);
            adapt = new OleDbDataAdapter(comm);
            //load_data_from_db_to_ds();
            //update_listbox();
            dbuilder = new OleDbCommandBuilder(adapt);

        }

        private void load_data_from_db_to_ds()
        {
            try
            {
                conn.Open();
                adapt.Fill(datas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void insertData (string action)
        {
            /*Inserting Data into the DataBase Access file Function
             * Gets the connection link and has a command line which provides the action to do
             * For now it inserts data of Date, Time and floorNumber that lift is going to
             * It gets the current date of the local machine and the time of it and populates it
             * In the GUI, listbox of DataBase is being populated
             * Setting a new connection and checking if old one still there
             * Setting a new command which will insert data into the old db command which contains table with data types
             * Making new adapter inserting
             * Inserting parameters of date, time and floorNumber
             * Opening connection, Executing INSERT query and closing it up 'Fills data in the Database File'
             */
            dataBConnection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\SMXaS\Desktop\C# Elevator app\Lift\Lift\bin\Debug\ElevatorDatabase2.mdb;User Id=admin;
Password=;";
            dataBCommand = "INSERT INTO [ActionsTable] ([Date], [Time], [floorNumber]) values (@date, @time, @floorNumber)";
            string date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToLongTimeString();

            dataBaseListBox.Items.Add(date + "\t\t" + time + "\t\t" + action);

            OleDbConnection connecDb = new OleDbConnection(dataBConnection);
            OleDbCommand commaInsert = new OleDbCommand(dataBCommand, connecDb);
            OleDbDataAdapter adapInsert = new OleDbDataAdapter(commaInsert);
            commaInsert.Parameters.AddWithValue("@date", date);
            commaInsert.Parameters.AddWithValue("@time", time);
            commaInsert.Parameters.AddWithValue("@floorNumber", action);

            connecDb.Open();

            commaInsert.ExecuteNonQuery();

            connecDb.Close();
        }

        private void clearListBox_Click(object sender, EventArgs e)
        {
            dataBaseListBox.Items.Clear();
        }

        private void requestButtonUp_Click(object sender, EventArgs e)
        {
            if (go_down)
            {
                return;
            }

            timerLiftUp.Start();
            insertData("Lift Going Up");
            go_up = true;
        }

        private void requestButtonDown_Click(object sender, EventArgs e)
        {
            if (go_up)
            {
                return;
            }

            timerLiftDown.Start();
            insertData("Lift Going Down");
            go_down = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (timerLiftUp.Enabled)
            {
                exitButton.Enabled = false;
            }
            else if (timerLiftDown.Enabled){

                exitButton.Enabled = false;
            }
            else
            {
                Close();
            }
        }
    }
}

// Check possitions of x and y of picture in the timers
// Work on database


