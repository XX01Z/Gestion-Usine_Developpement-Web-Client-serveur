﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Usine
{
    public partial class Employe : Form
    {
        Database con = new Database();

        public Employe()
        {
            InitializeComponent();
        }

        private void GetTables()
        {
            // get Employe
            if (con.Set.Tables["Employe"] != null)
            {
                con.Set.Tables["Employe"].Clear();
            }
            con.Adapter = new SqlDataAdapter("select * from Employe", con.db);
            con.Adapter.Fill(con.Set, "Employe");
        }

        private bool Search(int id,string table,string colonm)
        {
            bool RowIndex = false;
            var result = from row in con.Set.Tables[table.ToString()].AsEnumerable()
                         where row.Field<int>(colonm.ToString()) == (int)id
                         select row;

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult d;
            d = MessageBox.Show("Voulez-vous que tous les champs sont vides ?", "Nouveau", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                maskedTextBox1.Text = "";
                maskedTextBox2.Text = "";
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //var dataRow = db.ds.Tables["Employe"].AsEnumerable().Where(x => x.Field<int>("Id") == 2).FirstOrDefault();
            /*
            var result = from row in db.ds.Tables["Employe"].AsEnumerable()
                                    where row.Field<int>("Mat") == 1
                                    select row;
            */
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" || textBox2.Text != "" || textBox3.Text == "" || textBox5.Text != "" || maskedTextBox1.Text != "" || maskedTextBox2.Text != "")
            {
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Employe_Load(object sender, EventArgs e)
        {
            con.Connection();
            GetTables();
            con.Disconnection();
        }
    }
}