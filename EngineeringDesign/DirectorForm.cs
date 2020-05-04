using GanttChart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;*/

namespace EngineeringDesign
{
    public partial class DirectorForm : Template
    {
        /*IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "11FxWLoJ9mePPXPPjNMY90omEV4OqHoWTaL6tA1L",
            BasePath = "https://sessionnetworkprogramming.firebaseio.com/"
        };

        IFirebaseClient client;*/

        /*public String Login = String.Empty;
        public string connectionPathMain = @"";
        public string connectionPathOptional = @"";
        public SqlConnection sqlConnection;
        public SqlDataReader sdr;
        public Bitmap MyImage;
        string[] imgExtencions = { "png", "jpg", "gif" };*/
        public DirectorForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPathMain);
            SqlCommand cmdUpdate = new SqlCommand("UPDATE [Workshops] SET [Plan]=@Plan WHERE [Name]=@Name", sqlConnection);
            workshopPictureBox.BringToFront();
            Bitmap bmp = new Bitmap(workshopPictureBox.Width, workshopPictureBox.Height);
            workshopPictureBox.DrawToBitmap(bmp, new Rectangle(workshopPictureBox.Location.X, workshopPictureBox.Location.Y, workshopPictureBox.Width, workshopPictureBox.Height));
            panel1.DrawToBitmap(bmp, new Rectangle(workshopPictureBox.Location.X, workshopPictureBox.Location.Y, workshopPictureBox.Width, workshopPictureBox.Height));
            Image img = bmp;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            cmdUpdate.Parameters.AddWithValue("Name", workshopComboBox.Text);
            cmdUpdate.Parameters.AddWithValue("Plan", arr);
            await sqlConnection.OpenAsync();
            await cmdUpdate.ExecuteNonQueryAsync();
            List<byte[]> iScreen = new List<byte[]>();
            SqlCommand cmdSelect = new SqlCommand("SELECT [Plan] FROM [Workshops] WHERE [Name]=@Name", sqlConnection);
            cmdSelect.Parameters.AddWithValue("Name", workshopComboBox.Text);
            sdr = await cmdSelect.ExecuteReaderAsync();
            byte[] iTrimByte = null;
            while (await sdr.ReadAsync())
            {
                iTrimByte = (byte[])sdr["Plan"];
                iScreen.Add(iTrimByte);
            }
            byte[] imageData = iScreen[0];
            MemoryStream ms = new MemoryStream(imageData);
            Image newImage = Image.FromStream(ms);
            workshopPictureBox.Image = newImage;
            sdr.Close();
            sqlConnection.Close();
            workshopPictureBox.SendToBack();
            for (int i = 0; i < koef; i++)
            {
                pictureBox[i].Dispose();
            }
            koef = 0;
            MessageBox.Show("Успешно сохранено!");
        }

        private async void RestartButton_Click(object sender, EventArgs e)
        {
            List<byte[]> iScreen = new List<byte[]>();
            sqlConnection = new SqlConnection(connectionPathMain);
            SqlCommand cmdSelect = new SqlCommand("SELECT [Empty_Plan] FROM [Workshops] WHERE [Name]=@Name", sqlConnection);
            SqlCommand cmdSelectPlan = new SqlCommand("SELECT [Plan] FROM [Workshops] WHERE [Name]=@Name", sqlConnection);
            SqlCommand cmdUpdate = new SqlCommand("UPDATE [Workshops] SET [Plan]=@Plan WHERE [Name]=@Name", sqlConnection);
            cmdSelect.Parameters.AddWithValue("Name", workshopComboBox.Text);
            await sqlConnection.OpenAsync();
            sdr = await cmdSelect.ExecuteReaderAsync();
            byte[] iTrimByte = null;
            while (await sdr.ReadAsync())
            {
                iTrimByte = (byte[])sdr["Empty_Plan"];
                iScreen.Add(iTrimByte);
            }
            sdr.Close();
            byte[] imageData = iScreen[0];
            cmdUpdate.Parameters.AddWithValue("Name", workshopComboBox.Text);
            cmdUpdate.Parameters.AddWithValue("Plan", imageData);
            await cmdUpdate.ExecuteNonQueryAsync();
            cmdSelectPlan.Parameters.AddWithValue("Name", workshopComboBox.Text);
            sdr = await cmdSelectPlan.ExecuteReaderAsync();
            iTrimByte = null;
            while (await sdr.ReadAsync())
            {
                iTrimByte = (byte[])sdr["Plan"];
                iScreen.Add(iTrimByte);
            }
            imageData = iScreen[0];
            MemoryStream ms = new MemoryStream(imageData);
            Image newImage = Image.FromStream(ms);
            workshopPictureBox.Image = newImage;
            sqlConnection.Close();
            for (int i = 0; i < koef; i++)
            {
                pictureBox[i].Dispose();
            }
            koef = 0;
            MessageBox.Show("Успешно пересобранно!");
        }

        private async void WorkshopComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            List<byte[]> iScreen = new List<byte[]>();
            sqlConnection = new SqlConnection(connectionPathMain);
            SqlCommand cmdSelect = new SqlCommand("SELECT [Plan] FROM [Workshops] WHERE [Name]=@Name", sqlConnection);
            cmdSelect.Parameters.AddWithValue("Name", workshopComboBox.Text);
            await sqlConnection.OpenAsync();
            sdr = await cmdSelect.ExecuteReaderAsync();
            byte[] iTrimByte = null;
            while (await sdr.ReadAsync())
            {
                iTrimByte = (byte[])sdr["Plan"];
                iScreen.Add(iTrimByte);
            }
            byte[] imageData = iScreen[0];
            MemoryStream ms = new MemoryStream(imageData);
            Image newImage = Image.FromStream(ms);
            workshopPictureBox.Image = newImage;
            sdr.Close();
            sqlConnection.Close();
        }

        private async void DirectorForm_Load(object sender, EventArgs e)
        {
            /*client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                //MessageBox.Show("Work DB!");
            }*/

            // TODO: This line of code loads data into the 'sweetDataBaseDataSet.Ingridients' table. You can move, or remove it, as needed.
            //this.ingridientsTableAdapter.Fill(this.sweetDataBaseDataSet.Ingridients);
            // TODO: This line of code loads data into the 'sweetDataBaseDataSet.Decoration' table. You can move, or remove it, as needed.
            //this.decorationTableAdapter.Fill(this.sweetDataBaseDataSet.Decoration);
            // TODO: This line of code loads data into the 'sweetDataBaseDataSet.typeOfEquipment' table. You can move, or remove it, as needed.
            //this.typeOfEquipmentTableAdapter.Fill(this.sweetDataBaseDataSet.typeOfEquipment);
            // TODO: This line of code loads data into the 'sweetDataBaseDataSet1.Ingridients' table. You can move, or remove it, as needed.
            //this.ingridientsTableAdapter.Fill(this.sweetDataBaseDataSet.Ingridients);
            // TODO: This line of code loads data into the 'sweetDataBaseDataSet.Equipment' table. You can move, or remove it, as needed.
            //this.equipmentTableAdapter.Fill(this.sweetDataBaseDataSet.Equipment);

        }

        PictureBox[] pictureBox = new PictureBox[16];
        int koef = 0;
        Control draggedPiece;
        private Point startDraggingPoint;
        private void EquipmentPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox[koef] = new System.Windows.Forms.PictureBox();
            pictureBox[koef].Location = equipmentPictureBox.Location;
            pictureBox[koef].Name = "pictureBox" + koef.ToString();
            pictureBox[koef].Size = equipmentPictureBox.Size;
            pictureBox[koef].SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox[koef].TabIndex = koef;
            pictureBox[koef].TabStop = false;
            pictureBox[koef].Image = equipmentPictureBox.Image;
            this.pictureBox[koef].MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBox[koef].MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBox[koef].MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            panel1.Controls.Add(pictureBox[koef]);
            pictureBox[koef].BringToFront();
            draggedPiece = pictureBox[koef] as Control;
            this.Cursor = Cursors.SizeAll;
            this.startDraggingPoint = e.Location;
            koef++;
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            draggedPiece = sender as Control;
            this.Cursor = Cursors.SizeAll;
            this.startDraggingPoint = e.Location;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggedPiece != null)
            {
                Point pt;
                if (draggedPiece == sender)
                    pt = new Point(e.X, e.Y);
                else
                    pt = draggedPiece.PointToClient((sender as Control).PointToScreen(new Point(e.X, e.Y)));

                draggedPiece.Left += pt.X - this.startDraggingPoint.X;
                draggedPiece.Top += pt.Y - this.startDraggingPoint.Y;
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.draggedPiece = null;
            this.startDraggingPoint = Point.Empty;
            this.Cursor = Cursors.Default;
        }

        private void FirstAidPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox[koef] = new System.Windows.Forms.PictureBox();
            pictureBox[koef].Location = firstAidPictureBox.Location;
            pictureBox[koef].Name = "pictureBox" + koef.ToString();
            pictureBox[koef].Size = firstAidPictureBox.Size;
            pictureBox[koef].SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox[koef].TabIndex = koef;
            pictureBox[koef].TabStop = false;
            pictureBox[koef].Image = firstAidPictureBox.Image;
            this.pictureBox[koef].MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBox[koef].MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBox[koef].MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            panel1.Controls.Add(pictureBox[koef]);
            pictureBox[koef].BringToFront();
            draggedPiece = pictureBox[koef] as Control;
            this.Cursor = Cursors.SizeAll;
            this.startDraggingPoint = e.Location;
            koef++;
        }

        private void FireExtinguisherPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox[koef] = new System.Windows.Forms.PictureBox();
            pictureBox[koef].Location = fireExtinguisherPictureBox.Location;
            pictureBox[koef].Name = "pictureBox" + koef.ToString();
            pictureBox[koef].Size = fireExtinguisherPictureBox.Size;
            pictureBox[koef].SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox[koef].TabIndex = koef;
            pictureBox[koef].TabStop = false;
            pictureBox[koef].Image = fireExtinguisherPictureBox.Image;
            this.pictureBox[koef].MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBox[koef].MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBox[koef].MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            panel1.Controls.Add(pictureBox[koef]);
            pictureBox[koef].BringToFront();
            draggedPiece = pictureBox[koef] as Control;
            this.Cursor = Cursors.SizeAll;
            this.startDraggingPoint = e.Location;
            koef++;
        }

        private void ExitPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox[koef] = new System.Windows.Forms.PictureBox();
            pictureBox[koef].Location = exitPictureBox.Location;
            pictureBox[koef].Name = "pictureBox" + koef.ToString();
            pictureBox[koef].Size = exitPictureBox.Size;
            pictureBox[koef].SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox[koef].TabIndex = koef;
            pictureBox[koef].TabStop = false;
            pictureBox[koef].Image = exitPictureBox.Image;
            this.pictureBox[koef].MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBox[koef].MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBox[koef].MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            panel1.Controls.Add(pictureBox[koef]);
            pictureBox[koef].BringToFront();
            draggedPiece = pictureBox[koef] as Control;
            this.Cursor = Cursors.SizeAll;
            this.startDraggingPoint = e.Location;
            koef++;
        }

        private void ToGanttChartButton_Click(object sender, EventArgs e)
        {
            try
            {
                Chart ganttChart = new Chart();
                ganttChart.StartDate = DateTime.Today;
                ganttChart.EndDate = DateTime.Today.AddDays(Convert.ToInt32(qtyDaysSumTextBox.Text));
                tabControl1.SelectedIndex = 7;
                panel2.Controls.Add(ganttChart);
                ganttChart.Dock = DockStyle.Fill;
                int k = Convert.ToInt32(firstTaskHourСomboBox.Text);
                for (int i = 0; i < rowsArray.Length / 2; i++)
                {
                    if (rowsArray[i, 0] != "")
                    {
                        Row row = new Row(rowsArray[i, 0]);
                        row.TimeBlocks.Add(new TimeBlock(DateTime.Today.AddHours(k), DateTime.Today.AddHours(k + Convert.ToInt32(rowsArray[i, 1]))) { Color = Color.Red });
                        k += Convert.ToInt32(rowsArray[i, 1]);
                        ganttChart.Rows.Add(row);
                        ganttChart.UpdateView();
                    }
                    else break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string[,] rowsArray = new string[16, 2];
        byte rowNum = 0;

        private void AddNewRow_Click(object sender, EventArgs e)
        {
            rowsArray[rowNum, 0] = rowNameTextBox.Text;
            rowsArray[rowNum, 1] = qtyDaysTextBox.Text;
            rowsComboBox.Items.Add(rowsArray[rowNum, 0]);
            rowNum++;
        }

        //Функция для сохранения фото в БД
        /*private async void button1_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPath);
            await sqlConnection.OpenAsync();
            SqlCommand cmdUpdate = new SqlCommand("UPDATE [Workshops] SET [Empty_Plan]=@Plan WHERE [Name]=@Name", sqlConnection);
            byte[] imageData;
            FileInfo fInfo = new FileInfo(@"D:\Desktop\Учёба\3 курс\1 семестр\Сетевое программирование\Дополнительные файлы\Практическая\Ресурсы - Сессия 2\Цеха\Цеха\Цех оформления.png");
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(@"D:\Desktop\Учёба\3 курс\1 семестр\Сетевое программирование\Дополнительные файлы\Практическая\Ресурсы - Сессия 2\Цеха\Цеха\Цех оформления.png", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            imageData = br.ReadBytes((int)numBytes);
            cmdUpdate.Parameters.AddWithValue("Plan", imageData);
            cmdUpdate.Parameters.AddWithValue("Name", textBox1.Text);
            await cmdUpdate.ExecuteNonQueryAsync();
        }*/
    }
}
