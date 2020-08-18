namespace quanlyhocsinh
{
    partial class EditSinhVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaSinhVien = new System.Windows.Forms.TextBox();
            this.TenSinhVien = new System.Windows.Forms.TextBox();
            this.GioiTinh = new System.Windows.Forms.TextBox();
            this.QueQuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdKetThuc = new Infragistics.Win.Misc.UltraButton();
            this.cmdLuu = new Infragistics.Win.Misc.UltraButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sinh Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính";
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.Location = new System.Drawing.Point(391, 53);
            this.MaSinhVien.Name = "MaSinhVien";
            this.MaSinhVien.Size = new System.Drawing.Size(262, 29);
            this.MaSinhVien.TabIndex = 5;
            this.MaSinhVien.TextChanged += new System.EventHandler(this.MaSinhVien_TextChanged);
            // 
            // TenSinhVien
            // 
            this.TenSinhVien.Location = new System.Drawing.Point(391, 114);
            this.TenSinhVien.Name = "TenSinhVien";
            this.TenSinhVien.Size = new System.Drawing.Size(165, 29);
            this.TenSinhVien.TabIndex = 6;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Location = new System.Drawing.Point(391, 183);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(92, 29);
            this.GioiTinh.TabIndex = 7;
            // 
            // QueQuan
            // 
            this.QueQuan.Location = new System.Drawing.Point(391, 254);
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.Size = new System.Drawing.Size(237, 29);
            this.QueQuan.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quê Quán";
            // 
            // cmdKetThuc
            // 
            this.cmdKetThuc.Location = new System.Drawing.Point(506, 367);
            this.cmdKetThuc.Name = "cmdKetThuc";
            this.cmdKetThuc.Size = new System.Drawing.Size(229, 42);
            this.cmdKetThuc.TabIndex = 11;
            this.cmdKetThuc.Text = "Hủy";
            this.cmdKetThuc.Click += new System.EventHandler(this.cmdKetThuc_Click);
            // 
            // cmdLuu
            // 
            this.cmdLuu.Location = new System.Drawing.Point(144, 367);
            this.cmdLuu.Name = "cmdLuu";
            this.cmdLuu.Size = new System.Drawing.Size(229, 42);
            this.cmdLuu.TabIndex = 10;
            this.cmdLuu.Text = "Lưu";
            this.cmdLuu.Click += new System.EventHandler(this.cmdLuu_Click);
            // 
            // EditSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdKetThuc);
            this.Controls.Add(this.cmdLuu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QueQuan);
            this.Controls.Add(this.GioiTinh);
            this.Controls.Add(this.TenSinhVien);
            this.Controls.Add(this.MaSinhVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditSinhVien";
            this.Text = "EditSinhVien";
            this.Load += new System.EventHandler(this.EditSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaSinhVien;
        private System.Windows.Forms.TextBox TenSinhVien;
        private System.Windows.Forms.TextBox GioiTinh;
        private System.Windows.Forms.TextBox QueQuan;
        private System.Windows.Forms.Label label4;
        private Infragistics.Win.Misc.UltraButton cmdKetThuc;
        private Infragistics.Win.Misc.UltraButton cmdLuu;
    }
}