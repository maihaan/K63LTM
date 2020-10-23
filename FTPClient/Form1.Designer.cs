namespace FTPClient
{
    partial class Form1
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
            this.tbThuMuc = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.clbDanhSach = new System.Windows.Forms.CheckedListBox();
            this.btTaiLen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenDN = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pgbTienTrinh = new System.Windows.Forms.ProgressBar();
            this.cbChon = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn thư mục";
            // 
            // tbThuMuc
            // 
            this.tbThuMuc.Location = new System.Drawing.Point(16, 177);
            this.tbThuMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbThuMuc.Name = "tbThuMuc";
            this.tbThuMuc.Size = new System.Drawing.Size(609, 23);
            this.tbThuMuc.TabIndex = 1;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(633, 174);
            this.btTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(100, 28);
            this.btTim.TabIndex = 2;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // clbDanhSach
            // 
            this.clbDanhSach.FormattingEnabled = true;
            this.clbDanhSach.Location = new System.Drawing.Point(16, 246);
            this.clbDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbDanhSach.Name = "clbDanhSach";
            this.clbDanhSach.Size = new System.Drawing.Size(719, 238);
            this.clbDanhSach.TabIndex = 3;
            // 
            // btTaiLen
            // 
            this.btTaiLen.Location = new System.Drawing.Point(16, 492);
            this.btTaiLen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTaiLen.Name = "btTaiLen";
            this.btTaiLen.Size = new System.Drawing.Size(100, 28);
            this.btTaiLen.TabIndex = 4;
            this.btTaiLen.Text = "Tải lên";
            this.btTaiLen.UseVisualStyleBackColor = true;
            this.btTaiLen.Click += new System.EventHandler(this.btTaiLen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ftp server";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(112, 31);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(582, 23);
            this.tbUrl.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên ĐN";
            // 
            // tbTenDN
            // 
            this.tbTenDN.Location = new System.Drawing.Point(112, 73);
            this.tbTenDN.Name = "tbTenDN";
            this.tbTenDN.Size = new System.Drawing.Size(169, 23);
            this.tbTenDN.TabIndex = 8;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(396, 76);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '*';
            this.tbMatKhau.Size = new System.Drawing.Size(169, 23);
            this.tbMatKhau.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mật khẩu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbMatKhau);
            this.groupBox1.Controls.Add(this.tbUrl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTenDN);
            this.groupBox1.Location = new System.Drawing.Point(19, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 121);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin truy cập máy chủ FTP";
            // 
            // pgbTienTrinh
            // 
            this.pgbTienTrinh.Location = new System.Drawing.Point(131, 497);
            this.pgbTienTrinh.Name = "pgbTienTrinh";
            this.pgbTienTrinh.Size = new System.Drawing.Size(602, 23);
            this.pgbTienTrinh.TabIndex = 12;
            // 
            // cbChon
            // 
            this.cbChon.AutoSize = true;
            this.cbChon.Location = new System.Drawing.Point(19, 218);
            this.cbChon.Name = "cbChon";
            this.cbChon.Size = new System.Drawing.Size(148, 21);
            this.cbChon.TabIndex = 13;
            this.cbChon.Text = "Chọn hết / Bỏ chọn";
            this.cbChon.UseVisualStyleBackColor = true;
            this.cbChon.CheckedChanged += new System.EventHandler(this.cbChon_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 539);
            this.Controls.Add(this.cbChon);
            this.Controls.Add(this.pgbTienTrinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btTaiLen);
            this.Controls.Add(this.clbDanhSach);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.tbThuMuc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbThuMuc;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.CheckedListBox clbDanhSach;
        private System.Windows.Forms.Button btTaiLen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTenDN;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pgbTienTrinh;
        private System.Windows.Forms.CheckBox cbChon;
    }
}

