using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class UserControl2 : UserControl
    {
        MySqlConnection conn;

        public Form prevform { get; set; }

        public UserControl2()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=finalnafinal;uid=root; Pwd = root;");

        }
        public void getText(string text)
        {
            username.Text = text;
        }
        private void executeQuery(string q)
        {
            conn.Open();
            MySqlCommand comm = new MySqlCommand(q, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            firstname.ForeColor = Color.Black;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_Click(object sender, EventArgs e)
        {


        }

        private void textBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lastname.ForeColor = Color.Black;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void contact_TextChanged(object sender, EventArgs e)
        {
            contact.ForeColor = Color.Black;
        }

        private void gender_TextChanged(object sender, EventArgs e)
        {
            gender.ForeColor = Color.Black;
        }

        private void contact_Click(object sender, EventArgs e)
        {



        }

        private void gender_Click(object sender, EventArgs e)
        {


        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            email.ForeColor = Color.Black;
        }

        private void loadAll()
        {
            string query = "SELECT * FROM user u inner join login l on l.login_id = u.login_login_id;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["user_id"].Visible = false;
            dataGridView1.Columns["login_login_id"].Visible = false;
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.Columns["login_id"].Visible = false;
            dataGridView1.Columns["firstname"].HeaderText = "First Name";
            dataGridView1.Columns["lastname"].HeaderText = "Last Name";
            dataGridView1.Columns["gender"].HeaderText = "Gender";
            dataGridView1.Columns["contact"].Visible = false;
            dataGridView1.Columns["email"].Visible = false;
            dataGridView1.Columns["username"].Visible = false;
            dataGridView1.Columns["type"].HeaderText = "User Type";
        }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(email.Text);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            

        }
        private void Update_Click(object sender, EventArgs e)
        {
           
        }

        private int select_user_id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void usertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void se_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM user u inner join login l on l.login_id = u.login_login_id where firstname like'" + search.Text + "%';";
            conn.Open();
            MySqlCommand comm = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(comm);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ('+'))
            {
                e.Handled = true;
            }
        }



        private void usereport_Click_1(object sender, EventArgs e)
        {
            
        }

        private void usereport_Click(object sender, EventArgs e)
        {
            UserReport ur = new UserReport();
            ur.id.Text = dataGridView1.CurrentRow.Cells["user_id"].Value.ToString();
            ur.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Update_Click_1(object sender, EventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"[0][9][0-9]{2}[0-9]{3}[0-9]{4}");
            string query = "";
            string query2 = "SELECT firstname FROM user WHERE firstname='" + firstname.Text + "' ";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query2, conn);
            MySqlDataAdapter user = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            user.Fill(dt);
            if (String.IsNullOrEmpty(firstname.Text) && String.IsNullOrEmpty(lastname.Text) && String.IsNullOrEmpty(gender.Text) && String.IsNullOrEmpty(email.Text) && String.IsNullOrEmpty(contact.Text) && String.IsNullOrEmpty(usertype.Text))
            {
                MessageBox.Show("Please choose a user by clicking one.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!String.IsNullOrEmpty(username.Text) || !String.IsNullOrEmpty(newp.Text) || !String.IsNullOrEmpty(retype.Text))
            {
                MessageBox.Show("Username or password can only be updated in the change privacy module!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!phoneNumpattern.IsMatch(contact.Text))
            {
                MessageBox.Show("Incorrect phone number", "Phone Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!IsValid(email.Text))
            {
                MessageBox.Show("Incorrect email address", "Email Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query += " UPDATE user SET firstname='" + firstname.Text + "', lastname='" + lastname.Text + "', gender='" + gender.Text + "', email='" + email.Text + "', contact='" + contact.Text + "', type='" + usertype.Text + "' WHERE user_id='" + id.Text + "'; ";
                MessageBox.Show("User updated!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                executeQuery(query);
                loadAll();
            }
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            Regex phoneNumpattern = new Regex(@"[0][9][0-9]{2}[0-9]{3}[0-9]{4}");
            string query = "SELECT username From login WHERE username='" + username.Text + "' ";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter member = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            member.Fill(dt);
            if (String.IsNullOrEmpty(firstname.Text) ||
                String.IsNullOrEmpty(lastname.Text) ||
                String.IsNullOrEmpty(gender.Text) ||
                String.IsNullOrEmpty(contact.Text) ||
                String.IsNullOrEmpty(email.Text) ||
                String.IsNullOrEmpty(usertype.Text) ||
                String.IsNullOrEmpty(username.Text) ||
                String.IsNullOrEmpty(newp.Text) ||
                String.IsNullOrEmpty(retype.Text))
                MessageBox.Show("Please fill all the fields.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Username already exist. Please choose a different username", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!phoneNumpattern.IsMatch(contact.Text))
                {
                    MessageBox.Show("Incorrect phone number", "Phone Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!IsValid(email.Text))
                {
                    MessageBox.Show("Incorrect email address", "Email Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (newp.Text != retype.Text)
                {
                    MessageBox.Show("Password does not match", "Not matched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query1 = "INSERT INTO login(username, password) values('" + username.Text + "', '" + retype.Text + "')";
                    executeQuery(query1);
                    string query2 = "INSERT INTO user(firstname, lastname, gender, contact, email, type, login_login_id) values('" + firstname.Text + "', '" + lastname.Text + "' , '" + gender.Text + "' , '" + contact.Text + "' , '" + email.Text + "' , '" + usertype.Text + "' , (select login_id from login where username= '" + username.Text + "'))";
                    executeQuery(query2);
                    MessageBox.Show("User added to the database.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadAll();
                }
            }
        }

        private void contact_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                select_user_id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["user_id"].Value.ToString());
                firstname.Text = dataGridView1.Rows[e.RowIndex].Cells["firstname"].Value.ToString();
                lastname.Text = dataGridView1.Rows[e.RowIndex].Cells["lastname"].Value.ToString();
                gender.Text = dataGridView1.Rows[e.RowIndex].Cells["gender"].Value.ToString();
                contact.Text = dataGridView1.Rows[e.RowIndex].Cells["contact"].Value.ToString();
                email.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
                usertype.Text = dataGridView1.Rows[e.RowIndex].Cells["type"].Value.ToString();
                id.Text = dataGridView1.Rows[e.RowIndex].Cells["user_id"].Value.ToString();
            }
        }
    }
}
