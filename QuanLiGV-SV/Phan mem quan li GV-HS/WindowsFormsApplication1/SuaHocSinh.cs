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
    public partial class SuaHocSinh : Form
    {
        public static string mahs = string.Empty, tenhs = string.Empty, ns = string.Empty, gt = string.Empty, dt = string.Empty,
            diachi = string.Empty, lop = string.Empty;


        public SuaHocSinh()
        {
            InitializeComponent();
        }

        private void SuaHocSinh_Load(object sender, EventArgs e)
        {
            txtMaHS.Text = mahs;
            txtHT.Text = tenhs;
            dtpNS.Text = ns;
            txtGT.Text = gt;
            txtDT.Text = dt;
            txtDC.Text = diachi;
            txtLop.Text = lop;
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            string sql = "SuaHS ";
            SqlCommand com = new SqlCommand(sql, Login.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@mahs", txtMaHS.Text);
            com.Parameters.AddWithValue("@ten", txtHT.Text);
            com.Parameters.AddWithValue("@ngaysinh", Convert.ToDateTime(dtpNS.Text));
            com.Parameters.AddWithValue("@gt", txtGT.Text);
            com.Parameters.AddWithValue("@dt", txtDT.Text);
            com.Parameters.AddWithValue("@diachi", txtDC.Text);
            com.Parameters.AddWithValue("@lop", txtLop.Text);
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
