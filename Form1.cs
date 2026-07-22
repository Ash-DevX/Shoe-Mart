using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shoe_Mart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {

                string constr = ConfigurationManager.ConnectionStrings["ShoemartConnection"].ToString();
                SqlConnection con = new SqlConnection(@"Data Source=MS;Initial Catalog=Shoemart;Integrated Security=True;TrustServerCertificate=True");

                {
                    // Check for empty fields
                    if (Login_UName_tb.Text.Trim() == "" || Login_Pass_tb.Text.Trim() == "")
                    {
                        MessageBox.Show("Please fill all fields.");
                        return;
                    }
                    {
                        SqlCommand cmd = new SqlCommand("sp_login", con);
                        cmd.CommandType = CommandType.StoredProcedure;


                        con.Open();

                        cmd.Parameters.Add("@UName", SqlDbType.VarChar);
                        cmd.Parameters["@UName"].Value = Login_UName_tb.Text.Trim();

                        cmd.Parameters.Add("@Pass", SqlDbType.VarChar);
                        cmd.Parameters["@Pass"].Value = Login_Pass_tb.Text.Trim();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            MessageBox.Show("Welcome Back " + Login_UName_tb.Text);

                            this.Hide();

                            NewUserPage nup = new NewUserPage();
                            nup.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password.");

                            Login_Pass_tb.Clear();
                            Login_Pass_tb.Focus();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
