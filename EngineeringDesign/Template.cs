using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace EngineeringDesign
{
    public partial class Template : Form
    {
        public String Login = String.Empty;
        public string connectionPathMain = @"";
        public string connectionPathOptional = @"";
        public SqlConnection sqlConnection;
        public SqlDataReader sdr;
        public Bitmap MyImage;
        public string[] imgExtencions = { "png", "jpg", "gif" };
        public bool readOnlyParameter = true;
        public Template()
        {
            InitializeComponent();
        }

        private void ВыйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
            this.Hide();
        }

        private void StandartForm_Load(object sender, EventArgs e)
        {
            loginLabel.Text += $"{Login}.";
        }

        public void StandartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
