﻿using System;
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
    public partial class prod : Form
    {
        MySqlConnection conn;
        public UserControl a3;
        public prod()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;Database=final;uid=root; Pwd = root;");
        }
        private void executeQuery(string q)
        {
            conn.Open();
            MySqlCommand comm = new MySqlCommand(q, conn);
            comm.ExecuteNonQuery();
            conn.Close();

        }


        private void loadAll2()
        {
            string query = "select name from category;";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                categ.Items.Add(dt.Rows[x][0].ToString());
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string query = "SELECT p.product_id From product p inner join category c WHERE description='" + desc.Text + "' and unit='" + unit.Text + "';  ";
            conn.Open();
            MySqlCommand com = new MySqlCommand(query, conn);
            MySqlDataAdapter user = new MySqlDataAdapter(com);
            conn.Close();
            DataTable dt = new DataTable();
            user.Fill(dt);
            if (String.IsNullOrEmpty(desc.Text) || String.IsNullOrEmpty(categ.Text))
            {
                MessageBox.Show("Please fill up all the fields.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Add product?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (dt.Rows.Count >= 1) MessageBox.Show("Product already exist. Please choose a different product", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        string query1 = "INSERT INTO product(description, unit, purchase_price, store_price, inc, cur_price, stock_in, stock_out, tot_quantity, cost_quantity, category_cat_id) VALUES('" + desc.Text + "', '" + unit.Text + "' ,0 ,0, 0, 0, 0, 0, 0, 0, (SELECT cat_id FROM category WHERE name='" + categ.Text + "'));";
                        MessageBox.Show("Product added!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        executeQuery(query1);
                        Purchasing p = new Purchasing();
                        p.loadAll();
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                }
            }
        }

        private void AddC_Click(object sender, EventArgs e)
        {
            addcategoryp a = new addcategoryp();
            a.a3 = this;
            DialogResult res = a.ShowDialog();
            if (res == DialogResult.Yes)
            {
                a.Show();
                loadAll2();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prod_Load(object sender, EventArgs e)
        {
            loadAll2();
        }
    }


    }
