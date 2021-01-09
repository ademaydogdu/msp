using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Msp.App.Contact
{
    public partial class frmMailSend : DevExpress.XtraEditors.XtraForm
    {
        public frmMailSend()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtfrom.Text))
            //{
            //    MessageBox.Show("From is empty!");
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtmessage.Text))
            //{
            //    MessageBox.Show("Message is empty!");
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtpassword.Text))
            //{
            //    MessageBox.Show("Password is empty!");
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtport.Text))
            //{
            //    MessageBox.Show("Port is empty!");
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtsmtp.Text))
            //{
            //    MessageBox.Show("Smtp is empty!");
            //    return;
            //}
            //if (string.IsNullOrEmpty(txtto.Text))
            //{
            //    MessageBox.Show("To is empty!");
            //    return;
            //}
            //try
            //{
            //    MailMessage email = new MailMessage();
            //    SmtpClient server = new SmtpClient(txtsmtp.Text.Trim());
            //    email.From = new MailAddress(txtfrom.Text.Trim());
            //    List<string> toes = txtto.Text.Split(';').ToList();
            //    foreach (string mail in toes)
            //    {
            //        email.To.Add(mail);
            //    }
            //    email.BodyEncoding = Encoding.UTF8;
            //    email.Subject = "CheckMail";
            //    email.Body = txtmessage.Text;
            //    server.Port = Convert.ToInt32(txtport.Text);
            //    server.Credentials = new System.Net.NetworkCredential(txtfrom.Text.Trim(), txtpassword.Text.Trim());
            //    if (sslCheck.Checked)
            //    {
            //        server.EnableSsl = true;
            //    }
            //    else
            //    {
            //        server.EnableSsl = false;
            //    }
            //    server.Send(email);
            //    MessageBox.Show("Message Sent!");
            //}
            //catch (Exception ee)
            //{
            //    MessageBox.Show(ee.Message + "\r\n" + ee.InnerException);
            //}
        }
    }
}