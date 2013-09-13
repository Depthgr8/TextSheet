namespace TextSheet___Beta
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Primary_Menu = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.newTextSheet = new System.Windows.Forms.ToolStripMenuItem();
            this.openTextSheet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveTextSheet = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptTextSheet = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptTextSheet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refresh_from_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tools = new System.Windows.Forms.ToolStripMenuItem();
            this.themes = new System.Windows.Forms.ToolStripMenuItem();
            this.red = new System.Windows.Forms.ToolStripMenuItem();
            this.green = new System.Windows.Forms.ToolStripMenuItem();
            this.blue = new System.Windows.Forms.ToolStripMenuItem();
            this.gray = new System.Windows.Forms.ToolStripMenuItem();
            this.options = new System.Windows.Forms.ToolStripMenuItem();
            this.preferences = new System.Windows.Forms.ToolStripMenuItem();
            this.set_password = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.help_me = new System.Windows.Forms.ToolStripMenuItem();
            this.help_credits = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.feedback = new System.Windows.Forms.ToolStripMenuItem();
            this.show_support = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.newfile = new System.Windows.Forms.ToolStripButton();
            this.openfile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.savefile = new System.Windows.Forms.ToolStripButton();
            this.encrypt_file = new System.Windows.Forms.ToolStripButton();
            this.decrypt_file = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.prefs = new System.Windows.Forms.ToolStripButton();
            this.password = new System.Windows.Forms.ToolStripButton();
            this.reset_theme = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.row = new System.Windows.Forms.ToolStripLabel();
            this.row_box = new System.Windows.Forms.ToolStripTextBox();
            this.column = new System.Windows.Forms.ToolStripLabel();
            this.column_box = new System.Windows.Forms.ToolStripTextBox();
            this.draw = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.add_row = new System.Windows.Forms.ToolStripButton();
            this.add_colm = new System.Windows.Forms.ToolStripButton();
            this.del_row = new System.Windows.Forms.ToolStripButton();
            this.del_colm = new System.Windows.Forms.ToolStripButton();
            this.urlbox = new System.Windows.Forms.ToolStripTextBox();
            this.close_browser = new System.Windows.Forms.ToolStripButton();
            this.container_panel = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textsheet_block = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.sheet_panel = new System.Windows.Forms.TableLayoutPanel();
            this.column_panel = new System.Windows.Forms.TableLayoutPanel();
            this.row_panel = new System.Windows.Forms.TableLayoutPanel();
            this.horiz_bar = new System.Windows.Forms.HScrollBar();
            this.vert_bar = new System.Windows.Forms.VScrollBar();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.message = new System.Windows.Forms.ToolStripStatusLabel();
            this.Primary_Menu.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.container_panel.SuspendLayout();
            this.textsheet_block.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // Primary_Menu
            // 
            this.Primary_Menu.BackColor = System.Drawing.Color.Lavender;
            this.Primary_Menu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Primary_Menu.GripMargin = new System.Windows.Forms.Padding(2);
            this.Primary_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.tools,
            this.options,
            this.help});
            this.Primary_Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Primary_Menu.Location = new System.Drawing.Point(0, 0);
            this.Primary_Menu.Name = "Primary_Menu";
            this.Primary_Menu.Size = new System.Drawing.Size(1215, 25);
            this.Primary_Menu.TabIndex = 0;
            this.Primary_Menu.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTextSheet,
            this.openTextSheet,
            this.toolStripSeparator1,
            this.saveTextSheet,
            this.encryptTextSheet,
            this.decryptTextSheet,
            this.toolStripSeparator2,
            this.refresh_from_menu,
            this.exit});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(40, 21);
            this.file.Text = "File";
            // 
            // newTextSheet
            // 
            this.newTextSheet.Image = global::TextSheet___Beta.Properties.Resources.fdf1;
            this.newTextSheet.Name = "newTextSheet";
            this.newTextSheet.Size = new System.Drawing.Size(189, 22);
            this.newTextSheet.Text = "New TextSheet";
            this.newTextSheet.Click += new System.EventHandler(this.newTextSheet_Click_1);
            // 
            // openTextSheet
            // 
            this.openTextSheet.Image = global::TextSheet___Beta.Properties.Resources.fdf;
            this.openTextSheet.Name = "openTextSheet";
            this.openTextSheet.Size = new System.Drawing.Size(189, 22);
            this.openTextSheet.Text = "Open TextSheet";
            this.openTextSheet.Click += new System.EventHandler(this.openTextSheet_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // saveTextSheet
            // 
            this.saveTextSheet.Image = global::TextSheet___Beta.Properties.Resources.fdf;
            this.saveTextSheet.Name = "saveTextSheet";
            this.saveTextSheet.Size = new System.Drawing.Size(189, 22);
            this.saveTextSheet.Text = "Save TextSheet";
            this.saveTextSheet.Click += new System.EventHandler(this.saveTextSheet_Click);
            // 
            // encryptTextSheet
            // 
            this.encryptTextSheet.Image = global::TextSheet___Beta.Properties.Resources.Icon_297;
            this.encryptTextSheet.Name = "encryptTextSheet";
            this.encryptTextSheet.Size = new System.Drawing.Size(189, 22);
            this.encryptTextSheet.Text = "Encrypt TextSheet";
            this.encryptTextSheet.Click += new System.EventHandler(this.encryptTextSheet_Click);
            // 
            // decryptTextSheet
            // 
            this.decryptTextSheet.Image = global::TextSheet___Beta.Properties.Resources.Icon_294;
            this.decryptTextSheet.Name = "decryptTextSheet";
            this.decryptTextSheet.Size = new System.Drawing.Size(189, 22);
            this.decryptTextSheet.Text = "Decrypt TextSheet";
            this.decryptTextSheet.Click += new System.EventHandler(this.decryptTextSheet_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // refresh_from_menu
            // 
            this.refresh_from_menu.Image = global::TextSheet___Beta.Properties.Resources.Icon_417;
            this.refresh_from_menu.Name = "refresh_from_menu";
            this.refresh_from_menu.Size = new System.Drawing.Size(189, 22);
            this.refresh_from_menu.Text = "Refresh";
            this.refresh_from_menu.Click += new System.EventHandler(this.refresh_Click);
            // 
            // exit
            // 
            this.exit.Image = global::TextSheet___Beta.Properties.Resources.Icon_192;
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(189, 22);
            this.exit.Text = "Exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // tools
            // 
            this.tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themes});
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(51, 21);
            this.tools.Text = "Tools";
            // 
            // themes
            // 
            this.themes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.red,
            this.green,
            this.blue,
            this.gray});
            this.themes.Image = global::TextSheet___Beta.Properties.Resources.Data_22___Copy;
            this.themes.Name = "themes";
            this.themes.Size = new System.Drawing.Size(123, 22);
            this.themes.Text = "Themes";
            // 
            // red
            // 
            this.red.Image = global::TextSheet___Beta.Properties.Resources.Red;
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(115, 22);
            this.red.Text = "Red";
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // green
            // 
            this.green.Image = global::TextSheet___Beta.Properties.Resources.Green;
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(115, 22);
            this.green.Text = "Green";
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // blue
            // 
            this.blue.Image = global::TextSheet___Beta.Properties.Resources.Blue;
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(115, 22);
            this.blue.Text = "Blue";
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // gray
            // 
            this.gray.Image = global::TextSheet___Beta.Properties.Resources.Data_26;
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(115, 22);
            this.gray.Text = "Gray";
            this.gray.Click += new System.EventHandler(this.gray_Click);
            // 
            // options
            // 
            this.options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferences,
            this.set_password});
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(70, 21);
            this.options.Text = "Options";
            // 
            // preferences
            // 
            this.preferences.Image = global::TextSheet___Beta.Properties.Resources.Icon_210;
            this.preferences.Name = "preferences";
            this.preferences.Size = new System.Drawing.Size(160, 22);
            this.preferences.Text = "Preferences";
            this.preferences.Click += new System.EventHandler(this.preferences_Click);
            // 
            // set_password
            // 
            this.set_password.Image = global::TextSheet___Beta.Properties.Resources.Icon_53;
            this.set_password.Name = "set_password";
            this.set_password.Size = new System.Drawing.Size(160, 22);
            this.set_password.Text = "Set Password";
            this.set_password.Click += new System.EventHandler(this.set_password_Click);
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about,
            this.toolStripSeparator6,
            this.help_me,
            this.help_credits,
            this.toolStripSeparator7,
            this.feedback,
            this.show_support});
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(49, 21);
            this.help.Text = "Help";
            // 
            // about
            // 
            this.about.Image = global::TextSheet___Beta.Properties.Resources.fdf;
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(165, 22);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(162, 6);
            // 
            // help_me
            // 
            this.help_me.Image = global::TextSheet___Beta.Properties.Resources.fdf;
            this.help_me.Name = "help_me";
            this.help_me.Size = new System.Drawing.Size(165, 22);
            this.help_me.Text = "Help";
            this.help_me.Click += new System.EventHandler(this.help_me_Click);
            // 
            // help_credits
            // 
            this.help_credits.Image = global::TextSheet___Beta.Properties.Resources.Icon_510;
            this.help_credits.Name = "help_credits";
            this.help_credits.Size = new System.Drawing.Size(165, 22);
            this.help_credits.Text = "Credits";
            this.help_credits.Click += new System.EventHandler(this.help_credits_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(162, 6);
            // 
            // feedback
            // 
            this.feedback.Image = global::TextSheet___Beta.Properties.Resources.Icon_247;
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(165, 22);
            this.feedback.Text = "Feedback";
            this.feedback.Click += new System.EventHandler(this.feedback_Click);
            // 
            // show_support
            // 
            this.show_support.Image = global::TextSheet___Beta.Properties.Resources.Icon_422;
            this.show_support.Name = "show_support";
            this.show_support.Size = new System.Drawing.Size(165, 22);
            this.show_support.Text = "Show Support";
            this.show_support.Click += new System.EventHandler(this.show_support_Click);
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.Lavender;
            this.toolbar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refresh,
            this.toolStripSeparator3,
            this.newfile,
            this.openfile,
            this.toolStripSeparator4,
            this.savefile,
            this.encrypt_file,
            this.decrypt_file,
            this.toolStripSeparator5,
            this.prefs,
            this.password,
            this.reset_theme,
            this.toolStripSeparator8,
            this.row,
            this.row_box,
            this.column,
            this.column_box,
            this.draw,
            this.toolStripSeparator10,
            this.add_row,
            this.add_colm,
            this.del_row,
            this.del_colm,
            this.urlbox,
            this.close_browser});
            this.toolbar.Location = new System.Drawing.Point(0, 25);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(1215, 25);
            this.toolbar.TabIndex = 1;
            this.toolbar.Text = "toolStrip1";
            // 
            // refresh
            // 
            this.refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refresh.Image = global::TextSheet___Beta.Properties.Resources.Icon_417;
            this.refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(23, 22);
            this.refresh.Text = "Refresh TextSheet";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // newfile
            // 
            this.newfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newfile.Image = global::TextSheet___Beta.Properties.Resources.Icon_70;
            this.newfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newfile.Name = "newfile";
            this.newfile.Size = new System.Drawing.Size(23, 22);
            this.newfile.Text = "toolStripButton2";
            this.newfile.ToolTipText = "New TextSheet";
            this.newfile.Click += new System.EventHandler(this.newfile_Click);
            // 
            // openfile
            // 
            this.openfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openfile.Image = global::TextSheet___Beta.Properties.Resources.fdf;
            this.openfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(23, 22);
            this.openfile.Text = "toolStripButton3";
            this.openfile.ToolTipText = "Open TextSheet";
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // savefile
            // 
            this.savefile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savefile.Image = global::TextSheet___Beta.Properties.Resources.Icon_9;
            this.savefile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savefile.Name = "savefile";
            this.savefile.Size = new System.Drawing.Size(23, 22);
            this.savefile.Text = "toolStripButton4";
            this.savefile.ToolTipText = "Save TextSheet";
            this.savefile.Click += new System.EventHandler(this.savefile_Click);
            // 
            // encrypt_file
            // 
            this.encrypt_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.encrypt_file.Image = global::TextSheet___Beta.Properties.Resources.Icon_297;
            this.encrypt_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.encrypt_file.Name = "encrypt_file";
            this.encrypt_file.Size = new System.Drawing.Size(23, 22);
            this.encrypt_file.Text = "toolStripButton5";
            this.encrypt_file.ToolTipText = "Encrypt TextSheet";
            this.encrypt_file.Click += new System.EventHandler(this.encrypt_file_Click);
            // 
            // decrypt_file
            // 
            this.decrypt_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decrypt_file.Image = global::TextSheet___Beta.Properties.Resources.Icon_294;
            this.decrypt_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decrypt_file.Name = "decrypt_file";
            this.decrypt_file.Size = new System.Drawing.Size(23, 22);
            this.decrypt_file.Text = "toolStripButton6";
            this.decrypt_file.ToolTipText = "Decrypt TextSheet";
            this.decrypt_file.Click += new System.EventHandler(this.decrypt_file_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // prefs
            // 
            this.prefs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prefs.Image = global::TextSheet___Beta.Properties.Resources.Icon_210;
            this.prefs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prefs.Name = "prefs";
            this.prefs.Size = new System.Drawing.Size(23, 22);
            this.prefs.Text = "toolStripButton7";
            this.prefs.ToolTipText = "Preferences";
            this.prefs.Click += new System.EventHandler(this.prefs_Click);
            // 
            // password
            // 
            this.password.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.password.Image = global::TextSheet___Beta.Properties.Resources.Icon_53;
            this.password.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(23, 22);
            this.password.Text = "toolStripButton9";
            this.password.ToolTipText = "Set Password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // reset_theme
            // 
            this.reset_theme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reset_theme.Image = global::TextSheet___Beta.Properties.Resources.Data_22___Copy;
            this.reset_theme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reset_theme.Name = "reset_theme";
            this.reset_theme.Size = new System.Drawing.Size(23, 22);
            this.reset_theme.Text = "toolStripButton8";
            this.reset_theme.ToolTipText = "Reset default theme";
            this.reset_theme.Click += new System.EventHandler(this.reset_theme_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // row
            // 
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(42, 22);
            this.row.Text = "Rows";
            // 
            // row_box
            // 
            this.row_box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.row_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.row_box.Name = "row_box";
            this.row_box.Size = new System.Drawing.Size(100, 25);
            this.row_box.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // column
            // 
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(65, 22);
            this.column.Text = "Columns";
            // 
            // column_box
            // 
            this.column_box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.column_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.column_box.Name = "column_box";
            this.column_box.Size = new System.Drawing.Size(100, 25);
            this.column_box.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // draw
            // 
            this.draw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.draw.Image = global::TextSheet___Beta.Properties.Resources.fdf1;
            this.draw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(23, 22);
            this.draw.Text = "toolStripButton11";
            this.draw.ToolTipText = "Draw TextSheet";
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // add_row
            // 
            this.add_row.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.add_row.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_row.Name = "add_row";
            this.add_row.Size = new System.Drawing.Size(50, 22);
            this.add_row.Text = "+ row";
            this.add_row.Click += new System.EventHandler(this.add_row_Click);
            // 
            // add_colm
            // 
            this.add_colm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.add_colm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_colm.Name = "add_colm";
            this.add_colm.Size = new System.Drawing.Size(74, 22);
            this.add_colm.Text = "+ column";
            this.add_colm.Click += new System.EventHandler(this.add_colm_Click);
            // 
            // del_row
            // 
            this.del_row.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.del_row.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.del_row.Name = "del_row";
            this.del_row.Size = new System.Drawing.Size(45, 22);
            this.del_row.Text = "- row";
            this.del_row.Click += new System.EventHandler(this.del_row_Click);
            // 
            // del_colm
            // 
            this.del_colm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.del_colm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.del_colm.Name = "del_colm";
            this.del_colm.Size = new System.Drawing.Size(69, 22);
            this.del_colm.Text = "- column";
            this.del_colm.Click += new System.EventHandler(this.del_colm_Click);
            // 
            // urlbox
            // 
            this.urlbox.AcceptsTab = true;
            this.urlbox.AutoToolTip = true;
            this.urlbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.urlbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urlbox.Name = "urlbox";
            this.urlbox.Size = new System.Drawing.Size(300, 25);
            this.urlbox.Text = "http://www.Github.com/Depthgr8/TextSheet";
            this.urlbox.Visible = false;
            // 
            // close_browser
            // 
            this.close_browser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.close_browser.Image = global::TextSheet___Beta.Properties.Resources.Icon_192;
            this.close_browser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.close_browser.Name = "close_browser";
            this.close_browser.Size = new System.Drawing.Size(23, 22);
            this.close_browser.Text = "close_browser";
            this.close_browser.Visible = false;
            this.close_browser.Click += new System.EventHandler(this.close_browser_Click);
            // 
            // container_panel
            // 
            this.container_panel.AutoScroll = true;
            this.container_panel.BackColor = System.Drawing.Color.Lavender;
            this.container_panel.Controls.Add(this.webBrowser1);
            this.container_panel.Controls.Add(this.textsheet_block);
            this.container_panel.Controls.Add(this.sheet_panel);
            this.container_panel.Controls.Add(this.column_panel);
            this.container_panel.Controls.Add(this.row_panel);
            this.container_panel.Controls.Add(this.horiz_bar);
            this.container_panel.Controls.Add(this.vert_bar);
            this.container_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_panel.Location = new System.Drawing.Point(0, 50);
            this.container_panel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.container_panel.Name = "container_panel";
            this.container_panel.Size = new System.Drawing.Size(1215, 412);
            this.container_panel.TabIndex = 3;
            this.container_panel.Visible = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1198, 395);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.Url = new System.Uri("http://github.com/Depthgr8/TextSheet", System.UriKind.Absolute);
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // textsheet_block
            // 
            this.textsheet_block.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textsheet_block.ColumnCount = 1;
            this.textsheet_block.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.textsheet_block.Controls.Add(this.label1, 0, 0);
            this.textsheet_block.Location = new System.Drawing.Point(19, 13);
            this.textsheet_block.Margin = new System.Windows.Forms.Padding(0);
            this.textsheet_block.Name = "textsheet_block";
            this.textsheet_block.Padding = new System.Windows.Forms.Padding(3);
            this.textsheet_block.RowCount = 1;
            this.textsheet_block.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.textsheet_block.Size = new System.Drawing.Size(109, 37);
            this.textsheet_block.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TextSheet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sheet_panel
            // 
            this.sheet_panel.AutoSize = true;
            this.sheet_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sheet_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sheet_panel.ColumnCount = 1;
            this.sheet_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sheet_panel.Location = new System.Drawing.Point(125, 44);
            this.sheet_panel.Margin = new System.Windows.Forms.Padding(0);
            this.sheet_panel.Name = "sheet_panel";
            this.sheet_panel.Padding = new System.Windows.Forms.Padding(3);
            this.sheet_panel.RowCount = 1;
            this.sheet_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sheet_panel.Size = new System.Drawing.Size(6, 6);
            this.sheet_panel.TabIndex = 5;
            // 
            // column_panel
            // 
            this.column_panel.AutoSize = true;
            this.column_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.column_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.column_panel.ColumnCount = 1;
            this.column_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.column_panel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.column_panel.Location = new System.Drawing.Point(19, 44);
            this.column_panel.Margin = new System.Windows.Forms.Padding(0);
            this.column_panel.Name = "column_panel";
            this.column_panel.Padding = new System.Windows.Forms.Padding(3);
            this.column_panel.RowCount = 1;
            this.column_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.column_panel.Size = new System.Drawing.Size(6, 6);
            this.column_panel.TabIndex = 4;
            // 
            // row_panel
            // 
            this.row_panel.AutoSize = true;
            this.row_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.row_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.row_panel.ColumnCount = 1;
            this.row_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.row_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.row_panel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.row_panel.Location = new System.Drawing.Point(125, 13);
            this.row_panel.Margin = new System.Windows.Forms.Padding(0);
            this.row_panel.Name = "row_panel";
            this.row_panel.Padding = new System.Windows.Forms.Padding(3);
            this.row_panel.RowCount = 1;
            this.row_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.row_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.row_panel.Size = new System.Drawing.Size(6, 6);
            this.row_panel.TabIndex = 3;
            // 
            // horiz_bar
            // 
            this.horiz_bar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horiz_bar.Enabled = false;
            this.horiz_bar.Location = new System.Drawing.Point(0, 395);
            this.horiz_bar.Name = "horiz_bar";
            this.horiz_bar.Size = new System.Drawing.Size(1198, 17);
            this.horiz_bar.TabIndex = 1;
            // 
            // vert_bar
            // 
            this.vert_bar.Dock = System.Windows.Forms.DockStyle.Right;
            this.vert_bar.Enabled = false;
            this.vert_bar.Location = new System.Drawing.Point(1198, 0);
            this.vert_bar.Name = "vert_bar";
            this.vert_bar.Size = new System.Drawing.Size(17, 412);
            this.vert_bar.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Lavender;
            this.Status.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.message});
            this.Status.Location = new System.Drawing.Point(0, 462);
            this.Status.Name = "Status";
            this.Status.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.Status.Size = new System.Drawing.Size(1215, 22);
            this.Status.TabIndex = 2;
            this.Status.Text = "statusStrip1";
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Image = global::TextSheet___Beta.Properties.Resources.fdf;
            this.message.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(400, 17);
            this.message.Text = "Welcome to TextSheet Beta - Your free SpreadSheet maker";
            // 
            // Main_Form
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1215, 484);
            this.Controls.Add(this.container_panel);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.Primary_Menu);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Primary_Menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(778, 522);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextSheet - Beta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Primary_Menu.ResumeLayout(false);
            this.Primary_Menu.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.container_panel.ResumeLayout(false);
            this.container_panel.PerformLayout();
            this.textsheet_block.ResumeLayout(false);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Primary_Menu;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem newTextSheet;
        private System.Windows.Forms.ToolStripMenuItem tools;
        private System.Windows.Forms.ToolStripMenuItem options;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem openTextSheet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveTextSheet;
        private System.Windows.Forms.ToolStripMenuItem encryptTextSheet;
        private System.Windows.Forms.ToolStripMenuItem decryptTextSheet;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton newfile;
        private System.Windows.Forms.ToolStripButton openfile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton savefile;
        private System.Windows.Forms.ToolStripButton encrypt_file;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton decrypt_file;
        private System.Windows.Forms.ToolStripButton prefs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem themes;
        private System.Windows.Forms.ToolStripMenuItem gray;
        private System.Windows.Forms.ToolStripMenuItem preferences;
        private System.Windows.Forms.ToolStripMenuItem set_password;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem help_me;
        private System.Windows.Forms.ToolStripMenuItem help_credits;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem feedback;
        private System.Windows.Forms.ToolStripMenuItem show_support;
        private System.Windows.Forms.ToolStripButton reset_theme;
        private System.Windows.Forms.ToolStripButton password;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripLabel row;
        private System.Windows.Forms.ToolStripTextBox row_box;
        private System.Windows.Forms.ToolStripLabel column;
        private System.Windows.Forms.ToolStripTextBox column_box;
        private System.Windows.Forms.ToolStripButton draw;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem red;
        private System.Windows.Forms.ToolStripMenuItem green;
        private System.Windows.Forms.ToolStripMenuItem blue;
        private System.Windows.Forms.Panel container_panel;
        private System.Windows.Forms.ToolStripProgressBar progress_bar1;
        private System.Windows.Forms.VScrollBar vert_bar;
        private System.Windows.Forms.HScrollBar horiz_bar;
        private System.Windows.Forms.TableLayoutPanel sheet_panel;
        private System.Windows.Forms.TableLayoutPanel column_panel;
        private System.Windows.Forms.TableLayoutPanel row_panel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripStatusLabel message;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripMenuItem refresh_from_menu;
        private System.Windows.Forms.TableLayoutPanel textsheet_block;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton add_row;
        private System.Windows.Forms.ToolStripButton add_colm;
        private System.Windows.Forms.ToolStripButton del_row;
        private System.Windows.Forms.ToolStripButton del_colm;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripTextBox urlbox;
        private System.Windows.Forms.ToolStripButton close_browser;
    }
}

