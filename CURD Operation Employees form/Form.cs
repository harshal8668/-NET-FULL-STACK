using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace CURD_Win_APK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Establishing connection with database
        SqlConnection con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Employees; Integrated Security = True");
        

        //insert
        private void button2_Click(object sender, EventArgs e)
        {

            int eid = int.Parse(textBox2.Text), eage = int.Parse(textBox4.Text);
            string ename = textBox1.Text, ecity = comboBox1.Text, esex = "";
            long econt = long.Parse(textBox3.Text);
            if (radioButton1.Checked) { esex = "Male"; }
            else { esex = "Female"; }
            con.Open();
            SqlCommand c = new SqlCommand("exec InsertData '" + eid + "','" + ename + "','" + econt + "','" + eage + "','" + esex + "','" + ecity + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Insertion Successfull....");
            GetEmpList(eid);
            con.Close();
        }
        
        //update
        private void button4_Click(object sender, EventArgs e)
        {

            int eid = int.Parse(textBox2.Text), eage = int.Parse(textBox4.Text);
            string ename = textBox1.Text, ecity = comboBox1.Text, esex = "";
            long econt = long.Parse(textBox3.Text);
            if (radioButton1.Checked) { esex = "Male"; }
            else { esex = "Female"; }
            con.Open();
            SqlCommand c = new SqlCommand("exec UpdateData '" + eid + "','" + ename + "','" + econt + "','" + eage + "','" + esex + "','" + ecity + "'", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Updation Successfull....");
            GetEmpList(eid);
            con.Close();

        }
        
        //delete
        private void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you Sure?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int eid = Convert.ToInt32(textBox2.Text);
                con.Open();
                SqlCommand c = new SqlCommand("exec DeleteData '" + eid + "'", con);
                c.ExecuteNonQuery();
                MessageBox.Show("Deletion Successfull....");
                GetEmpList(eid);
                con.Close();
            }
        }
        
        //Display
        void GetEmpList(int eid)
        {

            SqlCommand c = new SqlCommand("exec ViewData '" + eid + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
       
        //View
        private void button3_Click(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(textBox2.Text);
            con.Open();
            GetEmpList(eid);
            con.Close();
        }

        //View All
        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand c = new SqlCommand("exec DisplayData ", con);
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

    }
}
