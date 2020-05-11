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

        public void StandartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
