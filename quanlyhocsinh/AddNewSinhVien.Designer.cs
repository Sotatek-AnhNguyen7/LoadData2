namespace quanlyhocsinh
{
    partial class AddNewSinhVien
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
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.MaSinhVien = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.TenSinhVien = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.GioiTinh = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.QueQuan = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.cmdLuu = new Infragistics.Win.Misc.UltraButton();
            this.cmdKetThuc = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.MaSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Location = new System.Drawing.Point(86, 66);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(294, 48);
            this.ultraLabel1.TabIndex = 0;
            this.ultraLabel1.Text = "Mã Sinh Viên";
            this.ultraLabel1.Click += new System.EventHandler(this.ultraLabel1_Click);
            // 
            // MaSinhVien
            // 
            this.MaSinhVien.Location = new System.Drawing.Point(306, 66);
            this.MaSinhVien.Name = "MaSinhVien";
            this.MaSinhVien.Size = new System.Drawing.Size(152, 31);
            this.MaSinhVien.TabIndex = 1;
            this.MaSinhVien.ValueChanged += new System.EventHandler(this.MaSinhVien_ValueChanged);
            // 
            // TenSinhVien
            // 
            this.TenSinhVien.Location = new System.Drawing.Point(306, 120);
            this.TenSinhVien.Name = "TenSinhVien";
            this.TenSinhVien.Size = new System.Drawing.Size(513, 31);
            this.TenSinhVien.TabIndex = 3;
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(86, 120);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(294, 48);
            this.ultraLabel2.TabIndex = 2;
            this.ultraLabel2.Text = "Tên Sinh Viên";
            // 
            // GioiTinh
            // 
            this.GioiTinh.Location = new System.Drawing.Point(306, 185);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(152, 31);
            this.GioiTinh.TabIndex = 5;
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Location = new System.Drawing.Point(86, 185);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(294, 48);
            this.ultraLabel3.TabIndex = 4;
            this.ultraLabel3.Text = "Giới Tính";
            // 
            // QueQuan
            // 
            this.QueQuan.Location = new System.Drawing.Point(306, 251);
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.Size = new System.Drawing.Size(513, 31);
            this.QueQuan.TabIndex = 7;
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.Location = new System.Drawing.Point(86, 251);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(294, 48);
            this.ultraLabel4.TabIndex = 6;
            this.ultraLabel4.Text = "Quê Quán";
            // 
            // cmdLuu
            // 
            this.cmdLuu.Location = new System.Drawing.Point(179, 382);
            this.cmdLuu.Name = "cmdLuu";
            this.cmdLuu.Size = new System.Drawing.Size(229, 42);
            this.cmdLuu.TabIndex = 8;
            this.cmdLuu.Text = "Lưu";
            this.cmdLuu.Click += new System.EventHandler(this.cmdLuu_Click);
            // 
            // cmdKetThuc
            // 
            this.cmdKetThuc.Location = new System.Drawing.Point(541, 382);
            this.cmdKetThuc.Name = "cmdKetThuc";
            this.cmdKetThuc.Size = new System.Drawing.Size(229, 42);
            this.cmdKetThuc.TabIndex = 9;
            this.cmdKetThuc.Text = "Hủy";
            this.cmdKetThuc.Click += new System.EventHandler(this.cmdKetThuc_Click);
            // 
            // AddNewSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 485);
            this.Controls.Add(this.cmdKetThuc);
            this.Controls.Add(this.cmdLuu);
            this.Controls.Add(this.QueQuan);
            this.Controls.Add(this.ultraLabel4);
            this.Controls.Add(this.GioiTinh);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.TenSinhVien);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.MaSinhVien);
            this.Controls.Add(this.ultraLabel1);
            this.Name = "AddNewSinhVien";
            this.Text = "AddNewSinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.MaSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor MaSinhVien;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor TenSinhVien;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor GioiTinh;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor QueQuan;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.Misc.UltraButton cmdLuu;
        private Infragistics.Win.Misc.UltraButton cmdKetThuc;
    }
}