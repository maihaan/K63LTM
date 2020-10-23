using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace FTPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                tbThuMuc.Text = fd.SelectedPath;
                
                DirectoryInfo di = new DirectoryInfo(fd.SelectedPath);
                FileInfo[] dsTep = di.GetFiles();
                if(dsTep.Length > 0)
                {
                    clbDanhSach.Items.Clear();
                    foreach (FileInfo f in dsTep)
                        clbDanhSach.Items.Add(f.FullName 
                            + " | " + (f.Length /(1024 * 1024)).ToString() + "MB");
                }    
                else
                {
                    clbDanhSach.Items.Clear();
                    clbDanhSach.Items.Add("[Không có tệp tin nào]");
                }    
            }
        }

        private void btTaiLen_Click(object sender, EventArgs e)
        {
            WebClient c = new WebClient();
            c.Credentials = new NetworkCredential(tbTenDN.Text.Trim(), tbMatKhau.Text.Trim());
            pgbTienTrinh.Maximum = clbDanhSach.Items.Count + 1;
            int dem = 0;
            foreach(var item in clbDanhSach.CheckedItems)
            {
                String duongDan = item.ToString().Split('|')[0].Trim();
                c.UploadFile(tbUrl.Text + "/" + Path.GetFileName(duongDan), duongDan);
                dem++;
                pgbTienTrinh.Value = dem;
                pgbTienTrinh.PerformStep();
                pgbTienTrinh.Refresh();
            }    
        }

        private void cbChon_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbDanhSach.Items.Count; i++)
                clbDanhSach.SetItemChecked(i, cbChon.Checked);
        }
    }
}
