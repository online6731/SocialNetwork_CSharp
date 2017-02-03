namespace SocialNetwork_Client
{
    partial class ClientForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groups_list = new System.Windows.Forms.ListBox();
            this.JoinButton = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.student_no = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SignupButton = new System.Windows.Forms.Button();
            this.first_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.login_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.login_ID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.group_type = new System.Windows.Forms.TextBox();
            this.MakegroupButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.group_describtion = new System.Windows.Forms.TextBox();
            this.group_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.group_id = new System.Windows.Forms.TextBox();
            this.AddtogroupButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server IP:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ConnectButton);
            this.panel1.Controls.Add(this.port);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ip);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 101);
            this.panel1.TabIndex = 2;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(52, 68);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 7;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(90, 38);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(88, 20);
            this.port.TabIndex = 4;
            this.port.Text = "8888";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Server Port:";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(90, 10);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(88, 20);
            this.ip.TabIndex = 2;
            this.ip.Text = "127.0.0.1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.groups_list);
            this.panel2.Controls.Add(this.JoinButton);
            this.panel2.Location = new System.Drawing.Point(208, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 150);
            this.panel2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Groups list:";
            // 
            // groups_list
            // 
            this.groups_list.FormattingEnabled = true;
            this.groups_list.Location = new System.Drawing.Point(17, 32);
            this.groups_list.Name = "groups_list";
            this.groups_list.Size = new System.Drawing.Size(161, 69);
            this.groups_list.TabIndex = 8;
            // 
            // JoinButton
            // 
            this.JoinButton.Location = new System.Drawing.Point(55, 114);
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.Size = new System.Drawing.Size(75, 23);
            this.JoinButton.TabIndex = 7;
            this.JoinButton.Text = "Join";
            this.JoinButton.UseVisualStyleBackColor = true;
            this.JoinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(-2, 448);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(16, 13);
            this.log.TabIndex = 9;
            this.log.Text = "...";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.password);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.student_no);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.last_name);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.SignupButton);
            this.panel3.Controls.Add(this.first_name);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(13, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 150);
            this.panel3.TabIndex = 9;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(90, 32);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(88, 20);
            this.password.TabIndex = 13;
            this.password.Text = "SHIT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Password:";
            // 
            // student_no
            // 
            this.student_no.Location = new System.Drawing.Point(90, 6);
            this.student_no.Name = "student_no";
            this.student_no.Size = new System.Drawing.Size(88, 20);
            this.student_no.TabIndex = 11;
            this.student_no.Text = "9512358036";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Student_No:";
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(90, 84);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(88, 20);
            this.last_name.TabIndex = 9;
            this.last_name.Text = "Shadmehr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Last_Name:";
            // 
            // SignupButton
            // 
            this.SignupButton.Location = new System.Drawing.Point(55, 116);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(75, 23);
            this.SignupButton.TabIndex = 7;
            this.SignupButton.Text = "Sign up";
            this.SignupButton.UseVisualStyleBackColor = true;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(90, 58);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(88, 20);
            this.first_name.TabIndex = 2;
            this.first_name.Text = "Bahman";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "First_Name:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.login_pass);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.login_ID);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.LoginButton);
            this.panel4.Location = new System.Drawing.Point(208, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 101);
            this.panel4.TabIndex = 14;
            // 
            // login_pass
            // 
            this.login_pass.Location = new System.Drawing.Point(90, 38);
            this.login_pass.Name = "login_pass";
            this.login_pass.Size = new System.Drawing.Size(88, 20);
            this.login_pass.TabIndex = 13;
            this.login_pass.Text = "SHIT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password:";
            // 
            // login_ID
            // 
            this.login_ID.Location = new System.Drawing.Point(90, 12);
            this.login_ID.Name = "login_ID";
            this.login_ID.Size = new System.Drawing.Size(88, 20);
            this.login_ID.TabIndex = 11;
            this.login_ID.Text = "9512358036";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Student_No:";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(55, 67);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.group_type);
            this.panel5.Controls.Add(this.MakegroupButton);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.group_describtion);
            this.panel5.Controls.Add(this.group_name);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(13, 274);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(189, 130);
            this.panel5.TabIndex = 15;
            // 
            // group_type
            // 
            this.group_type.Location = new System.Drawing.Point(90, 34);
            this.group_type.Name = "group_type";
            this.group_type.Size = new System.Drawing.Size(88, 20);
            this.group_type.TabIndex = 19;
            this.group_type.Text = "group";
            // 
            // MakegroupButton
            // 
            this.MakegroupButton.Location = new System.Drawing.Point(55, 96);
            this.MakegroupButton.Name = "MakegroupButton";
            this.MakegroupButton.Size = new System.Drawing.Size(75, 23);
            this.MakegroupButton.TabIndex = 7;
            this.MakegroupButton.Text = "Make group";
            this.MakegroupButton.UseVisualStyleBackColor = true;
            this.MakegroupButton.Click += new System.EventHandler(this.MakegroupButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Type:";
            // 
            // group_describtion
            // 
            this.group_describtion.Location = new System.Drawing.Point(90, 60);
            this.group_describtion.Name = "group_describtion";
            this.group_describtion.Size = new System.Drawing.Size(88, 20);
            this.group_describtion.TabIndex = 15;
            this.group_describtion.Text = "Cool Shit";
            // 
            // group_name
            // 
            this.group_name.Location = new System.Drawing.Point(90, 8);
            this.group_name.Name = "group_name";
            this.group_name.Size = new System.Drawing.Size(88, 20);
            this.group_name.TabIndex = 17;
            this.group_name.Text = "threedot";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Describtion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Name:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.group_id);
            this.panel6.Controls.Add(this.AddtogroupButton);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.user_id);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Location = new System.Drawing.Point(208, 275);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(189, 130);
            this.panel6.TabIndex = 20;
            // 
            // group_id
            // 
            this.group_id.Location = new System.Drawing.Point(90, 34);
            this.group_id.Name = "group_id";
            this.group_id.Size = new System.Drawing.Size(88, 20);
            this.group_id.TabIndex = 19;
            this.group_id.Text = "threedot";
            // 
            // AddtogroupButton
            // 
            this.AddtogroupButton.Location = new System.Drawing.Point(43, 95);
            this.AddtogroupButton.Name = "AddtogroupButton";
            this.AddtogroupButton.Size = new System.Drawing.Size(96, 23);
            this.AddtogroupButton.TabIndex = 7;
            this.AddtogroupButton.Text = "Add to group";
            this.AddtogroupButton.UseVisualStyleBackColor = true;
            this.AddtogroupButton.Click += new System.EventHandler(this.AddtogroupButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Group ID:";
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(90, 8);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(88, 20);
            this.user_id.TabIndex = 17;
            this.user_id.Text = "9512358036";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Student_No:";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 417);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.log);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button JoinButton;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox student_no;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.ListBox groups_list;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox login_pass;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox group_type;
        private System.Windows.Forms.Button MakegroupButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox group_describtion;
        private System.Windows.Forms.TextBox group_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox group_id;
        private System.Windows.Forms.Button AddtogroupButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox login_ID;
    }
}

