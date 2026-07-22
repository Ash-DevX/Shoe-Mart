using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Shoe_Mart
{
    public partial class NewUserPage : Form
    {
        public NewUserPage()
        {
            InitializeComponent();
        }


        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {

                string conStr = ConfigurationManager.ConnectionStrings["ShoemartConnection"].ToString();
                SqlConnection con = new SqlConnection(conStr);
                {

                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_Add", con);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add("@UName", SqlDbType.VarChar);
                    cmd.Parameters["@UName"].Value = Add_UName_tb.Text.Trim();

                    cmd.Parameters.Add("@Pass", SqlDbType.VarChar);
                    cmd.Parameters["@Pass"].Value = Add_Pass_tb.Text.Trim();

                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                    {
                        MessageBox.Show("User Added Successfully.");

                        // Clear TextBoxes
                        Add_UName_tb.Clear();
                        Add_Pass_tb.Clear();
                        Add_UName_tb.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add user.");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Do nothing, user canceled the exit
            }
        }

        private void MAX_btn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void MIN_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewPage VP = new ViewPage();
            VP.Show();
        }

        private void Add_Pass_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
