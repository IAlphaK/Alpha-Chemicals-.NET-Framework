﻿namespace A3_M2
{
    partial class templateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(templateForm));
            this.topBar = new System.Windows.Forms.Panel();
            this.loggedUserInfoPanel = new System.Windows.Forms.Panel();
            this.logoutPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.companyLogoNav = new System.Windows.Forms.PictureBox();
            this.navPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.reportButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.companyButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.creditsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productsButton = new System.Windows.Forms.Button();
            this.navPanel1 = new System.Windows.Forms.Panel();
            this.farmersButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.topBar.SuspendLayout();
            this.loggedUserInfoPanel.SuspendLayout();
            this.logoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoNav)).BeginInit();
            this.navPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.navPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topBar.Controls.Add(this.loggedUserInfoPanel);
            this.topBar.Controls.Add(this.imagePanel);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1600, 85);
            this.topBar.TabIndex = 0;
            // 
            // loggedUserInfoPanel
            // 
            this.loggedUserInfoPanel.Controls.Add(this.logoutPanel);
            this.loggedUserInfoPanel.Controls.Add(this.usernameLabel);
            this.loggedUserInfoPanel.Controls.Add(this.welcomeLabel);
            this.loggedUserInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.loggedUserInfoPanel.Location = new System.Drawing.Point(1128, 0);
            this.loggedUserInfoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loggedUserInfoPanel.Name = "loggedUserInfoPanel";
            this.loggedUserInfoPanel.Size = new System.Drawing.Size(472, 85);
            this.loggedUserInfoPanel.TabIndex = 1;
            // 
            // logoutPanel
            // 
            this.logoutPanel.Controls.Add(this.pictureBox1);
            this.logoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoutPanel.Location = new System.Drawing.Point(387, 0);
            this.logoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutPanel.Name = "logoutPanel";
            this.logoutPanel.Size = new System.Drawing.Size(85, 85);
            this.logoutPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.usernameLabel.Location = new System.Drawing.Point(201, 43);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(131, 28);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "NotVisible";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.welcomeLabel.ForeColor = System.Drawing.Color.Lime;
            this.welcomeLabel.Location = new System.Drawing.Point(65, 43);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(129, 28);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome";
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.panel2);
            this.imagePanel.Controls.Add(this.companyLogoNav);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(139, 85);
            this.imagePanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(139, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 62);
            this.panel2.TabIndex = 1;
            // 
            // companyLogoNav
            // 
            this.companyLogoNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.companyLogoNav.Image = ((System.Drawing.Image)(resources.GetObject("companyLogoNav.Image")));
            this.companyLogoNav.Location = new System.Drawing.Point(5, 4);
            this.companyLogoNav.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.companyLogoNav.Name = "companyLogoNav";
            this.companyLogoNav.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.companyLogoNav.Size = new System.Drawing.Size(129, 70);
            this.companyLogoNav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.companyLogoNav.TabIndex = 0;
            this.companyLogoNav.TabStop = false;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.navPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navPanel.Controls.Add(this.panel6);
            this.navPanel.Controls.Add(this.panel5);
            this.navPanel.Controls.Add(this.panel4);
            this.navPanel.Controls.Add(this.panel1);
            this.navPanel.Controls.Add(this.navPanel1);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(0, 85);
            this.navPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(138, 653);
            this.navPanel.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.reportButton);
            this.panel6.Location = new System.Drawing.Point(3, 357);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(131, 82);
            this.panel6.TabIndex = 6;
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reportButton.FlatAppearance.BorderSize = 0;
            this.reportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.reportButton.ForeColor = System.Drawing.Color.Lime;
            this.reportButton.Location = new System.Drawing.Point(0, 0);
            this.reportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportButton.Name = "reportButton";
            this.reportButton.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.reportButton.Size = new System.Drawing.Size(131, 82);
            this.reportButton.TabIndex = 6;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.MouseEnter += new System.EventHandler(this.reportButton_MouseEnter);
            this.reportButton.MouseLeave += new System.EventHandler(this.reportButton_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.companyButton);
            this.panel5.Location = new System.Drawing.Point(3, 270);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(131, 82);
            this.panel5.TabIndex = 5;
            // 
            // companyButton
            // 
            this.companyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.companyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.companyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.companyButton.FlatAppearance.BorderSize = 0;
            this.companyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.companyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.companyButton.Font = new System.Drawing.Font("Segoe UI", 11.2F, System.Drawing.FontStyle.Italic);
            this.companyButton.ForeColor = System.Drawing.Color.Lime;
            this.companyButton.Location = new System.Drawing.Point(0, 0);
            this.companyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.companyButton.Name = "companyButton";
            this.companyButton.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.companyButton.Size = new System.Drawing.Size(131, 82);
            this.companyButton.TabIndex = 5;
            this.companyButton.Text = "Company";
            this.companyButton.UseVisualStyleBackColor = false;
            this.companyButton.MouseEnter += new System.EventHandler(this.companyButton_MouseEnter);
            this.companyButton.MouseLeave += new System.EventHandler(this.companyButton_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.creditsButton);
            this.panel4.Location = new System.Drawing.Point(3, 180);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(131, 82);
            this.panel4.TabIndex = 4;
            // 
            // creditsButton
            // 
            this.creditsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.creditsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.creditsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creditsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.creditsButton.FlatAppearance.BorderSize = 0;
            this.creditsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.creditsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.creditsButton.ForeColor = System.Drawing.Color.Lime;
            this.creditsButton.Location = new System.Drawing.Point(0, 0);
            this.creditsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.creditsButton.Name = "creditsButton";
            this.creditsButton.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.creditsButton.Size = new System.Drawing.Size(131, 82);
            this.creditsButton.TabIndex = 4;
            this.creditsButton.Text = "Credits";
            this.creditsButton.UseVisualStyleBackColor = false;
            this.creditsButton.MouseEnter += new System.EventHandler(this.creditsButton_MouseEnter);
            this.creditsButton.MouseLeave += new System.EventHandler(this.creditsButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.productsButton);
            this.panel1.Location = new System.Drawing.Point(3, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 82);
            this.panel1.TabIndex = 3;
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.productsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.productsButton.FlatAppearance.BorderSize = 0;
            this.productsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.productsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.productsButton.ForeColor = System.Drawing.Color.Lime;
            this.productsButton.Location = new System.Drawing.Point(0, 0);
            this.productsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsButton.Name = "productsButton";
            this.productsButton.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.productsButton.Size = new System.Drawing.Size(131, 82);
            this.productsButton.TabIndex = 3;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.MouseEnter += new System.EventHandler(this.productsButton_MouseEnter);
            this.productsButton.MouseLeave += new System.EventHandler(this.productsButton_MouseLeave);
            // 
            // navPanel1
            // 
            this.navPanel1.Controls.Add(this.farmersButton);
            this.navPanel1.Location = new System.Drawing.Point(3, 2);
            this.navPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navPanel1.Name = "navPanel1";
            this.navPanel1.Size = new System.Drawing.Size(131, 82);
            this.navPanel1.TabIndex = 2;
            // 
            // farmersButton
            // 
            this.farmersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.farmersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.farmersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.farmersButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.farmersButton.FlatAppearance.BorderSize = 0;
            this.farmersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.farmersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.farmersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.farmersButton.ForeColor = System.Drawing.Color.Lime;
            this.farmersButton.Location = new System.Drawing.Point(0, 0);
            this.farmersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.farmersButton.Name = "farmersButton";
            this.farmersButton.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.farmersButton.Size = new System.Drawing.Size(131, 82);
            this.farmersButton.TabIndex = 2;
            this.farmersButton.Text = "Farmers";
            this.farmersButton.UseVisualStyleBackColor = false;
            this.farmersButton.Click += new System.EventHandler(this.farmersButton_Click);
            this.farmersButton.MouseEnter += new System.EventHandler(this.farmersButton_MouseEnter);
            this.farmersButton.MouseLeave += new System.EventHandler(this.farmersButton_MouseLeave);
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(138, 85);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.mainPanel.Size = new System.Drawing.Size(1462, 653);
            this.mainPanel.TabIndex = 2;
            // 
            // templateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1600, 738);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "templateForm";
            this.topBar.ResumeLayout(false);
            this.loggedUserInfoPanel.ResumeLayout(false);
            this.loggedUserInfoPanel.PerformLayout();
            this.logoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoNav)).EndInit();
            this.navPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.navPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Panel loggedUserInfoPanel;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.PictureBox companyLogoNav;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel navPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button farmersButton;
        private System.Windows.Forms.Panel logoutPanel;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button companyButton;
        private System.Windows.Forms.Button creditsButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mainPanel;
    }
}
