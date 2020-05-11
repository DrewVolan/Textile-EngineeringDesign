using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EngineeringDesign
{
    public partial class AuthorizationForm : Template
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }

        int countInvalidAttempts = 3;

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm reg = new RegistrationForm();
            reg.Size = this.Size;
            reg.Left = this.Left;
            reg.Top = this.Top;
            reg.Show();
            this.Hide();
        }

        Timer tmrShow = new Timer();

        private void UnlockForm(object sender, EventArgs e)
        {
            tmrShow.Stop();
            tmrShow.Tick -= new EventHandler(UnlockForm);
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            EnterButton.Enabled = true;
            RegistrationButton.Enabled = true;
            infoLabel.Visible = false;
        }

        private async void EnterButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM [Users]", sqlConnection);
            bool checkLog = false;
            try
            {
                sdr = await cmdSelect.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    if (textBox1.Text == Convert.ToString(sdr["Login"]))
                    {
                        checkLog = true;
                        if (textBox2.Text == Convert.ToString(sdr["Password"]))
                        {
                            switch (Convert.ToString(sdr["Role"]))
                            {
                                case "Заказчик":
                                    CustomerForm regC = new CustomerForm();
                                    regC.Login = textBox1.Text;
                                    regC.Left = this.Left;
                                    regC.Top = this.Top;
                                    regC.Show();
                                    this.Hide();
                                    break;
                                case "Менеджер":
                                    ManagerForm managerForm = new ManagerForm();
                                    managerForm.Login = textBox1.Text;
                                    managerForm.Left = this.Left;
                                    managerForm.Top = this.Top;
                                    managerForm.Show();
                                    this.Hide();
                                    break;
                                case "Кладовщик":
                                    StorekeeperForm storekeeperForm = new StorekeeperForm();
                                    storekeeperForm.Login = textBox1.Text;
                                    storekeeperForm.Left = this.Left;
                                    storekeeperForm.Top = this.Top;
                                    storekeeperForm.Show();
                                    this.Hide();
                                    break;
                                case "Администратор":
                                    AdministratorForm administratorForm = new AdministratorForm();
                                    administratorForm.Login = textBox1.Text;
                                    administratorForm.Left = this.Left;
                                    administratorForm.Top = this.Top;
                                    administratorForm.Show();
                                    this.Hide();
                                    break;
                                case "Директор":
                                    DirectorForm directorForm = new DirectorForm();
                                    directorForm.Login = textBox1.Text;
                                    directorForm.Left = this.Left;
                                    directorForm.Top = this.Top;
                                    directorForm.Show();
                                    this.Hide();
                                    break;
                            }
                        }
                        else
                        {
                            warningLabel.Text = "Пароль неверный, попробуйте ещё раз!";
                            warningLabel.Visible = true;
                            textBox2.Text = "";
                        }
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
                if (checkLog == false)
                {
                    warningLabel.Text = "Данный логин незарегистрирован!";
                    warningLabel.Visible = true;
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            countInvalidAttempts--;
            countAttempt.Text = $"У вас осталось {countInvalidAttempts} попыток";
            countAttempt.Visible = true;
            if (countInvalidAttempts == 0)
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                EnterButton.Enabled = false;
                RegistrationButton.Enabled = false;


                tmrShow.Interval = 5000;
                tmrShow.Tick += new System.EventHandler(UnlockForm);
                tmrShow.Start();

                countAttempt.Visible = false;
                warningLabel.Visible = false;
                infoLabel.Text = "Авторизация заблокирована на 5 секунд!";
                infoLabel.Visible = true;
                countInvalidAttempts = 3;
            }
        }

        private void AuthorizationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) EnterButton.PerformClick();
        }

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
