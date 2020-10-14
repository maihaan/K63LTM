using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace SMPTClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btThemTep_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = true;
            if(od.ShowDialog() == DialogResult.OK)
            {
                foreach (String tep in od.FileNames)
                    lbTep.Items.Add(tep);    
            }    
        }

        private void btXoaTep_Click(object sender, EventArgs e)
        {
            if (lbTep.SelectedItem != null)
                lbTep.Items.RemoveAt(lbTep.SelectedIndex);
        }

        private void btGui_Click(object sender, EventArgs e)
        {
            foreach (String toEmail in tbNguoiNhan.Text.Split(','))
            {
                String em = toEmail.Trim();
                if (!String.IsNullOrEmpty(em))
                {
                    String emailAddress = "anminhfirewatcher@gmail.com";
                    String emailPassword = "12345678";
                    try
                    {
                        SmtpClient emailSender = new SmtpClient();
                        MailMessage msg = new MailMessage(emailAddress, em, tbTieuDe.Text, tbNoiDung.Text);
                        msg.BodyEncoding = Encoding.UTF8;
                        msg.IsBodyHtml = true;

                        foreach(var tep in lbTep.Items)
                        {
                            String duongDan = tep.ToString();
                            if(File.Exists(duongDan))
                            {
                                Attachment at = new Attachment(duongDan);
                                msg.Attachments.Add(at);
                            }    
                        }    

                        emailSender.Host = "smtp.gmail.com";
                        emailSender.Port = 587;
                        emailSender.UseDefaultCredentials = false;
                        emailSender.Credentials = new System.Net.NetworkCredential(emailAddress, emailPassword);
                        emailSender.EnableSsl = true;
                        emailSender.Send(msg);
                    }
                    catch{ }
                }
            }
        }
    }
}
