namespace A3_M2.Forms
{
    partial class companyEditForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.insFarmerID = new System.Windows.Forms.TextBox();
            this.insAddress = new System.Windows.Forms.TextBox();
            this.farmeridlabel = new System.Windows.Forms.Label();
            this.Addresslabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.insBalance = new System.Windows.Forms.TextBox();
            this.insContact = new System.Windows.Forms.TextBox();
            this.insName = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.insFarmerID);
            this.panel1.Controls.Add(this.insAddress);
            this.panel1.Controls.Add(this.farmeridlabel);
            this.panel1.Controls.Add(this.Addresslabel);
            this.panel1.Controls.Add(this.BalanceLabel);
            this.panel1.Controls.Add(this.ContactLabel);
            this.panel1.Controls.Add(this.namelabel);
            this.panel1.Controls.Add(this.insBalance);
            this.panel1.Controls.Add(this.insContact);
            this.panel1.Controls.Add(this.insName);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.ForeColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 349);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseButton.ForeColor = System.Drawing.Color.Lime;
            this.CloseButton.Location = new System.Drawing.Point(298, 281);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(89, 49);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(179, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Company Updation Form";
            // 
            // insFarmerID
            // 
            this.insFarmerID.AcceptsReturn = true;
            this.insFarmerID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insFarmerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insFarmerID.ForeColor = System.Drawing.Color.Lime;
            this.insFarmerID.Location = new System.Drawing.Point(421, 54);
            this.insFarmerID.Name = "insFarmerID";
            this.insFarmerID.ReadOnly = true;
            this.insFarmerID.Size = new System.Drawing.Size(112, 23);
            this.insFarmerID.TabIndex = 4;
            // 
            // insAddress
            // 
            this.insAddress.AcceptsReturn = true;
            this.insAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insAddress.ForeColor = System.Drawing.Color.Lime;
            this.insAddress.Location = new System.Drawing.Point(421, 105);
            this.insAddress.Name = "insAddress";
            this.insAddress.Size = new System.Drawing.Size(112, 23);
            this.insAddress.TabIndex = 5;
            // 
            // farmeridlabel
            // 
            this.farmeridlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.farmeridlabel.AutoSize = true;
            this.farmeridlabel.ForeColor = System.Drawing.Color.White;
            this.farmeridlabel.Location = new System.Drawing.Point(307, 60);
            this.farmeridlabel.Name = "farmeridlabel";
            this.farmeridlabel.Size = new System.Drawing.Size(90, 17);
            this.farmeridlabel.TabIndex = 8;
            this.farmeridlabel.Text = "Company ID";
            this.farmeridlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Addresslabel
            // 
            this.Addresslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.ForeColor = System.Drawing.Color.White;
            this.Addresslabel.Location = new System.Drawing.Point(307, 111);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(57, 17);
            this.Addresslabel.TabIndex = 8;
            this.Addresslabel.Text = "Address";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.ForeColor = System.Drawing.Color.White;
            this.BalanceLabel.Location = new System.Drawing.Point(30, 159);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(60, 17);
            this.BalanceLabel.TabIndex = 6;
            this.BalanceLabel.Text = "Balance";
            // 
            // ContactLabel
            // 
            this.ContactLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.ForeColor = System.Drawing.Color.White;
            this.ContactLabel.Location = new System.Drawing.Point(30, 111);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContactLabel.Size = new System.Drawing.Size(87, 17);
            this.ContactLabel.TabIndex = 5;
            this.ContactLabel.Text = "ContactInfo";
            // 
            // namelabel
            // 
            this.namelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namelabel.AutoSize = true;
            this.namelabel.ForeColor = System.Drawing.Color.White;
            this.namelabel.Location = new System.Drawing.Point(28, 60);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(117, 17);
            this.namelabel.TabIndex = 4;
            this.namelabel.Text = "Company Name";
            // 
            // insBalance
            // 
            this.insBalance.AcceptsReturn = true;
            this.insBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insBalance.ForeColor = System.Drawing.Color.Lime;
            this.insBalance.Location = new System.Drawing.Point(156, 153);
            this.insBalance.Name = "insBalance";
            this.insBalance.Size = new System.Drawing.Size(112, 23);
            this.insBalance.TabIndex = 3;
            // 
            // insContact
            // 
            this.insContact.AcceptsReturn = true;
            this.insContact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insContact.ForeColor = System.Drawing.Color.Lime;
            this.insContact.Location = new System.Drawing.Point(156, 105);
            this.insContact.Name = "insContact";
            this.insContact.Size = new System.Drawing.Size(112, 23);
            this.insContact.TabIndex = 2;
            // 
            // insName
            // 
            this.insName.AcceptsReturn = true;
            this.insName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insName.ForeColor = System.Drawing.Color.Lime;
            this.insName.Location = new System.Drawing.Point(156, 54);
            this.insName.Name = "insName";
            this.insName.Size = new System.Drawing.Size(112, 23);
            this.insName.TabIndex = 1;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditButton.ForeColor = System.Drawing.Color.Lime;
            this.EditButton.Location = new System.Drawing.Point(183, 281);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(89, 49);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // companyEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(584, 373);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "companyEditForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox insName;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox insBalance;
        private System.Windows.Forms.TextBox insContact;
        private System.Windows.Forms.Label Addresslabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox insAddress;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox insFarmerID;
        private System.Windows.Forms.Label farmeridlabel;
    }
}