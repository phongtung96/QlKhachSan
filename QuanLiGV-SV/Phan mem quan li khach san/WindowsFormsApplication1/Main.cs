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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N728DT6\SQLEXPRESS;Initial Catalog=QuanLiHS-GV;Integrated Security=True");
        public static string Username = string.Empty;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
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
        }

        private void btHS_Click(object sender, EventArgs e)
        {
            string sql = "DS_HS ";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHS.DataSource = dt;

            grbTB.Hide();
            grbGV.Hide();
            grbHS.Show();
        }

        private void btGV_Click(object sender, EventArgs e)
        {
            string sql = "DS_GV";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGV.DataSource = dt;

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
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@magv", txbMaGV.Text);
            com.Parameters.AddWithValue("@ten", txbTenGV.Text);
            com.Parameters.AddWithValue("@ns", Convert.ToDateTime(dtpNSGV.Text));
            com.Parameters.AddWithValue("@bomon", cboBM.Text);

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGV.DataSource = dt;
        }

        private void txbMaGV_Leave(object sender, EventArgs e)
        {
            TimKiemGV();
        }

        private void txbMaGV_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyValue == 13)
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
            if(e.KeyValue == 13)
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
            SqlCommand com = new SqlCommand(sql, con);
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
            if(e.KeyValue == 13)
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
            if(e.KeyValue == 13)
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

    }
}
