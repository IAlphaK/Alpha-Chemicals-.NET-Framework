﻿namespace A3_M2.Forms
{
    partial class farmersInsertForm
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
            this.InsertButton = new System.Windows.Forms.Button();
            this.insFarmerID = new System.Windows.Forms.TextBox();
            this.insAddress = new System.Windows.Forms.TextBox();
            this.farmeridlabel = new System.Windows.Forms.Label();
            this.Addresslabel = new System.Windows.Forms.Label();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.insBatch = new System.Windows.Forms.TextBox();
            this.insContact = new System.Windows.Forms.TextBox();
            this.insName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.insFarmerID);
            this.panel1.Controls.Add(this.insAddress);
            this.panel1.Controls.Add(this.farmeridlabel);
            this.panel1.Controls.Add(this.Addresslabel);
            this.panel1.Controls.Add(this.BalanceLabel);
            this.panel1.Controls.Add(this.ContactLabel);
            this.panel1.Controls.Add(this.namelabel);
            this.panel1.Controls.Add(this.insBatch);
            this.panel1.Controls.Add(this.insContact);
            this.panel1.Controls.Add(this.insName);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.InsertButton);
            this.panel1.ForeColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 349);
            this.panel1.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseButton.ForeColor = System.Drawing.Color.Lime;
            this.CloseButton.Location = new System.Drawing.Point(298, 281);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(89, 49);
            this.CloseButton.TabIndex = 16;
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
            this.label4.Size = new System.Drawing.Size(263, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Farmer Insertion Form";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InsertButton.ForeColor = System.Drawing.Color.Lime;
            this.InsertButton.Location = new System.Drawing.Point(183, 281);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(89, 49);
            this.InsertButton.TabIndex = 0;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // insFarmerID
            // 
            this.insFarmerID.AcceptsReturn = true;
            this.insFarmerID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insFarmerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insFarmerID.ForeColor = System.Drawing.Color.Lime;
            this.insFarmerID.Location = new System.Drawing.Point(418, 77);
            this.insFarmerID.Name = "insFarmerID";
            this.insFarmerID.ReadOnly = true;
            this.insFarmerID.Size = new System.Drawing.Size(112, 27);
            this.insFarmerID.TabIndex = 25;
            // 
            // insAddress
            // 
            this.insAddress.AcceptsReturn = true;
            this.insAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insAddress.ForeColor = System.Drawing.Color.Lime;
            this.insAddress.Location = new System.Drawing.Point(418, 128);
            this.insAddress.Name = "insAddress";
            this.insAddress.Size = new System.Drawing.Size(112, 27);
            this.insAddress.TabIndex = 26;
            // 
            // farmeridlabel
            // 
            this.farmeridlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.farmeridlabel.AutoSize = true;
            this.farmeridlabel.ForeColor = System.Drawing.Color.White;
            this.farmeridlabel.Location = new System.Drawing.Point(304, 83);
            this.farmeridlabel.Name = "farmeridlabel";
            this.farmeridlabel.Size = new System.Drawing.Size(89, 21);
            this.farmeridlabel.TabIndex = 23;
            this.farmeridlabel.Text = "Farmer ID";
            // 
            // Addresslabel
            // 
            this.Addresslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.ForeColor = System.Drawing.Color.White;
            this.Addresslabel.Location = new System.Drawing.Point(304, 134);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(77, 21);
            this.Addresslabel.TabIndex = 24;
            this.Addresslabel.Text = "Address";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.ForeColor = System.Drawing.Color.White;
            this.BalanceLabel.Location = new System.Drawing.Point(27, 182);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(79, 21);
            this.BalanceLabel.TabIndex = 22;
            this.BalanceLabel.Text = "Balance";
            // 
            // ContactLabel
            // 
            this.ContactLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.ForeColor = System.Drawing.Color.White;
            this.ContactLabel.Location = new System.Drawing.Point(27, 134);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContactLabel.Size = new System.Drawing.Size(113, 21);
            this.ContactLabel.TabIndex = 21;
            this.ContactLabel.Text = "ContactInfo";
            // 
            // namelabel
            // 
            this.namelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namelabel.AutoSize = true;
            this.namelabel.ForeColor = System.Drawing.Color.White;
            this.namelabel.Location = new System.Drawing.Point(25, 83);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(122, 21);
            this.namelabel.TabIndex = 20;
            this.namelabel.Text = "Farmer Name";
            // 
            // insBatch
            // 
            this.insBatch.AcceptsReturn = true;
            this.insBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insBatch.ForeColor = System.Drawing.Color.Lime;
            this.insBatch.Location = new System.Drawing.Point(153, 176);
            this.insBatch.Name = "insBatch";
            this.insBatch.Size = new System.Drawing.Size(112, 27);
            this.insBatch.TabIndex = 19;
            // 
            // insContact
            // 
            this.insContact.AcceptsReturn = true;
            this.insContact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insContact.ForeColor = System.Drawing.Color.Lime;
            this.insContact.Location = new System.Drawing.Point(153, 128);
            this.insContact.Name = "insContact";
            this.insContact.Size = new System.Drawing.Size(112, 27);
            this.insContact.TabIndex = 18;
            // 
            // insName
            // 
            this.insName.AcceptsReturn = true;
            this.insName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insName.ForeColor = System.Drawing.Color.Lime;
            this.insName.Location = new System.Drawing.Point(153, 77);
            this.insName.Name = "insName";
            this.insName.Size = new System.Drawing.Size(112, 27);
            this.insName.TabIndex = 17;
            // 
            // farmersInsertForm
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
            this.Name = "farmersInsertForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox insFarmerID;
        private System.Windows.Forms.TextBox insAddress;
        private System.Windows.Forms.Label farmeridlabel;
        private System.Windows.Forms.Label Addresslabel;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox insBatch;
        private System.Windows.Forms.TextBox insContact;
        private System.Windows.Forms.TextBox insName;
    }
}