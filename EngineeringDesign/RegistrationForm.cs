using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringDesign
{
    public partial class RegistrationForm : Template
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }

        private async void RegistrationButton_Click(object sender, EventArgs e)
        {
            bool checkPassword = CheckPass(passwordTextBox.Text.ToString(), loginTextBox.Text.ToString());
            if (checkPassword == true)
            {
                sqlConnection = new SqlConnection(connectionPathMain);
                await sqlConnection.OpenAsync();
                SqlDataReader sdr = null;
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM [Users]", sqlConnection);
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO [Users] (Login, Pass, Role, Id)VALUES(@Login, @Password, @Role, 10)", sqlConnection);
                cmdInsert.Parameters.AddWithValue("Login", loginTextBox.Text);
                cmdInsert.Parameters.AddWithValue("Password", passwordTextBox.Text);
                cmdInsert.Parameters.AddWithValue("Role", "Заказчик");
                bool regCheck = true; //Проверка логина на повтор в базе данных.
                bool checkLogin = true; //Проверка логина на символы русского алфавита.
                char[] loginLetters = loginTextBox.Text.ToCharArray();

                for (int i = 0; i < loginLetters.Length; i++)
                {
                    if (loginLetters[i] >= 'А' && loginLetters[i] <= 'ё' && loginLetters.Length != 0)
                    {
                        checkLogin = false;
                        MessageBox.Show("Логин не должен содержать символы русского алфавита!");
                        break;
                    }
                }
                if (checkPassword == true && checkLogin == true)
                {
                    try
                    {
                        sdr = await cmdSelect.ExecuteReaderAsync();
                        while (await sdr.ReadAsync())
                        {
                            if (loginTextBox.Text == Convert.ToString(sdr["Login"]))
                            {
                                MessageBox.Show("Такой логин уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                regCheck = false;
                                loginTextBox.Text = "";
                                passwordTextBox.Text = "";
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (sdr != null) sdr.Close();
                        if (regCheck == true)
                        {
                            //cmdInsert.Connection.Open();
                            await cmdInsert.ExecuteNonQueryAsync();
                            //cmdInsert.Connection.Close();
                            loginTextBox.Text = "";
                            passwordTextBox.Text = "";
                            //Здесь надо сделать выход!!!!!!!!!!!!!!!!!!!!!!
                        }
                    }
                    sqlConnection.Close();
                    AuthorizationForm authorizationForm = new AuthorizationForm();
                    authorizationForm.Size = this.Size;
                    authorizationForm.Left = this.Left;
                    authorizationForm.Top = this.Top;
                    authorizationForm.Show();
                    this.Hide();

                }
            }
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Проверка пароля по всем параметрам.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckPass(string password, string login)
        {
            wrongPasswordLogin.ForeColor = Color.Red;
            wrongPasswordLength.ForeColor = Color.Red;
            wrongPasswordLetters.ForeColor = Color.Red;


            Regex regex = new Regex(@"(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z!@#$%]");
            char[] passLetters = password.ToCharArray();
            bool checkLength = false;
            bool checkLogin = false;
            bool checkLetters = false;

            if (regex.Match(password).Success)
            {
                checkLetters = true;

                if (wrongPasswordAnt.Visible == true)
                {
                    wrongPasswordLetters.ForeColor = Color.Green;
                    wrongPasswordLetters.Visible = true;
                    wrongPasswordLength.Visible = true;
                    wrongPasswordLogin.Visible = true;
                }
            }
            else
            {
                wrongPasswordAnt.Visible = true;
                wrongPasswordLetters.Visible = true;

                if (wrongPasswordAnt.Visible == true)
                {
                    wrongPasswordLetters.Visible = true;
                    wrongPasswordLength.Visible = true;
                    wrongPasswordLogin.Visible = true;
                }
            }

            if (passLetters.Length >= 5 && passLetters.Length <= 20)
            {
                checkLength = true;

                if (wrongPasswordAnt.Visible == true)
                {
                    wrongPasswordLength.ForeColor = Color.Green;
                    wrongPasswordLetters.Visible = true;
                    wrongPasswordLength.Visible = true;
                    wrongPasswordLogin.Visible = true;

                }
            }
            else
            {
                wrongPasswordAnt.Visible = true;
                wrongPasswordLength.Visible = true;

                if (wrongPasswordAnt.Visible == true)
                {
                    wrongPasswordLetters.Visible = true;
                    wrongPasswordLength.Visible = true;
                    wrongPasswordLogin.Visible = true;
                }
            }

            string passwordLowerCase = password.ToLower();
            string loginLowerCase = login.ToLower();
            if (!passwordLowerCase.Contains(loginLowerCase))
            {
                checkLogin = true;

                if (wrongPasswordAnt.Visible == true)
                {
                    wrongPasswordLogin.ForeColor = Color.Green;
                    wrongPasswordLetters.Visible = true;
                    wrongPasswordLength.Visible = true;
                    wrongPasswordLogin.Visible = true;
                }
            }
            else
            {
                wrongPasswordAnt.Visible = true;
                wrongPasswordLogin.Visible = true;

                if (wrongPasswordAnt.Visible == true)
                {
                    wrongPasswordLetters.Visible = true;
                    wrongPasswordLength.Visible = true;
                    wrongPasswordLogin.Visible = true;
                }
            }

            if (checkLetters == true && checkLength == true && checkLogin == true)
            {
                wrongPasswordLength.Visible = false;
                wrongPasswordLetters.Visible = false;
                wrongPasswordLogin.Visible = false;
                wrongPasswordAnt.Visible = false;

                return true;
            }

            return false;
        }

        private void LookPassButton_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTextBox.PasswordChar = '\0';
        }

        private void LookPassButton_MouseUp(object sender, MouseEventArgs e)
        {
            passwordTextBox.PasswordChar = '●';
        }
    }
}
