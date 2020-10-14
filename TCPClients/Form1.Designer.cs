namespace TCPClients
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
            this.tbNguoiGui = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNguoiNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTinNhan = new System.Windows.Forms.TextBox();
            this.btGui = new System.Windows.Forms.Button();
            this.tbLichSu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người gửi";
            // 
            // tbNguoiGui
            // 
            this.tbNguoiGui.Location = new System.Drawing.Point(21, 37);
            this.tbNguoiGui.Margin = new System.Windows.Forms.Padding(4);
            this.tbNguoiGui.Name = "tbNguoiGui";
            this.tbNguoiGui.Size = new System.Drawing.Size(533, 23);
            this.tbNguoiGui.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Người nhận";
            // 
            // tbNguoiNhan
            // 
            this.tbNguoiNhan.Location = new System.Drawing.Point(25, 91);
            this.tbNguoiNhan.Margin = new System.Windows.Forms.Padding(4);
            this.tbNguoiNhan.Name = "tbNguoiNhan";
            this.tbNguoiNhan.Size = new System.Drawing.Size(529, 23);
            this.tbNguoiNhan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tin nhắn";
            // 
            // tbTinNhan
            // 
            this.tbTinNhan.Location = new System.Drawing.Point(21, 145);
            this.tbTinNhan.Margin = new System.Windows.Forms.Padding(4);
            this.tbTinNhan.Multiline = true;
            this.tbTinNhan.Name = "tbTinNhan";
            this.tbTinNhan.Size = new System.Drawing.Size(533, 78);
            this.tbTinNhan.TabIndex = 5;
            // 
            // btGui
            // 
            this.btGui.Location = new System.Drawing.Point(21, 231);
            this.btGui.Margin = new System.Windows.Forms.Padding(4);
            this.btGui.Name = "btGui";
            this.btGui.Size = new System.Drawing.Size(100, 28);
            this.btGui.TabIndex = 6;
            this.btGui.Text = "Gửi";
            this.btGui.UseVisualStyleBackColor = true;
            this.btGui.Click += new System.EventHandler(this.btGui_Click);
            // 
            // tbLichSu
            // 
            this.tbLichSu.Location = new System.Drawing.Point(21, 267);
            this.tbLichSu.Margin = new System.Windows.Forms.Padding(4);
            this.tbLichSu.Multiline = true;
            this.tbLichSu.Name = "tbLichSu";
            this.tbLichSu.ReadOnly = true;
            this.tbLichSu.Size = new System.Drawing.Size(533, 283);
            this.tbLichSu.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 572);
            this.Controls.Add(this.tbLichSu);
            this.Controls.Add(this.btGui);
            this.Controls.Add(this.tbTinNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNguoiNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNguoiGui);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNguoiGui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNguoiNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTinNhan;
        private System.Windows.Forms.Button btGui;
        private System.Windows.Forms.TextBox tbLichSu;
    }
}

