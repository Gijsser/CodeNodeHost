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
            this.tBFileName = new System.Windows.Forms.TextBox();
            this.ReadTimer = new System.Windows.Forms.Timer(this.components);
            this.nUDData = new System.Windows.Forms.NumericUpDown();
            this.nUDBRet = new System.Windows.Forms.NumericUpDown();
            this.nUDInstNr = new System.Windows.Forms.NumericUpDown();
            this.nUDSenNr = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nUDData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBRet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDInstNr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSenNr)).BeginInit();
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
            // tBFileName
            // 
            this.tBFileName.Location = new System.Drawing.Point(382, 186);
            this.tBFileName.Name = "tBFileName";
            this.tBFileName.Size = new System.Drawing.Size(100, 22);
            this.tBFileName.TabIndex = 6;
            this.tBFileName.Text = "File Name";
            // 
            // ReadTimer
            // 
            this.ReadTimer.Enabled = true;
            this.ReadTimer.Interval = 1000;
            this.ReadTimer.Tick += new System.EventHandler(this.ReadTimer_Tick);
            // 
            // nUDData
            // 
            this.nUDData.Location = new System.Drawing.Point(382, 158);
            this.nUDData.Name = "nUDData";
            this.nUDData.Size = new System.Drawing.Size(120, 22);
            this.nUDData.TabIndex = 7;
            // 
            // nUDBRet
            // 
            this.nUDBRet.Location = new System.Drawing.Point(382, 130);
            this.nUDBRet.Name = "nUDBRet";
            this.nUDBRet.Size = new System.Drawing.Size(120, 22);
            this.nUDBRet.TabIndex = 8;
            // 
            // nUDInstNr
            // 
            this.nUDInstNr.Location = new System.Drawing.Point(382, 102);
            this.nUDInstNr.Name = "nUDInstNr";
            this.nUDInstNr.Size = new System.Drawing.Size(120, 22);
            this.nUDInstNr.TabIndex = 9;
            // 
            // nUDSenNr
            // 
            this.nUDSenNr.Location = new System.Drawing.Point(382, 73);
            this.nUDSenNr.Name = "nUDSenNr";
            this.nUDSenNr.Size = new System.Drawing.Size(120, 22);
            this.nUDSenNr.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nUDSenNr);
            this.Controls.Add(this.nUDInstNr);
            this.Controls.Add(this.nUDBRet);
            this.Controls.Add(this.nUDData);
            this.Controls.Add(this.tBFileName);
            this.Controls.Add(this.cBComPoort);
            this.Controls.Add(this.btnSelectJson);
            this.Controls.Add(this.btnMakeJson);
            this.Controls.Add(this.btnSendFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUDData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBRet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDInstNr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSenNr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnMakeJson;
        private System.Windows.Forms.Button btnSelectJson;
        private System.Windows.Forms.ComboBox cBComPoort;
        private System.Windows.Forms.TextBox tBFileName;
        private System.Windows.Forms.Timer ReadTimer;
        private System.Windows.Forms.NumericUpDown nUDData;
        private System.Windows.Forms.NumericUpDown nUDBRet;
        private System.Windows.Forms.NumericUpDown nUDInstNr;
        private System.Windows.Forms.NumericUpDown nUDSenNr;
    }
}

