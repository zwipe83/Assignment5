namespace Assignment5.Forms
{
    partial class FormMain
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
            lblId = new Label();
            lblName = new Label();
            lblOfficePhone = new Label();
            lblOfficeEmail = new Label();
            lstContacts = new ListBox();
            grpContactDetails = new GroupBox();
            lblContactPhoneNumbers = new Label();
            lblContactEmails = new Label();
            lblContactAddress = new Label();
            btnAddContact = new Button();
            btnEditContact = new Button();
            btnDeleteContact = new Button();
            grpContactDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(44, 41);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(186, 41);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name (Last, First)";
            // 
            // lblOfficePhone
            // 
            lblOfficePhone.AutoSize = true;
            lblOfficePhone.Location = new Point(369, 41);
            lblOfficePhone.Name = "lblOfficePhone";
            lblOfficePhone.Size = new Size(76, 15);
            lblOfficePhone.TabIndex = 0;
            lblOfficePhone.Text = "Office phone";
            // 
            // lblOfficeEmail
            // 
            lblOfficeEmail.AutoSize = true;
            lblOfficeEmail.Location = new Point(598, 41);
            lblOfficeEmail.Name = "lblOfficeEmail";
            lblOfficeEmail.Size = new Size(76, 15);
            lblOfficeEmail.TabIndex = 0;
            lblOfficeEmail.Text = "Office E-mail";
            // 
            // lstContacts
            // 
            lstContacts.FormattingEnabled = true;
            lstContacts.ItemHeight = 15;
            lstContacts.Location = new Point(12, 71);
            lstContacts.Name = "lstContacts";
            lstContacts.Size = new Size(762, 394);
            lstContacts.TabIndex = 1;
            // 
            // grpContactDetails
            // 
            grpContactDetails.Controls.Add(lblContactPhoneNumbers);
            grpContactDetails.Controls.Add(lblContactEmails);
            grpContactDetails.Controls.Add(lblContactAddress);
            grpContactDetails.Location = new Point(787, 41);
            grpContactDetails.Name = "grpContactDetails";
            grpContactDetails.Size = new Size(401, 424);
            grpContactDetails.TabIndex = 2;
            grpContactDetails.TabStop = false;
            grpContactDetails.Text = "Contact details";
            // 
            // lblContactPhoneNumbers
            // 
            lblContactPhoneNumbers.AutoSize = true;
            lblContactPhoneNumbers.Location = new Point(6, 233);
            lblContactPhoneNumbers.Name = "lblContactPhoneNumbers";
            lblContactPhoneNumbers.Size = new Size(152, 15);
            lblContactPhoneNumbers.TabIndex = 0;
            lblContactPhoneNumbers.Text = "<Contact phone numbers>";
            // 
            // lblContactEmails
            // 
            lblContactEmails.AutoSize = true;
            lblContactEmails.Location = new Point(6, 132);
            lblContactEmails.Name = "lblContactEmails";
            lblContactEmails.Size = new Size(102, 15);
            lblContactEmails.TabIndex = 0;
            lblContactEmails.Text = "<Contact emails>";
            // 
            // lblContactAddress
            // 
            lblContactAddress.AutoSize = true;
            lblContactAddress.Location = new Point(6, 19);
            lblContactAddress.Name = "lblContactAddress";
            lblContactAddress.Size = new Size(108, 15);
            lblContactAddress.TabIndex = 0;
            lblContactAddress.Text = "<Contact address>";
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(44, 484);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(164, 43);
            btnAddContact.TabIndex = 3;
            btnAddContact.Text = "Add";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // btnEditContact
            // 
            btnEditContact.Location = new Point(238, 484);
            btnEditContact.Name = "btnEditContact";
            btnEditContact.Size = new Size(164, 43);
            btnEditContact.TabIndex = 3;
            btnEditContact.Text = "Edit";
            btnEditContact.UseVisualStyleBackColor = true;
            btnEditContact.Click += btnEditContact_Click;
            // 
            // btnDeleteContact
            // 
            btnDeleteContact.Location = new Point(435, 484);
            btnDeleteContact.Name = "btnDeleteContact";
            btnDeleteContact.Size = new Size(164, 43);
            btnDeleteContact.TabIndex = 3;
            btnDeleteContact.Text = "Delete";
            btnDeleteContact.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 554);
            Controls.Add(btnDeleteContact);
            Controls.Add(btnEditContact);
            Controls.Add(btnAddContact);
            Controls.Add(grpContactDetails);
            Controls.Add(lstContacts);
            Controls.Add(lblOfficeEmail);
            Controls.Add(lblOfficePhone);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Name = "FormMain";
            Text = "CRM by Samuel Jeffman";
            grpContactDetails.ResumeLayout(false);
            grpContactDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblOfficePhone;
        private Label lblOfficeEmail;
        private ListBox lstContacts;
        private GroupBox grpContactDetails;
        private Button btnAddContact;
        private Button btnEditContact;
        private Button btnDeleteContact;
        private Label lblContactAddress;
        private Label lblContactEmails;
        private Label lblContactPhoneNumbers;
    }
}