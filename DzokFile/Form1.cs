using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
using System.IO;

namespace DzokFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select your path";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = fbd.SelectedPath;
            }
        }

        private void btnFileName_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files|*.*", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    txtFileName.Text = ofd.FileName;
            }
        }

        private void btnZipFolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
            {
                MessageBox.Show("Please, select your folder", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFolder.Focus();
                return;
            }
            string path = txtFolder.Text;
            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    zip.AddDirectory(path);
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
                    zip.SaveProgress += Zip_SaveProgress;
                    zip.Save(string.Format("{0}{1}.zip", di.Parent.FullName, di.Name));
                }
            })
            { IsBackground = true };
            thread.Start();
        }

        private void Zip_SaveProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if(e.EventType == Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                progressBar.Invoke(new MethodInvoker(delegate
                {
                    progressBar.Maximum = e.EntriesTotal;
                    progressBar.Value = e.EntriesSaved + 1;
                    progressBar.Update();
                }));
            }
        }

        private void Zip_SaveFileProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
            {
                progressBar.Invoke(new MethodInvoker(delegate
                {
                    progressBar.Maximum = 100;
                    progressBar.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                    progressBar.Update();
                }));
            }
        }

        private void btnZipFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFileName.Text))
            {
                MessageBox.Show("Please, select your filename", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFileName.Focus();
                return;
            }
            string fileName = txtFileName.Text;
            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    FileInfo fi = new FileInfo(fileName);
                    zip.AddFile(fileName);
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(fileName);
                    zip.SaveProgress += Zip_SaveFileProgress;
                    zip.Save(string.Format("{0}/{1}.zip", di.Parent.FullName, di.Name));
                }
            })
            { IsBackground = true };
            thread.Start();
        }
    }
}
