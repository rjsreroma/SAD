namespace WindowsFormsApplication4
{
    partial class In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(In));
            this.cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.quan = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel.Location = new System.Drawing.Point(141, 84);
            this.cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(128, 54);
            this.cancel.TabIndex = 96;
            this.cancel.Text = "Cancel";
            this.cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Add
            // 
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(11, 84);
            this.Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(134, 54);
            this.Add.TabIndex = 95;
            this.Add.Text = " Stock in";
            this.Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(22, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 94;
            this.label7.Text = "Quantity:";
            // 
            // quan
            // 
            this.quan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quan.Location = new System.Drawing.Point(141, 20);
            this.quan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quan.Name = "quan";
            this.quan.Size = new System.Drawing.Size(111, 28);
            this.quan.TabIndex = 93;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(165, 54);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(54, 20);
            this.id.TabIndex = 97;
            this.id.Visible = false;
            // 
            // In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(278, 149);
            this.Controls.Add(this.id);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "In";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.In_FormClosing);
            this.Load += new System.EventHandler(this.In_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox quan;
        public System.Windows.Forms.TextBox id;
    }
}
