﻿namespace WindowsFormsApplication4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.loginIn = new System.Windows.Forms.Label();
            this.usern = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.purchasing1 = new WindowsFormsApplication4.Purchasing();
            this.transaction1 = new WindowsFormsApplication4.transaction();
            this.changeprivacy1 = new WindowsFormsApplication4.changeprivacy();
            this.userControl21 = new WindowsFormsApplication4.UserControl2();
            this.inventory1 = new WindowsFormsApplication4.inventory();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 47);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1312, 47);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angel\'s Access Point";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel3.Controls.Add(this.loginIn);
            this.panel3.Controls.Add(this.usern);
            this.panel3.Controls.Add(this.type);
            this.panel3.Controls.Add(this.sidepanel);
            this.panel3.Controls.Add(this.logout);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 682);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // loginIn
            // 
            this.loginIn.AutoSize = true;
            this.loginIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginIn.Location = new System.Drawing.Point(19, 639);
            this.loginIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginIn.Name = "loginIn";
            this.loginIn.Size = new System.Drawing.Size(86, 31);
            this.loginIn.TabIndex = 8;
            this.loginIn.Text = "label2";
            // 
            // usern
            // 
            this.usern.Location = new System.Drawing.Point(96, 84);
            this.usern.Margin = new System.Windows.Forms.Padding(4);
            this.usern.Name = "usern";
            this.usern.Size = new System.Drawing.Size(119, 22);
            this.usern.TabIndex = 7;
            this.usern.Visible = false;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(96, 42);
            this.type.Margin = new System.Windows.Forms.Padding(4);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(119, 22);
            this.type.TabIndex = 6;
            this.type.Visible = false;
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sidepanel.Location = new System.Drawing.Point(1, 114);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(23, 62);
            this.sidepanel.TabIndex = 2;
            this.sidepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidepanel_Paint);
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(27, 454);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(263, 62);
            this.logout.TabIndex = 5;
            this.logout.Text = "     Logout";
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(27, 386);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(263, 62);
            this.button5.TabIndex = 4;
            this.button5.Text = "     Change Privacy";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(27, 320);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(263, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "     User List";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(29, 254);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "     Transaction";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(29, 182);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "     Inventory";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(29, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "     Purchasing List";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // purchasing1
            // 
            this.purchasing1.BackColor = System.Drawing.Color.GhostWhite;
            this.purchasing1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchasing1.ForeColor = System.Drawing.Color.Black;
            this.purchasing1.Location = new System.Drawing.Point(0, 0);
            this.purchasing1.Margin = new System.Windows.Forms.Padding(5);
            this.purchasing1.Name = "purchasing1";
            this.purchasing1.Size = new System.Drawing.Size(1312, 729);
            this.purchasing1.TabIndex = 7;
            this.purchasing1.Load += new System.EventHandler(this.purchasing1_Load);
            // 
            // transaction1
            // 
            this.transaction1.BackColor = System.Drawing.Color.GhostWhite;
            this.transaction1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transaction1.ForeColor = System.Drawing.Color.Black;
            this.transaction1.Location = new System.Drawing.Point(0, 0);
            this.transaction1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transaction1.Name = "transaction1";
            this.transaction1.Size = new System.Drawing.Size(1312, 729);
            this.transaction1.TabIndex = 6;
            // 
            // changeprivacy1
            // 
            this.changeprivacy1.BackColor = System.Drawing.Color.GhostWhite;
            this.changeprivacy1.Location = new System.Drawing.Point(291, 46);
            this.changeprivacy1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeprivacy1.Name = "changeprivacy1";
            this.changeprivacy1.Size = new System.Drawing.Size(1021, 682);
            this.changeprivacy1.TabIndex = 5;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.GhostWhite;
            this.userControl21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userControl21.Location = new System.Drawing.Point(291, 46);
            this.userControl21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl21.Name = "userControl21";
            this.userControl21.prevform = null;
            this.userControl21.Size = new System.Drawing.Size(1021, 682);
            this.userControl21.TabIndex = 4;
            // 
            // inventory1
            // 
            this.inventory1.BackColor = System.Drawing.Color.GhostWhite;
            this.inventory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventory1.ForeColor = System.Drawing.Color.Black;
            this.inventory1.Location = new System.Drawing.Point(0, 0);
            this.inventory1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inventory1.Name = "inventory1";
            this.inventory1.Size = new System.Drawing.Size(1312, 729);
            this.inventory1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1312, 729);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.purchasing1);
            this.Controls.Add(this.transaction1);
            this.Controls.Add(this.changeprivacy1);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.inventory1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel sidepanel;
        private inventory inventory1;
        private UserControl2 userControl21;
        private changeprivacy changeprivacy1;
        private System.Windows.Forms.TextBox type;
        public System.Windows.Forms.TextBox usern;
        private transaction transaction1;
        private System.Windows.Forms.Label loginIn;
        private Purchasing purchasing1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}