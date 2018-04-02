namespace DzokFile
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnZipFolder = new System.Windows.Forms.Button();
            this.btnZipFile = new System.Windows.Forms.Button();
            this.btnFileName = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder:";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(89, 44);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(262, 22);
            this.txtFolder.TabIndex = 1;
            this.txtFolder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(358, 39);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(42, 32);
            this.btnFolder.TabIndex = 2;
            this.btnFolder.Text = "...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnZipFolder
            // 
            this.btnZipFolder.Location = new System.Drawing.Point(406, 39);
            this.btnZipFolder.Name = "btnZipFolder";
            this.btnZipFolder.Size = new System.Drawing.Size(75, 32);
            this.btnZipFolder.TabIndex = 3;
            this.btnZipFolder.Text = "Zip";
            this.btnZipFolder.UseVisualStyleBackColor = true;
            this.btnZipFolder.Click += new System.EventHandler(this.btnZipFolder_Click);
            // 
            // btnZipFile
            // 
            this.btnZipFile.Location = new System.Drawing.Point(406, 77);
            this.btnZipFile.Name = "btnZipFile";
            this.btnZipFile.Size = new System.Drawing.Size(75, 32);
            this.btnZipFile.TabIndex = 7;
            this.btnZipFile.Text = "Zip";
            this.btnZipFile.UseVisualStyleBackColor = true;
            this.btnZipFile.Click += new System.EventHandler(this.btnZipFile_Click);
            // 
            // btnFileName
            // 
            this.btnFileName.Location = new System.Drawing.Point(358, 75);
            this.btnFileName.Name = "btnFileName";
            this.btnFileName.Size = new System.Drawing.Size(42, 36);
            this.btnFileName.TabIndex = 6;
            this.btnFileName.Text = "...";
            this.btnFileName.UseVisualStyleBackColor = true;
            this.btnFileName.Click += new System.EventHandler(this.btnFileName_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(89, 82);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(262, 22);
            this.txtFileName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "File:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(89, 123);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(262, 23);
            this.progressBar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 230);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnZipFile);
            this.Controls.Add(this.btnFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZipFolder);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Archiver by Dmitrii Voitovich";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnZipFolder;
        private System.Windows.Forms.Button btnZipFile;
        private System.Windows.Forms.Button btnFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

