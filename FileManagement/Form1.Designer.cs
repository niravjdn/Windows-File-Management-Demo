namespace FileManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_jead = new System.Windows.Forms.Label();
            this.cmb_drive = new System.Windows.Forms.ComboBox();
            this.txt_drive = new System.Windows.Forms.TextBox();
            this.btn_drive = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_copy_dir = new System.Windows.Forms.Button();
            this.lbl_dir_dest = new System.Windows.Forms.Label();
            this.lbl_dir_source = new System.Windows.Forms.Label();
            this.txt_source_dir = new System.Windows.Forms.TextBox();
            this.txt_dest_dir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_dir_path = new System.Windows.Forms.Label();
            this.btn_create_new_dir = new System.Windows.Forms.Button();
            this.btn_subdir = new System.Windows.Forms.Button();
            this.cmb_sub_dir = new System.Windows.Forms.ComboBox();
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_write = new System.Windows.Forms.Button();
            this.txt_write = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_newvalue = new System.Windows.Forms.TextBox();
            this.btn_replace = new System.Windows.Forms.Button();
            this.txt_oldvalue = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_rename = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_rename = new System.Windows.Forms.TextBox();
            this.btn_append = new System.Windows.Forms.Button();
            this.txt_append = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_read = new System.Windows.Forms.Button();
            this.txt_read = new System.Windows.Forms.TextBox();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_jead
            // 
            this.lbl_jead.AutoSize = true;
            this.lbl_jead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jead.Location = new System.Drawing.Point(374, 23);
            this.lbl_jead.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_jead.Name = "lbl_jead";
            this.lbl_jead.Size = new System.Drawing.Size(237, 31);
            this.lbl_jead.TabIndex = 0;
            this.lbl_jead.Text = "File Management";
            // 
            // cmb_drive
            // 
            this.cmb_drive.FormattingEnabled = true;
            this.cmb_drive.Location = new System.Drawing.Point(35, 31);
            this.cmb_drive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_drive.Name = "cmb_drive";
            this.cmb_drive.Size = new System.Drawing.Size(198, 23);
            this.cmb_drive.TabIndex = 1;
            this.cmb_drive.SelectedIndexChanged += new System.EventHandler(this.cmb_drive_SelectedIndexChanged);
            // 
            // txt_drive
            // 
            this.txt_drive.Location = new System.Drawing.Point(35, 73);
            this.txt_drive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_drive.Multiline = true;
            this.txt_drive.Name = "txt_drive";
            this.txt_drive.Size = new System.Drawing.Size(198, 73);
            this.txt_drive.TabIndex = 2;
            // 
            // btn_drive
            // 
            this.btn_drive.Location = new System.Drawing.Point(35, 162);
            this.btn_drive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_drive.Name = "btn_drive";
            this.btn_drive.Size = new System.Drawing.Size(199, 26);
            this.btn_drive.TabIndex = 3;
            this.btn_drive.Text = "Show My System Drive Detail";
            this.btn_drive.UseVisualStyleBackColor = true;
            this.btn_drive.Click += new System.EventHandler(this.btn_drive_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_copy_dir);
            this.panel1.Controls.Add(this.lbl_dir_dest);
            this.panel1.Controls.Add(this.lbl_dir_source);
            this.panel1.Controls.Add(this.txt_source_dir);
            this.panel1.Controls.Add(this.txt_dest_dir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_dir_path);
            this.panel1.Controls.Add(this.btn_create_new_dir);
            this.panel1.Controls.Add(this.btn_subdir);
            this.panel1.Controls.Add(this.cmb_sub_dir);
            this.panel1.Controls.Add(this.txt_dir);
            this.panel1.Controls.Add(this.btn_drive);
            this.panel1.Controls.Add(this.cmb_drive);
            this.panel1.Controls.Add(this.txt_drive);
            this.panel1.Location = new System.Drawing.Point(23, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 250);
            this.panel1.TabIndex = 4;
            // 
            // btn_copy_dir
            // 
            this.btn_copy_dir.Location = new System.Drawing.Point(783, 153);
            this.btn_copy_dir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_copy_dir.Name = "btn_copy_dir";
            this.btn_copy_dir.Size = new System.Drawing.Size(199, 26);
            this.btn_copy_dir.TabIndex = 15;
            this.btn_copy_dir.Text = "Copy Directory";
            this.btn_copy_dir.UseVisualStyleBackColor = true;
            this.btn_copy_dir.Click += new System.EventHandler(this.btn_copy_dir_Click);
            // 
            // lbl_dir_dest
            // 
            this.lbl_dir_dest.AutoSize = true;
            this.lbl_dir_dest.Location = new System.Drawing.Point(722, 111);
            this.lbl_dir_dest.Name = "lbl_dir_dest";
            this.lbl_dir_dest.Size = new System.Drawing.Size(27, 15);
            this.lbl_dir_dest.TabIndex = 14;
            this.lbl_dir_dest.Text = "Dest";
            // 
            // lbl_dir_source
            // 
            this.lbl_dir_source.AutoSize = true;
            this.lbl_dir_source.Location = new System.Drawing.Point(722, 73);
            this.lbl_dir_source.Name = "lbl_dir_source";
            this.lbl_dir_source.Size = new System.Drawing.Size(39, 15);
            this.lbl_dir_source.TabIndex = 13;
            this.lbl_dir_source.Text = "Source";
            // 
            // txt_source_dir
            // 
            this.txt_source_dir.Location = new System.Drawing.Point(784, 68);
            this.txt_source_dir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_source_dir.Name = "txt_source_dir";
            this.txt_source_dir.Size = new System.Drawing.Size(198, 20);
            this.txt_source_dir.TabIndex = 12;
            // 
            // txt_dest_dir
            // 
            this.txt_dest_dir.Location = new System.Drawing.Point(784, 103);
            this.txt_dest_dir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_dest_dir.Name = "txt_dest_dir";
            this.txt_dest_dir.Size = new System.Drawing.Size(198, 20);
            this.txt_dest_dir.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(721, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Copy Directory From One Drive To Another";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Directory";
            // 
            // lbl_dir_path
            // 
            this.lbl_dir_path.AutoSize = true;
            this.lbl_dir_path.Location = new System.Drawing.Point(285, 30);
            this.lbl_dir_path.Name = "lbl_dir_path";
            this.lbl_dir_path.Size = new System.Drawing.Size(127, 15);
            this.lbl_dir_path.TabIndex = 8;
            this.lbl_dir_path.Text = "Enter FIle Name With Path";
            // 
            // btn_create_new_dir
            // 
            this.btn_create_new_dir.Location = new System.Drawing.Point(417, 53);
            this.btn_create_new_dir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_create_new_dir.Name = "btn_create_new_dir";
            this.btn_create_new_dir.Size = new System.Drawing.Size(179, 26);
            this.btn_create_new_dir.TabIndex = 7;
            this.btn_create_new_dir.Text = "Create New Directory";
            this.btn_create_new_dir.UseVisualStyleBackColor = true;
            this.btn_create_new_dir.Click += new System.EventHandler(this.btn_create_new_dir_Click);
            // 
            // btn_subdir
            // 
            this.btn_subdir.Location = new System.Drawing.Point(416, 144);
            this.btn_subdir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_subdir.Name = "btn_subdir";
            this.btn_subdir.Size = new System.Drawing.Size(199, 26);
            this.btn_subdir.TabIndex = 6;
            this.btn_subdir.Text = "Show My Subdirectory Drive Detail";
            this.btn_subdir.UseVisualStyleBackColor = true;
            this.btn_subdir.Click += new System.EventHandler(this.btn_subdir_Click);
            // 
            // cmb_sub_dir
            // 
            this.cmb_sub_dir.FormattingEnabled = true;
            this.cmb_sub_dir.Location = new System.Drawing.Point(420, 102);
            this.cmb_sub_dir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_sub_dir.Name = "cmb_sub_dir";
            this.cmb_sub_dir.Size = new System.Drawing.Size(198, 23);
            this.cmb_sub_dir.TabIndex = 4;
            // 
            // txt_dir
            // 
            this.txt_dir.Location = new System.Drawing.Point(417, 27);
            this.txt_dir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Size = new System.Drawing.Size(198, 20);
            this.txt_dir.TabIndex = 5;
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(145, 341);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(228, 23);
            this.btn_change.TabIndex = 5;
            this.btn_change.Text = "Show File Management Tools";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btn_write);
            this.panel2.Controls.Add(this.txt_write);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txt_newvalue);
            this.panel2.Controls.Add(this.btn_replace);
            this.panel2.Controls.Add(this.txt_oldvalue);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.btn_rename);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txt_rename);
            this.panel2.Controls.Add(this.btn_append);
            this.panel2.Controls.Add(this.txt_append);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btn_find);
            this.panel2.Controls.Add(this.txt_find);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btn_read);
            this.panel2.Controls.Add(this.txt_read);
            this.panel2.Controls.Add(this.txt_file);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Location = new System.Drawing.Point(12, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1045, 247);
            this.panel2.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Enter Your File content";
            // 
            // btn_write
            // 
            this.btn_write.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_write.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_write.Location = new System.Drawing.Point(46, 182);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(70, 37);
            this.btn_write.TabIndex = 65;
            this.btn_write.Text = "Write";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // txt_write
            // 
            this.txt_write.Location = new System.Drawing.Point(15, 84);
            this.txt_write.Multiline = true;
            this.txt_write.Name = "txt_write";
            this.txt_write.Size = new System.Drawing.Size(130, 92);
            this.txt_write.TabIndex = 64;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(968, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 63;
            this.label16.Text = "New Value";
            // 
            // txt_newvalue
            // 
            this.txt_newvalue.Location = new System.Drawing.Point(962, 107);
            this.txt_newvalue.Multiline = true;
            this.txt_newvalue.Name = "txt_newvalue";
            this.txt_newvalue.Size = new System.Drawing.Size(74, 32);
            this.txt_newvalue.TabIndex = 62;
            // 
            // btn_replace
            // 
            this.btn_replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_replace.Location = new System.Drawing.Point(894, 175);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(95, 30);
            this.btn_replace.TabIndex = 61;
            this.btn_replace.Text = "Replace";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // txt_oldvalue
            // 
            this.txt_oldvalue.Location = new System.Drawing.Point(877, 107);
            this.txt_oldvalue.Multiline = true;
            this.txt_oldvalue.Name = "txt_oldvalue";
            this.txt_oldvalue.Size = new System.Drawing.Size(69, 33);
            this.txt_oldvalue.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(884, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 59;
            this.label15.Text = "Old Value";
            // 
            // btn_rename
            // 
            this.btn_rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rename.Location = new System.Drawing.Point(724, 175);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(89, 28);
            this.btn_rename.TabIndex = 58;
            this.btn_rename.Text = "Rename";
            this.btn_rename.UseVisualStyleBackColor = true;
            this.btn_rename.Click += new System.EventHandler(this.btn_rename_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(644, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(224, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "Enter Path and Rename the File Name";
            // 
            // txt_rename
            // 
            this.txt_rename.Location = new System.Drawing.Point(679, 119);
            this.txt_rename.Name = "txt_rename";
            this.txt_rename.Size = new System.Drawing.Size(189, 20);
            this.txt_rename.TabIndex = 56;
            // 
            // btn_append
            // 
            this.btn_append.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_append.Location = new System.Drawing.Point(517, 180);
            this.btn_append.Name = "btn_append";
            this.btn_append.Size = new System.Drawing.Size(91, 34);
            this.btn_append.TabIndex = 55;
            this.btn_append.Text = "Append";
            this.btn_append.UseVisualStyleBackColor = true;
            this.btn_append.Click += new System.EventHandler(this.btn_append_Click);
            // 
            // txt_append
            // 
            this.txt_append.Location = new System.Drawing.Point(487, 79);
            this.txt_append.Multiline = true;
            this.txt_append.Name = "txt_append";
            this.txt_append.Size = new System.Drawing.Size(151, 90);
            this.txt_append.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(500, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Append the Contents to Existing File";
            // 
            // btn_find
            // 
            this.btn_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.Location = new System.Drawing.Point(368, 187);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(89, 34);
            this.btn_find.TabIndex = 52;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_find
            // 
            this.txt_find.Location = new System.Drawing.Point(338, 79);
            this.txt_find.Multiline = true;
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(140, 92);
            this.txt_find.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(335, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Find the words in the file";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(151, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Read the Existing File content";
            // 
            // btn_read
            // 
            this.btn_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.Location = new System.Drawing.Point(191, 186);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(86, 37);
            this.btn_read.TabIndex = 48;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // txt_read
            // 
            this.txt_read.Location = new System.Drawing.Point(166, 79);
            this.txt_read.Multiline = true;
            this.txt_read.Name = "txt_read";
            this.txt_read.Size = new System.Drawing.Size(158, 92);
            this.txt_read.TabIndex = 47;
            // 
            // txt_file
            // 
            this.txt_file.Location = new System.Drawing.Point(623, 32);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(323, 20);
            this.txt_file.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(676, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(215, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Enter Your Drive path and File Name";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(-215, 79);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(213, 92);
            this.textBox7.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 416);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_jead);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_jead;
        private System.Windows.Forms.ComboBox cmb_drive;
        private System.Windows.Forms.TextBox txt_drive;
        private System.Windows.Forms.Button btn_drive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_subdir;
        private System.Windows.Forms.ComboBox cmb_sub_dir;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.Button btn_create_new_dir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_dir_path;
        private System.Windows.Forms.Button btn_copy_dir;
        private System.Windows.Forms.Label lbl_dir_dest;
        private System.Windows.Forms.Label lbl_dir_source;
        private System.Windows.Forms.TextBox txt_source_dir;
        private System.Windows.Forms.TextBox txt_dest_dir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_newvalue;
        private System.Windows.Forms.Button btn_replace;
        private System.Windows.Forms.TextBox txt_oldvalue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_rename;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_rename;
        private System.Windows.Forms.Button btn_append;
        private System.Windows.Forms.TextBox txt_append;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.TextBox txt_read;
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.TextBox txt_write;
    }
}

