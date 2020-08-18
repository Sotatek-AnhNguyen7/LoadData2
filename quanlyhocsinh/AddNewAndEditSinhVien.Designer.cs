namespace quanlyhocsinh
{
    partial class AddNewAndEditSinhVien
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.MaSinhVien = new System.Windows.Forms.TextBox();
            this.TenSinhVien = new System.Windows.Forms.TextBox();
            this.QueQuan = new System.Windows.Forms.TextBox();
            this.cobGioiTinh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Sinh Viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quê Quán";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.Location = new System.Drawing.Point(155, 493);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(150, 71);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(648, 493);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 71);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.Location = new System.Drawing.Point(474, 72);
            this.MaSinhVien.Name = "MaSinhVien";
            this.MaSinhVien.Size = new System.Drawing.Size(229, 29);
            this.MaSinhVien.TabIndex = 6;
            this.MaSinhVien.TextChanged += new System.EventHandler(this.MaSinhVien_TextChanged);
            // 
            // TenSinhVien
            // 
            this.TenSinhVien.Location = new System.Drawing.Point(474, 151);
            this.TenSinhVien.Name = "TenSinhVien";
            this.TenSinhVien.Size = new System.Drawing.Size(336, 29);
            this.TenSinhVien.TabIndex = 7;
            // 
            // QueQuan
            // 
            this.QueQuan.Location = new System.Drawing.Point(474, 314);
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.Size = new System.Drawing.Size(277, 29);
            this.QueQuan.TabIndex = 8;
            // 
            // cobGioiTinh
            // 
            this.cobGioiTinh.FormattingEnabled = true;
            this.cobGioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ",
            "Không Xác Định"});
            this.cobGioiTinh.Location = new System.Drawing.Point(474, 228);
            this.cobGioiTinh.Name = "cobGioiTinh";
            this.cobGioiTinh.Size = new System.Drawing.Size(197, 32);
            this.cobGioiTinh.TabIndex = 9;
            // 
            // AddNewAndEditSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 603);
            this.Controls.Add(this.cobGioiTinh);
            this.Controls.Add(this.QueQuan);
            this.Controls.Add(this.TenSinhVien);
            this.Controls.Add(this.MaSinhVien);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewAndEditSinhVien";
            this.Text = "AddNewAndEdit";
            this.Load += new System.EventHandler(this.AddNewAndEditSinhVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox MaSinhVien;
        private System.Windows.Forms.TextBox TenSinhVien;
        private System.Windows.Forms.TextBox QueQuan;
        private System.Windows.Forms.ComboBox cobGioiTinh;
    }
}