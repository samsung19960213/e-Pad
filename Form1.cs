using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace epad
{

    public partial class Form1 : Form
    {
        bool Add_Flag;
        bool val;

        String sex;
        OleDbConnection conn = new OleDbConnection();



        private void DisplayForm3()
        {
            int i;


            Enabled = false;
            Form1 f1 = new Form1();

            f1.Show();
            Form3 f3 = new Form3();
            f3.ShowForm3();


            for (i = 1; i <= 10000; i++)
            {
                f3.ShowForm3();
            }

            // Let the splash screen know we are ready
            // to begin work.

        }

        public void ClearFields()
        {
            addnew.Enabled = true;
            save.Enabled = false;
            savenotes.Enabled = false;
            regno.Text = "";
            address.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            male.Checked = true;
            female.Checked = false;
            pracnotes.Text = "";
            age.Text = "";
            name.Text = "";
            email.Text = "";
            phoneno.Text = "";
            txtsrc.Text = "(Enter Name or Phone or Reg.No)";
            pres.Text = "";

        }
        private void checkblank()
        {
            // Removed the prescription check as it is not madatory to have prescription while adding the new patient.
            // Prescription can be entered later
            if (name.Text == "" | address.Text == "")
                val = true;
            else
                val = false;
        }

        //private void GetRegNo()
        // {
        //  string lastPatient = "SELECT Max(patient_no) FROM Table";

        //  OleDbConnection conn = new OleDbConnection();
        //  OleDbCommand cmd = new OleDbCommand(lastPatient, conn);
        //   conn.Open();

        //   OleDbDataReader dataReader;
        //    dataReader = cmd.ExecuteReader();
        //  while (dataReader.Read())

        //   {
        //   if (dataReader !=null)
        //    
        // if (!IsDBNull(dataReader(0)))
        //    pno = dataReader.Equals.
        //    else
        //         pno = 1;
        //   }
        //  lastPatient = "SELECT register_no from Patients where patient_no like'" + pno + "'";
        // cmd = new OleDb.OleDbCommand(lastPatient, conn);
        //  dataReader = cmd.ExecuteReader;
        //  while (dataReader.Read())
        ///{
        //      if (!IsDBNull(dr(0)))
        //    pno = dataReader(0) + 1;
        //  else
        //      pno = 1;
        //     }
        //  TxtRegNo.Text = pno;
        //  conn.Close();
        // }


        public Form1()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\visual studio\epadDb.accdb";
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel41_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel42_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phoneno_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regno_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addnew_Click(object sender, EventArgs e)
        {
            string ConnectionString;
            OleDbConnection conn;

            ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sam\Desktop\e-pad\epadDb.accdb";
            conn = new OleDbConnection(ConnectionString);

            OleDbCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Patient (Address,Last_Visit,Date_Of_Joining,Prescription,Patient_Notes,Name,Phone,E-mail,Patient_No,Age) VALUES ('" + address.Text + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "','" + pres.Text + "','" + pracnotes.Text + "','" + name.Text + "','" + phoneno.Text + "','" + email.Text + "','" + regno.Text + "','" + age.Text + "',)";
            
            cmd.ExecuteNonQuery();


            

            MessageBox.Show("New Data Recorded");
            conn.Close();

            //C:\Users\Sam\Desktop\e-pad\epadDbDataSet.xsd


            ClearFields();

            Add_Flag = true;

            save.Enabled = true;
            //GetRegNo();
            addnew.Enabled = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (Add_Flag == true)
            {
                Save_Patient();
                savenotes.Enabled = true;
            }
            else
            {
                Update_Patient();
                savenotes.Enabled = true;
            }
        }

        private void Save_Patient()
        {
            string Reg;
            OleDbConnection conn = new OleDbConnection();
            OleDbDataAdapter adapter = new OleDbDataAdapter();



            checkblank();
            if (val)
                MessageBox.Show("Please fill all the fields for the new patient.");
            else
            {
                if (male.Checked == true)
                    sex = "Male";
                else
                    sex = "Female";

                string querystring = "";
                // OleDbConnection conn = new OleDbConnection();



                if (pracnotes.Text == "")
                    pracnotes.Text = " ";

                querystring = "INSERT INTO Tables (Patient_No, Address, Last_Visit, Date_Of_Joining, Precription, Sex, Name, Phone, E_mail, Age,Patitent_Notes,) VALUES ('" + regno + "','" + address.Text + "',#" + dateTimePicker1.Value + "#,#" + dateTimePicker2.Value + "#,'" + pres.Text + "','" + sex + "','" + name.Text + "','" + phoneno.Text + "','" + email.Text + "','" + age.Text + "','" + pracnotes.Text + "');";
                OleDbCommand cmd = new OleDbCommand(querystring, conn);

                adapter.InsertCommand = new OleDbCommand(querystring, conn);
                adapter.InsertCommand.ExecuteNonQuery();
                Reg = regno.Text;
                MessageBox.Show("Record inserted. Register No : " + regno);

                save.Enabled = false;
                addnew.Enabled = true;
                conn.Close();
            }
        }

        private void Update_Patient()
        {
            string querystring = "";
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            Add_Flag = false;
            checkblank();
            if (val)
                MessageBox.Show("No Fields are there to Update.");
            else
            {
                if (male.Checked == true)
                    sex = "Male";
                else
                    sex = "Female";

                if (savenotes.Text == "")
                    savenotes.Text = " ";

                conn.Open();
                querystring = "UPDATE Table SET  name ='" + name.Text + "', address ='" + address.Text + "', last_visit = #" + dateTimePicker1 + "#, date_of_join = #" + dateTimePicker2.Value + "#, sex = '" + sex + "', phone='" + phoneno.Text + "', e_mail='" + email.Text + "', age = '" + age.Text + "', [Precription] = '" + pres.Text + "' WHERE Patient_No LIKE '" + regno.Text + "'";
                adapter.InsertCommand = new OleDbCommand(querystring, conn);
                adapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("Patient information is updated");

                ClearFields();
                conn.Close();
            }
        }


        private void panel28_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel44_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel32_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel40_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel43_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pres.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'epadDbDataSet.Table' table. You can move, or remove it, as needed.
            //this.tableTableAdapter.Fill(this.epadDbDataSet.Table);
            // TODO: This line of code loads data into the 'epadDbDataSet.Query2' table. You can move, or remove it, as needed.
            //this.query2TableAdapter.Fill(this.epadDbDataSet.Query2);
            // TODO: This line of code loads data into the 'epadDbDataSet.Query1' table. You can move, or remove it, as needed.
            //this.query1TableAdapter.Fill(this.epadDbDataSet.Query1);
            ClearFields();
            Add_Flag = false;

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.query2TableAdapter.FillBy(this.epadDbDataSet.Query2);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void settings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }
    }
}
