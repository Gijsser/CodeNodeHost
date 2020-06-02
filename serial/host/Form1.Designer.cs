namespace host
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
            this.coboCommunication = new System.Windows.Forms.ComboBox();
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coboCommunication
            // 
            this.coboCommunication.FormattingEnabled = true;
            this.coboCommunication.Location = new System.Drawing.Point(12, 75);
            this.coboCommunication.Name = "coboCommunication";
            this.coboCommunication.Size = new System.Drawing.Size(121, 24);
            this.coboCommunication.TabIndex = 0;
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Location = new System.Drawing.Point(139, 12);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(292, 178);
            this.inputRichTextBox.TabIndex = 2;
            this.inputRichTextBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(12, 12);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(121, 57);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.inputRichTextBox);
            this.Controls.Add(this.coboCommunication);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox coboCommunication;
        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.Button sendButton;
    }
}

