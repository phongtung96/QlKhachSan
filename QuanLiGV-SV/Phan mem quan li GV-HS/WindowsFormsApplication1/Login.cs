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

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=NGUYENHIEP\SQLEXPRESS;Initial Catalog=QuanLiHS-GV;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }
        
        private void Login_Load(object sender, EventArgs e)
        {
            con.Open();
        }
        private void Login_GV()
        {
            string sql = "LoginGV ";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ten", txtName.Text);
            com.Parameters.AddWithValue("@mk", txtPass.Text);

            int x = (int)com.ExecuteScalar();
            if (x == 1)
            {
                Main.Username = txtName.Text;
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                lbWrong.Text = "Username or Password is wrong";
                txtName.Text = "";
                txtPass.Text = "";
                txtName.Focus();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Login_GV();
        }

        private void ckbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShow.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                Login_GV();
            }
        }
    }
}
