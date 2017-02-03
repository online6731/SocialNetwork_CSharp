namespace SocialNetwork_Client
{
    partial class ChatForm
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
            this.allmesseges = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.messege = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // allmesseges
            // 
            this.allmesseges.Location = new System.Drawing.Point(12, 12);
            this.allmesseges.Multiline = true;
            this.allmesseges.Name = "allmesseges";
            this.allmesseges.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.allmesseges.Size = new System.Drawing.Size(409, 172);
            this.allmesseges.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messege
            // 
            this.messege.Location = new System.Drawing.Point(72, 198);
            this.messege.Name = "messege";
            this.messege.Size = new System.Drawing.Size(253, 20);
            this.messege.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Messege:";
            // 
            // ChatView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messege);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.allmesseges);
            this.Name = "ChatView";
            this.Text = "ChatView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox allmesseges;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox messege;
        private System.Windows.Forms.Label label1;
    }
}