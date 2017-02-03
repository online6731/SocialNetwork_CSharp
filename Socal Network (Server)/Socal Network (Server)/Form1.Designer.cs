namespace SocialNetwork_Server
{
    partial class ServerForm
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
            log = new System.Windows.Forms.TextBox();
            port = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            closeButton = new System.Windows.Forms.Button();
            startButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // log
            // 
            log.Location = new System.Drawing.Point(11, 41);
            log.Multiline = true;
            log.Name = "log";
            log.ReadOnly = true;
            log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            log.Size = new System.Drawing.Size(334, 116);
            log.TabIndex = 9;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(57, 14);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(100, 20);
            this.port.TabIndex = 5;
            this.port.Text = "8888";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(262, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(181, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 172);
            this.Controls.Add(log);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.port);
            this.Controls.Add(this.label2);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button startButton;
        public static System.Windows.Forms.TextBox log;
    }
}

