using System.Data;
using System.Data.SqlClient;

namespace Employees_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection
            ("Data Source=DESKTOP-4G199F4\\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True");
        //SqlConnection conn = new SqlConnection
        //    ("Server = DESKTOP-4G199F4\\SQLEXPRESS;database=PhoneBook;user=sa;password=1234;");

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //int empID = int.Parse(textBoxID.Text);
            string empName = textBoxName.Text;
            string empCity = comboBoxCity.Text;
            int empAge = int.Parse(textBoxAge.Text);
            string empContact = textBoxContact.Text;
            DateTime empDate = DateTime.Parse(dateTimePickerJoin.Text);

            string empSex = radioBtnMale.Checked ? "Male" : "Female";

            conn.Open();
            string sqlCommand = "INSERT INTO EmployeeTest1 " +
                 "(Emp_Name,City,Age,Sex,Contact,JoinDate) VALUES " +
                 "(@EmpName, @EmpCity, @EmpAge, @EmpSex, @EmpContact, @EmpDate)";
            SqlCommand cmdInsert = new SqlCommand(sqlCommand, conn);

            //cmdUpdate.Parameters.AddWithValue("@EmpID", empID);
            cmdInsert.Parameters.AddWithValue("@EmpName", empName);
            cmdInsert.Parameters.AddWithValue("@EmpCity", empCity);
            cmdInsert.Parameters.AddWithValue("@EmpAge", empAge);
            cmdInsert.Parameters.AddWithValue("@EmpSex", empSex);
            cmdInsert.Parameters.AddWithValue("@EmpContact", empContact);
            cmdInsert.Parameters.AddWithValue("@EmpDate", empDate);
            //SqlCommand cmdInsert = new SqlCommand
            //    ("exec InsertEmp_SP1 '" + empName + "','" + empCity + "'," +
            //    "'" + empAge + "','" + empSex + "', '" + empContact + "','" + empDate + "' ", conn);
            cmdInsert.ExecuteNonQuery();
            MessageBox.Show("Successfully inserted...");
            conn.Close();
            Clear();
            GetEmpList();
        }
        void GetEmpList()
        {
            SqlCommand cmdGet = new SqlCommand("exec ListEmp_SP1", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmdGet);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }
        private void GetDataByName(string Value)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter
                ("select Emp_ID, Emp_Name, City," +
                "Age, " +
                "Sex, Contact, JoinDate from EmployeeTest1 where Emp_Name like" +
                "'%'+@EmpName+'%' order by Emp_Name asc", conn);
            da.SelectCommand.Parameters.AddWithValue("@EmpName", Value);
            da.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];
            dataGridView.Columns[0].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmpList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int empID = int.Parse(textBoxID.Text); // if exists *******************************
            string empName = textBoxName.Text;
            string empCity = comboBoxCity.Text;
            double empAge = double.Parse(textBoxAge.Text);
            string empContact = textBoxContact.Text;
            DateTime empDate = DateTime.Parse(dateTimePickerJoin.Text);

            string empSex = radioBtnMale.Checked ? "Male" : "Female";

            conn.Open();
            //*************************** P A R A M E T A R I Z O V A N I *********************************
            string sqlCommand = "UPDATE EmployeeTest1 set Emp_Name=@EmpName,City=@EmpCity,Age=@EmpAge,Sex=@EmpSex,Contact=@EmpContact,JoinDate=@EmpDate where Emp_ID =@EmpID";
            SqlCommand cmdUpdate = new SqlCommand(sqlCommand, conn);

            cmdUpdate.Parameters.AddWithValue("@EmpID", empID);
            cmdUpdate.Parameters.AddWithValue("@EmpName", empName);
            cmdUpdate.Parameters.AddWithValue("@EmpCity", empCity);
            cmdUpdate.Parameters.AddWithValue("@EmpAge", empAge);
            cmdUpdate.Parameters.AddWithValue("@EmpSex", empSex);
            cmdUpdate.Parameters.AddWithValue("@EmpContact", empContact);
            cmdUpdate.Parameters.AddWithValue("@EmpDate", empDate);

            cmdUpdate.ExecuteNonQuery();
            MessageBox.Show("Update successful...");
            conn.Close();
            Clear();
            GetEmpList();
            //*********************** S K R I V E N A   P R O C E D U R A ********************************

            //SqlCommand cmdUpdate = new SqlCommand
            //    ("exec UpdateEmp_SP '" + empID + "','" + empName + "','" + empCity + "'," +
            //    "'" + empAge + "','" + empSex + "', '" + empContact + "','" + empDate + "' ", conn);
            //cmdUpdate.ExecuteNonQuery();
            //MessageBox.Show("Update successful...");
            //GetEmpList();
        }

        int empID = 0;
        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            empID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value);

            SqlCommand com = new SqlCommand
                ("select * from EmployeeTest1 Where Emp_ID=@EmpID", conn);
            com.Parameters.AddWithValue("@EmpID", empID);
            conn.Open();

            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                textBoxID.Text = dr["Emp_ID"].ToString();
                textBoxName.Text = dr["Emp_Name"].ToString();
                comboBoxCity.Text = dr["City"].ToString();
                textBoxAge.Text = dr["Age"].ToString();

                //*********************************************
                // Ovde ništa nisam bio dirao i na dupli klik lepo je obeležavalo dugmenca, a sada ne radi.
                //...ma šta da kliknem, uvek mi obeleži "Female". 

                if (dr["Sex"].ToString() == "Male")
                {
                    radioBtnMale.Checked = true;
                    radioBtnFemale.Checked = false;
                }
                else
                { 
                    radioBtnFemale.Checked = true; 
                    radioBtnMale.Checked = false;
                }
                // ***********************************************************

                textBoxContact.Text = dr["Contact"].ToString();
                dateTimePickerJoin.Text = dr["JoinDate"].ToString();
            }
            dr.Close();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You Are About To Delete . Are You Sure?", "Warnning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            SqlCommand com = new SqlCommand("delete from EmployeeTest1 Where Emp_ID=@EmpID", conn);

            com.Parameters.AddWithValue("@EmpID", empID);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            GetEmpList();
            empID = 0;
        }
        private void Clear()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox && c.TabStop == true)
                {
                    c.ResetText();
                }
                radioBtnMale.Checked = false;
                radioBtnFemale.Checked = false;
                comboBoxCity.ResetText();
                empID = 0;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            GetDataByName(textBoxSearch.Text);
        }
    }
}