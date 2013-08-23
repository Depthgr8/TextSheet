using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TextSheet___Beta
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void savefile_Click(object sender, EventArgs e)
        {

        }

        private void saveTextSheet_Click(object sender, EventArgs e)
        {
            try
            {
                int r, c;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "DNS Files (*.dns)|*.dns";
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
        }

        private void openTextSheet_Click(object sender, EventArgs e)
        {

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
                ofd.Filter = "DNS Files (*.dns)|*.dns";
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
                    textboxrow.Location = new System.Drawing.Point(0,0);
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
                    textboxcolumn.TextAlign =System.Windows.Forms.HorizontalAlignment.Center;
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
            Primary_Menu.Dispose();
            toolbar.Dispose();
            container_panel.Dispose();
            Status.Dispose();
            InitializeComponent();
            toolbar.Enabled = true;
            container_panel.Visible = false;
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
            reset_theme_Click(sender,e);
        }

       
    }
}
