using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FileManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_drive.Multiline = true;
            panel1.Visible = true;
            panel2.Visible = false;
            txt_read.Enabled = false;
        }

        private void btn_drive_Click(object sender, EventArgs e)
        {
            cmb_drive.Items.Clear();
            try
            {
                int i;
                String[] strd = Directory.GetLogicalDrives();
                for (i = 0; i < strd.Length; i++)
                {
                    cmb_drive.Items.Add(strd[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_create_new_dir_Click(object sender, EventArgs e)
        {
            cmb_sub_dir.Items.Clear();
            try
            {
                if (!Directory.Exists(txt_dir.Text))
                {
                    Directory.CreateDirectory(txt_dir.Text);
                    MessageBox.Show("Directory created");
                }
                else
                {
                    MessageBox.Show("Please Enter correct directory path and File name");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_subdir_Click(object sender, EventArgs e)
        {
            cmb_sub_dir.Items.Clear();
          
            try
            {
                String path = txt_dir.Text;
                DirectoryInfo dinfo = new DirectoryInfo(path);
                if (dinfo.Exists)
                {
                    DirectoryInfo[] subdir = dinfo.GetDirectories();
                    foreach (DirectoryInfo s in subdir)
                    {
                        cmb_sub_dir.Items.Add(s);
                    }

                    FileInfo[] finfo = dinfo.GetFiles("*");
                    foreach (FileInfo f in finfo)
                    {
                        cmb_sub_dir.Items.Add(f);
                    }

                }
                else
                {
                    MessageBox.Show("Directory does not Exist,Please enter valid directory path and name");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmb_drive_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String val = cmb_drive.SelectedItem.ToString();
                System.IO.DriveInfo dinfo = new System.IO.DriveInfo(val);
                txt_drive.Text = "your selected drive is:" + val + "\n Total Size of Drive is:" + dinfo.TotalSize + "\n Available Free space in Drive:" + dinfo.AvailableFreeSpace;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_copy_dir_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo srcdir = new DirectoryInfo(txt_source_dir.Text);
                DirectoryInfo destdir = new DirectoryInfo(txt_dest_dir.Text);
                CopyDirectory(srcdir, destdir);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //user defined
        private void CopyDirectory(DirectoryInfo srcdir, DirectoryInfo destdir)
        {
            try
            {
                if (!destdir.Exists)
                {
                    destdir.Create();
                    FileInfo[] finfo = srcdir.GetFiles();
                    foreach (FileInfo f in finfo)
                    {
                        f.CopyTo(Path.Combine(destdir.FullName, f.Name));
                    }
                    DirectoryInfo[] dinfo = srcdir.GetDirectories();
                    foreach (DirectoryInfo d in dinfo)
                    {
                        String dest = Path.Combine(destdir.FullName, d.Name);
                        CopyDirectory(d, new DirectoryInfo(dest));
                    }
                    MessageBox.Show("Directory has Copied successfully to another Drive");
                }
                else
                {
                    MessageBox.Show("Please enter valid path and File name");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
//end of user defined
        private void btn_change_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
                panel2.Visible = true;               
            }
            else
            {
                panel1.Visible = true;
                panel2.Visible = false ;
            }
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(txt_file.Text, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(textBox7.Text);
                sw.Flush();
                string content = txt_write.Text; 
                sw.Write(content.Replace("\n", Environment.NewLine));
                sw.Close();  
                fs.Close();
                MessageBox.Show("Content is written in file successfully");
                txt_write.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(txt_file.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                txt_read.Text = 
                sr.ReadToEnd();
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(txt_file.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                String str = sr.ReadToEnd();
                int i = (str.IndexOf(txt_find.Text, 0));
                if (i > -1)
                {
                    MessageBox.Show("This word is exist in the file");
                }
                else
                {
                    MessageBox.Show("This word is not exist in the file try another words");
                }
                sr.Close();
                fs.Close();
                txt_find.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_append_Click(object sender, EventArgs e)
        {
            try
            {
                String str = txt_file.Text;
                StreamWriter sw = File.AppendText(str);
                sw.WriteLine(txt_append.Text);
                sw.Close();
                MessageBox.Show("File contents appended successfully");
                txt_append.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_rename_Click(object sender, EventArgs e)
        {
            String src = txt_file.Text;
            String dest = txt_rename.Text;
            try
            {
                FileInfo srcfile = new FileInfo(src);
                if (srcfile.Exists)
                {
                    srcfile.MoveTo(dest);
                    MessageBox.Show("File is Renamed successfully");
                    txt_rename.Clear();
                }
                else
                {
                    MessageBox.Show("Entere correct File Name and Path again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            String text = File.ReadAllText(txt_file.Text);

            String Value = text.Replace(txt_oldvalue.Text, txt_newvalue.Text);
            File.WriteAllText(txt_file.Text, Value);
            MessageBox.Show("successfully Replaced");
            txt_oldvalue.Clear();
            txt_newvalue.Clear();
        }
    }
}
