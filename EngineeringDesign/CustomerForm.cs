using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace EngineeringDesign
{
    public partial class CustomerForm : Template
    {
        public CustomerForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void CustomerForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            SqlCommand selectGoods = new SqlCommand("SELECT * FROM [Goods]", sqlConnection);
            SqlCommand selectOrders = new SqlCommand("SELECT * FROM [Orders]", sqlConnection);
            SqlCommand selectCustomerGoods = new SqlCommand("SELECT * FROM [CustomerGoods] WHERE [Customer]=@Customer", sqlConnection);
            selectCustomerGoods.Parameters.AddWithValue("Customer", Login);
            try
            {
                sdr = await selectGoods.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    if (Convert.ToString(sdr["Status"]) == "True")
                        goodsList.Items.Add("Артикул: " + Convert.ToString(sdr["Id"]) + " Наименование: " + Convert.ToString(sdr["Name"]) + " Широта: " + Convert.ToString(sdr["Width"]) + " Высота: " + Convert.ToString(sdr["Height"]) + " Ткань: " + Convert.ToString(sdr["Cloth"]) + " Трим: " + Convert.ToString(sdr["Trim"]) + " Фурнитура: " + Convert.ToString(sdr["Furniture"]));
                }
                sdr.Close();
                sdr = await selectOrders.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    if (Convert.ToString(sdr["Customer"]) == Login)
                        orderList.Items.Add("Номер заказа: " + Convert.ToString(sdr["id"]) + " Время заказа: " + Convert.ToString(sdr["Date"]) + " Заказ: " + Convert.ToString(sdr["Sum"]) + " Менеджер заказа: " + Convert.ToString(sdr["Manager"]) + " Статус заказа: " + Convert.ToString(sdr["Status"]));
                }
                sdr.Close();
                sdr = await selectCustomerGoods.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    if (Convert.ToString(sdr["Status"]) == "True")
                        myGoodsListBox.Items.Add("Артикул: " + Convert.ToString(sdr["Id"]) + " Наименование: " + Convert.ToString(sdr["Name"]) + " Широта: " + Convert.ToString(sdr["Width"]) + " Высота: " + Convert.ToString(sdr["Height"]) + " Ткань: " + Convert.ToString(sdr["Cloth"]) + " Окантовка: " + Convert.ToString(sdr["Trim"]));
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataSet DS = new DataSet();
            SqlDataAdapter sdaClothes = new SqlDataAdapter("SELECT * FROM [Clothes] WHERE (Status='true')", sqlConnection);
            SqlDataAdapter sdaFurnitures = new SqlDataAdapter("SELECT * FROM [Furnitures] WHERE (Status='true')", sqlConnection);
            sdaClothes.Fill(DS, "Clothes");
            sdaFurnitures.Fill(DS, "Furnitures");
            clothComboBox.Items.Clear();
            furnitureComboBox.Items.Clear();
            for (int i = 0; i < DS.Tables["Clothes"].Rows.Count; i++)
            {
                clothComboBox.Items.Add(DS.Tables["Clothes"].Rows[i][1].ToString());
            }
            for (int i = 0; i < DS.Tables["Furnitures"].Rows.Count; i++)
                furnitureComboBox.Items.Add(DS.Tables["Furnitures"].Rows[i][1].ToString() + " " + DS.Tables["Furnitures"].Rows[i][0].ToString());
            sqlConnection.Close();
            loginLabel.Text += $"{Login}.";
        }

        private void AddToOrder_Click(object sender, EventArgs e)
        {
            if (goodsList.SelectedIndex != -1 && IsDigits(qtyBox.Text) && Convert.ToInt32(qtyBox.Text) > 0)
            {
                string id = (goodsList.Text.Split(new char[] { ' ' }))[1];
                int qty = Convert.ToInt32(qtyBox.Text);
                currentOrder.Items.Add($"{id} {qty} шт.");
                goodsList.SelectedIndex = -1;
                qtyBox.Text = "0";
            }
            else MessageBox.Show("Выберите товар и количество больше нуля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool IsDigits(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsDigit(text[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private async void AddOrderButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            SqlCommand checkId = new SqlCommand("SELECT * FROM [Orders]", sqlConnection);
            SqlCommand cmdInsert = new SqlCommand("INSERT INTO [Orders] (Id, Date, Sum, Customer, Status)VALUES(@Id, @Date, @Sum, @Customer, @Status)", sqlConnection);
            sdr = await checkId.ExecuteReaderAsync();
            int id = 0;
            while (await sdr.ReadAsync())
            {
                id++;
            }
            sdr.Close();
            string sum = " ";
            for (int i = 0; i < currentOrder.Items.Count; i++)
            {
                sum += $"{currentOrder.Items[i]}; ";
            }
            cmdInsert.Parameters.AddWithValue("Id", id + 1);
            cmdInsert.Parameters.AddWithValue("Date", DateTime.Now);
            cmdInsert.Parameters.AddWithValue("Sum", sum);
            cmdInsert.Parameters.AddWithValue("Customer", Login);
            cmdInsert.Parameters.AddWithValue("Status", "Новый");
            try
            {
                if (sum != "")
                {
                    await cmdInsert.ExecuteNonQueryAsync();
                    currentOrder.Items.Clear();
                }
                else MessageBox.Show("Корзина пуста!", "Ошибка оформления заказа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
            MessageBox.Show("Заказ оформлен. Не забудьте перепроверить во вкладке 'Мои заказы' и подтвердить.");
            ОбновитьToolStripMenuItem_Click(this, e);
        }

        private async void UpdateOrder_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            SqlCommand cmdUpdate = new SqlCommand("UPDATE [Orders] SET [Sum]=@Sum WHERE [Id]=@Id", sqlConnection);
            string sum = "";
            for (int i = 0; i < currentOrder.Items.Count; i++)
            {
                sum += $"{currentOrder.Items[i]}; ";
            }
            cmdUpdate.Parameters.AddWithValue("Id", Convert.ToInt32(orderNum.Text));
            cmdUpdate.Parameters.AddWithValue("Sum", sum);
            await cmdUpdate.ExecuteNonQueryAsync();
            sqlConnection.Close();
            ОбновитьToolStripMenuItem_Click(this, e);
        }

        private void CurrentOrder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (currentOrder.SelectedIndex != -1)
            {
                currentOrder.Items.RemoveAt(currentOrder.SelectedIndex);
            }
        }

        private void ОбновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goodsList.Items.Clear();
            orderList.Items.Clear();
            currentOrder.Items.Clear();
            goodsList.SelectedIndex = -1;
            currentOrder.SelectedIndex = -1;
            orderList.SelectedIndex = -1;
            qtyBox.Text = "0";
            orderNum.Text = "";
            loginLabel.Text = "Вы вошли под логином ";
            nameTextBox.Text = "";
            clothComboBox.Text = "";
            clothComboBox.Items.Clear();
            trimComboBox.Text = "";
            trimComboBox.Items.Clear();
            furnitureComboBox.Items.Clear();
            myGoodsListBox.Items.Clear();
            myGoodsListBox.SelectedIndex = -1;
            /*Array.Clear(pictureBox, 0, 10);
            Array.Clear(imageArray, 0, 11);
            Array.Clear(pictureBoxArray, 0, 33);
            koef = 0;*/
            CustomerForm_Load(this, e);
        }

        private void ВыйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
            this.Hide();
        }

        private async void AcceptButton_Click(object sender, EventArgs e)
        {
            if (acceptButton.Text == "Подтвердить")
            {
                sqlConnection = new SqlConnection(connectionPathMain);
                await sqlConnection.OpenAsync();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE [Orders] SET [Status]=@Status WHERE [Id]=@Id", sqlConnection);
                cmdUpdate.Parameters.AddWithValue("Id", (orderList.SelectedItem.ToString().Split(new char[] { ' ' }))[2]);
                cmdUpdate.Parameters.AddWithValue("Status", "Ожидает");
                await cmdUpdate.ExecuteNonQueryAsync();
                sqlConnection.Close();
                MessageBox.Show("Заказ подтверждён. Ожидайте ответа менеджера.");
                ОбновитьToolStripMenuItem_Click(this, e);
            }
            else if (acceptButton.Text == "Оплатить")
            {
                sqlConnection = new SqlConnection(connectionPathMain);
                await sqlConnection.OpenAsync();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE [Orders] SET [Status]=@Status WHERE [Id]=@Id", sqlConnection);
                cmdUpdate.Parameters.AddWithValue("Id", (orderList.SelectedItem.ToString().Split(new char[] { ' ' }))[2]);
                cmdUpdate.Parameters.AddWithValue("Status", "Оплачен");
                await cmdUpdate.ExecuteNonQueryAsync();
                sqlConnection.Close();
                MessageBox.Show("Заказ оплачен. Ожидайте выполнение заказа.");
                ОбновитьToolStripMenuItem_Click(this, e);
            }
        }

        private async void OrderList_MouseClick(object sender, MouseEventArgs e)
        {
            if (orderList.SelectedIndex != -1)
            {
                string id = (orderList.SelectedItem.ToString().Split(new char[] { ' ' }))[2];
                string status = "";
                sqlConnection = new SqlConnection(connectionPathMain);
                await sqlConnection.OpenAsync();
                SqlCommand checkStatus = new SqlCommand("SELECT * FROM [Orders]", sqlConnection);
                try
                {
                    sdr = await checkStatus.ExecuteReaderAsync();
                    while (await sdr.ReadAsync())
                    {
                        if (Convert.ToString(sdr["Id"]) == id)
                        {
                            status = Convert.ToString(sdr["Status"]);
                            break;
                        }
                    }
                    sdr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
                switch (status)
                {
                    case "Новый":
                        acceptButton.Text = "Подтвердить";
                        acceptButton.Visible = true;
                        break;
                    case "Ожидает":
                        acceptButton.Visible = false;
                        break;
                    case "Обработка":
                        acceptButton.Visible = false;
                        break;
                    case "Отклонён":
                        acceptButton.Visible = false;
                        break;
                    case "К оплате":
                        acceptButton.Text = "Оплатить";
                        acceptButton.Visible = true;
                        break;
                    case "Оплачен":
                        acceptButton.Visible = false;
                        break;
                    case "Раскрой":
                        acceptButton.Visible = false;
                        break;
                    case "Готов":
                        acceptButton.Visible = false;
                        break;
                }
            }
        }

        private async void CreateCustomerGoodButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            SqlCommand checkId = new SqlCommand("SELECT * FROM [CustomerGoods]", sqlConnection);
            SqlCommand cmdInsert = new SqlCommand("INSERT INTO [CustomerGoods] (Id, Name, Width, Height, Cloth, Trim, Customer, Image)VALUES(@Id, @Name, @Width, @Height, @Cloth, @Trim, @Customer, @Image)", sqlConnection);
            sdr = await checkId.ExecuteReaderAsync();
            int id = 0;
            while (await sdr.ReadAsync())
            {
                id++;
            }
            sdr.Close();
            goodSchemePictureBox.BringToFront();
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            Image img = bmp;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            cmdInsert.Parameters.AddWithValue("Id", id + 1);
            cmdInsert.Parameters.AddWithValue("Name", nameTextBox.Text);
            cmdInsert.Parameters.AddWithValue("Width", Convert.ToInt32(widthTextBox.Text));
            cmdInsert.Parameters.AddWithValue("Height", Convert.ToInt32(heightTextBox.Text));
            cmdInsert.Parameters.AddWithValue("Cloth", clothComboBox.Text);
            cmdInsert.Parameters.AddWithValue("Trim", trimComboBox.Text);
            cmdInsert.Parameters.AddWithValue("Customer", Login);
            cmdInsert.Parameters.AddWithValue("Image", arr);
            try
            {
                if (nameTextBox.Text != "" && clothComboBox.Text != "")
                {
                    await cmdInsert.ExecuteNonQueryAsync();
                }
                else
                    MessageBox.Show("Поля 'Наименование изделия', 'Ткань' и 'Окантовка' должны быть заполнены!", "Ошибка оформления заказа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
            MessageBox.Show("Изделие создано!");
            ОбновитьToolStripMenuItem_Click(this, e);
        }

        Image[] imageArray = new Image[11];
        string[,] pictureBoxArray = new string[11, 3];
        PictureBox[] pictureBox = new PictureBox[10];
        int koef = 0;
        private async void AddFurnitureButton_Click(object sender, EventArgs e)
        {
            List<byte[]> iScreen = new List<byte[]>();
            List<string> iScreen_format = new List<string>();
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            SqlCommand selectFurnitures = new SqlCommand("SELECT [Image], [Extension] FROM [Furnitures] WHERE [Id]=@Id", sqlConnection);
            int id = Convert.ToInt32((furnitureComboBox.SelectedItem.ToString().Split(new char[] { ' ' }))[1]);
            selectFurnitures.Parameters.AddWithValue("Id", id);
            try
            {
                {
                    sdr = await selectFurnitures.ExecuteReaderAsync();
                    byte[] iTrimByte = null;
                    string iTrimText = null;
                    while (await sdr.ReadAsync())
                    {
                        iTrimByte = (byte[])sdr["Image"];
                        iScreen.Add(iTrimByte);
                        iTrimText = sdr["Extension"].ToString().TrimStart().TrimEnd();
                        iScreen_format.Add(iTrimText);
                    }
                }
                //if (sdr["Image"] != null)
                //{
                sqlConnection.Close();
                byte[] imageData = iScreen[0];
                MemoryStream ms = new MemoryStream(imageData);
                Image newImage = Image.FromStream(ms);
                //PictureBox[] pictureBox = new PictureBox[10];
                pictureBox[koef] = new System.Windows.Forms.PictureBox();
                pictureBox[koef].Location = new System.Drawing.Point(100, 100);
                //pictureBox[koef].Size = new Size(50, 50);
                //pictureBox[koef].BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox[koef].SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox[koef].Name = "pictureBox" + koef.ToString();
                pictureBox[koef].TabIndex = koef;
                pictureBox[koef].TabStop = false;
                pictureBox[koef].Image = newImage;
                this.pictureBox[koef].MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
                this.pictureBox[koef].MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
                this.pictureBox[koef].MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
                panel1.Controls.Add(pictureBox[koef]);
                pictureBox[koef].BringToFront();
                pictureBoxArray[koef, 0] = pictureBox[koef].Name;
                pictureBoxArray[koef, 1] = "0";
                pictureBoxArray[koef, 2] = "false";
                imageArray[koef] = pictureBox[koef].Image;
                koef++;
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

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            draggedPiece = sender as Control;

            for (int i = 0; i < 11; i++)
            {
                pictureBoxArray[i, 2] = "false";
                if ((sender as PictureBox).Name == pictureBoxArray[i, 0])
                {
                    pictureBoxArray[i, 2] = "true";
                    rotateTrackBar.Value = Convert.ToInt32(pictureBoxArray[i, 1]);
                    pictureBox[i].BringToFront();
                }
            }

            if ((e.X <= resizingMargin) || (e.X >= draggedPiece.Width - resizingMargin) ||
            (e.Y <= resizingMargin) || (e.Y >= draggedPiece.Height - resizingMargin))
            {
                resizing = true;

                this.Cursor = Cursors.SizeNWSE;

                this.startSize = new Size(e.X, e.Y);
            }
            else
            {
                resizing = false;
                this.Cursor = Cursors.SizeAll;
            }

            this.startDraggingPoint = e.Location;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggedPiece != null)
            {
                if (resizing)
                {
                    rectProposedSize.Width = e.X - this.startDraggingPoint.X + this.startSize.Width;
                    rectProposedSize.Height = e.Y - this.startDraggingPoint.Y + this.startSize.Height;
                    widthTextBox.Text = rectProposedSize.Width.ToString();
                    heightTextBox.Text = rectProposedSize.Height.ToString();
                    this.draggedPiece.Size = rectProposedSize.Size;
                }
                else
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
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (resizing)
            {
                if (rectProposedSize.Width > 10 && rectProposedSize.Height > 10)
                {
                    this.draggedPiece.Size = rectProposedSize.Size;
                }
                else
                {
                    this.draggedPiece.Size = new Size((int)Math.Max(10, rectProposedSize.Width), Math.Max(10, rectProposedSize.Height));
                }
            }
            this.draggedPiece = null;
            this.startDraggingPoint = Point.Empty;
            this.Cursor = Cursors.Default;
            for (int i = 0; i < 11; i++)
            {
                if ((sender as PictureBox).Name == pictureBoxArray[i, 0] && i != 10)
                {
                    pictureBox[i].Image = imageArray[i];
                    pictureBox[i].Image = RotateImage(imageArray[i], Convert.ToInt64(pictureBoxArray[i, 1]));
                }
                else if ((sender as PictureBox).Name == pictureBoxArray[i, 0] && i == 10)
                {
                    goodSchemePictureBox.Image = imageArray[i];
                    goodSchemePictureBox.Image = RotateImage(imageArray[i], Convert.ToInt64(pictureBoxArray[i, 1]));
                }
            }
        }

        /// <summary>
        /// Функция изменения угла изображения.
        /// </summary>
        /// <param name="img"></param>
        /// <param name="rotationAngle"></param>
        /// <returns></returns>
        private static Image RotateImage(Image img, float rotationAngle)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            Graphics gfx = Graphics.FromImage(bmp);
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
            gfx.RotateTransform(rotationAngle);
            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
            gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gfx.DrawImage(img, new Point(0, 0));
            gfx.Dispose();
            return bmp;
        }

        private void RotateTrackBar_Scroll(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                if (pictureBoxArray[i, 2] == "true" && i != 10)
                {
                    pictureBox[i].Image = RotateImage(imageArray[i], rotateTrackBar.Value);

                }
                else if (pictureBoxArray[i, 2] == "true" && i == 10)
                    goodSchemePictureBox.Image = RotateImage(imageArray[i], rotateTrackBar.Value);
            }
        }

        private void AddPrintButtom_Click(object sender, EventArgs e)
        {
            Bitmap image;
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    goodSchemePictureBox.Image = image;
                    goodSchemePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    goodSchemePictureBox.Invalidate();
                    imageArray[10] = goodSchemePictureBox.Image;
                    pictureBoxArray[10, 0] = goodSchemePictureBox.Name;
                    pictureBoxArray[10, 1] = "0";
                    pictureBoxArray[10, 2] = "false";
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        Control draggedPiece = null;
        bool resizing = false;
        private Point startDraggingPoint;
        private Size startSize;
        Rectangle rectProposedSize = Rectangle.Empty;
        int resizingMargin = 5;

        private void GoodSchemePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            draggedPiece = sender as Control;
            for (int i = 0; i < 11; i++)
            {
                pictureBoxArray[i, 2] = "false";
                if ((sender as PictureBox).Name == pictureBoxArray[i, 0])
                {
                    pictureBoxArray[i, 2] = "true";
                    rotateTrackBar.Value = Convert.ToInt32(pictureBoxArray[i, 1]);
                }
            }
            if ((e.X <= resizingMargin) || (e.X >= draggedPiece.Width - resizingMargin) ||
            (e.Y <= resizingMargin) || (e.Y >= draggedPiece.Height - resizingMargin))
            {
                resizing = true;

                this.Cursor = Cursors.SizeNWSE;

                this.startSize = new Size(e.X, e.Y);
            }
            else
            {
                resizing = false;
                this.Cursor = Cursors.SizeAll;
            }

            this.startDraggingPoint = e.Location;
        }

        private void GoodSchemePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggedPiece != null)
            {
                if (resizing)
                {
                    rectProposedSize.Width = e.X - this.startDraggingPoint.X + this.startSize.Width;
                    rectProposedSize.Height = e.Y - this.startDraggingPoint.Y + this.startSize.Height;
                    widthTextBox.Text = rectProposedSize.Width.ToString();
                    heightTextBox.Text = rectProposedSize.Height.ToString();
                    this.draggedPiece.Size = rectProposedSize.Size;
                }
                else
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
        }

        private void GoodSchemePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (resizing)
            {
                if (rectProposedSize.Width > 10 && rectProposedSize.Height > 10)
                {
                    this.draggedPiece.Size = rectProposedSize.Size;
                }
                else
                {
                    this.draggedPiece.Size = new Size((int)Math.Max(10, rectProposedSize.Width), Math.Max(10, rectProposedSize.Height));
                }
            }
            this.draggedPiece = null;
            this.startDraggingPoint = Point.Empty;
            this.Cursor = Cursors.Default;
            for (int i = 0; i < 11; i++)
            {
                if ((sender as PictureBox).Name == pictureBoxArray[i, 0] && i != 10)
                {
                    pictureBox[i].Image = imageArray[i];
                    pictureBox[i].Image = RotateImage(imageArray[i], Convert.ToInt64(pictureBoxArray[i, 1]));
                }
                else if ((sender as PictureBox).Name == pictureBoxArray[i, 0] && i == 10)
                {
                    goodSchemePictureBox.Image = imageArray[i];
                    goodSchemePictureBox.Image = RotateImage(imageArray[i], Convert.ToInt64(pictureBoxArray[i, 1]));
                }
            }
        }

        private void RotateTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                if (pictureBoxArray[i, 2] == "true")
                {
                    pictureBoxArray[i, 1] = rotateTrackBar.Value.ToString();
                }
            }
        }

        private async void MyGoodsListBox_MouseClick(object sender, MouseEventArgs e)
        {
            List<byte[]> iScreen = new List<byte[]>();
            List<string> iScreen_format = new List<string>();
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            SqlCommand selectFurnitures = new SqlCommand("SELECT [Image] FROM [CustomerGoods] WHERE [Id]=@Id", sqlConnection);
            int id = Convert.ToInt32((myGoodsListBox.SelectedItem.ToString().Split(new char[] { ' ' }))[1]);
            selectFurnitures.Parameters.AddWithValue("Id", id);
            try
            {
                {
                    sdr = await selectFurnitures.ExecuteReaderAsync();
                    byte[] iTrimByte = null;
                    while (await sdr.ReadAsync())
                    {
                        iTrimByte = (byte[])sdr["Image"];
                        iScreen.Add(iTrimByte);
                    }
                }
                //if (sdr["Image"] != null)
                //{
                sqlConnection.Close();
                byte[] imageData = iScreen[0];
                MemoryStream ms = new MemoryStream(imageData);
                Image newImage = Image.FromStream(ms);
                myGoodPictureBox.Image = newImage;
                myGoodPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                myGoodPictureBox.Invalidate();
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

        private void DeleteFurnitureButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
                if (pictureBoxArray[i, 2] == "true")
                    pictureBox[i].Dispose();
        }

        private void DeletePrintButton_Click(object sender, EventArgs e)
        {
            goodSchemePictureBox.Image = null;
            imageArray[10] = null;
            pictureBoxArray[10, 1] = "0";
        }

        private async void DeleteMyGoodButton_Click(object sender, EventArgs e)
        {
            if (myGoodsListBox.SelectedIndex != -1)
            {
                sqlConnection = new SqlConnection(connectionPathMain);
                SqlCommand cmdUpdate = new SqlCommand("UPDATE [CustomerGoods] SET [Status]=@Status WHERE [Id]=@Id", sqlConnection);
                int id = Convert.ToInt32((myGoodsListBox.SelectedItem.ToString().Split(new char[] { ' ' }))[1]);
                cmdUpdate.Parameters.AddWithValue("Id", id);
                cmdUpdate.Parameters.AddWithValue("Status", false);
                await sqlConnection.OpenAsync();
                await cmdUpdate.ExecuteNonQueryAsync();
                sqlConnection.Close();
                ОбновитьToolStripMenuItem_Click(this, e);
            }
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
            this.Hide();
        }
    }
}
