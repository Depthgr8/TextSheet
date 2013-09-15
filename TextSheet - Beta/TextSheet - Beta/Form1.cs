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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            try
            {
                StreamReader sw = new StreamReader(@"c:\Program files\textsheet.config");
                String theme = sw.ReadLine();
                sw.Close();
                if (theme == "red" || theme == "Red")
                {
                    row_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                    column_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                    sheet_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                    textsheet_block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                }
                if (theme == "green" || theme == "Green")
                {
                    row_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                    column_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                    sheet_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                    textsheet_block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                }
                if (theme == "blue" || theme == "Blue")
                {
                    row_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    column_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    sheet_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                    textsheet_block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                }
                add_row.Enabled = false;
                add_colm.Enabled = false;
                del_row.Enabled = false;
                del_colm.Enabled = false;
            }
            catch (Exception)
            {
            }
        }

        public static String showdialog(String text, String caption)
        {
            Form prompt = new Form();
            prompt.Height = 220;
            prompt.Width = 500;
            prompt.Text = caption;
            Label textLable = new Label() { Left = 50, Top = 20, Width = 400, Height = 70, Text = text};
            TextBox textbox = new TextBox() { Left = 50, Top = 100, Width = 400 };
            Button confirmation = new Button() { Text = "OK", Left= 350, Width = 100, Top = 130 };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLable);
            prompt.Controls.Add(textbox);
            textbox.UseSystemPasswordChar = true;
            prompt.ShowDialog();
            return textbox.Text;
        }

        private void savefile_Click(object sender, EventArgs e)
        {
            saveTextSheet_Click(sender, e);
        }

        private void saveTextSheet_Click(object sender, EventArgs e)
        {
            try
            {
                int r, c;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "TEXTSHEET Files (*.txh)|*.txh";
                sfd.ShowDialog();
                StreamWriter sw = new StreamWriter(sfd.FileName);
                r = sheet_panel.RowCount;
                c = sheet_panel.ColumnCount;
                sw.WriteLine(r);
                sw.WriteLine(c);
                foreach (Control ctr in row_panel.Controls)
                    sw.WriteLine(ctr.Text);
                foreach (Control ctr in column_panel.Controls)
                    sw.WriteLine(ctr.Text);
                foreach (Control ctr in sheet_panel.Controls)
                    sw.WriteLine(ctr.Text);
                sw.Flush();
                sw.Close();
            }
            catch (Exception)
            {
            }
        }
        private void draw_Click(object sender, EventArgs e)
        {
            container_panel.Visible = true;
            int r, c;
            message.Text = "You can now enter your Data";
            try
            {
                r = int.Parse(row_box.Text);
                c = int.Parse(column_box.Text);
                for (int i = 0; i < c; i++)
                {
                    row_panel.ColumnCount = c;
                    System.Windows.Forms.TextBox textboxrow;
                    textboxrow = new System.Windows.Forms.TextBox();
                    this.row_panel.Controls.Add(textboxrow, i, 0);
                    textboxrow.Location = new System.Drawing.Point(1, 1);
                    textboxrow.Name = "textboxrow" + "i";
                    textboxrow.Text = (i + 1).ToString();
                    textboxrow.Size = new System.Drawing.Size(100, 15);
                    textboxrow.TabIndex = 0;
                    textboxrow.BackColor = System.Drawing.SystemColors.ControlLight;
                    textboxrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                }
                for (int i = 0; i < r; i++)
                {
                    column_panel.RowCount = r;
                    System.Windows.Forms.TextBox textboxcolumn;
                    textboxcolumn = new System.Windows.Forms.TextBox();
                    this.column_panel.Controls.Add(textboxcolumn, 0, i);
                    textboxcolumn.Location = new System.Drawing.Point(1, 1);
                    textboxcolumn.Name = "textboxcolumn" + "i";
                    textboxcolumn.Text = (i + 1).ToString();
                    textboxcolumn.Size = new System.Drawing.Size(100, 15);
                    textboxcolumn.TabIndex = 0;
                    textboxcolumn.BackColor = System.Drawing.SystemColors.ControlLight;
                    textboxcolumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                }
                int j = 0, k = 0;
                for (j = 0; j < r; j++)
                {
                    for (k = 0; k < c; k++)
                    {
                        sheet_panel.RowCount = r;
                        sheet_panel.ColumnCount = c;
                        System.Windows.Forms.TextBox textBox1;
                        textBox1 = new System.Windows.Forms.TextBox();
                        this.sheet_panel.Controls.Add(textBox1, k, j);
                        textBox1.Location = new System.Drawing.Point(1, 1);
                        textBox1.Name = k + "," + j;
                        textBox1.Text = "";
                        textBox1.Size = new System.Drawing.Size(100, 15);
                        textBox1.TabIndex = 0;
                        textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    }
                }
            }
            catch (Exception)
            {
            }
            message.Text = "Your SpreadSheet is now ready";
            row_box.Enabled = false;
            column_box.Enabled = false;
            draw.Enabled = false;
            add_row.Enabled = true;
            add_colm.Enabled = true;
            del_row.Enabled = true;
            del_colm.Enabled = true;
        }
        private void newTextSheet_Click(object sender, EventArgs e)
        {
            toolbar.Enabled = true;
            message.Text = "Please enter your desired number of columns and rows";
        }
        private void openTextSheet_Click_1(object sender, EventArgs e)
        {
            try
            {
                container_panel.Visible = true;
                int r, c;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "TEXTSHEET Files (*.txh)|*.txh";
                ofd.ShowDialog();
                StreamReader fo = new StreamReader(ofd.FileName);
                row_box.Text = (fo.ReadLine()).ToString();
                column_box.Text = (fo.ReadLine()).ToString();
                column_panel.RowCount = r = int.Parse(row_box.Text);
                column_panel.ColumnCount = c = int.Parse(column_box.Text);
                message.Text = "You can now enter your Data";
                r = int.Parse(row_box.Text);
                c = int.Parse(column_box.Text);
                for (int i = 0; i < c; i++)
                {
                    row_panel.ColumnCount = c;
                    System.Windows.Forms.TextBox textboxrow;
                    textboxrow = new System.Windows.Forms.TextBox();
                    this.row_panel.Controls.Add(textboxrow, i, 0);
                    textboxrow.Location = new System.Drawing.Point(0, 0);
                    textboxrow.Name = "textboxrow" + "i";
                    textboxrow.Text = (fo.ReadLine()).ToString();
                    textboxrow.Size = new System.Drawing.Size(100, 20);
                    textboxrow.TabIndex = 0;
                    textboxrow.BackColor = System.Drawing.SystemColors.ControlLight;
                    textboxrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                }
                for (int i = 0; i < r; i++)
                {
                    column_panel.RowCount = r;
                    System.Windows.Forms.TextBox textboxcolumn;
                    textboxcolumn = new System.Windows.Forms.TextBox();
                    this.column_panel.Controls.Add(textboxcolumn, 0, i);
                    textboxcolumn.Location = new System.Drawing.Point(0, 0);
                    textboxcolumn.Name = "textboxcolumn" + "i";
                    textboxcolumn.Text = (fo.ReadLine()).ToString();
                    textboxcolumn.Size = new System.Drawing.Size(100, 20);
                    textboxcolumn.TabIndex = 0;
                    textboxcolumn.BackColor = System.Drawing.SystemColors.ControlLight;
                    textboxcolumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                }
                int j = 0, k = 0;
                for (j = 0; j < r; j++)
                {
                    for (k = 0; k < c; k++)
                    {
                        sheet_panel.RowCount = r;
                        sheet_panel.ColumnCount = c;
                        System.Windows.Forms.TextBox textBox1;
                        textBox1 = new System.Windows.Forms.TextBox();
                        this.sheet_panel.Controls.Add(textBox1, k, j);
                        textBox1.Location = new System.Drawing.Point(0, 0);
                        textBox1.Name = k + "," + j;
                        textBox1.Text = (fo.ReadLine()).ToString(); ;
                        textBox1.Size = new System.Drawing.Size(100, 20);
                        textBox1.TabIndex = 0;
                        textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    }
                }
            }
            catch (Exception)
            {
            }
            message.Text = "Your SpreadSheet is now ready";
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                Primary_Menu.Dispose();
                toolbar.Dispose();
                container_panel.Dispose();
                Status.Dispose();
                InitializeComponent();
                toolbar.Enabled = true;
                container_panel.Visible = false;
                add_row.Enabled = false;
                add_colm.Enabled = false;
                del_row.Enabled = false;
                del_colm.Enabled = false;
            }
            catch
            {
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Main_Form.ActiveForm.Close();
        }
        private void reset_theme_Click(object sender, EventArgs e)
        {
            row_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            column_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            sheet_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            textsheet_block.BackColor = System.Drawing.SystemColors.ControlLight;
        }

        private void red_Click(object sender, EventArgs e)
        {
            row_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            column_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            sheet_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            textsheet_block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        }

        private void green_Click(object sender, EventArgs e)
        {
            row_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            column_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            sheet_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            textsheet_block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }

        private void blue_Click(object sender, EventArgs e)
        {
            row_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            column_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            sheet_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            textsheet_block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
        }

        private void gray_Click(object sender, EventArgs e)
        {
            reset_theme_Click(sender, e);
        }

        private void newfile_Click(object sender, EventArgs e)
        {
            newTextSheet_Click_1(sender, e);
        }

        private void newTextSheet_Click_1(object sender, EventArgs e)
        {
            refresh_Click(sender, e);
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            openTextSheet_Click_1(sender, e);
        }

        private void encrypt_file_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"c:\Program Files\textsheet.txh", FileMode.Open, FileAccess.Read);
                DESCryptoServiceProvider crypt = new DESCryptoServiceProvider();
                crypt.Key = ASCIIEncoding.ASCII.GetBytes("TEXTSHET");
                crypt.IV = ASCIIEncoding.ASCII.GetBytes("TEXTSHET");
                CryptoStream cs = new CryptoStream(fs, crypt.CreateDecryptor(), CryptoStreamMode.Read);
                StreamReader srd = new StreamReader(cs);
                String match = srd.ReadLine().ToString();
                srd.Close();
                fs.Close();
                String pwd = showdialog("Please Enter your password to encrypt a file", "TextSheet - Security");
                if (match == pwd)
                {
                    String key = match;
                    int r, c;
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "TEN Files (*.ten)|*.ten";
                    sfd.ShowDialog();
                    String fileName = sfd.FileName;
                    FileStream fStream = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();
                    cryptic.Key = ASCIIEncoding.ASCII.GetBytes(key);
                    cryptic.IV = ASCIIEncoding.ASCII.GetBytes(key);
                    CryptoStream crStream = new CryptoStream(fStream, cryptic.CreateEncryptor(), CryptoStreamMode.Write);
                    r = sheet_panel.RowCount;
                    c = sheet_panel.ColumnCount;
                    byte[] row = ASCIIEncoding.ASCII.GetBytes(r.ToString() + '\n');
                    crStream.Write(row, 0, row.Length);
                    byte[] col = ASCIIEncoding.ASCII.GetBytes(c.ToString() + '\n');
                    crStream.Write(col, 0, col.Length);
                    foreach (Control ctr in row_panel.Controls)
                    {
                        byte[] con_row = ASCIIEncoding.ASCII.GetBytes(ctr.Text + '\n');
                        crStream.Write(con_row, 0, con_row.Length);
                    }
                    foreach (Control ctr in column_panel.Controls)
                    {
                        byte[] con_col = ASCIIEncoding.ASCII.GetBytes(ctr.Text + '\n');
                        crStream.Write(con_col, 0, con_col.Length);
                    }
                    foreach (Control ctr in sheet_panel.Controls)
                    {
                        byte[] con_sheet = ASCIIEncoding.ASCII.GetBytes(ctr.Text + '\n');
                        crStream.Write(con_sheet, 0, con_sheet.Length);
                    }
                    crStream.Close();
                    fStream.Close();
                }
                else
                    MessageBox.Show("You entered a wrong password");
            }
            catch (Exception)
            {
            }
      
        }

        private void decrypt_file_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"c:\Program Files\textsheet.txh", FileMode.Open, FileAccess.Read);
                DESCryptoServiceProvider crypt = new DESCryptoServiceProvider();
                crypt.Key = ASCIIEncoding.ASCII.GetBytes("TEXTSHET");
                crypt.IV = ASCIIEncoding.ASCII.GetBytes("TEXTSHET");
                CryptoStream cs = new CryptoStream(fs, crypt.CreateDecryptor(), CryptoStreamMode.Read);
                StreamReader srd = new StreamReader(cs);
                String match = srd.ReadLine().ToString();
                srd.Close();
                fs.Close();
                String pwd = showdialog("Please Enter your password to decrypt a file", "TextSheet - Security");
                if (pwd == match)
                {
                    try
                    {
                        String key = pwd;
                        container_panel.Visible = true;
                        int r, c;
                        OpenFileDialog ofd = new OpenFileDialog();
                        ofd.Filter = "TEN Files (*.ten)|*.ten";
                        ofd.ShowDialog();
                        String fileName = ofd.FileName;
                        FileStream fStream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                        DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();
                        cryptic.Key = ASCIIEncoding.ASCII.GetBytes(key);
                        cryptic.IV = ASCIIEncoding.ASCII.GetBytes(key);
                        CryptoStream crStream = new CryptoStream(fStream, cryptic.CreateDecryptor(), CryptoStreamMode.Read);
                        StreamReader sr = new StreamReader(crStream);
                        string row = sr.ReadLine();
                        row_box.Text = row.ToString();
                        string col = sr.ReadLine();
                        column_box.Text = col.ToString();
                        column_panel.RowCount = r = int.Parse(row_box.Text);
                        column_panel.ColumnCount = c = int.Parse(column_box.Text);
                        message.Text = "You can now enter your Data";
                        for (int i = 0; i < c; i++)
                        {
                            row_panel.ColumnCount = c;
                            System.Windows.Forms.TextBox textboxrow;
                            textboxrow = new System.Windows.Forms.TextBox();
                            this.row_panel.Controls.Add(textboxrow, i, 0);
                            textboxrow.Location = new System.Drawing.Point(0, 0);
                            textboxrow.Name = "textboxrow" + "i";
                            textboxrow.Text = (sr.ReadLine()).ToString();
                            textboxrow.Size = new System.Drawing.Size(100, 20);
                            textboxrow.TabIndex = 0;
                            textboxrow.BackColor = System.Drawing.SystemColors.ControlLight;
                            textboxrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        }
                        for (int i = 0; i < r; i++)
                        {
                            column_panel.RowCount = r;
                            System.Windows.Forms.TextBox textboxcolumn;
                            textboxcolumn = new System.Windows.Forms.TextBox();
                            this.column_panel.Controls.Add(textboxcolumn, 0, i);
                            textboxcolumn.Location = new System.Drawing.Point(0, 0);
                            textboxcolumn.Name = "textboxcolumn" + "i";
                            textboxcolumn.Text = (sr.ReadLine()).ToString();
                            textboxcolumn.Size = new System.Drawing.Size(100, 20);
                            textboxcolumn.TabIndex = 0;
                            textboxcolumn.BackColor = System.Drawing.SystemColors.ControlLight;
                            textboxcolumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        }
                        int j = 0, k = 0;
                        for (j = 0; j < r; j++)
                        {
                            for (k = 0; k < c; k++)
                            {
                                sheet_panel.RowCount = r;
                                sheet_panel.ColumnCount = c;
                                System.Windows.Forms.TextBox textBox1;
                                textBox1 = new System.Windows.Forms.TextBox();
                                this.sheet_panel.Controls.Add(textBox1, k, j);
                                textBox1.Location = new System.Drawing.Point(0, 0);
                                textBox1.Name = k + "," + j;
                                textBox1.Text = (sr.ReadLine()).ToString(); ;
                                textBox1.Size = new System.Drawing.Size(100, 20);
                                textBox1.TabIndex = 0;
                                textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                            }
                        }
                        sr.Close();
                        fStream.Close();
                    }
                    catch (Exception)
                    {
                    }
                }
                else
                    MessageBox.Show("You entered a wrong password");
            }
            catch
            {  
            }  
        }

        private void encryptTextSheet_Click(object sender, EventArgs e)
        {
            encrypt_file_Click(sender,e);
        }

        private void decryptTextSheet_Click(object sender, EventArgs e)
        {
            decrypt_file_Click(sender,e);
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Welcome to the TextSheet wiki page


TextSheet is a freeware application which you can use and develop freely on your Windows platform.

TextSheet is a SpreadSheet like application, which will be able to create, edit, open and save your text data in a secure .TEN file format.
Loading it with cool features like themes, preferences and encryption.

Yes, we can work together that's why I made this repository public, It would be good if you let me know that you want to develop it with us, feel free to fork it and you can ask your queries at
depthgr8@yahoo.in
 ","About Texhsheet - Please leave a feedback for us");
        }

        private void help_me_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Welcome to the TextSheet wiki page

To encrypt a file, you need to set a password

You can set each file with a different password, for this you need to set your password everytime you want to encrypt a file.

You will also need your password to decrypt a file. For more queries you can ask them on http://www.facebook.com/textsheet

 ", "Texsheet Help center - Please leave a feedback for us");
            try
            {
                close_browser.Visible = true;
                urlbox.Visible = true;
                urlbox.Text = "http://www.depthgr8.wordpress.com/2013/09/11/textsheet/";
                container_panel.Visible = true;
                webBrowser1.Visible = true;
                webBrowser1.Navigate("http://www.depthgr8.wordpress.com/2013/09/11/textsheet/");
            }
            catch
            {
            }
        }

        private void help_credits_Click(object sender, EventArgs e)
        {
            String mesg = "The credit of TextSheet Application goes to Deepak Sharma for the following roles\n\n  1.   Founder\n  2.   Designer\n  3.   Developer\n  4.   Debugger\n  5.   Tester\n\n__________________________ TextSheet 2013 Copyright ______________________________";
            MessageBox.Show(mesg, "Credit of TextSheet", MessageBoxButtons.OK);
        }

        private void feedback_Click(object sender, EventArgs e)
        {
            try
            {
                close_browser.Visible = true;
                urlbox.Visible = true;
                urlbox.Text = "http://www.github.com/depthgr8/textsheet";
                container_panel.Visible = true;
                webBrowser1.Visible = true;
                webBrowser1.Navigate("http://www.github.com/depthgr8/textsheet");
            }
            catch
            {
            }
        }

        private void show_support_Click(object sender, EventArgs e)
        {
            try
            {  
                close_browser.Visible = true;
                urlbox.Visible = true;
                urlbox.Text = "http://www.facebook.com/textsheet";
                container_panel.Visible = true;
                webBrowser1.Visible = true;
                webBrowser1.Navigate("http://www.facebook.com/textsheet");  
            }  
            catch
            {
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void close_browser_Click(object sender, EventArgs e)
        {
            try
            {
                close_browser.Visible = false;
                urlbox.Visible = false;
                urlbox.Text = "http://www.github.com/depthgr8/textsheet";
                container_panel.Visible = false;
                webBrowser1.Visible = false;
            }
            catch
            {
            }
        }
        private void preferences_Click(object sender, EventArgs e)
        {
            prefs_Click(sender,e);
        }

        private void set_password_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 f = new Form2();
                f.ShowDialog();
            }
            catch
            {
            }
        }

        private void prefs_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"c:\Program Files\textsheet.config");
                String default_theme = showdialog("You can set your theme here, choose from\n\n 1.  Red\n 2.  Green\n 3.  Blue\n", "Set preferences");
                sw.WriteLine(default_theme);
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }

        private void password_Click(object sender, EventArgs e)
        {
            set_password_Click(sender,e);
        }

        private void add_row_Click(object sender, EventArgs e)
        {
            try
            {
                int c = int.Parse(column_box.Text);
                int r = int.Parse(row_box.Text);

                column_panel.RowCount = r + 1;
                System.Windows.Forms.TextBox textboxcolumn;
                textboxcolumn = new System.Windows.Forms.TextBox();
                this.column_panel.Controls.Add(textboxcolumn, 0, r);
                textboxcolumn.Location = new System.Drawing.Point(1, 1);
                textboxcolumn.Name = "textboxcolumn" + "i";
                textboxcolumn.Text = (r + 1).ToString();
                textboxcolumn.Size = new System.Drawing.Size(100, 15);
                textboxcolumn.TabIndex = 0;
                textboxcolumn.BackColor = System.Drawing.SystemColors.ControlLight;
                textboxcolumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                sheet_panel.RowCount = r + 1;
                for (int k = 0; k < c; k++)
                {
                    System.Windows.Forms.TextBox textBox1;
                    textBox1 = new System.Windows.Forms.TextBox();
                    this.sheet_panel.Controls.Add(textBox1, k, r);
                    textBox1.Location = new System.Drawing.Point(1, 1);
                    textBox1.Name = k + "," + c;
                    textBox1.Text = "";
                    textBox1.Size = new System.Drawing.Size(100, 15);
                    textBox1.TabIndex = 0;
                    textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                }
                row_box.Text = (r + 1).ToString();
            }
            catch 
            {
            }
        }

        private void add_colm_Click(object sender, EventArgs e)
        {
            try
            {
                int c = int.Parse(column_box.Text);
                int r = int.Parse(row_box.Text);
                row_panel.ColumnCount = c + 1;
                System.Windows.Forms.TextBox textboxcolumn;
                textboxcolumn = new System.Windows.Forms.TextBox();
                this.row_panel.Controls.Add(textboxcolumn, 0, c);
                textboxcolumn.Location = new System.Drawing.Point(1, 1);
                textboxcolumn.Name = "textboxcolumn" + "i";
                textboxcolumn.Text = (c + 1).ToString();
                textboxcolumn.Size = new System.Drawing.Size(100, 15);
                textboxcolumn.TabIndex = 0;
                textboxcolumn.BackColor = System.Drawing.SystemColors.ControlLight;
                textboxcolumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                sheet_panel.ColumnCount = c + 1;
                for (int k = 0; k < r; k++)
                {
                    System.Windows.Forms.TextBox textBox1;
                    textBox1 = new System.Windows.Forms.TextBox();
                    this.sheet_panel.Controls.Add(textBox1, c, k);
                    textBox1.Location = new System.Drawing.Point(1, 1);
                    textBox1.Name = k + "," + c;
                    textBox1.Text = "";
                    textBox1.Size = new System.Drawing.Size(100, 15);
                    textBox1.TabIndex = 0;
                    textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                }
                column_box.Text = (c + 1).ToString();
            }
            catch (Exception) 
            {
            }
        }

        private void del_row_Click(object sender, EventArgs e)
        {
            try
            {
                int c = int.Parse(column_box.Text);
                int r = int.Parse(row_box.Text);
                System.Windows.Forms.TextBox textboxcolumn;
                textboxcolumn = new System.Windows.Forms.TextBox();
                this.column_panel.Controls.RemoveAt(r-1);
                textboxcolumn.Location = new System.Drawing.Point(1, 1);
                textboxcolumn.Name = "textboxcolumn" + "i";
                textboxcolumn.Text = (r + 1).ToString();
                textboxcolumn.Size = new System.Drawing.Size(100, 15);
                textboxcolumn.TabIndex = 0;
                textboxcolumn.BackColor = System.Drawing.SystemColors.ControlLight;
                textboxcolumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                column_panel.RowCount = r - 1;
                for (int k = 0; k < c; k++)
                {
                    System.Windows.Forms.TextBox textBox1;
                    textBox1 = new System.Windows.Forms.TextBox();
                    this.sheet_panel.Controls.RemoveAt(((r*c)-k)-1);
                    textBox1.Location = new System.Drawing.Point(1, 1);
                    textBox1.Name = k + "," + c;
                    textBox1.Text = "";
                    textBox1.Size = new System.Drawing.Size(100, 15);
                    textBox1.TabIndex = 0;
                    textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                }
                sheet_panel.RowCount = r - 1;
                row_box.Text = (r - 1).ToString();
            }
            catch(Exception)
            {

            }
        }

        private void del_colm_Click(object sender, EventArgs e)
        {
            try
            {
                int c = int.Parse(column_box.Text);
                int r = int.Parse(row_box.Text);
                row_panel.ColumnCount = c - 1;
                System.Windows.Forms.TextBox textboxrow;
                textboxrow = new System.Windows.Forms.TextBox();
                this.row_panel.Controls.RemoveAt(c - 1);
                textboxrow.Location = new System.Drawing.Point(1, 1);
                textboxrow.Name = "textboxrow" + "i";
                textboxrow.Text = (r - 1).ToString();
                textboxrow.Size = new System.Drawing.Size(100, 15);
                textboxrow.TabIndex = 0;
                textboxrow.BackColor = System.Drawing.SystemColors.ControlLight;
                textboxrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                for (int k = 0; k < r; k++)
                {
                    System.Windows.Forms.TextBox textBox1;
                    textBox1 = new System.Windows.Forms.TextBox();
                    this.sheet_panel.Controls.RemoveAt(((r * c)) - ((c * k) + 1));
                    textBox1.Location = new System.Drawing.Point(1, 1);
                    textBox1.Name = k + "," + c;
                    textBox1.Text = "";
                    textBox1.Size = new System.Drawing.Size(100, 15);
                    textBox1.TabIndex = 0;
                    textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                }              
                column_box.Text = (c - 1).ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
