namespace POS_Q80
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            connectBtn = new Button();
            sendDataBtn = new Button();
            SuspendLayout();
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(12, 12);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(401, 65);
            connectBtn.TabIndex = 0;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // sendDataBtn
            // 
            sendDataBtn.Location = new Point(12, 83);
            sendDataBtn.Name = "sendDataBtn";
            sendDataBtn.Size = new Size(401, 65);
            sendDataBtn.TabIndex = 1;
            sendDataBtn.Text = "Send Data";
            sendDataBtn.UseVisualStyleBackColor = true;
            sendDataBtn.Click += sendDataBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 450);
            Controls.Add(sendDataBtn);
            Controls.Add(connectBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button connectBtn;
        private Button sendDataBtn;
    }
}