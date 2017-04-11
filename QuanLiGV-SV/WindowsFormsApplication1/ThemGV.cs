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
    public partial class ThemGV : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N728DT6\SQLEXPRESS;Initial Catalog=QuanLiHS-GV;Integrated Security=True");
        public ThemGV()
        {
            InitializeComponent();
        }

        private void ThemGV_Load(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string sql = "ThemGV ";
            SqlCommand com = new SqlCommand(sql, con);
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
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
                MessageBox.Show("Không thể thêm", "Thông báo");
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
