using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineeringDesign
{
    public partial class ManagerForm : Template
    {
        bool deny = false;
        int qtyRoll = 0;


        public ManagerForm()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void ManagerForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            SqlDataReader sdr;
            SqlCommand selectGoods = new SqlCommand("SELECT * FROM [Goods]", sqlConnection);
            SqlCommand selectOrders = new SqlCommand("SELECT * FROM [Orders]", sqlConnection);
            SqlCommand selectClothes = new SqlCommand("SELECT * FROM [ClothesStorage]", sqlConnection);
            try
            {
                sdr = await selectGoods.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    if (Convert.ToString(sdr["Status"]) == "True")
                        goodsList.Items.Add(Convert.ToString(sdr["Id"]) + "    " + Convert.ToString(sdr["Name"]) + "    " + Convert.ToString(sdr["Width"]) + "    " + Convert.ToString(sdr["Height"]) + "    " + Convert.ToString(sdr["Cloth"]) + "    " + Convert.ToString(sdr["Trim"]) + "    " + Convert.ToString(sdr["Furniture"]));
                }
                sdr.Close();
                sdr = await selectOrders.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    if (!deny)
                    {
                        if (Convert.ToString(sdr["Manager"]) == Login && Convert.ToString(sdr["Status"]) != "Новый")
                            orderList.Items.Add("Номер заказа: " + Convert.ToString(sdr["id"]) + " Время заказа: " + Convert.ToString(sdr["Date"]) + " Заказ: " + Convert.ToString(sdr["Sum"]) + " Менеджер заказа: " + Convert.ToString(sdr["Manager"]) + " Статус заказа: " + Convert.ToString(sdr["Status"]));
                        else if (Convert.ToString(sdr["Manager"]) == "" && Convert.ToString(sdr["Status"]) != "Новый")
                            orderList.Items.Add("Номер заказа: " + Convert.ToString(sdr["id"]) + " Время заказа: " + Convert.ToString(sdr["Date"]) + " Статус заказа: " + Convert.ToString(sdr["Status"]));
                    }
                    else
                    {
                        if (Convert.ToString(sdr["Manager"]) == Login && Convert.ToString(sdr["Status"]) != "Новый" && Convert.ToString(sdr["Status"]) != "Отклонён")
                            orderList.Items.Add("Номер заказа: " + Convert.ToString(sdr["id"]) + " Время заказа: " + Convert.ToString(sdr["Date"]) + " Заказ: " + Convert.ToString(sdr["Sum"]) + " Менеджер заказа: " + Convert.ToString(sdr["Manager"]) + " Статус заказа: " + Convert.ToString(sdr["Status"]));
                        else if (Convert.ToString(sdr["Manager"]) == "" && Convert.ToString(sdr["Status"]) != "Новый" && Convert.ToString(sdr["Status"]) != "Отклонён")
                            orderList.Items.Add("Номер заказа: " + Convert.ToString(sdr["id"]) + " Время заказа: " + Convert.ToString(sdr["Date"]) + " Статус заказа: " + Convert.ToString(sdr["Status"]));
                    }
                }
                sdr.Close();
                sdr = await selectClothes.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    clothesStorage.Items.Add("Артикул: " + Convert.ToString(sdr["Id"]) + "; Наименование: " + Convert.ToString(sdr["Name"]) + "; Широта: " + Convert.ToString(sdr["Width"]) + "; Долгота: " + Convert.ToString(sdr["Height"]));
                    qtyRoll++;
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
            comboBoxCloth.Items.Clear();
            clothInStorage.Items.Clear();
            comboBoxFurniture.Items.Clear();
            for (int i = 0; i < DS.Tables["Clothes"].Rows.Count; i++)
            {
                comboBoxCloth.Items.Add(DS.Tables["Clothes"].Rows[i][1].ToString());
                clothInStorage.Items.Add(DS.Tables["Clothes"].Rows[i][1].ToString());
            }
            for (int i = 0; i < DS.Tables["Furnitures"].Rows.Count; i++)
                comboBoxFurniture.Items.Add(DS.Tables["Furnitures"].Rows[i][1].ToString());
            loginLabel.Text += $"{Login}.";
            sqlConnection.Close();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (goodsList.SelectedIndex != -1)
            {
                sqlConnection = new SqlConnection(connectionPathMain);
                await sqlConnection.OpenAsync();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE [Goods] SET [Status]=0 WHERE [Id]=@Id", sqlConnection);
                int id = Convert.ToInt32((goodsList.SelectedItem.ToString().Split(new char[] { ' ' }))[0]); //Мегаважно для удаления из листа по ID
                cmdUpdate.Parameters.AddWithValue("Id", id);
                await cmdUpdate.ExecuteNonQueryAsync();
                goodsList.Items.RemoveAt(goodsList.SelectedIndex);
                sqlConnection.Close();
            }
            else
                MessageBox.Show("Выберите элемент!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ОбновитьToolStripMenuItem_Click(this, e);
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            SqlDataReader sdr;
            SqlCommand checkId = new SqlCommand("SELECT * FROM [Goods]", sqlConnection);
            SqlCommand cmdInsert = new SqlCommand("INSERT INTO [Goods] (Id, Name, Width, Height, Cloth, Trim, Furniture)VALUES(@Id, @Name, @Width, @Height, @Cloth, @Trim, @Furniture)", sqlConnection);
            sdr = await checkId.ExecuteReaderAsync();
            int id = 0;
            while (await sdr.ReadAsync())
            {
                id++;
            }
            sdr.Close();
            cmdInsert.Parameters.AddWithValue("Id", id + 1);
            cmdInsert.Parameters.AddWithValue("Name", textBoxName.Text);
            cmdInsert.Parameters.AddWithValue("Width", textBoxWidth.Text);
            cmdInsert.Parameters.AddWithValue("Height", textBoxHeight.Text);
            cmdInsert.Parameters.AddWithValue("Cloth", comboBoxCloth.Text);
            cmdInsert.Parameters.AddWithValue("Trim", textBoxTrim.Text);
            cmdInsert.Parameters.AddWithValue("Furniture", comboBoxFurniture.Text);
            try
            {
                if (Convert.ToInt32(textBoxWidth.Text) > 0 && IsDigits(textBoxWidth.Text) && Convert.ToInt32(textBoxHeight.Text) > 0 && IsDigits(textBoxHeight.Text) && textBoxName.Text != "" && comboBoxCloth.Text != "" && textBoxTrim.Text != "" && comboBoxFurniture.Text != "")
                {
                    await cmdInsert.ExecuteNonQueryAsync();
                }
                else
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlConnection.Close();
            MessageBox.Show("Изделие добавлено в базу данных.");
            ОбновитьToolStripMenuItem_Click(this, e);
        }

        /// <summary>
        /// Проверка текста, число ли это.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
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

        private void ОбновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goodsList.Items.Clear();
            orderList.Items.Clear();
            clothesStorage.Items.Clear();
            orderList.SelectedIndex = -1;
            clothesStorage.SelectedIndex = -1;
            goodsList.SelectedIndex = -1;
            addManagerButton.Visible = false;
            denyButton.Visible = false;
            toCuttingButton.Visible = false;
            loginLabel.Text = "Вы зашли под логином ";
            ManagerForm_Load(this, e);
        }

        private void ВыйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
            this.Hide();
        }

        private async void OrderList_MouseClick(object sender, MouseEventArgs e)
        {
            if (orderList.SelectedIndex != -1)
            {
                string id = (orderList.SelectedItem.ToString().Split(new char[] { ' ' }))[2];
                string status = "";
                string connectionPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Desktop\Учёба\3 курс\1 семестр\Сетевое программирование\Session\Session\Database.mdf;Integrated Security=True";
                sqlConnection = new SqlConnection(connectionPath);
                await sqlConnection.OpenAsync();
                SqlDataReader sdr;
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
                    case "Ожидает":
                        addManagerButton.Text = "Стать менеджером заказа";
                        addManagerButton.Visible = true;
                        denyButton.Visible = false;
                        toCuttingButton.Visible = false;
                        break;
                    case "Обработка":
                        addManagerButton.Text = "Подтвердить заказ";
                        addManagerButton.Visible = true;
                        denyButton.Visible = true;
                        toCuttingButton.Visible = false;
                        break;
                    case "Отклонён":
                        addManagerButton.Visible = false;
                        denyButton.Visible = false;
                        toCuttingButton.Visible = false;
                        break;
                    case "К оплате":
                        addManagerButton.Visible = false;
                        denyButton.Visible = false;
                        toCuttingButton.Visible = false;
                        break;
                    case "Оплачен":
                        addManagerButton.Text = "Отправить на раскрой";
                        addManagerButton.Visible = true;
                        denyButton.Visible = false;
                        toCuttingButton.Visible = false;
                        break;
                    case "Раскрой":
                        addManagerButton.Visible = false;
                        denyButton.Visible = false;
                        toCuttingButton.Visible = true;
                        break;
                    case "Готов":
                        addManagerButton.Visible = false;
                        denyButton.Visible = false;
                        toCuttingButton.Visible = false;
                        break;
                }
            }
        }

        private async void AddManagerButton_Click(object sender, EventArgs e)
        {
            if (addManagerButton.Text == "Стать менеджером заказа")
            {
                sqlConnection = new SqlConnection(connectionPathMain);
                await sqlConnection.OpenAsync();
                SqlCommand cmdUpdateStatus = new SqlCommand("UPDATE [Orders] SET [Status]=@Status WHERE [Id]=@Id", sqlConnection);
                SqlCommand cmdUpdateManager = new SqlCommand("UPDATE [Orders] SET [Manager]=@Manager WHERE [Id]=@Id", sqlConnection);
                cmdUpdateStatus.Parameters.AddWithValue("Id", (orderList.SelectedItem.ToString().Split(new char[] { ' ' }))[2]);
                cmdUpdateStatus.Parameters.AddWithValue("Status", "Обработка");
                cmdUpdateManager.Parameters.AddWithValue("Id", (orderList.SelectedItem.ToString().Split(new char[] { ' ' }))[2]);
                cmdUpdateManager.Parameters.AddWithValue("Manager", Login);
                await cmdUpdateStatus.ExecuteNonQueryAsync();
                await cmdUpdateManager.ExecuteNonQueryAsync();
                sqlConnection.Close();
                MessageBox.Show("Вы стали менеджером заказа.");
            }
            else if (addManagerButton.Text == "Подтвердить заказ")
            {
                sqlConnection = new SqlConnection(connectionPathMain);
                await sqlConnection.OpenAsync();
                SqlCommand cmdUpdateStatus = new SqlCommand("UPDATE [Orders] SET [Status]=@Status WHERE [Id]=@Id", sqlConnection);
                cmdUpdateStatus.Parameters.AddWithValue("Id", (orderList.SelectedItem.ToString().Split(new char[] { ' ' }))[2]);
                cmdUpdateStatus.Parameters.AddWithValue("Status", "К оплате");
                await cmdUpdateStatus.ExecuteNonQueryAsync();
                sqlConnection.Close();
                MessageBox.Show("Заказ подтверждён.");
            }
            else if (addManagerButton.Text == "Отправить на раскрой")
            {
                sqlConnection = new SqlConnection(connectionPathMain);
                await sqlConnection.OpenAsync();
                SqlCommand cmdUpdateStatus = new SqlCommand("UPDATE [Orders] SET [Status]=@Status WHERE [Id]=@Id", sqlConnection);
                cmdUpdateStatus.Parameters.AddWithValue("Id", (orderList.SelectedItem.ToString().Split(new char[] { ' ' }))[2]);
                cmdUpdateStatus.Parameters.AddWithValue("Status", "Раскрой");
                await cmdUpdateStatus.ExecuteNonQueryAsync();
                sqlConnection.Close();
                MessageBox.Show("Заказ отправлен на раскрой.");
            }
            ОбновитьToolStripMenuItem_Click(this, e);
        }

        private async void DenyButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            SqlCommand cmdUpdateStatus = new SqlCommand("UPDATE [Orders] SET [Status]=@Status WHERE [Id]=@Id", sqlConnection);
            SqlCommand cmdUpdateManager = new SqlCommand("UPDATE [Orders] SET [Manager]=@Manager WHERE [Id]=@Id", sqlConnection);
            cmdUpdateStatus.Parameters.AddWithValue("Id", (orderList.SelectedItem.ToString().Split(new char[] { ' ' }))[2]);
            cmdUpdateStatus.Parameters.AddWithValue("Status", "Отклонён");
            cmdUpdateManager.Parameters.AddWithValue("Id", (orderList.SelectedItem.ToString().Split(new char[] { ' ' }))[2]);
            cmdUpdateManager.Parameters.AddWithValue("Manager", Login);
            await cmdUpdateStatus.ExecuteNonQueryAsync();
            await cmdUpdateManager.ExecuteNonQueryAsync();
            sqlConnection.Close();
            MessageBox.Show("Заказ отклонён.");
            ОбновитьToolStripMenuItem_Click(this, e);
        }

        private void DenyFilter_CheckedChanged(object sender, EventArgs e)
        {
            deny = !deny;
            ОбновитьToolStripMenuItem_Click(this, e);
        }

        private async void OrderClothes_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            SqlDataReader sdr;
            SqlCommand checkId = new SqlCommand("SELECT * FROM [ClothesStorage]", sqlConnection);
            SqlCommand cmdInsert = new SqlCommand("INSERT INTO [ClothesStorage] (Id, Name, Width, Height)VALUES(@Id, @Name, @Width, @Height)", sqlConnection);
            if (Convert.ToInt32(qtyCloth.Text) > 0 && IsDigits(qtyCloth.Text))
            {
                for (int i = 0; i < Convert.ToInt32(qtyCloth.Text); i++)
                {
                    sdr = await checkId.ExecuteReaderAsync();
                    int id = 0;
                    while (await sdr.ReadAsync())
                    {
                        id++;
                    }
                    sdr.Close();
                    cmdInsert.Parameters.AddWithValue("Id", id + 1);
                    cmdInsert.Parameters.AddWithValue("Name", clothInStorage.Text);
                    cmdInsert.Parameters.AddWithValue("Width", widthCloth.Text);
                    cmdInsert.Parameters.AddWithValue("Height", heightCloth.Text);
                    try
                    {
                        if (Convert.ToInt32(widthCloth.Text) > 0 && IsDigits(widthCloth.Text) && Convert.ToInt32(heightCloth.Text) > 0 && IsDigits(heightCloth.Text) && clothInStorage.Text != "")
                        {
                            await cmdInsert.ExecuteNonQueryAsync();
                        }
                        else
                        {
                            MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Некорректное количество!");
            sqlConnection.Close();
            MessageBox.Show("Ткань доставлена на склад.");
            ОбновитьToolStripMenuItem_Click(this, e);
        }
        string[] goods; //Список айдишников товаров
        string[] clothes; //Список нужных тканей
        int[] qty; //Количество каждого разного вида заказанного товара
        string[,] clothesArray;
        string id;
        private async void ToCuttingButton_Click(object sender, EventArgs e)
        {
            if (orderList.SelectedIndex != -1)
            {
                smallPictureBox.Visible = false;
                bigPictureBox.Visible = false;
                cuttingGoodsComboBox.Items.Clear();
                cuttingClothComboBox.Items.Clear();
                tabControl1.SelectedIndex = 3;
                id = (orderList.SelectedItem.ToString().Split(new char[] { ' ' }))[2]; //ID заказа
                string order = ""; //Переменная для вписывания самого заказа из всего текста информации про заказ
                orderLabel.Text = $"Вы работаете с заказом №{id}.";
                sqlConnection = new SqlConnection(connectionPathMain);
                await sqlConnection.OpenAsync();
                SqlDataReader sdr;
                SqlCommand selectOrders = new SqlCommand("SELECT * FROM [Orders] WHERE (Id=@Id)", sqlConnection);
                SqlCommand selectClothes = new SqlCommand("SELECT * FROM [ClothesStorage]", sqlConnection);
                selectOrders.Parameters.AddWithValue("Id", id);
                sdr = await selectOrders.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    order = Convert.ToString(sdr["Sum"]);
                }
                sdr.Close();
                string[] orders = order.Split(new char[] { ';' }); //Разделил весь список товаров в заказе на массив отдельных конкретных объектов, кстати общая сумма всех заказанных товаров равна длине этого массива -1, так как напортачил с оформлением текста в заказе
                qty = new int[orders.Length - 1];
                goods = new string[orders.Length - 1];
                clothes = new string[orders.Length - 1];
                int qtySum = 0;
                for (int i = 0; i < (orders.Length - 1); i++)
                {
                    SqlCommand selectGoods = new SqlCommand($"SELECT * FROM [Goods] WHERE (Id=@GoodId{i})", sqlConnection);
                    qty[i] = Convert.ToInt32((orders[i].Split(new char[] { ' ' }))[2]);
                    qtySum += qty[i];
                    goods[i] = (orders[i].Split(new char[] { ' ' }))[1];
                    selectGoods.Parameters.AddWithValue($"GoodId{i}", goods[i]);
                    sdr = await selectGoods.ExecuteReaderAsync();
                    while (await sdr.ReadAsync())
                    {
                        clothes[i] = Convert.ToString(sdr["Cloth"]);
                        for (int j = 0; j < qty[i]; j++)
                            cuttingGoodsComboBox.Items.Add($"{sdr["Name"]} {goods[i]}");
                    }
                    sdr.Close();
                }
                clothes = clothes.Distinct().ToArray();
                clothesArray = new string[clothes.Length * qtySum * qtyRoll, 4];
                Array.Clear(clothesArray, 0, clothesArray.Length);
                int k = 0;
                for (int i = 0; i < clothes.Length; i++)
                {
                    sdr = await selectClothes.ExecuteReaderAsync();
                    while (await sdr.ReadAsync())
                    {
                        if (Convert.ToString(sdr["Name"]) == clothes[i])
                        {
                            //cuttingClothComboBox.Items.Add($"{Convert.ToString(sdr["Name"])} {Convert.ToString(sdr["Id"])}");
                            clothesArray[k, 0] = Convert.ToString(sdr["Id"]);
                            clothesArray[k, 1] = Convert.ToString(sdr["Width"]);
                            clothesArray[k, 2] = Convert.ToString(sdr["Height"]);
                            clothesArray[k, 3] = Convert.ToString(sdr["Name"]);
                            k++;
                        }
                    }
                    sdr.Close();
                }
                sqlConnection.Close();
                ОбновитьToolStripMenuItem_Click(this, e);
            }
        }

        private async void CuttingGoodsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            cuttingClothComboBox.Items.Clear();
            int widthSelectedCloth = bigPictureBox.Width;
            int heightSelectedCloth = bigPictureBox.Height;
            smallPictureBox.Visible = true;
            smallPictureBox.Location = new Point(0, 0);
            string selectedGoodId = (cuttingGoodsComboBox.Items[Convert.ToInt32(cuttingGoodsComboBox.SelectedIndex)].ToString()).Split(new char[] { ' ' })[1];
            await sqlConnection.OpenAsync();
            SqlDataReader sdr;
            SqlCommand selectedGood = new SqlCommand("SELECT * FROM [Goods] WHERE (Id=@Id)", sqlConnection);
            selectedGood.Parameters.AddWithValue("Id", selectedGoodId);
            string widthSelectedGood = "";
            string heightSelectedGood = "";
            sdr = await selectedGood.ExecuteReaderAsync();
            while (await sdr.ReadAsync())
            {
                widthSelectedGood = Convert.ToString(sdr["Width"]);
                heightSelectedGood = Convert.ToString(sdr["Height"]);
            }
            sdr.Close();
            //int k = 0;
            for (int i = 0; i < (clothesArray.Length / 4); i++)
            {
                sdr = await selectedGood.ExecuteReaderAsync();
                while (await sdr.ReadAsync())
                {
                    if (Convert.ToString(sdr["Cloth"]) == clothesArray[i, 3])
                    {
                        cuttingClothComboBox.Items.Add($"{Convert.ToString(sdr["Cloth"])} {clothesArray[i, 0]}");
                        /*clothesArray[k, 3] = Convert.ToInt32(sdr["Id"]);
                        k++;*/
                    }
                }
                sdr.Close();
            }
            sqlConnection.Close();
            smallPictureBox.Width = Convert.ToInt32(widthSelectedGood);
            smallPictureBox.Height = Convert.ToInt32(heightSelectedGood);
            if (CheckSize(Convert.ToInt32(widthSelectedGood), Convert.ToInt32(heightSelectedGood), widthSelectedCloth, heightSelectedCloth) && bigPictureBox.Visible == true)
            {
                if (Convert.ToInt32(widthSelectedGood) <= widthSelectedCloth && Convert.ToInt32(heightSelectedGood) <= heightSelectedCloth && Convert.ToInt32(widthSelectedGood) <= heightSelectedCloth && Convert.ToInt32(heightSelectedGood) <= widthSelectedCloth)
                {
                    if ((widthSelectedCloth - Convert.ToInt32(widthSelectedGood)) > (heightSelectedCloth - Convert.ToInt32(heightSelectedGood)))
                    {
                        smallPictureBox.Width = Convert.ToInt32(heightSelectedGood);
                        smallPictureBox.Height = Convert.ToInt32(widthSelectedGood);
                        cuttingGoodButton.Visible = true;
                    }
                    else
                    {
                        smallPictureBox.Width = Convert.ToInt32(widthSelectedGood);
                        smallPictureBox.Height = Convert.ToInt32(heightSelectedGood);
                        cuttingGoodButton.Visible = true;
                    }
                }
                else if (Convert.ToInt32(widthSelectedGood) <= widthSelectedCloth && Convert.ToInt32(heightSelectedGood) <= heightSelectedCloth)
                {
                    smallPictureBox.Width = Convert.ToInt32(widthSelectedGood);
                    smallPictureBox.Height = Convert.ToInt32(heightSelectedGood);
                    cuttingGoodButton.Visible = true;
                }
                else if (Convert.ToInt32(widthSelectedGood) <= heightSelectedCloth && Convert.ToInt32(heightSelectedGood) <= widthSelectedCloth)
                {
                    smallPictureBox.Width = Convert.ToInt32(heightSelectedGood);
                    smallPictureBox.Height = Convert.ToInt32(widthSelectedGood);
                    cuttingGoodButton.Visible = true;
                }
                else
                {
                    MessageBox.Show("Данный рулон меньше товара! Выберите другой рулон.");
                    cuttingGoodButton.Visible = false;
                    bigPictureBox.Visible = false;
                }
            }
        }

        private void CuttingClothComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            int widthSelectedGood = smallPictureBox.Width;
            int heightSelectedGood = smallPictureBox.Height;
            bigPictureBox.Visible = true;
            bigPictureBox.Location = new Point(0, 0);
            //string selectedClothId = (cuttingClothComboBox.Items[Convert.ToInt32(cuttingClothComboBox.SelectedIndex)].ToString()).Split(new char[] { ' ' })[1];
            int selectedClothId = Convert.ToInt32(clothesArray[cuttingClothComboBox.SelectedIndex, 0]);
            //await sqlConnection.OpenAsync();
            //SqlDataReader sdr;
            //SqlCommand selectedGood = new SqlCommand("SELECT * FROM [ClothesStorage] WHERE (Id=@Id)", sqlConnection);
            //selectedGood.Parameters.AddWithValue("Id", selectedClothId);
            //string widthSelectedCloth = "";
            //string heightSelectedCloth = "";
            int widthSelectedCloth = Convert.ToInt32(clothesArray[cuttingClothComboBox.SelectedIndex, 1]);
            int heightSelectedCloth = Convert.ToInt32(clothesArray[cuttingClothComboBox.SelectedIndex, 2]);
            /*sdr = await selectedGood.ExecuteReaderAsync();
            while (await sdr.ReadAsync())
            {
                widthSelectedCloth = Convert.ToString(sdr["Width"]);
                heightSelectedCloth = Convert.ToString(sdr["Height"]);
            }
            sdr.Close();*/
            //sqlConnection.Close();
            if (CheckSize(widthSelectedGood, heightSelectedGood, Convert.ToInt32(widthSelectedCloth), Convert.ToInt32(heightSelectedCloth)) && smallPictureBox.Visible == true)
            {
                bigPictureBox.Width = Convert.ToInt32(widthSelectedCloth);
                bigPictureBox.Height = Convert.ToInt32(heightSelectedCloth);
                if (widthSelectedGood <= Convert.ToInt32(widthSelectedCloth) && heightSelectedGood <= Convert.ToInt32(heightSelectedCloth) && widthSelectedGood <= Convert.ToInt32(heightSelectedCloth) && heightSelectedGood <= Convert.ToInt32(widthSelectedCloth))
                {
                    if ((bigPictureBox.Width - widthSelectedGood) > (bigPictureBox.Height - heightSelectedGood))
                    {
                        /*if ((bigPictureBox.Height - widthSelectedGood) < (bigPictureBox.Height - heightSelectedGood))
                        {*/
                        smallPictureBox.Width = Convert.ToInt32(widthSelectedGood);
                        smallPictureBox.Height = Convert.ToInt32(heightSelectedGood);
                        cuttingGoodButton.Visible = true;
                        /*}
                        else
                        {
                            smallPictureBox.Width = Convert.ToInt32(heightSelectedGood);
                            smallPictureBox.Height = Convert.ToInt32(widthSelectedGood);
                        }*/
                    }
                    else
                    {
                        /* if ((bigPictureBox.Width - widthSelectedGood) < (bigPictureBox.Width - heightSelectedGood))
                         {
                             smallPictureBox.Width = Convert.ToInt32(widthSelectedGood);
                             smallPictureBox.Height = Convert.ToInt32(heightSelectedGood);
                         }
                         else
                         {*/
                        smallPictureBox.Width = Convert.ToInt32(heightSelectedGood);
                        smallPictureBox.Height = Convert.ToInt32(widthSelectedGood);
                        cuttingGoodButton.Visible = true;
                        //}
                    }
                }
                else if (widthSelectedGood <= bigPictureBox.Width && heightSelectedGood <= bigPictureBox.Height)
                {
                    smallPictureBox.Width = Convert.ToInt32(widthSelectedGood);
                    smallPictureBox.Height = Convert.ToInt32(heightSelectedGood);
                    cuttingGoodButton.Visible = true;
                }
                else if (widthSelectedGood <= bigPictureBox.Height && heightSelectedGood <= bigPictureBox.Width)
                {
                    smallPictureBox.Width = Convert.ToInt32(heightSelectedGood);
                    smallPictureBox.Height = Convert.ToInt32(widthSelectedGood);
                    cuttingGoodButton.Visible = true;
                }
                else
                {
                    MessageBox.Show("Данный рулон меньше товара! Выберите другой рулон.");
                    cuttingGoodButton.Visible = false;
                    bigPictureBox.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Данный рулон меньше товара! Выберите другой рулон.");
                bigPictureBox.Visible = false;
            }
        }
        public bool CheckSize(int smallWidth, int smallHeight, int bigWidth, int bigHeight)
        {
            if (smallHeight <= bigHeight && smallWidth <= bigWidth || smallHeight <= bigWidth && smallWidth <= bigHeight)
                return true;
            else return false;
        }

        private void CuttingGoodButton_Click(object sender, EventArgs e)
        {
            if (smallPictureBox.Visible == true && bigPictureBox.Visible == true)
            {
                cuttingGoodsList.Items.Add($"{cuttingGoodsComboBox.Items[cuttingGoodsComboBox.SelectedIndex]} {cuttingClothComboBox.Items[cuttingClothComboBox.SelectedIndex]} {smallPictureBox.Width} {smallPictureBox.Height}");
                cuttingGoodsComboBox.Items.RemoveAt(cuttingGoodsComboBox.SelectedIndex);
                if (smallPictureBox.Width < smallPictureBox.Height)
                {
                    clothesArray[cuttingClothComboBox.SelectedIndex, 1] = Convert.ToString(Convert.ToInt32(clothesArray[cuttingClothComboBox.SelectedIndex, 1]) - smallPictureBox.Width);
                }
                else
                {
                    clothesArray[cuttingClothComboBox.SelectedIndex, 1] = Convert.ToString(Convert.ToInt32(clothesArray[cuttingClothComboBox.SelectedIndex, 1]) - smallPictureBox.Height);
                }
            }
            bigPictureBox.Visible = false;
            smallPictureBox.Visible = false;
            if (cuttingGoodsComboBox.Items.Count == 0)
            {
                readyButton.Visible = true;
            }
        }

        private async void ReadyButton_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionPathMain);
            await sqlConnection.OpenAsync();
            for (int i = 0; i < (clothesArray.Length / 4); i++)
            {
                if (clothesArray[i, 0] != null)
                {
                    SqlCommand cmdUpdateWidth = new SqlCommand($"UPDATE [ClothesStorage] SET [Width]=@Width{i} WHERE [Id]=@Id{i}", sqlConnection);
                    SqlCommand cmdUpdateHeight = new SqlCommand($"UPDATE [ClothesStorage] SET [Height]=@Height{i} WHERE [Id]=@Id{i}", sqlConnection);
                    cmdUpdateWidth.Parameters.AddWithValue($"Id{i}", clothesArray[i, 0]);
                    cmdUpdateHeight.Parameters.AddWithValue($"Id{i}", clothesArray[i, 0]);
                    cmdUpdateWidth.Parameters.AddWithValue($"Width{i}", clothesArray[i, 1]);
                    cmdUpdateHeight.Parameters.AddWithValue($"Height{i}", clothesArray[i, 2]);
                    await cmdUpdateWidth.ExecuteNonQueryAsync();
                    await cmdUpdateHeight.ExecuteNonQueryAsync();
                }
            }
            SqlCommand cmdUpdateStatus = new SqlCommand($"UPDATE [Orders] SET [Status]=@Status WHERE [Id]=@Id", sqlConnection);
            cmdUpdateStatus.Parameters.AddWithValue("Id", Convert.ToInt32(id));
            cmdUpdateStatus.Parameters.AddWithValue("Status", "Готов");
            await cmdUpdateStatus.ExecuteNonQueryAsync();
            sqlConnection.Close();
            MessageBox.Show("Заказ готов.");
            ОбновитьToolStripMenuItem_Click(this, e);
        }
    }
}
