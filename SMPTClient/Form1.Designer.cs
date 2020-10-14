namespace SMPTClient
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
            this.tbNguoiNhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTieuDe = new System.Windows.Forms.TextBox();
            this.lbTep = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btThemTep = new System.Windows.Forms.Button();
            this.btXoaTep = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNoiDung = new System.Windows.Forms.TextBox();
            this.btGui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngời nhận";
            // 
            // tbNguoiNhan
            // 
            this.tbNguoiNhan.Location = new System.Drawing.Point(16, 30);
            this.tbNguoiNhan.Multiline = true;
            this.tbNguoiNhan.Name = "tbNguoiNhan";
            this.tbNguoiNhan.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbNguoiNhan.Size = new System.Drawing.Size(772, 53);
            this.tbNguoiNhan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiêu đề thư";
            // 
            // tbTieuDe
            // 
            this.tbTieuDe.Location = new System.Drawing.Point(16, 107);
            this.tbTieuDe.Name = "tbTieuDe";
            this.tbTieuDe.Size = new System.Drawing.Size(772, 20);
            this.tbTieuDe.TabIndex = 3;
            // 
            // lbTep
            // 
            this.lbTep.FormattingEnabled = true;
            this.lbTep.Location = new System.Drawing.Point(16, 180);
            this.lbTep.Name = "lbTep";
            this.lbTep.Size = new System.Drawing.Size(772, 69);
            this.lbTep.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tệp đính kèm";
            // 
            // btThemTep
            // 
            this.btThemTep.Location = new System.Drawing.Point(16, 151);
            this.btThemTep.Name = "btThemTep";
            this.btThemTep.Size = new System.Drawing.Size(75, 23);
            this.btThemTep.TabIndex = 6;
            this.btThemTep.Text = "Thêm tệp";
            this.btThemTep.UseVisualStyleBackColor = true;
            this.btThemTep.Click += new System.EventHandler(this.btThemTep_Click);
            // 
            // btXoaTep
            // 
            this.btXoaTep.Location = new System.Drawing.Point(97, 151);
            this.btXoaTep.Name = "btXoaTep";
            this.btXoaTep.Size = new System.Drawing.Size(75, 23);
            this.btXoaTep.TabIndex = 7;
            this.btXoaTep.Text = "Xóa tệp";
            this.btXoaTep.UseVisualStyleBackColor = true;
            this.btXoaTep.Click += new System.EventHandler(this.btXoaTep_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nội dung thư";
            // 
            // tbNoiDung
            // 
            this.tbNoiDung.Location = new System.Drawing.Point(16, 273);
            this.tbNoiDung.Multiline = true;
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbNoiDung.Size = new System.Drawing.Size(772, 140);
            this.tbNoiDung.TabIndex = 9;
            // 
            // btGui
            // 
            this.btGui.Location = new System.Drawing.Point(16, 419);
            this.btGui.Name = "btGui";
            this.btGui.Size = new System.Drawing.Size(75, 23);
            this.btGui.TabIndex = 10;
            this.btGui.Text = "Gửi";
            this.btGui.UseVisualStyleBackColor = true;
            this.btGui.Click += new System.EventHandler(this.btGui_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btGui);
            this.Controls.Add(this.tbNoiDung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btXoaTep);
            this.Controls.Add(this.btThemTep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTep);
            this.Controls.Add(this.tbTieuDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNguoiNhan);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNguoiNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTieuDe;
        private System.Windows.Forms.ListBox lbTep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btThemTep;
        private System.Windows.Forms.Button btXoaTep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNoiDung;
        private System.Windows.Forms.Button btGui;
    }
}

