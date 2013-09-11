using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace TextSheet___Beta
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void change_pwd_button_Click(object sender, EventArgs e)
        {
            
            if (new_pwd_txt.TextLength != 8)
            {
                String status = MessageBox.Show("Your password length must be of 8 characters", "An Error occured during vallidation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning).ToString();
                if (status == "Cancel")
                {
                    this.Dispose();
                }
            }
            else if (new_pwd_txt.Text != cnfrm_pwd_txt.Text)
            {
                String status = MessageBox.Show("Your passwords are different", "An Error occured during vallidation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning).ToString();
                if (status == "Cancel")
                {
                    this.Dispose();
                }
            }
            else
            {
                String status = MessageBox.Show("You successfully changed your password", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information).ToString();
                try
                {
                    String key = new_pwd_txt.Text;
                    FileStream fStream = new FileStream(@"c:\Program Files\textsheet.txh", FileMode.OpenOrCreate, FileAccess.Write);
                    DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();
                    cryptic.Key = ASCIIEncoding.ASCII.GetBytes("TEXTSHET");
                    cryptic.IV = ASCIIEncoding.ASCII.GetBytes("TEXTSHET");
                    CryptoStream crStream = new CryptoStream(fStream, cryptic.CreateEncryptor(), CryptoStreamMode.Write);
                    byte[] pwd = ASCIIEncoding.ASCII.GetBytes(key);
                    crStream.Write(pwd, 0, pwd.Length);
                    crStream.Close();
                    fStream.Close();
                }
                catch (Exception)
                {
                }
                this.Dispose();
            }
        }
    }
}
