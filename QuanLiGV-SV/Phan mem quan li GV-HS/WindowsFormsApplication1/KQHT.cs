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
    public partial class KQHT : Form
    {
        public static string mahs = string.Empty, tenhs = string.Empty, ns = string.Empty, lop = string.Empty;

        private void KQHT_Load(object sender, EventArgs e)
        {
            lbHT.Text = tenhs;
            lbMaHS.Text = mahs;
            lbNS.Text = ns;
            lbLop.Text = lop;

            string sql = "XemKQHT ";
            SqlCommand com = new SqlCommand(sql, Login.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@mahs", mahs);

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTTHT.DataSource = dt;
            dgvTTHT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public KQHT()
        {
            InitializeComponent();
        }

    }
}
