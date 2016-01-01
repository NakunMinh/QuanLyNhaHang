namespace NHAHANG
{
    partial class QLThietBi
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
            this.btnSuaThongTin = new System.Windows.Forms.Button();
            this.btnXoaThietBi = new System.Windows.Forms.Button();
            this.btnThemThietBi = new System.Windows.Forms.Button();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSThietBi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.labelChao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelChao);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 45);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuaThongTin);
            this.groupBox1.Controls.Add(this.btnXoaThietBi);
            this.groupBox1.Controls.Add(this.btnThemThietBi);
            this.groupBox1.Controls.Add(this.btnDanhSach);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 410);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thiết bị";
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.ForeColor = System.Drawing.Color.Teal;
            this.btnSuaThongTin.Location = new System.Drawing.Point(6, 380);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(138, 23);
            this.btnSuaThongTin.TabIndex = 11;
            this.btnSuaThongTin.Text = "Sửa thông tin";
            this.btnSuaThongTin.UseVisualStyleBackColor = true;
            this.btnSuaThongTin.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // btnXoaThietBi
            // 
            this.btnXoaThietBi.ForeColor = System.Drawing.Color.Teal;
            this.btnXoaThietBi.Location = new System.Drawing.Point(6, 349);
            this.btnXoaThietBi.Name = "btnXoaThietBi";
            this.btnXoaThietBi.Size = new System.Drawing.Size(138, 23);
            this.btnXoaThietBi.TabIndex = 10;
            this.btnXoaThietBi.Text = "Xóa thiết bị";
            this.btnXoaThietBi.UseVisualStyleBackColor = true;
            this.btnXoaThietBi.Click += new System.EventHandler(this.btnXoaThietBi_Click);
            // 
            // btnThemThietBi
            // 
            this.btnThemThietBi.ForeColor = System.Drawing.Color.Teal;
            this.btnThemThietBi.Location = new System.Drawing.Point(6, 318);
            this.btnThemThietBi.Name = "btnThemThietBi";
            this.btnThemThietBi.Size = new System.Drawing.Size(138, 23);
            this.btnThemThietBi.TabIndex = 9;
            this.btnThemThietBi.Text = "Thêm thiết bị";
            this.btnThemThietBi.UseVisualStyleBackColor = true;
            this.btnThemThietBi.Click += new System.EventHandler(this.btnThemThietBi_Click);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.BackColor = System.Drawing.Color.Snow;
            this.btnDanhSach.ForeColor = System.Drawing.Color.Teal;
            this.btnDanhSach.Location = new System.Drawing.Point(6, 287);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(138, 23);
            this.btnDanhSach.TabIndex = 8;
            this.btnDanhSach.Text = "Danh sách";
            this.btnDanhSach.UseVisualStyleBackColor = false;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(6, 81);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(120, 20);
            this.txtTen.TabIndex = 7;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(6, 120);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(120, 20);
            this.txtDonGia.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(6, 159);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(120, 20);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 42);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(120, 20);
            this.txtID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSThietBi);
            this.groupBox2.Location = new System.Drawing.Point(218, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 410);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thiết bị";
            // 
            // dgvDSThietBi
            // 
            this.dgvDSThietBi.AllowUserToAddRows = false;
            this.dgvDSThietBi.AllowUserToDeleteRows = false;
            this.dgvDSThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThietBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSThietBi.Location = new System.Drawing.Point(3, 16);
            this.dgvDSThietBi.Name = "dgvDSThietBi";
            this.dgvDSThietBi.ReadOnly = true;
            this.dgvDSThietBi.Size = new System.Drawing.Size(772, 391);
            this.dgvDSThietBi.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chào!";
            // 
            // labelChao
            // 
            this.labelChao.AutoSize = true;
            this.labelChao.Location = new System.Drawing.Point(68, 14);
            this.labelChao.Name = "labelChao";
            this.labelChao.Size = new System.Drawing.Size(35, 13);
            this.labelChao.TabIndex = 1;
            this.labelChao.Text = "label6";
            // 
            // QLThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1008, 473);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "QLThietBi";
            this.Text = "QLThietBi";
            this.Load += new System.EventHandler(this.QLThietBi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThietBi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.Button btnXoaThietBi;
        private System.Windows.Forms.Button btnThemThietBi;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSThietBi;
        private System.Windows.Forms.Label labelChao;
        private System.Windows.Forms.Label label5;
    }
}