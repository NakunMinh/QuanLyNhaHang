namespace NHAHANG
{
    partial class QLNhaBep
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
            this.btnQLNhapXuatHang = new System.Windows.Forms.Button();
            this.btnQLMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelChao = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQLNhapXuatHang
            // 
            this.btnQLNhapXuatHang.BackColor = System.Drawing.Color.Teal;
            this.btnQLNhapXuatHang.ForeColor = System.Drawing.Color.White;
            this.btnQLNhapXuatHang.Location = new System.Drawing.Point(12, 62);
            this.btnQLNhapXuatHang.Name = "btnQLNhapXuatHang";
            this.btnQLNhapXuatHang.Size = new System.Drawing.Size(175, 85);
            this.btnQLNhapXuatHang.TabIndex = 0;
            this.btnQLNhapXuatHang.Text = "Quản lý nhập xuất hàng";
            this.btnQLNhapXuatHang.UseVisualStyleBackColor = false;
            this.btnQLNhapXuatHang.Click += new System.EventHandler(this.btnQLNhapXuatHang_Click);
            // 
            // btnQLMenu
            // 
            this.btnQLMenu.BackColor = System.Drawing.Color.Teal;
            this.btnQLMenu.Location = new System.Drawing.Point(211, 62);
            this.btnQLMenu.Name = "btnQLMenu";
            this.btnQLMenu.Size = new System.Drawing.Size(180, 85);
            this.btnQLMenu.TabIndex = 1;
            this.btnQLMenu.Text = "Quản lý menu";
            this.btnQLMenu.UseVisualStyleBackColor = false;
            this.btnQLMenu.Click += new System.EventHandler(this.btnQLMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelChao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 45);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào!";
            // 
            // labelChao
            // 
            this.labelChao.AutoSize = true;
            this.labelChao.Location = new System.Drawing.Point(61, 17);
            this.labelChao.Name = "labelChao";
            this.labelChao.Size = new System.Drawing.Size(35, 13);
            this.labelChao.TabIndex = 1;
            this.labelChao.Text = "label2";
            // 
            // QLNhaBep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(403, 172);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQLMenu);
            this.Controls.Add(this.btnQLNhapXuatHang);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "QLNhaBep";
            this.Text = "Quản lý nhà bếp";
            this.Load += new System.EventHandler(this.QLNhaBep_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQLNhapXuatHang;
        private System.Windows.Forms.Button btnQLMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelChao;
        private System.Windows.Forms.Label label1;
    }
}