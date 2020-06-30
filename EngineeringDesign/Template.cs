using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace EngineeringDesign
{
    public partial class Template : Form
    {
        public String Login = String.Empty;
        public string connectionPathMain = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Desktop\Учёба\3 курс\2 семестр\Инженерное проектирование\EngineeringDesign\EngineeringDesign\Database.mdf';Integrated Security=True;Connect Timeout=30";
        public string connectionPathOptional = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Desktop\Учёба\3 курс\2 семестр\Инженерное проектирование\EngineeringDesign\EngineeringDesign\Database_2.mdf';Integrated Security=True;Connect Timeout=30";
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
