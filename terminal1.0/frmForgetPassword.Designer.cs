namespace terminal1._0
{
    partial class frmForgetPassword
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnDisplyNewPassword = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.cmbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxSecurityQuestion = new System.Windows.Forms.GroupBox();
            this.btnCheckUsername = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbxSMSEmail = new System.Windows.Forms.GroupBox();
            this.rdbSecurityQuestion = new System.Windows.Forms.RadioButton();
            this.rdbEmail = new System.Windows.Forms.RadioButton();
            this.rdbSMS = new System.Windows.Forms.RadioButton();
            this.gbxTypeOfRecovery = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbxSecurityQuestion.SuspendLayout();
            this.gbxSMSEmail.SuspendLayout();
            this.gbxTypeOfRecovery.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "new password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(120, 151);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(278, 23);
            this.txtNewPassword.TabIndex = 6;
            // 
            // btnDisplyNewPassword
            // 
            this.btnDisplyNewPassword.Location = new System.Drawing.Point(120, 115);
            this.btnDisplyNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDisplyNewPassword.Name = "btnDisplyNewPassword";
            this.btnDisplyNewPassword.Size = new System.Drawing.Size(278, 28);
            this.btnDisplyNewPassword.TabIndex = 5;
            this.btnDisplyNewPassword.Text = "Disply new password";
            this.btnDisplyNewPassword.UseVisualStyleBackColor = true;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(120, 84);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(278, 23);
            this.txtAnswer.TabIndex = 4;
            // 
            // cmbSecurityQuestion
            // 
            this.cmbSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSecurityQuestion.FormattingEnabled = true;
            this.cmbSecurityQuestion.Items.AddRange(new object[] {
            "What is the first book you read?",
            "What is your favorite song?",
            "What is your favorite air?",
            "What is your nickname among your friends?",
            "What is your favorite movie name?",
            "What is your favorite sport?",
            "What was your favorite teacher?"});
            this.cmbSecurityQuestion.Location = new System.Drawing.Point(120, 52);
            this.cmbSecurityQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSecurityQuestion.Name = "cmbSecurityQuestion";
            this.cmbSecurityQuestion.Size = new System.Drawing.Size(278, 24);
            this.cmbSecurityQuestion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Security Question";
            // 
            // gbxSecurityQuestion
            // 
            this.gbxSecurityQuestion.Controls.Add(this.btnCheckUsername);
            this.gbxSecurityQuestion.Controls.Add(this.label4);
            this.gbxSecurityQuestion.Controls.Add(this.txtNewPassword);
            this.gbxSecurityQuestion.Controls.Add(this.btnDisplyNewPassword);
            this.gbxSecurityQuestion.Controls.Add(this.txtAnswer);
            this.gbxSecurityQuestion.Controls.Add(this.cmbSecurityQuestion);
            this.gbxSecurityQuestion.Controls.Add(this.label3);
            this.gbxSecurityQuestion.Controls.Add(this.label2);
            this.gbxSecurityQuestion.Location = new System.Drawing.Point(15, 159);
            this.gbxSecurityQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSecurityQuestion.Name = "gbxSecurityQuestion";
            this.gbxSecurityQuestion.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSecurityQuestion.Size = new System.Drawing.Size(412, 192);
            this.gbxSecurityQuestion.TabIndex = 9;
            this.gbxSecurityQuestion.TabStop = false;
            this.gbxSecurityQuestion.Text = "select a question and answer it";
            // 
            // btnCheckUsername
            // 
            this.btnCheckUsername.Location = new System.Drawing.Point(120, 23);
            this.btnCheckUsername.Name = "btnCheckUsername";
            this.btnCheckUsername.Size = new System.Drawing.Size(278, 23);
            this.btnCheckUsername.TabIndex = 7;
            this.btnCheckUsername.Text = "Check username";
            this.btnCheckUsername.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(7, 11);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(398, 28);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // gbxSMSEmail
            // 
            this.gbxSMSEmail.Controls.Add(this.btnSend);
            this.gbxSMSEmail.Location = new System.Drawing.Point(15, 104);
            this.gbxSMSEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSMSEmail.Name = "gbxSMSEmail";
            this.gbxSMSEmail.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSMSEmail.Size = new System.Drawing.Size(412, 47);
            this.gbxSMSEmail.TabIndex = 8;
            this.gbxSMSEmail.TabStop = false;
            // 
            // rdbSecurityQuestion
            // 
            this.rdbSecurityQuestion.AutoSize = true;
            this.rdbSecurityQuestion.Location = new System.Drawing.Point(9, 23);
            this.rdbSecurityQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbSecurityQuestion.Name = "rdbSecurityQuestion";
            this.rdbSecurityQuestion.Size = new System.Drawing.Size(126, 20);
            this.rdbSecurityQuestion.TabIndex = 2;
            this.rdbSecurityQuestion.Text = "Security Question";
            this.rdbSecurityQuestion.UseVisualStyleBackColor = true;
            this.rdbSecurityQuestion.CheckedChanged += new System.EventHandler(this.rdbSecurityQuestion_CheckedChanged);
            // 
            // rdbEmail
            // 
            this.rdbEmail.AutoSize = true;
            this.rdbEmail.Location = new System.Drawing.Point(179, 23);
            this.rdbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbEmail.Name = "rdbEmail";
            this.rdbEmail.Size = new System.Drawing.Size(57, 20);
            this.rdbEmail.TabIndex = 1;
            this.rdbEmail.Text = "Email";
            this.rdbEmail.UseVisualStyleBackColor = true;
            this.rdbEmail.CheckedChanged += new System.EventHandler(this.rdbEmail_CheckedChanged);
            // 
            // rdbSMS
            // 
            this.rdbSMS.AutoSize = true;
            this.rdbSMS.Checked = true;
            this.rdbSMS.Location = new System.Drawing.Point(321, 23);
            this.rdbSMS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbSMS.Name = "rdbSMS";
            this.rdbSMS.Size = new System.Drawing.Size(52, 20);
            this.rdbSMS.TabIndex = 0;
            this.rdbSMS.TabStop = true;
            this.rdbSMS.Text = "SMS";
            this.rdbSMS.UseVisualStyleBackColor = true;
            this.rdbSMS.CheckedChanged += new System.EventHandler(this.rdbSMS_CheckedChanged);
            // 
            // gbxTypeOfRecovery
            // 
            this.gbxTypeOfRecovery.Controls.Add(this.rdbSecurityQuestion);
            this.gbxTypeOfRecovery.Controls.Add(this.rdbEmail);
            this.gbxTypeOfRecovery.Controls.Add(this.rdbSMS);
            this.gbxTypeOfRecovery.Location = new System.Drawing.Point(15, 37);
            this.gbxTypeOfRecovery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTypeOfRecovery.Name = "gbxTypeOfRecovery";
            this.gbxTypeOfRecovery.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTypeOfRecovery.Size = new System.Drawing.Size(412, 59);
            this.gbxTypeOfRecovery.TabIndex = 7;
            this.gbxTypeOfRecovery.TabStop = false;
            this.gbxTypeOfRecovery.Text = "Type of recovery";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(83, 6);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(344, 23);
            this.txtUserName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "username";
            // 
            // frmForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 357);
            this.Controls.Add(this.gbxSecurityQuestion);
            this.Controls.Add(this.gbxSMSEmail);
            this.Controls.Add(this.gbxTypeOfRecovery);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmForgetPassword";
            this.Text = "Forget Password";
            this.Load += new System.EventHandler(this.frmForgetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbxSecurityQuestion.ResumeLayout(false);
            this.gbxSecurityQuestion.PerformLayout();
            this.gbxSMSEmail.ResumeLayout(false);
            this.gbxTypeOfRecovery.ResumeLayout(false);
            this.gbxTypeOfRecovery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbxSecurityQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnDisplyNewPassword;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.ComboBox cmbSecurityQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxSMSEmail;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox gbxTypeOfRecovery;
        private System.Windows.Forms.RadioButton rdbSecurityQuestion;
        private System.Windows.Forms.RadioButton rdbEmail;
        private System.Windows.Forms.RadioButton rdbSMS;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckUsername;
    }
}