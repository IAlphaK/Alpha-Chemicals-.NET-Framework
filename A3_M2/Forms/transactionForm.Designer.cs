namespace A3_M2
{
    partial class transactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transactionForm));
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.selectionBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.insID = new System.Windows.Forms.TextBox();
            this.insDate = new System.Windows.Forms.TextBox();
            this.insProID = new System.Windows.Forms.TextBox();
            this.insType = new System.Windows.Forms.TextBox();
            this.insStatus = new System.Windows.Forms.TextBox();
            this.insAmount = new System.Windows.Forms.TextBox();
            this.insTransID = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
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
            this.mainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topBar.Controls.Add(this.loggedUserInfoPanel);
            this.topBar.Controls.Add(this.imagePanel);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Margin = new System.Windows.Forms.Padding(2);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1200, 69);
            this.topBar.TabIndex = 0;
            // 
            // loggedUserInfoPanel
            // 
            this.loggedUserInfoPanel.Controls.Add(this.logoutPanel);
            this.loggedUserInfoPanel.Controls.Add(this.usernameLabel);
            this.loggedUserInfoPanel.Controls.Add(this.welcomeLabel);
            this.loggedUserInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.loggedUserInfoPanel.Location = new System.Drawing.Point(846, 0);
            this.loggedUserInfoPanel.Margin = new System.Windows.Forms.Padding(2);
            this.loggedUserInfoPanel.Name = "loggedUserInfoPanel";
            this.loggedUserInfoPanel.Size = new System.Drawing.Size(354, 69);
            this.loggedUserInfoPanel.TabIndex = 1;
            // 
            // logoutPanel
            // 
            this.logoutPanel.Controls.Add(this.pictureBox1);
            this.logoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoutPanel.Location = new System.Drawing.Point(290, 0);
            this.logoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.logoutPanel.Name = "logoutPanel";
            this.logoutPanel.Size = new System.Drawing.Size(64, 69);
            this.logoutPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 69);
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
            this.usernameLabel.Location = new System.Drawing.Point(151, 35);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(101, 22);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "NotVisible";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic);
            this.welcomeLabel.ForeColor = System.Drawing.Color.Lime;
            this.welcomeLabel.Location = new System.Drawing.Point(49, 35);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(98, 22);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome";
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.panel2);
            this.imagePanel.Controls.Add(this.companyLogoNav);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagePanel.Location = new System.Drawing.Point(0, 0);
            this.imagePanel.Margin = new System.Windows.Forms.Padding(2);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(104, 69);
            this.imagePanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(104, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 50);
            this.panel2.TabIndex = 1;
            // 
            // companyLogoNav
            // 
            this.companyLogoNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.companyLogoNav.Image = ((System.Drawing.Image)(resources.GetObject("companyLogoNav.Image")));
            this.companyLogoNav.Location = new System.Drawing.Point(4, 3);
            this.companyLogoNav.Margin = new System.Windows.Forms.Padding(10);
            this.companyLogoNav.Name = "companyLogoNav";
            this.companyLogoNav.Padding = new System.Windows.Forms.Padding(10);
            this.companyLogoNav.Size = new System.Drawing.Size(97, 57);
            this.companyLogoNav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.companyLogoNav.TabIndex = 0;
            this.companyLogoNav.TabStop = false;
            this.companyLogoNav.Click += new System.EventHandler(this.companyLogoNav_Click);
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
            this.navPanel.Location = new System.Drawing.Point(0, 69);
            this.navPanel.Margin = new System.Windows.Forms.Padding(2);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(104, 531);
            this.navPanel.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.reportButton);
            this.panel6.Location = new System.Drawing.Point(2, 290);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(98, 67);
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
            this.reportButton.Margin = new System.Windows.Forms.Padding(2);
            this.reportButton.Name = "reportButton";
            this.reportButton.Padding = new System.Windows.Forms.Padding(4);
            this.reportButton.Size = new System.Drawing.Size(98, 67);
            this.reportButton.TabIndex = 6;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.MouseEnter += new System.EventHandler(this.reportButton_MouseEnter);
            this.reportButton.MouseLeave += new System.EventHandler(this.reportButton_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.companyButton);
            this.panel5.Location = new System.Drawing.Point(2, 219);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(98, 67);
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
            this.companyButton.Margin = new System.Windows.Forms.Padding(2);
            this.companyButton.Name = "companyButton";
            this.companyButton.Padding = new System.Windows.Forms.Padding(4);
            this.companyButton.Size = new System.Drawing.Size(98, 67);
            this.companyButton.TabIndex = 5;
            this.companyButton.Text = "Company";
            this.companyButton.UseVisualStyleBackColor = false;
            this.companyButton.Click += new System.EventHandler(this.companyButton_Click);
            this.companyButton.MouseEnter += new System.EventHandler(this.companyButton_MouseEnter);
            this.companyButton.MouseLeave += new System.EventHandler(this.companyButton_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.creditsButton);
            this.panel4.Location = new System.Drawing.Point(2, 146);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(98, 67);
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
            this.creditsButton.Margin = new System.Windows.Forms.Padding(2);
            this.creditsButton.Name = "creditsButton";
            this.creditsButton.Padding = new System.Windows.Forms.Padding(4);
            this.creditsButton.Size = new System.Drawing.Size(98, 67);
            this.creditsButton.TabIndex = 4;
            this.creditsButton.Text = "Credits";
            this.creditsButton.UseVisualStyleBackColor = false;
            this.creditsButton.MouseEnter += new System.EventHandler(this.creditsButton_MouseEnter);
            this.creditsButton.MouseLeave += new System.EventHandler(this.creditsButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.productsButton);
            this.panel1.Location = new System.Drawing.Point(2, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(98, 67);
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
            this.productsButton.Margin = new System.Windows.Forms.Padding(2);
            this.productsButton.Name = "productsButton";
            this.productsButton.Padding = new System.Windows.Forms.Padding(4);
            this.productsButton.Size = new System.Drawing.Size(98, 67);
            this.productsButton.TabIndex = 3;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            this.productsButton.MouseEnter += new System.EventHandler(this.productsButton_MouseEnter);
            this.productsButton.MouseLeave += new System.EventHandler(this.productsButton_MouseLeave);
            // 
            // navPanel1
            // 
            this.navPanel1.Controls.Add(this.farmersButton);
            this.navPanel1.Location = new System.Drawing.Point(2, 2);
            this.navPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.navPanel1.Name = "navPanel1";
            this.navPanel1.Size = new System.Drawing.Size(98, 67);
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
            this.farmersButton.Margin = new System.Windows.Forms.Padding(2);
            this.farmersButton.Name = "farmersButton";
            this.farmersButton.Padding = new System.Windows.Forms.Padding(4);
            this.farmersButton.Size = new System.Drawing.Size(98, 67);
            this.farmersButton.TabIndex = 2;
            this.farmersButton.Text = "Farmers";
            this.farmersButton.UseVisualStyleBackColor = false;
            this.farmersButton.Click += new System.EventHandler(this.farmersButton_Click_1);
            this.farmersButton.MouseEnter += new System.EventHandler(this.farmersButton_MouseEnter);
            this.farmersButton.MouseLeave += new System.EventHandler(this.farmersButton_MouseLeave);
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(104, 69);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.mainPanel.Size = new System.Drawing.Size(1096, 531);
            this.mainPanel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.selectionBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.insID);
            this.panel3.Controls.Add(this.insDate);
            this.panel3.Controls.Add(this.insProID);
            this.panel3.Controls.Add(this.insType);
            this.panel3.Controls.Add(this.insStatus);
            this.panel3.Controls.Add(this.insAmount);
            this.panel3.Controls.Add(this.insTransID);
            this.panel3.Controls.Add(this.InsertButton);
            this.panel3.Location = new System.Drawing.Point(55, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 505);
            this.panel3.TabIndex = 0;
            // 
            // selectionBox
            // 
            this.selectionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectionBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionBox.ForeColor = System.Drawing.Color.Silver;
            this.selectionBox.FormattingEnabled = true;
            this.selectionBox.ItemHeight = 13;
            this.selectionBox.Items.AddRange(new object[] {
            "Company",
            "Farmer"});
            this.selectionBox.Location = new System.Drawing.Point(431, 36);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectionBox.Size = new System.Drawing.Size(135, 21);
            this.selectionBox.TabIndex = 28;
            this.selectionBox.Text = "SELECT";
            this.selectionBox.SelectedIndexChanged += new System.EventHandler(this.filterByBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(558, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Date";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(558, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Amount";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(558, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(139, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(139, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(139, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Transaction ID";
            // 
            // insID
            // 
            this.insID.AcceptsReturn = true;
            this.insID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insID.ForeColor = System.Drawing.Color.Lime;
            this.insID.Location = new System.Drawing.Point(288, 172);
            this.insID.Multiline = true;
            this.insID.Name = "insID";
            this.insID.Size = new System.Drawing.Size(112, 29);
            this.insID.TabIndex = 18;
            this.insID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insDate
            // 
            this.insDate.AcceptsReturn = true;
            this.insDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insDate.ForeColor = System.Drawing.Color.Lime;
            this.insDate.Location = new System.Drawing.Point(703, 245);
            this.insDate.Multiline = true;
            this.insDate.Name = "insDate";
            this.insDate.Size = new System.Drawing.Size(112, 29);
            this.insDate.TabIndex = 17;
            this.insDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insProID
            // 
            this.insProID.AcceptsReturn = true;
            this.insProID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insProID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insProID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insProID.ForeColor = System.Drawing.Color.Lime;
            this.insProID.Location = new System.Drawing.Point(288, 245);
            this.insProID.Multiline = true;
            this.insProID.Name = "insProID";
            this.insProID.Size = new System.Drawing.Size(112, 29);
            this.insProID.TabIndex = 16;
            this.insProID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insType
            // 
            this.insType.AcceptsReturn = true;
            this.insType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insType.ForeColor = System.Drawing.Color.Lime;
            this.insType.Location = new System.Drawing.Point(288, 316);
            this.insType.Multiline = true;
            this.insType.Name = "insType";
            this.insType.Size = new System.Drawing.Size(112, 29);
            this.insType.TabIndex = 15;
            this.insType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insStatus
            // 
            this.insStatus.AcceptsReturn = true;
            this.insStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insStatus.ForeColor = System.Drawing.Color.Lime;
            this.insStatus.Location = new System.Drawing.Point(703, 101);
            this.insStatus.Multiline = true;
            this.insStatus.Name = "insStatus";
            this.insStatus.Size = new System.Drawing.Size(112, 29);
            this.insStatus.TabIndex = 13;
            this.insStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insAmount
            // 
            this.insAmount.AcceptsReturn = true;
            this.insAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insAmount.ForeColor = System.Drawing.Color.Lime;
            this.insAmount.Location = new System.Drawing.Point(703, 172);
            this.insAmount.Multiline = true;
            this.insAmount.Name = "insAmount";
            this.insAmount.Size = new System.Drawing.Size(112, 29);
            this.insAmount.TabIndex = 12;
            this.insAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insTransID
            // 
            this.insTransID.AcceptsReturn = true;
            this.insTransID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insTransID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insTransID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insTransID.ForeColor = System.Drawing.Color.Lime;
            this.insTransID.Location = new System.Drawing.Point(288, 101);
            this.insTransID.Multiline = true;
            this.insTransID.Name = "insTransID";
            this.insTransID.Size = new System.Drawing.Size(112, 29);
            this.insTransID.TabIndex = 11;
            this.insTransID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InsertButton.ForeColor = System.Drawing.Color.Lime;
            this.InsertButton.Location = new System.Drawing.Point(391, 405);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(239, 49);
            this.InsertButton.TabIndex = 10;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = false;
            // 
            // transactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.topBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "transactionForm";
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
            this.mainPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox insTransID;
        private System.Windows.Forms.TextBox insID;
        private System.Windows.Forms.TextBox insDate;
        private System.Windows.Forms.TextBox insProID;
        private System.Windows.Forms.TextBox insType;
        private System.Windows.Forms.TextBox insStatus;
        private System.Windows.Forms.TextBox insAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectionBox;
    }
}
