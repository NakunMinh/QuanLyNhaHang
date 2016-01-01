namespace NHAHANG
{
    partial class QLTiec
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSMon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSDaDat = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDSTiec = new System.Windows.Forms.DataGridView();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtNgayToChuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelChao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSMon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDaDat)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSTiec)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelChao);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 45);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewDSMon);
            this.groupBox1.Location = new System.Drawing.Point(0, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 386);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách món";
            // 
            // dataGridViewDSMon
            // 
            this.dataGridViewDSMon.AllowUserToAddRows = false;
            this.dataGridViewDSMon.AllowUserToDeleteRows = false;
            this.dataGridViewDSMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDSMon.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDSMon.Name = "dataGridViewDSMon";
            this.dataGridViewDSMon.ReadOnly = true;
            this.dataGridViewDSMon.Size = new System.Drawing.Size(339, 367);
            this.dataGridViewDSMon.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewDSDaDat);
            this.groupBox2.Location = new System.Drawing.Point(351, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 386);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đã đặt";
            // 
            // dataGridViewDSDaDat
            // 
            this.dataGridViewDSDaDat.AllowUserToAddRows = false;
            this.dataGridViewDSDaDat.AllowUserToDeleteRows = false;
            this.dataGridViewDSDaDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSDaDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDSDaDat.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDSDaDat.Name = "dataGridViewDSDaDat";
            this.dataGridViewDSDaDat.ReadOnly = true;
            this.dataGridViewDSDaDat.Size = new System.Drawing.Size(297, 367);
            this.dataGridViewDSDaDat.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewDSTiec);
            this.groupBox3.Location = new System.Drawing.Point(663, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 308);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách tiệc";
            // 
            // dataGridViewDSTiec
            // 
            this.dataGridViewDSTiec.AllowUserToAddRows = false;
            this.dataGridViewDSTiec.AllowUserToDeleteRows = false;
            this.dataGridViewDSTiec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSTiec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDSTiec.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewDSTiec.Name = "dataGridViewDSTiec";
            this.dataGridViewDSTiec.ReadOnly = true;
            this.dataGridViewDSTiec.Size = new System.Drawing.Size(327, 289);
            this.dataGridViewDSTiec.TabIndex = 0;
            this.dataGridViewDSTiec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSTiec_CellClick);
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(176, 444);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(80, 23);
            this.btnThemMon.TabIndex = 4;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(402, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng tiền:";
            // 
            // labelTongTien
            // 
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.ForeColor = System.Drawing.Color.White;
            this.labelTongTien.Location = new System.Drawing.Point(463, 449);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(52, 13);
            this.labelTongTien.TabIndex = 6;
            this.labelTongTien.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(703, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(660, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày tổ chức:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(679, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tổng tiền:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(740, 369);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 20);
            this.txtID.TabIndex = 11;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(740, 421);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(120, 20);
            this.txtTongTien.TabIndex = 14;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Location = new System.Drawing.Point(866, 365);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(61, 50);
            this.btnDanhSach.TabIndex = 15;
            this.btnDanhSach.Text = "Danh sách";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(933, 365);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 50);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(866, 417);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 50);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(933, 417);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(60, 50);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtNgayToChuc
            // 
            this.txtNgayToChuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayToChuc.Location = new System.Drawing.Point(740, 395);
            this.txtNgayToChuc.Name = "txtNgayToChuc";
            this.txtNgayToChuc.Size = new System.Drawing.Size(120, 20);
            this.txtNgayToChuc.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(70, 444);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chào!";
            // 
            // labelChao
            // 
            this.labelChao.AutoSize = true;
            this.labelChao.ForeColor = System.Drawing.Color.White;
            this.labelChao.Location = new System.Drawing.Point(53, 19);
            this.labelChao.Name = "labelChao";
            this.labelChao.Size = new System.Drawing.Size(35, 13);
            this.labelChao.TabIndex = 1;
            this.labelChao.Text = "label7";
            // 
            // QLTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNgayToChuc);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnDanhSach);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "QLTiec";
            this.Text = "QLTiec";
            this.Load += new System.EventHandler(this.QLTiec_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSMon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSDaDat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSTiec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewDSMon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewDSDaDat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewDSTiec;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DateTimePicker txtNgayToChuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label labelChao;
        private System.Windows.Forms.Label label4;
    }
}