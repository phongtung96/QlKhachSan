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
    public partial class Main : Form
    {
        public static string Username = string.Empty;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            grbTB.Show();
            grbHS.Hide();
            grbGV.Hide();
        }

        private void mntThemGV_Click(object sender, EventArgs e)
        {
            ThemGV gv = new ThemGV();
            gv.Show();
        }

        private void mntThemHS_Click(object sender, EventArgs e)
        {
            ThemHS hs = new ThemHS();
            hs.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTB_Click(object sender, EventArgs e)
        {
            grbTB.Show();
            grbHS.Hide();
            grbGV.Hide();
        }

        private void btHS_Click(object sender, EventArgs e)
        {
            string sql = "DS_HS ";
            SqlCommand com = new SqlCommand(sql, Login.con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHS.DataSource = dt;
            dgvHS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grbTB.Hide();
            grbGV.Hide();
            grbHS.Show();
        }

        private void btGV_Click(object sender, EventArgs e)
        {
            string sql = "DS_GV";
            SqlCommand com = new SqlCommand(sql, Login.con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGV.DataSource = dt;
            dgvGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grbTB.Hide();
            grbHS.Hide();
            grbGV.Show();
        }

        private void dgvGV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvGV.Rows[e.RowIndex].Cells["STTGV"].Value = e.RowIndex + 1;
        }

        private void dgvHS_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvHS.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void TimKiemGV()
        {
            string sql = "TimKiemGV ";
            SqlCommand com = new SqlCommand(sql, Login.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@magv", txbMaGV.Text);
            com.Parameters.AddWithValue("@ten", txbTenGV.Text);
            com.Parameters.AddWithValue("@ns", Convert.ToDateTime(dtpNSGV.Text));
            com.Parameters.AddWithValue("@bomon", cboBM.Text);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGV.DataSource = dt;
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void txbMaGV_Leave(object sender, EventArgs e)
        {
            TimKiemGV();
        }

        private void txbMaGV_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TimKiemGV();
            }
        }

        private void txbHT_Leave(object sender, EventArgs e)
        {
            TimKiemGV();
        }

        private void txbTenGV_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TimKiemGV();
            }
        }

        private void dtpNSGV_ValueChanged(object sender, EventArgs e)
        {
            TimKiemGV();
        }

        private void cboBM_SelectedValueChanged(object sender, EventArgs e)
        {
            TimKiemGV();
        }

        private void TimKiemHS()
        {
            string sql = "TimKiemHS ";
            SqlCommand com = new SqlCommand(sql, Login.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@mahs", txbMaHS.Text);
            com.Parameters.AddWithValue("@ten", txbTenHS.Text);
            com.Parameters.AddWithValue("@ns", Convert.ToDateTime(dtpNSHS.Text));
            com.Parameters.AddWithValue("@lop", cboLop.Text);
            com.Parameters.AddWithValue("@namhoc", cboNamHoc.Text);

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHS.DataSource = dt;
        }

        private void txbMaHS_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TimKiemHS();
            }
        }

        private void txbMaHS_Leave(object sender, EventArgs e)
        {
            TimKiemHS();
        }

        private void txbTenHS_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                TimKiemHS();
            }
        }

        private void txbTenHS_Leave(object sender, EventArgs e)
        {
            TimKiemHS();
        }

        private void dtpNSHS_ValueChanged(object sender, EventArgs e)
        {
            TimKiemHS();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemHS();
        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemHS();
        }
        
        private void dgvGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SuaGiaoVien.magv = Convert.ToString(dgvGV.CurrentRow.Cells["IdGV"].Value);
            SuaGiaoVien.tengv = Convert.ToString(dgvGV.CurrentRow.Cells["TenGV"].Value);
            SuaGiaoVien.ns = Convert.ToString(dgvGV.CurrentRow.Cells["NgaySinh"].Value);
            SuaGiaoVien.gt = Convert.ToString(dgvGV.CurrentRow.Cells["GioiTinh"].Value);
            SuaGiaoVien.dt = Convert.ToString(dgvGV.CurrentRow.Cells["DanToc"].Value);
            SuaGiaoVien.trinhdohv = Convert.ToString(dgvGV.CurrentRow.Cells["trinhDoHV"].Value);
            SuaGiaoVien.sodt = Convert.ToString(dgvGV.CurrentRow.Cells["SoDT"].Value);
            SuaGiaoVien.email = Convert.ToString(dgvGV.CurrentRow.Cells["Email"].Value);
            SuaGiaoVien.bm = Convert.ToString(dgvGV.CurrentRow.Cells["BoMon"].Value);
            SuaGiaoVien.chucvu = Convert.ToString(dgvGV.CurrentRow.Cells["ChucVu"].Value);

            btSuaGV.Enabled = true;
            btXoaGV.Enabled = true;
        }

        private void btSuaGV_Click(object sender, EventArgs e)
        {
            SuaGiaoVien sgv = new SuaGiaoVien();
            sgv.Show();
        }

        private void dgvGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SuaHocSinh.mahs = Convert.ToString(dgvHS.CurrentRow.Cells["IdHS"].Value);
            SuaHocSinh.tenhs = Convert.ToString(dgvHS.CurrentRow.Cells["TenHS"].Value);
            SuaHocSinh.ns = Convert.ToString(dgvHS.CurrentRow.Cells["NS"].Value);
            SuaHocSinh.gt = Convert.ToString(dgvHS.CurrentRow.Cells["GT"].Value);
            SuaHocSinh.dt = Convert.ToString(dgvHS.CurrentRow.Cells["DT"].Value);
            SuaHocSinh.lop = Convert.ToString(dgvHS.CurrentRow.Cells["TenLop"].Value);
            SuaHocSinh.diachi = Convert.ToString(dgvHS.CurrentRow.Cells["DiaChi"].Value);

            btSuaHS.Enabled = true;
            btXoaHS.Enabled = true;
        }

        private void btSuaHS_Click(object sender, EventArgs e)
        {
            SuaHocSinh shs = new SuaHocSinh();
            shs.Show();
        }

        private void dgvHS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            KQHT.mahs = Convert.ToString(dgvHS.CurrentRow.Cells["IdHS"].Value);
            KQHT.tenhs = Convert.ToString(dgvHS.CurrentRow.Cells["TenHS"].Value);
            KQHT.lop = Convert.ToString(dgvHS.CurrentRow.Cells["TenLop"].Value);
            KQHT.ns = Convert.ToString(dgvHS.CurrentRow.Cells["NS"].Value);

            KQHT kq = new KQHT();
            kq.Show();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
