namespace WindowsFormsApplication1
{
    partial class KQHT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbLop = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbNS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbMaHS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbHT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTTHT = new System.Windows.Forms.DataGridView();
            this.NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBHK1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBHK2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanhKiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTHT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbLop);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbNS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbMaHS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbHT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Location = new System.Drawing.Point(379, 67);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(0, 13);
            this.lbLop.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lớp:";
            // 
            // lbNS
            // 
            this.lbNS.AutoSize = true;
            this.lbNS.Location = new System.Drawing.Point(379, 29);
            this.lbNS.Name = "lbNS";
            this.lbNS.Size = new System.Drawing.Size(0, 13);
            this.lbNS.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Sinh:";
            // 
            // lbMaHS
            // 
            this.lbMaHS.AutoSize = true;
            this.lbMaHS.Location = new System.Drawing.Point(104, 67);
            this.lbMaHS.Name = "lbMaHS";
            this.lbMaHS.Size = new System.Drawing.Size(0, 13);
            this.lbMaHS.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã HS: ";
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Location = new System.Drawing.Point(104, 29);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(0, 13);
            this.lbHT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTTHT);
            this.groupBox2.Location = new System.Drawing.Point(24, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 260);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin học tập";
            // 
            // dgvTTHT
            // 
            this.dgvTTHT.AllowUserToAddRows = false;
            this.dgvTTHT.AllowUserToDeleteRows = false;
            this.dgvTTHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTHT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamHoc,
            this.TBHK1,
            this.TBHK2,
            this.TBCN,
            this.HocLuc,
            this.HanhKiem});
            this.dgvTTHT.Location = new System.Drawing.Point(6, 23);
            this.dgvTTHT.Name = "dgvTTHT";
            this.dgvTTHT.ReadOnly = true;
            this.dgvTTHT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTTHT.Size = new System.Drawing.Size(634, 231);
            this.dgvTTHT.TabIndex = 0;
            // 
            // NamHoc
            // 
            this.NamHoc.DataPropertyName = "NamHoc";
            this.NamHoc.HeaderText = "Năm Học";
            this.NamHoc.Name = "NamHoc";
            this.NamHoc.ReadOnly = true;
            // 
            // TBHK1
            // 
            this.TBHK1.DataPropertyName = "TBHK1";
            this.TBHK1.HeaderText = "TBHK1";
            this.TBHK1.Name = "TBHK1";
            this.TBHK1.ReadOnly = true;
            this.TBHK1.Width = 90;
            // 
            // TBHK2
            // 
            this.TBHK2.DataPropertyName = "TBHK2";
            this.TBHK2.HeaderText = "TBHK2";
            this.TBHK2.Name = "TBHK2";
            this.TBHK2.ReadOnly = true;
            this.TBHK2.Width = 90;
            // 
            // TBCN
            // 
            this.TBCN.DataPropertyName = "TBCN";
            this.TBCN.HeaderText = "TBCN";
            this.TBCN.Name = "TBCN";
            this.TBCN.ReadOnly = true;
            this.TBCN.Width = 90;
            // 
            // HocLuc
            // 
            this.HocLuc.DataPropertyName = "HocLuc";
            this.HocLuc.HeaderText = "Học Lực";
            this.HocLuc.Name = "HocLuc";
            this.HocLuc.ReadOnly = true;
            this.HocLuc.Width = 90;
            // 
            // HanhKiem
            // 
            this.HanhKiem.DataPropertyName = "HanhKiem";
            this.HanhKiem.HeaderText = "Hạnh Kiểm";
            this.HanhKiem.Name = "HanhKiem";
            this.HanhKiem.ReadOnly = true;
            this.HanhKiem.Width = 90;
            // 
            // KQHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 456);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KQHT";
            this.Text = "Kết Quả Học Tập";
            this.Load += new System.EventHandler(this.KQHT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTHT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbNS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbMaHS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTTHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TBHK1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TBHK2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TBCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanhKiem;
    }
}