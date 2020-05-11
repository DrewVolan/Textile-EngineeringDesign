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

namespace EngineeringDesign
{
    public partial class StorekeeperForm : Template
    {
        public StorekeeperForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }

        private void StorekeeperForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void StorekeeperForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            SqlCommand selectClothes = new SqlCommand("SELECT * FROM [Clothes]", sqlConnection);
            SqlCommand selectFurnitures = new SqlCommand("SELECT * FROM [Furnitures]", sqlConnection);
            try
            {
                sdr = await selectClothes.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    if (Convert.ToString(sdr["Status"]) == "True")
                        clothesList.Items.Add(Convert.ToString(sdr["Id"]) + "    " + Convert.ToString(sdr["Name"]));
                }
                sdr.Close();
                sdr = await selectFurnitures.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    if (Convert.ToString(sdr["Status"]) == "True")
                        furnituresList.Items.Add(Convert.ToString(sdr["Id"]) + "    " + Convert.ToString(sdr["Name"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sdr != null) sdr.Close();
                sqlConnection.Close();
            }
            //loginLabel.Text += $"{Login}.";
        }

        private async void AddCloth_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            SqlCommand checkId = new SqlCommand("SELECT * FROM [Clothes]", sqlConnection);
            SqlCommand cmdInsert = new SqlCommand("INSERT INTO [Clothes] (Id, Name)VALUES(@Id, @Name)", sqlConnection);
            sdr = await checkId.ExecuteReaderAsync();
            int id = 0;
            while (await sdr.ReadAsync())
            {
                id++;
            }
            sdr.Close();
            cmdInsert.Parameters.AddWithValue("Id", id + 1);
            cmdInsert.Parameters.AddWithValue("Name", clothesName.Text);
            try
            {
                if (clothesName.Text != "")
                {
                    await cmdInsert.ExecuteNonQueryAsync();
                }
                else
                {
                    MessageBox.Show("Заполните название ткани!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
            MessageBox.Show("Тип ткани добавлен в базу данных.");
            ОбновитьToolStripMenuItem_Click(this, e);
        }

        private async void DeleteCloth_Click(object sender, EventArgs e)
        {
            if (clothesList.SelectedIndex != -1)
            {
                sqlConnection = new SqlConnection(connectionPathMain);
                await sqlConnection.OpenAsync();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE [Clothes] SET [Status]=0 WHERE [Id]=@Id", sqlConnection);
                int id = Convert.ToInt32((clothesList.SelectedItem.ToString().Split(new char[] { ' ' }))[0]); //Мегаважно для удаления из листа по ID
                cmdUpdate.Parameters.AddWithValue("Id", id);
                await cmdUpdate.ExecuteNonQueryAsync();
                clothesList.Items.RemoveAt(clothesList.SelectedIndex);
                sqlConnection.Close();
            }
            else
                MessageBox.Show("Выберите элемент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Тип ткани удалён.");
            ОбновитьToolStripMenuItem_Click(this, e);
        }

        private async void AddFurniture_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            SqlCommand checkId = new SqlCommand("SELECT * FROM [Furnitures]", sqlConnection);
            SqlCommand cmdInsert = new SqlCommand("INSERT INTO [Furnitures] (Id, Name, Image, Extension)VALUES(@Id, @Name, @Image, @Extension)", sqlConnection);
            sdr = await checkId.ExecuteReaderAsync();
            int id = 0;
            while (await sdr.ReadAsync())
            {
                id++;
            }
            sdr.Close();
            byte[] imageData;
            FileInfo fInfo = new FileInfo(linkTextBox.Text);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(linkTextBox.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            imageData = br.ReadBytes((int)numBytes);
            string iImageExtension = (Path.GetExtension(linkTextBox.Text)).Replace(".", "").ToLower();
            cmdInsert.Parameters.AddWithValue("Id", id + 1);
            cmdInsert.Parameters.AddWithValue("Name", furnitureName.Text);
            cmdInsert.Parameters.AddWithValue("Image", (object)imageData);
            cmdInsert.Parameters.AddWithValue("Extension", iImageExtension);
            try
            {
                if (furnitureName.Text != "")
                {
                    await cmdInsert.ExecuteNonQueryAsync();
                }
                else
                {
                    MessageBox.Show("Заполните название фурнитуры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
            MessageBox.Show("Фурнитура добавлена в базу данных.");
            ОбновитьToolStripMenuItem_Click(this, e);
        }

        private async void DeleteFurniture_Click(object sender, EventArgs e)
        {
            if (clothesList.SelectedIndex != -1)
            {
                string connectionPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desktop\Учёба\3 курс\1 семестр\Сетевое программирование\Session\Session\Database.mdf;Integrated Security=True";
                sqlConnection = new SqlConnection(connectionPath);
                await sqlConnection.OpenAsync();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE [Furnitures] SET [Status]=0 WHERE [Id]=@Id", sqlConnection);
                int id = Convert.ToInt32((furnituresList.SelectedItem.ToString().Split(new char[] { ' ' }))[0]); //Мегаважно для удаления из листа по ID
                cmdUpdate.Parameters.AddWithValue("Id", id);
                await cmdUpdate.ExecuteNonQueryAsync();
                furnituresList.Items.RemoveAt(furnituresList.SelectedIndex);
                sqlConnection.Close();
            }
            else
                MessageBox.Show("Выберите элемент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Фурнитура удалена.");
            ОбновитьToolStripMenuItem_Click(this, e);
        }

        private void ОбновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clothesList.Items.Clear();
            furnituresList.Items.Clear();
            //loginLabel.Text = "Вы зашли под логином ";
            StorekeeperForm_Load(this, e);
        }

        private void ВыйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
            this.Hide();
        }

        private void AddPictureButton_Click(object sender, EventArgs e)
        {
            Bitmap image; //Bitmap для открываемого изображения
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    furniturePictureBox.Image = image;
                    furniturePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    furniturePictureBox.Invalidate();
                    linkTextBox.Text = open_dialog.FileName;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void FurnituresList_MouseClick(object sender, MouseEventArgs e)
        {
            List<byte[]> iScreen = new List<byte[]>(); // сделав запрос к БД мы получим множество строк в ответе, поэтому мы их сможем загнать в массив/List
            List<string> iScreen_format = new List<string>();
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            SqlCommand selectFurnitures = new SqlCommand("SELECT [Image], [Extension] FROM [Furnitures] WHERE [Id]=@Id", sqlConnection);
            int id = Convert.ToInt32((furnituresList.SelectedItem.ToString().Split(new char[] { ' ' }))[0]);
            selectFurnitures.Parameters.AddWithValue("Id", id);
            try
            {
                {
                    sdr = await selectFurnitures.ExecuteReaderAsync();
                    byte[] iTrimByte = null;
                    string iTrimText = null;
                    while (await sdr.ReadAsync()) // считываем и вносим в лист результаты
                    {
                        iTrimByte = (byte[])sdr["Image"]; // читаем строки с изображениями
                        iScreen.Add(iTrimByte);
                        iTrimText = sdr["Extension"].ToString().TrimStart().TrimEnd(); // читаем строки с форматом изображения
                        iScreen_format.Add(iTrimText);
                    }
                }
                //if (sdr["Image"] != null)
                //{
                sqlConnection.Close();
                byte[] imageData = iScreen[0]; // возвращает массив байт из БД. Так как у нас SQL вернёт одну запись и в ней хранится нужное нам изображение, то из листа берём единственное значение с индексом '0'
                MemoryStream ms = new MemoryStream(imageData);
                Image newImage = Image.FromStream(ms);
                // сохраняем изоражение на диск
                /*string iImageExtension = iScreen_format[0]; // получаем расширение текущего изображения хранящееся в БД
                string iImageName = @"C:\result_new" + "." + iImageExtension; // задаём путь сохранения и имя нового изображения
                if (iImageExtension == "png") { newImage.Save(iImageName, System.Drawing.Imaging.ImageFormat.Png); }
                else if (iImageExtension == "jpg" || iImageExtension == "jpeg") { newImage.Save(iImageName, System.Drawing.Imaging.ImageFormat.Jpeg); }
                else if (iImageExtension == "gif") { newImage.Save(iImageName, System.Drawing.Imaging.ImageFormat.Gif); }*/
                furniturePictureBox.Image = newImage;
                furniturePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                furniturePictureBox.Invalidate();
                //}
                //else
                //{
                //    furniturePictureBox.Image = null;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
