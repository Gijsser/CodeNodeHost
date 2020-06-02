namespace Host
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
            this.components = new System.ComponentModel.Container();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnMakeJson = new System.Windows.Forms.Button();
            this.btnSelectJson = new System.Windows.Forms.Button();
            this.cBComPoort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBFileName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.ReadTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(55, 44);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(75, 23);
            this.btnSendFile.TabIndex = 0;
            this.btnSendFile.Text = "Send File";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnMakeJson
            // 
            this.btnMakeJson.Location = new System.Drawing.Point(284, 186);
            this.btnMakeJson.Name = "btnMakeJson";
            this.btnMakeJson.Size = new System.Drawing.Size(91, 23);
            this.btnMakeJson.TabIndex = 2;
            this.btnMakeJson.Text = "Make File";
            this.btnMakeJson.UseVisualStyleBackColor = true;
            this.btnMakeJson.Click += new System.EventHandler(this.btnMakeJson_Click);
            // 
            // btnSelectJson
            // 
            this.btnSelectJson.Location = new System.Drawing.Point(284, 215);
            this.btnSelectJson.Name = "btnSelectJson";
            this.btnSelectJson.Size = new System.Drawing.Size(91, 23);
            this.btnSelectJson.TabIndex = 3;
            this.btnSelectJson.Text = "Select File";
            this.btnSelectJson.UseVisualStyleBackColor = true;
            this.btnSelectJson.Click += new System.EventHandler(this.btnSelectJson_Click);
            // 
            // cBComPoort
            // 
            this.cBComPoort.FormattingEnabled = true;
            this.cBComPoort.Location = new System.Drawing.Point(55, 73);
            this.cBComPoort.Name = "cBComPoort";
            this.cBComPoort.Size = new System.Drawing.Size(121, 24);
            this.cBComPoort.TabIndex = 4;
            this.cBComPoort.SelectedIndexChanged += new System.EventHandler(this.cBComPoort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "read als file ontvangen is";
            // 
            // tBFileName
            // 
            this.tBFileName.Location = new System.Drawing.Point(382, 186);
            this.tBFileName.Name = "tBFileName";
            this.tBFileName.Size = new System.Drawing.Size(100, 22);
            this.tBFileName.TabIndex = 6;
            this.tBFileName.Text = "File Name";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(382, 158);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 22);
            this.tbID.TabIndex = 7;
            this.tbID.Text = "ID";
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(382, 130);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(100, 22);
            this.tbAdres.TabIndex = 8;
            this.tbAdres.Text = "Adres";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(382, 102);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 9;
            this.tbName.Text = "Name";
            // 
            // ReadTimer
            // 
            this.ReadTimer.Enabled = true;
            this.ReadTimer.Interval = 1000;
            this.ReadTimer.Tick += new System.EventHandler(this.ReadTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tBFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBComPoort);
            this.Controls.Add(this.btnSelectJson);
            this.Controls.Add(this.btnMakeJson);
            this.Controls.Add(this.btnSendFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnMakeJson;
        private System.Windows.Forms.Button btnSelectJson;
        private System.Windows.Forms.ComboBox cBComPoort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBFileName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Timer ReadTimer;
    }
}

