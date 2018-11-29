namespace SE_Final2
{
    partial class adminWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.companyLink1 = new System.Windows.Forms.Button();
            this.globalLink1 = new System.Windows.Forms.Button();
            this.globalLink2 = new System.Windows.Forms.Button();
            this.adminLink1 = new System.Windows.Forms.Button();
            this.adminLink2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(640, 395);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(124, 31);
            this.logout.TabIndex = 6;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // companyLink1
            // 
            this.companyLink1.Location = new System.Drawing.Point(174, 139);
            this.companyLink1.Name = "companyLink1";
            this.companyLink1.Size = new System.Drawing.Size(203, 39);
            this.companyLink1.TabIndex = 7;
            this.companyLink1.Text = "Company Link";
            this.companyLink1.UseVisualStyleBackColor = true;
            this.companyLink1.Click += new System.EventHandler(this.companyLink1_Click);
            // 
            // globalLink1
            // 
            this.globalLink1.Location = new System.Drawing.Point(174, 183);
            this.globalLink1.Name = "globalLink1";
            this.globalLink1.Size = new System.Drawing.Size(204, 40);
            this.globalLink1.TabIndex = 8;
            this.globalLink1.Text = "Global Link";
            this.globalLink1.UseVisualStyleBackColor = true;
            this.globalLink1.Click += new System.EventHandler(this.globalLink1_Click);
            // 
            // globalLink2
            // 
            this.globalLink2.Location = new System.Drawing.Point(174, 229);
            this.globalLink2.Name = "globalLink2";
            this.globalLink2.Size = new System.Drawing.Size(204, 38);
            this.globalLink2.TabIndex = 9;
            this.globalLink2.Text = "Global Link 2";
            this.globalLink2.UseVisualStyleBackColor = true;
            this.globalLink2.Click += new System.EventHandler(this.globalLink2_Click);
            // 
            // adminLink1
            // 
            this.adminLink1.Location = new System.Drawing.Point(471, 139);
            this.adminLink1.Name = "adminLink1";
            this.adminLink1.Size = new System.Drawing.Size(203, 39);
            this.adminLink1.TabIndex = 10;
            this.adminLink1.Text = "Admin Link 1";
            this.adminLink1.UseVisualStyleBackColor = true;
            this.adminLink1.Click += new System.EventHandler(this.adminLink1_Click);
            // 
            // adminLink2
            // 
            this.adminLink2.Location = new System.Drawing.Point(471, 184);
            this.adminLink2.Name = "adminLink2";
            this.adminLink2.Size = new System.Drawing.Size(203, 39);
            this.adminLink2.TabIndex = 11;
            this.adminLink2.Text = "Admin Link 2";
            this.adminLink2.UseVisualStyleBackColor = true;
            this.adminLink2.Click += new System.EventHandler(this.adminLink2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminLink2);
            this.Controls.Add(this.adminLink1);
            this.Controls.Add(this.globalLink2);
            this.Controls.Add(this.globalLink1);
            this.Controls.Add(this.companyLink1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label1);
            this.Name = "adminWindow";
            this.Text = "adminWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button companyLink1;
        private System.Windows.Forms.Button globalLink1;
        private System.Windows.Forms.Button globalLink2;
        private System.Windows.Forms.Button adminLink1;
        private System.Windows.Forms.Button adminLink2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}