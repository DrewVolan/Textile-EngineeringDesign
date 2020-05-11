namespace EngineeringDesign
{
    partial class ManagerForm
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
            this.goodsList = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxTrim = new System.Windows.Forms.TextBox();
            this.comboBoxFurniture = new System.Windows.Forms.ComboBox();
            this.comboBoxCloth = new System.Windows.Forms.ComboBox();
            this.labelFurniture = new System.Windows.Forms.Label();
            this.labelTrim = new System.Windows.Forms.Label();
            this.labelCloth = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toCuttingButton = new System.Windows.Forms.Button();
            this.denyFilter = new System.Windows.Forms.CheckBox();
            this.denyButton = new System.Windows.Forms.Button();
            this.addManagerButton = new System.Windows.Forms.Button();
            this.orderList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.orderClothes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qtyCloth = new System.Windows.Forms.TextBox();
            this.clothInStorage = new System.Windows.Forms.ComboBox();
            this.widthCloth = new System.Windows.Forms.TextBox();
            this.heightCloth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clothesStorage = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.readyButton = new System.Windows.Forms.Button();
            this.cuttingGoodButton = new System.Windows.Forms.Button();
            this.cuttingGoodsList = new System.Windows.Forms.ListBox();
            this.cuttingClothComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.smallPictureBox = new System.Windows.Forms.PictureBox();
            this.bigPictureBox = new System.Windows.Forms.PictureBox();
            this.cuttingGoodsComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smallPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsList
            // 
            this.goodsList.FormattingEnabled = true;
            this.goodsList.Location = new System.Drawing.Point(6, 27);
            this.goodsList.Name = "goodsList";
            this.goodsList.Size = new System.Drawing.Size(776, 225);
            this.goodsList.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(707, 389);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(47, 391);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 16;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(47, 339);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 15;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(47, 282);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 14;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(6, 394);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 13;
            this.labelHeight.Text = "Height";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(6, 342);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 12;
            this.labelWidth.Text = "Width";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 285);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name";
            // 
            // textBoxTrim
            // 
            this.textBoxTrim.Location = new System.Drawing.Point(266, 339);
            this.textBoxTrim.Name = "textBoxTrim";
            this.textBoxTrim.Size = new System.Drawing.Size(121, 20);
            this.textBoxTrim.TabIndex = 22;
            // 
            // comboBoxFurniture
            // 
            this.comboBoxFurniture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFurniture.FormattingEnabled = true;
            this.comboBoxFurniture.Location = new System.Drawing.Point(266, 391);
            this.comboBoxFurniture.Name = "comboBoxFurniture";
            this.comboBoxFurniture.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFurniture.TabIndex = 21;
            // 
            // comboBoxCloth
            // 
            this.comboBoxCloth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCloth.FormattingEnabled = true;
            this.comboBoxCloth.Location = new System.Drawing.Point(266, 282);
            this.comboBoxCloth.Name = "comboBoxCloth";
            this.comboBoxCloth.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCloth.TabIndex = 20;
            // 
            // labelFurniture
            // 
            this.labelFurniture.AutoSize = true;
            this.labelFurniture.Location = new System.Drawing.Point(198, 394);
            this.labelFurniture.Name = "labelFurniture";
            this.labelFurniture.Size = new System.Drawing.Size(48, 13);
            this.labelFurniture.TabIndex = 19;
            this.labelFurniture.Text = "Furniture";
            // 
            // labelTrim
            // 
            this.labelTrim.AutoSize = true;
            this.labelTrim.Location = new System.Drawing.Point(198, 342);
            this.labelTrim.Name = "labelTrim";
            this.labelTrim.Size = new System.Drawing.Size(27, 13);
            this.labelTrim.TabIndex = 18;
            this.labelTrim.Text = "Trim";
            // 
            // labelCloth
            // 
            this.labelCloth.AutoSize = true;
            this.labelCloth.Location = new System.Drawing.Point(198, 285);
            this.labelCloth.Name = "labelCloth";
            this.labelCloth.Size = new System.Drawing.Size(31, 13);
            this.labelCloth.TabIndex = 17;
            this.labelCloth.Text = "Cloth";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(613, 389);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 23;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструментыToolStripMenuItem,
            this.аккаунтToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.ОбновитьToolStripMenuItem_Click);
            // 
            // аккаунтToolStripMenuItem
            // 
            this.аккаунтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem});
            this.аккаунтToolStripMenuItem.Name = "аккаунтToolStripMenuItem";
            this.аккаунтToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.аккаунтToolStripMenuItem.Text = "Аккаунт";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.ВыйтиToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 443);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.goodsList);
            this.tabPage1.Controls.Add(this.deleteButton);
            this.tabPage1.Controls.Add(this.labelName);
            this.tabPage1.Controls.Add(this.addButton);
            this.tabPage1.Controls.Add(this.labelWidth);
            this.tabPage1.Controls.Add(this.textBoxTrim);
            this.tabPage1.Controls.Add(this.labelHeight);
            this.tabPage1.Controls.Add(this.comboBoxFurniture);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Controls.Add(this.comboBoxCloth);
            this.tabPage1.Controls.Add(this.textBoxWidth);
            this.tabPage1.Controls.Add(this.labelFurniture);
            this.tabPage1.Controls.Add(this.textBoxHeight);
            this.tabPage1.Controls.Add(this.labelTrim);
            this.tabPage1.Controls.Add(this.labelCloth);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список товаров";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.toCuttingButton);
            this.tabPage2.Controls.Add(this.denyFilter);
            this.tabPage2.Controls.Add(this.denyButton);
            this.tabPage2.Controls.Add(this.addManagerButton);
            this.tabPage2.Controls.Add(this.orderList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toCuttingButton
            // 
            this.toCuttingButton.Location = new System.Drawing.Point(181, 364);
            this.toCuttingButton.Name = "toCuttingButton";
            this.toCuttingButton.Size = new System.Drawing.Size(81, 47);
            this.toCuttingButton.TabIndex = 4;
            this.toCuttingButton.Text = "Перейти к раскрою";
            this.toCuttingButton.UseVisualStyleBackColor = true;
            this.toCuttingButton.Visible = false;
            this.toCuttingButton.Click += new System.EventHandler(this.ToCuttingButton_Click);
            // 
            // denyFilter
            // 
            this.denyFilter.AutoSize = true;
            this.denyFilter.Location = new System.Drawing.Point(7, 212);
            this.denyFilter.Name = "denyFilter";
            this.denyFilter.Size = new System.Drawing.Size(231, 17);
            this.denyFilter.TabIndex = 3;
            this.denyFilter.Text = "Убрать заказы со статусом \"Отклонён\"";
            this.denyFilter.UseVisualStyleBackColor = true;
            this.denyFilter.CheckedChanged += new System.EventHandler(this.DenyFilter_CheckedChanged);
            // 
            // denyButton
            // 
            this.denyButton.Location = new System.Drawing.Point(94, 364);
            this.denyButton.Name = "denyButton";
            this.denyButton.Size = new System.Drawing.Size(81, 47);
            this.denyButton.TabIndex = 2;
            this.denyButton.Text = "Отклонить заказ";
            this.denyButton.UseVisualStyleBackColor = true;
            this.denyButton.Visible = false;
            this.denyButton.Click += new System.EventHandler(this.DenyButton_Click);
            // 
            // addManagerButton
            // 
            this.addManagerButton.Location = new System.Drawing.Point(7, 364);
            this.addManagerButton.Name = "addManagerButton";
            this.addManagerButton.Size = new System.Drawing.Size(81, 47);
            this.addManagerButton.TabIndex = 1;
            this.addManagerButton.Text = "Стать менеджером заказа";
            this.addManagerButton.UseVisualStyleBackColor = true;
            this.addManagerButton.Visible = false;
            this.addManagerButton.Click += new System.EventHandler(this.AddManagerButton_Click);
            // 
            // orderList
            // 
            this.orderList.FormattingEnabled = true;
            this.orderList.Location = new System.Drawing.Point(7, 7);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(778, 199);
            this.orderList.TabIndex = 0;
            this.orderList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OrderList_MouseClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.orderClothes);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.qtyCloth);
            this.tabPage3.Controls.Add(this.clothInStorage);
            this.tabPage3.Controls.Add(this.widthCloth);
            this.tabPage3.Controls.Add(this.heightCloth);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.clothesStorage);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(791, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ткани на складе";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // orderClothes
            // 
            this.orderClothes.Location = new System.Drawing.Point(18, 379);
            this.orderClothes.Name = "orderClothes";
            this.orderClothes.Size = new System.Drawing.Size(75, 35);
            this.orderClothes.TabIndex = 33;
            this.orderClothes.Text = "Оформить заказ";
            this.orderClothes.UseVisualStyleBackColor = true;
            this.orderClothes.Click += new System.EventHandler(this.OrderClothes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quality";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Height";
            // 
            // qtyCloth
            // 
            this.qtyCloth.Location = new System.Drawing.Point(56, 274);
            this.qtyCloth.Name = "qtyCloth";
            this.qtyCloth.Size = new System.Drawing.Size(100, 20);
            this.qtyCloth.TabIndex = 26;
            // 
            // clothInStorage
            // 
            this.clothInStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clothInStorage.FormattingEnabled = true;
            this.clothInStorage.Location = new System.Drawing.Point(248, 274);
            this.clothInStorage.Name = "clothInStorage";
            this.clothInStorage.Size = new System.Drawing.Size(121, 21);
            this.clothInStorage.TabIndex = 32;
            // 
            // widthCloth
            // 
            this.widthCloth.Location = new System.Drawing.Point(56, 331);
            this.widthCloth.Name = "widthCloth";
            this.widthCloth.Size = new System.Drawing.Size(100, 20);
            this.widthCloth.TabIndex = 27;
            // 
            // heightCloth
            // 
            this.heightCloth.Location = new System.Drawing.Point(248, 331);
            this.heightCloth.Name = "heightCloth";
            this.heightCloth.Size = new System.Drawing.Size(100, 20);
            this.heightCloth.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cloth";
            // 
            // clothesStorage
            // 
            this.clothesStorage.FormattingEnabled = true;
            this.clothesStorage.Location = new System.Drawing.Point(4, 4);
            this.clothesStorage.Name = "clothesStorage";
            this.clothesStorage.Size = new System.Drawing.Size(784, 225);
            this.clothesStorage.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.readyButton);
            this.tabPage4.Controls.Add(this.cuttingGoodButton);
            this.tabPage4.Controls.Add(this.cuttingGoodsList);
            this.tabPage4.Controls.Add(this.cuttingClothComboBox);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.cuttingGoodsComboBox);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.orderLabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(791, 417);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Раскрой";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // readyButton
            // 
            this.readyButton.Location = new System.Drawing.Point(681, 376);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(81, 38);
            this.readyButton.TabIndex = 10;
            this.readyButton.Text = "Подтвердить";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Visible = false;
            this.readyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // cuttingGoodButton
            // 
            this.cuttingGoodButton.Location = new System.Drawing.Point(17, 376);
            this.cuttingGoodButton.Name = "cuttingGoodButton";
            this.cuttingGoodButton.Size = new System.Drawing.Size(85, 38);
            this.cuttingGoodButton.TabIndex = 9;
            this.cuttingGoodButton.Text = "Раскроить данный товар";
            this.cuttingGoodButton.UseVisualStyleBackColor = true;
            this.cuttingGoodButton.Visible = false;
            this.cuttingGoodButton.Click += new System.EventHandler(this.CuttingGoodButton_Click);
            // 
            // cuttingGoodsList
            // 
            this.cuttingGoodsList.FormattingEnabled = true;
            this.cuttingGoodsList.Location = new System.Drawing.Point(597, 87);
            this.cuttingGoodsList.Name = "cuttingGoodsList";
            this.cuttingGoodsList.Size = new System.Drawing.Size(165, 277);
            this.cuttingGoodsList.TabIndex = 8;
            // 
            // cuttingClothComboBox
            // 
            this.cuttingClothComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuttingClothComboBox.FormattingEnabled = true;
            this.cuttingClothComboBox.Location = new System.Drawing.Point(641, 38);
            this.cuttingClothComboBox.Name = "cuttingClothComboBox";
            this.cuttingClothComboBox.Size = new System.Drawing.Size(121, 21);
            this.cuttingClothComboBox.TabIndex = 7;
            this.cuttingClothComboBox.SelectedValueChanged += new System.EventHandler(this.CuttingClothComboBox_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(594, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Рулон:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.smallPictureBox);
            this.panel1.Controls.Add(this.bigPictureBox);
            this.panel1.Location = new System.Drawing.Point(17, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 329);
            this.panel1.TabIndex = 5;
            // 
            // smallPictureBox
            // 
            this.smallPictureBox.BackColor = System.Drawing.Color.LightCoral;
            this.smallPictureBox.Location = new System.Drawing.Point(309, 29);
            this.smallPictureBox.Name = "smallPictureBox";
            this.smallPictureBox.Size = new System.Drawing.Size(100, 50);
            this.smallPictureBox.TabIndex = 1;
            this.smallPictureBox.TabStop = false;
            this.smallPictureBox.Visible = false;
            // 
            // bigPictureBox
            // 
            this.bigPictureBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.bigPictureBox.Location = new System.Drawing.Point(32, 29);
            this.bigPictureBox.Name = "bigPictureBox";
            this.bigPictureBox.Size = new System.Drawing.Size(144, 73);
            this.bigPictureBox.TabIndex = 0;
            this.bigPictureBox.TabStop = false;
            this.bigPictureBox.Visible = false;
            // 
            // cuttingGoodsComboBox
            // 
            this.cuttingGoodsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuttingGoodsComboBox.FormattingEnabled = true;
            this.cuttingGoodsComboBox.Location = new System.Drawing.Point(641, 10);
            this.cuttingGoodsComboBox.Name = "cuttingGoodsComboBox";
            this.cuttingGoodsComboBox.Size = new System.Drawing.Size(121, 21);
            this.cuttingGoodsComboBox.TabIndex = 4;
            this.cuttingGoodsComboBox.SelectedValueChanged += new System.EventHandler(this.CuttingGoodsComboBox_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Товар:";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(14, 13);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(57, 13);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Text = "orderLabel";
            // 
            // loginLabel
            // 
            this.loginLabel.BackColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(221, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(586, 22);
            this.loginLabel.TabIndex = 27;
            this.loginLabel.Text = "Вы вошли под логином ";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 497);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экран менеджера";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smallPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox goodsList;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxTrim;
        private System.Windows.Forms.ComboBox comboBoxFurniture;
        private System.Windows.Forms.ComboBox comboBoxCloth;
        private System.Windows.Forms.Label labelFurniture;
        private System.Windows.Forms.Label labelTrim;
        private System.Windows.Forms.Label labelCloth;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox orderList;
        private System.Windows.Forms.Button addManagerButton;
        private System.Windows.Forms.Button denyButton;
        private System.Windows.Forms.CheckBox denyFilter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button orderClothes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qtyCloth;
        private System.Windows.Forms.ComboBox clothInStorage;
        private System.Windows.Forms.TextBox widthCloth;
        private System.Windows.Forms.TextBox heightCloth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox clothesStorage;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button toCuttingButton;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.ComboBox cuttingGoodsComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox smallPictureBox;
        private System.Windows.Forms.PictureBox bigPictureBox;
        private System.Windows.Forms.ComboBox cuttingClothComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.Button cuttingGoodButton;
        private System.Windows.Forms.ListBox cuttingGoodsList;
        private System.Windows.Forms.Label loginLabel;
    }
}