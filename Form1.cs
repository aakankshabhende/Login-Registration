using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginRegister
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True");
            cn.Open();

        }

        private void rebbtn_Click(object sender, EventArgs e)
        {
            if(pass.Text != string.Empty || cpass.Text != string.Empty || user.Text != string.Empty)
            {
                if (pass.Text == cpass.Text)
                {
                    cmd = new SqlCommand("select * from users where username='" + user.Text + "' " , cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();                    
                        MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into users values (@username, @password)", cn);
                        cmd.Parameters.AddWithValue("username", user.Text);
                        cmd.Parameters.AddWithValue("password", pass.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account created, login now", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Enter both passwords same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void log_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
