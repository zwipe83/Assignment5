namespace Assignment5.Forms
{
    partial class FormContact
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
            grpName = new GroupBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            grpEmailPhone = new GroupBox();
            txtPrivateEmail = new TextBox();
            txtBusinessEmail = new TextBox();
            txtMobilePhone = new TextBox();
            txtHomePhone = new TextBox();
            lblPrivateEmail = new Label();
            lblBusinessEmail = new Label();
            lblCellPhone = new Label();
            lblHomePhone = new Label();
            grpAddress = new GroupBox();
            cmbCountry = new ComboBox();
            txtZipCode = new TextBox();
            txtCity = new TextBox();
            txtStreet = new TextBox();
            lblCountry = new Label();
            lblZipCode = new Label();
            lblCity = new Label();
            lblStreet = new Label();
            btnOkAdd = new Button();
            btnCancelAdd = new Button();
            grpName.SuspendLayout();
            grpEmailPhone.SuspendLayout();
            grpAddress.SuspendLayout();
            SuspendLayout();
            // 
            // grpName
            // 
            grpName.Controls.Add(txtLastName);
            grpName.Controls.Add(txtFirstName);
            grpName.Controls.Add(lblLastName);
            grpName.Controls.Add(lblFirstName);
            grpName.Location = new Point(12, 22);
            grpName.Name = "grpName";
            grpName.Size = new Size(578, 124);
            grpName.TabIndex = 100;
            grpName.TabStop = false;
            grpName.Text = "Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(172, 71);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(400, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(172, 31);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(400, 23);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(103, 74);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name";
            lblLastName.TextAlign = ContentAlignment.TopRight;
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFirstName.AutoSize = true;
            lblFirstName.ImageAlign = ContentAlignment.MiddleRight;
            lblFirstName.Location = new Point(102, 34);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            lblFirstName.TextAlign = ContentAlignment.TopRight;
            // 
            // grpEmailPhone
            // 
            grpEmailPhone.Controls.Add(txtPrivateEmail);
            grpEmailPhone.Controls.Add(txtBusinessEmail);
            grpEmailPhone.Controls.Add(txtMobilePhone);
            grpEmailPhone.Controls.Add(txtHomePhone);
            grpEmailPhone.Controls.Add(lblPrivateEmail);
            grpEmailPhone.Controls.Add(lblBusinessEmail);
            grpEmailPhone.Controls.Add(lblCellPhone);
            grpEmailPhone.Controls.Add(lblHomePhone);
            grpEmailPhone.Location = new Point(12, 161);
            grpEmailPhone.Name = "grpEmailPhone";
            grpEmailPhone.Size = new Size(578, 209);
            grpEmailPhone.TabIndex = 200;
            grpEmailPhone.TabStop = false;
            grpEmailPhone.Text = "Email and phone";
            // 
            // txtPrivateEmail
            // 
            txtPrivateEmail.Location = new Point(172, 168);
            txtPrivateEmail.Name = "txtPrivateEmail";
            txtPrivateEmail.Size = new Size(400, 23);
            txtPrivateEmail.TabIndex = 6;
            // 
            // txtBusinessEmail
            // 
            txtBusinessEmail.Location = new Point(172, 131);
            txtBusinessEmail.Name = "txtBusinessEmail";
            txtBusinessEmail.Size = new Size(400, 23);
            txtBusinessEmail.TabIndex = 5;
            // 
            // txtMobilePhone
            // 
            txtMobilePhone.Location = new Point(172, 89);
            txtMobilePhone.Name = "txtMobilePhone";
            txtMobilePhone.Size = new Size(400, 23);
            txtMobilePhone.TabIndex = 4;
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(172, 52);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(400, 23);
            txtHomePhone.TabIndex = 3;
            // 
            // lblPrivateEmail
            // 
            lblPrivateEmail.AutoSize = true;
            lblPrivateEmail.Location = new Point(91, 171);
            lblPrivateEmail.Name = "lblPrivateEmail";
            lblPrivateEmail.Size = new Size(75, 15);
            lblPrivateEmail.TabIndex = 0;
            lblPrivateEmail.Text = "Private email";
            lblPrivateEmail.TextAlign = ContentAlignment.TopRight;
            // 
            // lblBusinessEmail
            // 
            lblBusinessEmail.AutoSize = true;
            lblBusinessEmail.Location = new Point(82, 134);
            lblBusinessEmail.Name = "lblBusinessEmail";
            lblBusinessEmail.Size = new Size(84, 15);
            lblBusinessEmail.TabIndex = 0;
            lblBusinessEmail.Text = "Business email";
            lblBusinessEmail.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCellPhone
            // 
            lblCellPhone.AutoSize = true;
            lblCellPhone.Location = new Point(85, 92);
            lblCellPhone.Name = "lblCellPhone";
            lblCellPhone.Size = new Size(81, 15);
            lblCellPhone.TabIndex = 0;
            lblCellPhone.Text = "Mobile phone";
            lblCellPhone.TextAlign = ContentAlignment.TopRight;
            // 
            // lblHomePhone
            // 
            lblHomePhone.AutoSize = true;
            lblHomePhone.Location = new Point(89, 55);
            lblHomePhone.Name = "lblHomePhone";
            lblHomePhone.Size = new Size(77, 15);
            lblHomePhone.TabIndex = 0;
            lblHomePhone.Text = "Home phone";
            lblHomePhone.TextAlign = ContentAlignment.TopRight;
            // 
            // grpAddress
            // 
            grpAddress.Controls.Add(cmbCountry);
            grpAddress.Controls.Add(txtZipCode);
            grpAddress.Controls.Add(txtCity);
            grpAddress.Controls.Add(txtStreet);
            grpAddress.Controls.Add(lblCountry);
            grpAddress.Controls.Add(lblZipCode);
            grpAddress.Controls.Add(lblCity);
            grpAddress.Controls.Add(lblStreet);
            grpAddress.Location = new Point(12, 376);
            grpAddress.Name = "grpAddress";
            grpAddress.Size = new Size(578, 209);
            grpAddress.TabIndex = 300;
            grpAddress.TabStop = false;
            grpAddress.Text = "Address";
            // 
            // cmbCountry
            // 
            cmbCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCountry.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(172, 124);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(400, 23);
            cmbCountry.TabIndex = 10;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(172, 75);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(156, 23);
            txtZipCode.TabIndex = 8;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(382, 72);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(190, 23);
            txtCity.TabIndex = 9;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(172, 43);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(400, 23);
            txtStreet.TabIndex = 7;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(116, 127);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(50, 15);
            lblCountry.TabIndex = 0;
            lblCountry.Text = "Country";
            lblCountry.TextAlign = ContentAlignment.TopRight;
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new Point(113, 78);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(53, 15);
            lblZipCode.TabIndex = 0;
            lblZipCode.Text = "Zip code";
            lblZipCode.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(348, 78);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 0;
            lblCity.Text = "City";
            lblCity.TextAlign = ContentAlignment.TopRight;
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(129, 46);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(37, 15);
            lblStreet.TabIndex = 0;
            lblStreet.Text = "Street";
            lblStreet.TextAlign = ContentAlignment.TopRight;
            // 
            // btnOkAdd
            // 
            btnOkAdd.DialogResult = DialogResult.OK;
            btnOkAdd.Location = new Point(140, 637);
            btnOkAdd.Name = "btnOkAdd";
            btnOkAdd.Size = new Size(101, 47);
            btnOkAdd.TabIndex = 12;
            btnOkAdd.Text = "OK";
            btnOkAdd.UseVisualStyleBackColor = true;
            btnOkAdd.Click += btnOkAdd_Click;
            // 
            // btnCancelAdd
            // 
            btnCancelAdd.DialogResult = DialogResult.Cancel;
            btnCancelAdd.Location = new Point(360, 637);
            btnCancelAdd.Name = "btnCancelAdd";
            btnCancelAdd.Size = new Size(101, 47);
            btnCancelAdd.TabIndex = 11;
            btnCancelAdd.Text = "Cancel";
            btnCancelAdd.UseVisualStyleBackColor = true;
            btnCancelAdd.Click += btnCancelAdd_Click;
            // 
            // FormContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 722);
            Controls.Add(btnCancelAdd);
            Controls.Add(btnOkAdd);
            Controls.Add(grpAddress);
            Controls.Add(grpEmailPhone);
            Controls.Add(grpName);
            Name = "FormContact";
            Text = "Customer";
            Shown += FormContact_Shown;
            grpName.ResumeLayout(false);
            grpName.PerformLayout();
            grpEmailPhone.ResumeLayout(false);
            grpEmailPhone.PerformLayout();
            grpAddress.ResumeLayout(false);
            grpAddress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpName;
        private GroupBox grpEmailPhone;
        private GroupBox grpAddress;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtPrivateEmail;
        private TextBox txtBusinessEmail;
        private TextBox txtMobilePhone;
        private TextBox txtHomePhone;
        private Label lblPrivateEmail;
        private Label lblBusinessEmail;
        private Label lblCellPhone;
        private Label lblHomePhone;
        private ComboBox cmbCountry;
        private TextBox txtZipCode;
        private TextBox txtCity;
        private TextBox txtStreet;
        private Label lblCountry;
        private Label lblZipCode;
        private Label lblCity;
        private Label lblStreet;
        private Button btnOkAdd;
        private Button btnCancelAdd;
    }
}