namespace EngineeringDesign
{
    partial class RegistrationForm
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
            this.registerButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lookPassButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.wrongPasswordAnt = new System.Windows.Forms.Label();
            this.wrongPasswordLength = new System.Windows.Forms.Label();
            this.wrongPasswordLetters = new System.Windows.Forms.Label();
            this.wrongPasswordLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(905, 697);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(121, 23);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Зарегистрироваться";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(905, 554);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(825, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(905, 434);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(200, 20);
            this.loginTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(825, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // lookPassButton
            // 
            this.lookPassButton.Location = new System.Drawing.Point(1142, 552);
            this.lookPassButton.Name = "lookPassButton";
            this.lookPassButton.Size = new System.Drawing.Size(114, 23);
            this.lookPassButton.TabIndex = 8;
            this.lookPassButton.Text = "Показать пароль";
            this.lookPassButton.UseVisualStyleBackColor = true;
            this.lookPassButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LookPassButton_MouseDown);
            this.lookPassButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LookPassButton_MouseUp);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(825, 592);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 9;
            // 
            // wrongPasswordAnt
            // 
            this.wrongPasswordAnt.AutoSize = true;
            this.wrongPasswordAnt.ForeColor = System.Drawing.Color.Red;
            this.wrongPasswordAnt.Location = new System.Drawing.Point(825, 592);
            this.wrongPasswordAnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongPasswordAnt.Name = "wrongPasswordAnt";
            this.wrongPasswordAnt.Size = new System.Drawing.Size(319, 13);
            this.wrongPasswordAnt.TabIndex = 10;
            this.wrongPasswordAnt.Text = "Введеный пароль не соотвествует следующим требованиям:";
            this.wrongPasswordAnt.Visible = false;
            // 
            // wrongPasswordLength
            // 
            this.wrongPasswordLength.AutoSize = true;
            this.wrongPasswordLength.ForeColor = System.Drawing.Color.Red;
            this.wrongPasswordLength.Location = new System.Drawing.Point(851, 619);
            this.wrongPasswordLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongPasswordLength.Name = "wrongPasswordLength";
            this.wrongPasswordLength.Size = new System.Drawing.Size(221, 13);
            this.wrongPasswordLength.TabIndex = 11;
            this.wrongPasswordLength.Text = "Длинна должна быть от 5 до 20 символов";
            this.wrongPasswordLength.Visible = false;
            // 
            // wrongPasswordLetters
            // 
            this.wrongPasswordLetters.AutoSize = true;
            this.wrongPasswordLetters.ForeColor = System.Drawing.Color.Red;
            this.wrongPasswordLetters.Location = new System.Drawing.Point(851, 646);
            this.wrongPasswordLetters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongPasswordLetters.Name = "wrongPasswordLetters";
            this.wrongPasswordLetters.Size = new System.Drawing.Size(268, 13);
            this.wrongPasswordLetters.TabIndex = 12;
            this.wrongPasswordLetters.Text = "Должны встречаться заглавные и строчные буквы";
            this.wrongPasswordLetters.Visible = false;
            // 
            // wrongPasswordLogin
            // 
            this.wrongPasswordLogin.AutoSize = true;
            this.wrongPasswordLogin.ForeColor = System.Drawing.Color.Red;
            this.wrongPasswordLogin.Location = new System.Drawing.Point(851, 672);
            this.wrongPasswordLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongPasswordLogin.Name = "wrongPasswordLogin";
            this.wrongPasswordLogin.Size = new System.Drawing.Size(191, 13);
            this.wrongPasswordLogin.TabIndex = 13;
            this.wrongPasswordLogin.Text = "Пароль не должен содержать логин";
            this.wrongPasswordLogin.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1289, 773);
            this.Controls.Add(this.wrongPasswordLogin);
            this.Controls.Add(this.wrongPasswordLetters);
            this.Controls.Add(this.wrongPasswordLength);
            this.Controls.Add(this.wrongPasswordAnt);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.lookPassButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerButton);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lookPassButton;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label wrongPasswordAnt;
        private System.Windows.Forms.Label wrongPasswordLength;
        private System.Windows.Forms.Label wrongPasswordLetters;
        private System.Windows.Forms.Label wrongPasswordLogin;
    }
}