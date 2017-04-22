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

namespace WindowsFormsApplication1
{
    public partial class SuaGiaoVien : Form
    {
        public static string magv = string.Empty, tengv = string.Empty, ns = string.Empty, gt = string.Empty, dt = string.Empty, 
            trinhdohv = string.Empty, sodt = string.Empty, email = string.Empty, bm = string.Empty, chucvu = string.Empty;


        public SuaGiaoVien()
        {
            InitializeComponent();
        }

        private void grbTTGV_Enter(object sender, EventArgs e)
        {

        }

        private void SuaGiaoVien_Load(object sender, EventArgs e)
        {
            txtMaGV.Text = magv;
            txtHT.Text = tengv;
            dtpNS.Text = ns;
            txtGT.Text = gt;
            txtDT.Text = dt;
            txtTrinhDoHV.Text = trinhdohv;
            txtSoDT.Text = sodt;
            txtEmail.Text = email;
            txtBM.Text = bm;
            txtChucVu.Text = chucvu;
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            string sql = "SuaGV ";
            SqlCommand com = new SqlCommand(sql, Login.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@magv", txtMaGV.Text);
            com.Parameters.AddWithValue("@ten", txtHT.Text);
            com.Parameters.AddWithValue("@ns", Convert.ToDateTime(dtpNS.Text));
            com.Parameters.AddWithValue("@gt", txtGT.Text);
            com.Parameters.AddWithValue("@dt", txtDT.Text);
            com.Parameters.AddWithValue("@trinhdohv", txtTrinhDoHV.Text);
            com.Parameters.AddWithValue("@sdt", txtMaGV.Text);
            com.Parameters.AddWithValue("@email", txtMaGV.Text);
            com.Parameters.AddWithValue("@bomon", txtMaGV.Text);
            com.Parameters.AddWithValue("@chucvu", txtMaGV.Text);
            int count = com.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            else
                MessageBox.Show("Không thể sửa", "Thông báo");
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
