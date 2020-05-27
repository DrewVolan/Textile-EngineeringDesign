namespace EngineeringDesign
{
    partial class StorekeeperForm
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
            this.deleteCloth = new System.Windows.Forms.Button();
            this.addCloth = new System.Windows.Forms.Button();
            this.clothesName = new System.Windows.Forms.TextBox();
            this.clothesNameLabel = new System.Windows.Forms.Label();
            this.clothesList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.furniturePictureBox = new System.Windows.Forms.PictureBox();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.addPictureButton = new System.Windows.Forms.Button();
            this.deleteFurniture = new System.Windows.Forms.Button();
            this.addFurniture = new System.Windows.Forms.Button();
            this.furnitureName = new System.Windows.Forms.TextBox();
            this.furnitureNameLabel = new System.Windows.Forms.Label();
            this.furnituresList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furniturePictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(508, 259);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.deleteCloth);
            this.tabPage1.Controls.Add(this.addCloth);
            this.tabPage1.Controls.Add(this.clothesName);
            this.tabPage1.Controls.Add(this.clothesNameLabel);
            this.tabPage1.Controls.Add(this.clothesList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список тканей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteCloth
            // 
            this.deleteCloth.Location = new System.Drawing.Point(180, 370);
            this.deleteCloth.Name = "deleteCloth";
            this.deleteCloth.Size = new System.Drawing.Size(75, 23);
            this.deleteCloth.TabIndex = 4;
            this.deleteCloth.Text = "Удалить";
            this.deleteCloth.UseVisualStyleBackColor = true;
            this.deleteCloth.Click += new System.EventHandler(this.DeleteCloth_Click);
            // 
            // addCloth
            // 
            this.addCloth.Location = new System.Drawing.Point(10, 370);
            this.addCloth.Name = "addCloth";
            this.addCloth.Size = new System.Drawing.Size(75, 23);
            this.addCloth.TabIndex = 3;
            this.addCloth.Text = "Добавить";
            this.addCloth.UseVisualStyleBackColor = true;
            this.addCloth.Click += new System.EventHandler(this.AddCloth_Click);
            // 
            // clothesName
            // 
            this.clothesName.Location = new System.Drawing.Point(48, 297);
            this.clothesName.Name = "clothesName";
            this.clothesName.Size = new System.Drawing.Size(100, 20);
            this.clothesName.TabIndex = 2;
            // 
            // clothesNameLabel
            // 
            this.clothesNameLabel.AutoSize = true;
            this.clothesNameLabel.Location = new System.Drawing.Point(7, 300);
            this.clothesNameLabel.Name = "clothesNameLabel";
            this.clothesNameLabel.Size = new System.Drawing.Size(35, 13);
            this.clothesNameLabel.TabIndex = 1;
            this.clothesNameLabel.Text = "Name";
            // 
            // clothesList
            // 
            this.clothesList.FormattingEnabled = true;
            this.clothesList.Location = new System.Drawing.Point(7, 7);
            this.clothesList.Name = "clothesList";
            this.clothesList.Size = new System.Drawing.Size(754, 277);
            this.clothesList.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.furniturePictureBox);
            this.tabPage2.Controls.Add(this.linkTextBox);
            this.tabPage2.Controls.Add(this.addPictureButton);
            this.tabPage2.Controls.Add(this.deleteFurniture);
            this.tabPage2.Controls.Add(this.addFurniture);
            this.tabPage2.Controls.Add(this.furnitureName);
            this.tabPage2.Controls.Add(this.furnitureNameLabel);
            this.tabPage2.Controls.Add(this.furnituresList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список фурнитуры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // furniturePictureBox
            // 
            this.furniturePictureBox.Location = new System.Drawing.Point(318, 343);
            this.furniturePictureBox.Name = "furniturePictureBox";
            this.furniturePictureBox.Size = new System.Drawing.Size(100, 50);
            this.furniturePictureBox.TabIndex = 11;
            this.furniturePictureBox.TabStop = false;
            // 
            // linkTextBox
            // 
            this.linkTextBox.Location = new System.Drawing.Point(318, 297);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.ReadOnly = true;
            this.linkTextBox.Size = new System.Drawing.Size(442, 20);
            this.linkTextBox.TabIndex = 10;
            // 
            // addPictureButton
            // 
            this.addPictureButton.Location = new System.Drawing.Point(176, 295);
            this.addPictureButton.Name = "addPictureButton";
            this.addPictureButton.Size = new System.Drawing.Size(136, 23);
            this.addPictureButton.TabIndex = 9;
            this.addPictureButton.Text = "Добавить изображение";
            this.addPictureButton.UseVisualStyleBackColor = true;
            this.addPictureButton.Click += new System.EventHandler(this.AddPictureButton_Click);
            // 
            // deleteFurniture
            // 
            this.deleteFurniture.Location = new System.Drawing.Point(176, 370);
            this.deleteFurniture.Name = "deleteFurniture";
            this.deleteFurniture.Size = new System.Drawing.Size(75, 23);
            this.deleteFurniture.TabIndex = 8;
            this.deleteFurniture.Text = "Удалить";
            this.deleteFurniture.UseVisualStyleBackColor = true;
            this.deleteFurniture.Click += new System.EventHandler(this.DeleteFurniture_Click);
            // 
            // addFurniture
            // 
            this.addFurniture.Location = new System.Drawing.Point(6, 370);
            this.addFurniture.Name = "addFurniture";
            this.addFurniture.Size = new System.Drawing.Size(75, 23);
            this.addFurniture.TabIndex = 7;
            this.addFurniture.Text = "Добавить";
            this.addFurniture.UseVisualStyleBackColor = true;
            this.addFurniture.Click += new System.EventHandler(this.AddFurniture_Click);
            // 
            // furnitureName
            // 
            this.furnitureName.Location = new System.Drawing.Point(44, 297);
            this.furnitureName.Name = "furnitureName";
            this.furnitureName.Size = new System.Drawing.Size(100, 20);
            this.furnitureName.TabIndex = 6;
            // 
            // furnitureNameLabel
            // 
            this.furnitureNameLabel.AutoSize = true;
            this.furnitureNameLabel.Location = new System.Drawing.Point(3, 300);
            this.furnitureNameLabel.Name = "furnitureNameLabel";
            this.furnitureNameLabel.Size = new System.Drawing.Size(35, 13);
            this.furnitureNameLabel.TabIndex = 5;
            this.furnitureNameLabel.Text = "Name";
            // 
            // furnituresList
            // 
            this.furnituresList.FormattingEnabled = true;
            this.furnituresList.Location = new System.Drawing.Point(6, 6);
            this.furnituresList.Name = "furnituresList";
            this.furnituresList.Size = new System.Drawing.Size(754, 277);
            this.furnituresList.TabIndex = 1;
            this.furnituresList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FurnituresList_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструментыToolStripMenuItem,
            this.аккаунтToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1295, 24);
            this.menuStrip1.TabIndex = 26;
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
            // loginLabel
            // 
            this.loginLabel.BackColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(202, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(586, 22);
            this.loginLabel.TabIndex = 27;
            this.loginLabel.Text = "Вы вошли под логином ";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StorekeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 696);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "StorekeeperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экран кладовщика";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StorekeeperForm_FormClosed);
            this.Load += new System.EventHandler(this.StorekeeperForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.furniturePictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox clothesList;
        private System.Windows.Forms.ListBox furnituresList;
        private System.Windows.Forms.Button addCloth;
        private System.Windows.Forms.TextBox clothesName;
        private System.Windows.Forms.Label clothesNameLabel;
        private System.Windows.Forms.Button deleteCloth;
        private System.Windows.Forms.Button deleteFurniture;
        private System.Windows.Forms.Button addFurniture;
        private System.Windows.Forms.TextBox furnitureName;
        private System.Windows.Forms.Label furnitureNameLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.Button addPictureButton;
        private System.Windows.Forms.PictureBox furniturePictureBox;
        private System.Windows.Forms.Label loginLabel;
    }
}