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
    public partial class ThemHS : Form
    {
        public ThemHS()
        {
            InitializeComponent();
        }

        private void ThemHS_Load(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string sql = "ThemGV ";
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
