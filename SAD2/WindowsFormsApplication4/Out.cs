using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class Out : Form
    {
        MySqlConnection conn;
        public Out()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=final;uid=root; Pwd = root;");
        }

        private void Out_Load(object sender, EventArgs e)
        {
            string query = "select description from product;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                name.Items.Add(dt.Rows[x][0].ToString());
            }
        }
        private void executeQuery(string q)
        {
            conn.Open();
            MySqlCommand comm = new MySqlCommand(q, conn);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            string query = "select stock_in, stock_out from product where description='" + name.Text + "';";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            int input = Int32.Parse(quan.Text);
            int s_in = Int32.Parse(dt.Rows[0][0].ToString());
            int s_out = Int32.Parse(dt.Rows[0][1].ToString());
            int dif = (s_in - input);
            int sum = input + s_out;
            if (String.IsNullOrEmpty(quan.Text))
            {
                MessageBox.Show("Please fill up the field.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (dif < 0)
                {
                    MessageBox.Show("Lacking stocked in items.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string query1 = "UPDATE product SET stock_in='" + s_in + "'- '" + input + "', stock_out='" + sum + "' where description= '" + name.Text + "';";
                    MessageBox.Show("Stocked out '" + input + "' items!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    executeQuery(query1);
                    this.Close();
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
