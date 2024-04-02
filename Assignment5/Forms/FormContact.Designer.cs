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
            grpEmailPhone = new GroupBox();
            grpAddress = new GroupBox();
            SuspendLayout();
            // 
            // grpName
            // 
            grpName.Location = new Point(12, 22);
            grpName.Name = "grpName";
            grpName.Size = new Size(578, 124);
            grpName.TabIndex = 0;
            grpName.TabStop = false;
            grpName.Text = "Name";
            // 
            // grpEmailPhone
            // 
            grpEmailPhone.Location = new Point(12, 161);
            grpEmailPhone.Name = "grpEmailPhone";
            grpEmailPhone.Size = new Size(578, 209);
            grpEmailPhone.TabIndex = 0;
            grpEmailPhone.TabStop = false;
            grpEmailPhone.Text = "Email and phone";
            // 
            // grpAddress
            // 
            grpAddress.Location = new Point(12, 376);
            grpAddress.Name = "grpAddress";
            grpAddress.Size = new Size(578, 209);
            grpAddress.TabIndex = 0;
            grpAddress.TabStop = false;
            grpAddress.Text = "Address";
            // 
            // FormContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 722);
            Controls.Add(grpAddress);
            Controls.Add(grpEmailPhone);
            Controls.Add(grpName);
            Name = "FormContact";
            Text = "FormContact";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpName;
        private GroupBox grpEmailPhone;
        private GroupBox grpAddress;
    }
}