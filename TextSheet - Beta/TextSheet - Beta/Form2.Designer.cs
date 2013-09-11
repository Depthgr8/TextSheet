namespace TextSheet___Beta
{
    partial class Form2
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
            this.new_pwd_lbl = new System.Windows.Forms.Label();
            this.cnfrm_pwd_lbl = new System.Windows.Forms.Label();
            this.new_pwd_txt = new System.Windows.Forms.TextBox();
            this.cnfrm_pwd_txt = new System.Windows.Forms.TextBox();
            this.change_pwd_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // new_pwd_lbl
            // 
            this.new_pwd_lbl.AutoSize = true;
            this.new_pwd_lbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_pwd_lbl.ForeColor = System.Drawing.SystemColors.GrayText;
            this.new_pwd_lbl.Location = new System.Drawing.Point(23, 53);
            this.new_pwd_lbl.Name = "new_pwd_lbl";
            this.new_pwd_lbl.Size = new System.Drawing.Size(158, 24);
            this.new_pwd_lbl.TabIndex = 0;
            this.new_pwd_lbl.Text = "New Password";
            // 
            // cnfrm_pwd_lbl
            // 
            this.cnfrm_pwd_lbl.AutoSize = true;
            this.cnfrm_pwd_lbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnfrm_pwd_lbl.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cnfrm_pwd_lbl.Location = new System.Drawing.Point(23, 107);
            this.cnfrm_pwd_lbl.Name = "cnfrm_pwd_lbl";
            this.cnfrm_pwd_lbl.Size = new System.Drawing.Size(183, 24);
            this.cnfrm_pwd_lbl.TabIndex = 1;
            this.cnfrm_pwd_lbl.Text = "Confirm Pasword";
            // 
            // new_pwd_txt
            // 
            this.new_pwd_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.new_pwd_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.new_pwd_txt.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_pwd_txt.Location = new System.Drawing.Point(233, 53);
            this.new_pwd_txt.Name = "new_pwd_txt";
            this.new_pwd_txt.PasswordChar = '.';
            this.new_pwd_txt.Size = new System.Drawing.Size(305, 41);
            this.new_pwd_txt.TabIndex = 2;
            this.new_pwd_txt.UseSystemPasswordChar = true;
            // 
            // cnfrm_pwd_txt
            // 
            this.cnfrm_pwd_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cnfrm_pwd_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cnfrm_pwd_txt.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnfrm_pwd_txt.Location = new System.Drawing.Point(233, 107);
            this.cnfrm_pwd_txt.Name = "cnfrm_pwd_txt";
            this.cnfrm_pwd_txt.PasswordChar = '.';
            this.cnfrm_pwd_txt.Size = new System.Drawing.Size(305, 41);
            this.cnfrm_pwd_txt.TabIndex = 3;
            this.cnfrm_pwd_txt.UseSystemPasswordChar = true;
            // 
            // change_pwd_button
            // 
            this.change_pwd_button.BackColor = System.Drawing.Color.LightSteelBlue;
            this.change_pwd_button.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_pwd_button.ForeColor = System.Drawing.Color.Maroon;
            this.change_pwd_button.Location = new System.Drawing.Point(27, 182);
            this.change_pwd_button.Name = "change_pwd_button";
            this.change_pwd_button.Size = new System.Drawing.Size(356, 42);
            this.change_pwd_button.TabIndex = 4;
            this.change_pwd_button.Text = "Change your password";
            this.change_pwd_button.UseVisualStyleBackColor = false;
            this.change_pwd_button.Click += new System.EventHandler(this.change_pwd_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(572, 253);
            this.Controls.Add(this.change_pwd_button);
            this.Controls.Add(this.cnfrm_pwd_txt);
            this.Controls.Add(this.new_pwd_txt);
            this.Controls.Add(this.cnfrm_pwd_lbl);
            this.Controls.Add(this.new_pwd_lbl);
            this.MaximumSize = new System.Drawing.Size(588, 291);
            this.MinimumSize = new System.Drawing.Size(588, 291);
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Set password";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label new_pwd_lbl;
        private System.Windows.Forms.Label cnfrm_pwd_lbl;
        private System.Windows.Forms.TextBox new_pwd_txt;
        private System.Windows.Forms.TextBox cnfrm_pwd_txt;
        private System.Windows.Forms.Button change_pwd_button;
    }
}