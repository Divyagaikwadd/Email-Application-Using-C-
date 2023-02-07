using System.Net.Mail;//to send the email
using System.IO;//for file attachment
using System.Net;

namespace EmailApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mm = new MailMessage("divyagaikwadd183@gmail.com",textBox1.Text);//from to sub body all are string type
            mm.Subject = textBox2.Text;
            mm.Body = textBox3.Text;
            //code for file attachment
            foreach(string filename in openFileDialog1.FileNames)
            {
                if (File.Exists(filename))
                {
                    string fname = Path.GetFileName(filename);
                    mm.Attachments.Add(new Attachment(filename));
                }
            }
            //smtp client details
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";  //host name
            smtp.Port = 587;  //gmail port number
            System.Net.NetworkCredential nc = new NetworkCredential("sender email address @gmail.com", "your app password"); //gmailid apppassword
            smtp.EnableSsl = true;
            smtp.Credentials = nc;
            smtp.Send(mm);
            label4.Text = "Mail has been send successfully";
        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            foreach (string filename in openFileDialog1.FileNames)
            {
                MessageBox.Show(filename);//it display the msg with file name
                label5.Text = filename.ToString(); //& that name display in this field

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}










