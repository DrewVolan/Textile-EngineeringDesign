namespace EngineeringDesign
{
    partial class CustomerForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.updateOrder = new System.Windows.Forms.Button();
            this.orderNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addToOrder = new System.Windows.Forms.Button();
            this.qtyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.currentOrder = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.goodsList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.acceptButton = new System.Windows.Forms.Button();
            this.orderList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteFurnitureButton = new System.Windows.Forms.Button();
            this.deletePrintButton = new System.Windows.Forms.Button();
            this.addPrintButtom = new System.Windows.Forms.Button();
            this.createCustomerGoodButton = new System.Windows.Forms.Button();
            this.addFurnitureButton = new System.Windows.Forms.Button();
            this.rotateTrackBar = new System.Windows.Forms.TrackBar();
            this.furnitureComboBox = new System.Windows.Forms.ComboBox();
            this.trimComboBox = new System.Windows.Forms.ComboBox();
            this.clothComboBox = new System.Windows.Forms.ComboBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goodSchemePictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.deleteMyGoodButton = new System.Windows.Forms.Button();
            this.myGoodPictureBox = new System.Windows.Forms.PictureBox();
            this.myGoodsListBox = new System.Windows.Forms.ListBox();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotateTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodSchemePictureBox)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGoodPictureBox)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(382, 208);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.updateOrder);
            this.tabPage1.Controls.Add(this.orderNum);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.addToOrder);
            this.tabPage1.Controls.Add(this.qtyBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.addOrderButton);
            this.tabPage1.Controls.Add(this.currentOrder);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.goodsList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список товаров";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // updateOrder
            // 
            this.updateOrder.Location = new System.Drawing.Point(421, 399);
            this.updateOrder.Name = "updateOrder";
            this.updateOrder.Size = new System.Drawing.Size(75, 23);
            this.updateOrder.TabIndex = 9;
            this.updateOrder.Text = "Изменить";
            this.updateOrder.UseVisualStyleBackColor = true;
            this.updateOrder.Click += new System.EventHandler(this.UpdateOrder_Click);
            // 
            // orderNum
            // 
            this.orderNum.Location = new System.Drawing.Point(297, 402);
            this.orderNum.Name = "orderNum";
            this.orderNum.Size = new System.Drawing.Size(100, 20);
            this.orderNum.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Изменить заказ можно только со статусом \"Новый\".\r\nВведите номер заказа, который х" +
    "отите изменить:";
            // 
            // addToOrder
            // 
            this.addToOrder.Location = new System.Drawing.Point(774, 183);
            this.addToOrder.Name = "addToOrder";
            this.addToOrder.Size = new System.Drawing.Size(75, 23);
            this.addToOrder.TabIndex = 6;
            this.addToOrder.Text = "Добавить";
            this.addToOrder.UseVisualStyleBackColor = true;
            this.addToOrder.Click += new System.EventHandler(this.AddToOrder_Click);
            // 
            // qtyBox
            // 
            this.qtyBox.Location = new System.Drawing.Point(774, 157);
            this.qtyBox.Name = "qtyBox";
            this.qtyBox.Size = new System.Drawing.Size(76, 20);
            this.qtyBox.TabIndex = 5;
            this.qtyBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(771, 141);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кол-во:";
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(774, 351);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(93, 38);
            this.addOrderButton.TabIndex = 3;
            this.addOrderButton.Text = "Оформить заказ";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // currentOrder
            // 
            this.currentOrder.FormattingEnabled = true;
            this.currentOrder.Location = new System.Drawing.Point(6, 229);
            this.currentOrder.Name = "currentOrder";
            this.currentOrder.Size = new System.Drawing.Size(754, 160);
            this.currentOrder.TabIndex = 2;
            this.currentOrder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CurrentOrder_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заказ:";
            // 
            // goodsList
            // 
            this.goodsList.FormattingEnabled = true;
            this.goodsList.Location = new System.Drawing.Point(7, 7);
            this.goodsList.Name = "goodsList";
            this.goodsList.Size = new System.Drawing.Size(753, 199);
            this.goodsList.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.acceptButton);
            this.tabPage2.Controls.Add(this.orderList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мои заказы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(7, 406);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(82, 23);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Подтвердить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Visible = false;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // orderList
            // 
            this.orderList.FormattingEnabled = true;
            this.orderList.Location = new System.Drawing.Point(7, 7);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(860, 199);
            this.orderList.TabIndex = 0;
            this.orderList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OrderList_MouseClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.nameTextBox);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.deleteFurnitureButton);
            this.tabPage3.Controls.Add(this.deletePrintButton);
            this.tabPage3.Controls.Add(this.addPrintButtom);
            this.tabPage3.Controls.Add(this.createCustomerGoodButton);
            this.tabPage3.Controls.Add(this.addFurnitureButton);
            this.tabPage3.Controls.Add(this.rotateTrackBar);
            this.tabPage3.Controls.Add(this.furnitureComboBox);
            this.tabPage3.Controls.Add(this.trimComboBox);
            this.tabPage3.Controls.Add(this.clothComboBox);
            this.tabPage3.Controls.Add(this.heightTextBox);
            this.tabPage3.Controls.Add(this.widthTextBox);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(886, 447);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Конструктор изделий";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(682, 9);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(188, 20);
            this.nameTextBox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(545, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Наименование изделия:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Легенда";
            // 
            // deleteFurnitureButton
            // 
            this.deleteFurnitureButton.Location = new System.Drawing.Point(811, 117);
            this.deleteFurnitureButton.Name = "deleteFurnitureButton";
            this.deleteFurnitureButton.Size = new System.Drawing.Size(59, 23);
            this.deleteFurnitureButton.TabIndex = 16;
            this.deleteFurnitureButton.Text = "Удалить";
            this.deleteFurnitureButton.UseVisualStyleBackColor = true;
            this.deleteFurnitureButton.Click += new System.EventHandler(this.DeleteFurnitureButton_Click);
            // 
            // deletePrintButton
            // 
            this.deletePrintButton.Location = new System.Drawing.Point(811, 73);
            this.deletePrintButton.Name = "deletePrintButton";
            this.deletePrintButton.Size = new System.Drawing.Size(59, 23);
            this.deletePrintButton.TabIndex = 15;
            this.deletePrintButton.Text = "Удалить принт";
            this.deletePrintButton.UseVisualStyleBackColor = true;
            this.deletePrintButton.Click += new System.EventHandler(this.DeletePrintButton_Click);
            // 
            // addPrintButtom
            // 
            this.addPrintButtom.Location = new System.Drawing.Point(733, 73);
            this.addPrintButtom.Name = "addPrintButtom";
            this.addPrintButtom.Size = new System.Drawing.Size(72, 23);
            this.addPrintButtom.TabIndex = 14;
            this.addPrintButtom.Text = "Добавить принт";
            this.addPrintButtom.UseVisualStyleBackColor = true;
            this.addPrintButtom.Click += new System.EventHandler(this.AddPrintButtom_Click);
            // 
            // createCustomerGoodButton
            // 
            this.createCustomerGoodButton.Location = new System.Drawing.Point(750, 409);
            this.createCustomerGoodButton.Name = "createCustomerGoodButton";
            this.createCustomerGoodButton.Size = new System.Drawing.Size(120, 23);
            this.createCustomerGoodButton.TabIndex = 13;
            this.createCustomerGoodButton.Text = "Создать изделие";
            this.createCustomerGoodButton.UseVisualStyleBackColor = true;
            this.createCustomerGoodButton.Click += new System.EventHandler(this.CreateCustomerGoodButton_Click);
            // 
            // addFurnitureButton
            // 
            this.addFurnitureButton.Location = new System.Drawing.Point(733, 117);
            this.addFurnitureButton.Name = "addFurnitureButton";
            this.addFurnitureButton.Size = new System.Drawing.Size(72, 23);
            this.addFurnitureButton.TabIndex = 12;
            this.addFurnitureButton.Text = "Добавить фурнитуру";
            this.addFurnitureButton.UseVisualStyleBackColor = true;
            this.addFurnitureButton.Click += new System.EventHandler(this.AddFurnitureButton_Click);
            // 
            // rotateTrackBar
            // 
            this.rotateTrackBar.Location = new System.Drawing.Point(538, 183);
            this.rotateTrackBar.Maximum = 359;
            this.rotateTrackBar.Name = "rotateTrackBar";
            this.rotateTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.rotateTrackBar.Size = new System.Drawing.Size(45, 194);
            this.rotateTrackBar.TabIndex = 11;
            this.rotateTrackBar.Scroll += new System.EventHandler(this.RotateTrackBar_Scroll);
            this.rotateTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RotateTrackBar_MouseUp);
            // 
            // furnitureComboBox
            // 
            this.furnitureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.furnitureComboBox.FormattingEnabled = true;
            this.furnitureComboBox.Location = new System.Drawing.Point(617, 119);
            this.furnitureComboBox.Name = "furnitureComboBox";
            this.furnitureComboBox.Size = new System.Drawing.Size(110, 21);
            this.furnitureComboBox.TabIndex = 10;
            // 
            // trimComboBox
            // 
            this.trimComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trimComboBox.FormattingEnabled = true;
            this.trimComboBox.Location = new System.Drawing.Point(616, 97);
            this.trimComboBox.Name = "trimComboBox";
            this.trimComboBox.Size = new System.Drawing.Size(111, 21);
            this.trimComboBox.TabIndex = 9;
            // 
            // clothComboBox
            // 
            this.clothComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clothComboBox.FormattingEnabled = true;
            this.clothComboBox.Location = new System.Drawing.Point(592, 75);
            this.clothComboBox.Name = "clothComboBox";
            this.clothComboBox.Size = new System.Drawing.Size(135, 21);
            this.clothComboBox.TabIndex = 8;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(649, 53);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.ReadOnly = true;
            this.heightTextBox.Size = new System.Drawing.Size(221, 20);
            this.heightTextBox.TabIndex = 7;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(649, 31);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.ReadOnly = true;
            this.widthTextBox.Size = new System.Drawing.Size(221, 20);
            this.widthTextBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Фурнитура:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Окантовка:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ткань:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Высота изделия:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ширина изделия:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.goodSchemePictureBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 374);
            this.panel1.TabIndex = 0;
            // 
            // goodSchemePictureBox
            // 
            this.goodSchemePictureBox.BackColor = System.Drawing.Color.Gray;
            this.goodSchemePictureBox.Location = new System.Drawing.Point(159, 119);
            this.goodSchemePictureBox.Name = "goodSchemePictureBox";
            this.goodSchemePictureBox.Size = new System.Drawing.Size(199, 120);
            this.goodSchemePictureBox.TabIndex = 0;
            this.goodSchemePictureBox.TabStop = false;
            this.goodSchemePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GoodSchemePictureBox_MouseDown);
            this.goodSchemePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GoodSchemePictureBox_MouseMove);
            this.goodSchemePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GoodSchemePictureBox_MouseUp);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.deleteMyGoodButton);
            this.tabPage4.Controls.Add(this.myGoodPictureBox);
            this.tabPage4.Controls.Add(this.myGoodsListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(886, 447);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Мои изделия";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // deleteMyGoodButton
            // 
            this.deleteMyGoodButton.Location = new System.Drawing.Point(795, 409);
            this.deleteMyGoodButton.Name = "deleteMyGoodButton";
            this.deleteMyGoodButton.Size = new System.Drawing.Size(75, 23);
            this.deleteMyGoodButton.TabIndex = 2;
            this.deleteMyGoodButton.Text = "Удалить";
            this.deleteMyGoodButton.UseVisualStyleBackColor = true;
            this.deleteMyGoodButton.Click += new System.EventHandler(this.DeleteMyGoodButton_Click);
            // 
            // myGoodPictureBox
            // 
            this.myGoodPictureBox.BackColor = System.Drawing.Color.Gray;
            this.myGoodPictureBox.Location = new System.Drawing.Point(3, 234);
            this.myGoodPictureBox.Name = "myGoodPictureBox";
            this.myGoodPictureBox.Size = new System.Drawing.Size(786, 198);
            this.myGoodPictureBox.TabIndex = 1;
            this.myGoodPictureBox.TabStop = false;
            // 
            // myGoodsListBox
            // 
            this.myGoodsListBox.FormattingEnabled = true;
            this.myGoodsListBox.Location = new System.Drawing.Point(3, 3);
            this.myGoodsListBox.Name = "myGoodsListBox";
            this.myGoodsListBox.Size = new System.Drawing.Size(867, 225);
            this.myGoodsListBox.TabIndex = 0;
            this.myGoodsListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyGoodsListBox_MouseClick);
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
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(221)))), ((int)(((byte)(215)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1288, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(95, 20);
            this.toolStripMenuItem1.Text = "Инструменты";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItem2.Text = "Обновить";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem3.Text = "Аккаунт";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItem4.Text = "Выйти";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.BackColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(304, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(586, 22);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Вы вошли под логином ";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 693);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.tabControl1);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экран заказчика";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotateTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.goodSchemePictureBox)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myGoodPictureBox)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox goodsList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox currentOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button addToOrder;
        private System.Windows.Forms.TextBox qtyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox orderList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateOrder;
        private System.Windows.Forms.TextBox orderNum;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox goodSchemePictureBox;
        private System.Windows.Forms.ComboBox furnitureComboBox;
        private System.Windows.Forms.ComboBox trimComboBox;
        private System.Windows.Forms.ComboBox clothComboBox;
        private System.Windows.Forms.TrackBar rotateTrackBar;
        private System.Windows.Forms.Button createCustomerGoodButton;
        private System.Windows.Forms.Button addFurnitureButton;
        private System.Windows.Forms.Button deleteFurnitureButton;
        private System.Windows.Forms.Button deletePrintButton;
        private System.Windows.Forms.Button addPrintButtom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox myGoodsListBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox myGoodPictureBox;
        private System.Windows.Forms.Button deleteMyGoodButton;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label loginLabel;
    }
}