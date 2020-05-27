namespace EngineeringDesign
{
    partial class DirectorForm
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
            this.restartButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.workshopComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fireExtinguisherPictureBox = new System.Windows.Forms.PictureBox();
            this.firstAidPictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.equipmentPictureBox = new System.Windows.Forms.PictureBox();
            this.workshopPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.firstTaskHourСomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qtyDaysSumTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.qtyDaysTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rowNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addNewRow = new System.Windows.Forms.Button();
            this.rowsComboBox = new System.Windows.Forms.ComboBox();
            this.toGanttChartButton = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fireExtinguisherPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstAidPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopPictureBox)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(425, 245);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 411);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.tabPage1.Controls.Add(this.restartButton);
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Controls.Add(this.workshopComboBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "План цехов";
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(230)))), ((int)(((byte)(177)))));
            this.restartButton.Location = new System.Drawing.Point(595, 356);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(82, 23);
            this.restartButton.TabIndex = 4;
            this.restartButton.Text = "Пересобрать";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(230)))), ((int)(((byte)(177)))));
            this.saveButton.Location = new System.Drawing.Point(683, 356);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // workshopComboBox
            // 
            this.workshopComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workshopComboBox.FormattingEnabled = true;
            this.workshopComboBox.Items.AddRange(new object[] {
            "Заготовительный цех",
            "Текстильный цех",
            "Упаковочный цех",
            "Швейный цех",
            "Цех оформления"});
            this.workshopComboBox.Location = new System.Drawing.Point(41, 321);
            this.workshopComboBox.Name = "workshopComboBox";
            this.workshopComboBox.Size = new System.Drawing.Size(121, 21);
            this.workshopComboBox.TabIndex = 2;
            this.workshopComboBox.SelectedValueChanged += new System.EventHandler(this.WorkshopComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цех:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.fireExtinguisherPictureBox);
            this.panel1.Controls.Add(this.firstAidPictureBox);
            this.panel1.Controls.Add(this.exitPictureBox);
            this.panel1.Controls.Add(this.equipmentPictureBox);
            this.panel1.Controls.Add(this.workshopPictureBox);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 309);
            this.panel1.TabIndex = 0;
            // 
            // fireExtinguisherPictureBox
            // 
            this.fireExtinguisherPictureBox.Image = global::EngineeringDesign.Properties.Resources.FireExtinguisher;
            this.fireExtinguisherPictureBox.Location = new System.Drawing.Point(703, 115);
            this.fireExtinguisherPictureBox.Name = "fireExtinguisherPictureBox";
            this.fireExtinguisherPictureBox.Size = new System.Drawing.Size(50, 50);
            this.fireExtinguisherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fireExtinguisherPictureBox.TabIndex = 4;
            this.fireExtinguisherPictureBox.TabStop = false;
            this.fireExtinguisherPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FireExtinguisherPictureBox_MouseDown);
            // 
            // firstAidPictureBox
            // 
            this.firstAidPictureBox.Image = global::EngineeringDesign.Properties.Resources.FirstAid;
            this.firstAidPictureBox.Location = new System.Drawing.Point(703, 59);
            this.firstAidPictureBox.Name = "firstAidPictureBox";
            this.firstAidPictureBox.Size = new System.Drawing.Size(50, 50);
            this.firstAidPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstAidPictureBox.TabIndex = 3;
            this.firstAidPictureBox.TabStop = false;
            this.firstAidPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FirstAidPictureBox_MouseDown);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Image = global::EngineeringDesign.Properties.Resources.Exit;
            this.exitPictureBox.Location = new System.Drawing.Point(703, 171);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(50, 50);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitPictureBox.TabIndex = 2;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitPictureBox_MouseDown);
            // 
            // equipmentPictureBox
            // 
            this.equipmentPictureBox.Image = global::EngineeringDesign.Properties.Resources.Equipment;
            this.equipmentPictureBox.Location = new System.Drawing.Point(703, 3);
            this.equipmentPictureBox.Name = "equipmentPictureBox";
            this.equipmentPictureBox.Size = new System.Drawing.Size(50, 50);
            this.equipmentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equipmentPictureBox.TabIndex = 1;
            this.equipmentPictureBox.TabStop = false;
            this.equipmentPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EquipmentPictureBox_MouseDown);
            // 
            // workshopPictureBox
            // 
            this.workshopPictureBox.Location = new System.Drawing.Point(0, 0);
            this.workshopPictureBox.Name = "workshopPictureBox";
            this.workshopPictureBox.Size = new System.Drawing.Size(697, 309);
            this.workshopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.workshopPictureBox.TabIndex = 0;
            this.workshopPictureBox.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.firstTaskHourСomboBox);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.qtyDaysSumTextBox);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.qtyDaysTextBox);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.rowNameTextBox);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.addNewRow);
            this.tabPage5.Controls.Add(this.rowsComboBox);
            this.tabPage5.Controls.Add(this.toGanttChartButton);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(768, 385);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Настройка диаграммы Гантта";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // firstTaskHourСomboBox
            // 
            this.firstTaskHourСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firstTaskHourСomboBox.FormattingEnabled = true;
            this.firstTaskHourСomboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.firstTaskHourСomboBox.Location = new System.Drawing.Point(662, 259);
            this.firstTaskHourСomboBox.Name = "firstTaskHourСomboBox";
            this.firstTaskHourСomboBox.Size = new System.Drawing.Size(100, 21);
            this.firstTaskHourСomboBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "С какого часа начать первую задачу:";
            // 
            // qtyDaysSumTextBox
            // 
            this.qtyDaysSumTextBox.Location = new System.Drawing.Point(662, 285);
            this.qtyDaysSumTextBox.Name = "qtyDaysSumTextBox";
            this.qtyDaysSumTextBox.Size = new System.Drawing.Size(100, 20);
            this.qtyDaysSumTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Общее число дней на проект:";
            // 
            // qtyDaysTextBox
            // 
            this.qtyDaysTextBox.Location = new System.Drawing.Point(160, 31);
            this.qtyDaysTextBox.Name = "qtyDaysTextBox";
            this.qtyDaysTextBox.Size = new System.Drawing.Size(100, 20);
            this.qtyDaysTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сроки задачи (кол-во часов):";
            // 
            // rowNameTextBox
            // 
            this.rowNameTextBox.Location = new System.Drawing.Point(160, 9);
            this.rowNameTextBox.Name = "rowNameTextBox";
            this.rowNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.rowNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наименование задачи:";
            // 
            // addNewRow
            // 
            this.addNewRow.Location = new System.Drawing.Point(9, 60);
            this.addNewRow.Name = "addNewRow";
            this.addNewRow.Size = new System.Drawing.Size(121, 23);
            this.addNewRow.TabIndex = 2;
            this.addNewRow.Text = "Добавить задачу";
            this.addNewRow.UseVisualStyleBackColor = true;
            this.addNewRow.Click += new System.EventHandler(this.AddNewRow_Click);
            // 
            // rowsComboBox
            // 
            this.rowsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rowsComboBox.FormattingEnabled = true;
            this.rowsComboBox.Location = new System.Drawing.Point(9, 89);
            this.rowsComboBox.Name = "rowsComboBox";
            this.rowsComboBox.Size = new System.Drawing.Size(121, 21);
            this.rowsComboBox.TabIndex = 1;
            // 
            // toGanttChartButton
            // 
            this.toGanttChartButton.Location = new System.Drawing.Point(447, 311);
            this.toGanttChartButton.Name = "toGanttChartButton";
            this.toGanttChartButton.Size = new System.Drawing.Size(315, 68);
            this.toGanttChartButton.TabIndex = 0;
            this.toGanttChartButton.Text = "Нажми меня ;)";
            this.toGanttChartButton.UseVisualStyleBackColor = true;
            this.toGanttChartButton.Click += new System.EventHandler(this.ToGanttChartButton_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.panel2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(768, 385);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Диаграмма Гантта";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 376);
            this.panel2.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(221)))), ((int)(((byte)(215)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструментыToolStripMenuItem,
            this.аккаунтToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1292, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
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
            this.loginLabel.Location = new System.Drawing.Point(202, 2);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(586, 22);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "Вы вошли под логином ";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 703);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DirectorForm";
            this.Text = "Экран директора";
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fireExtinguisherPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstAidPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopPictureBox)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox workshopComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox workshopPictureBox;
        private System.Windows.Forms.PictureBox fireExtinguisherPictureBox;
        private System.Windows.Forms.PictureBox firstAidPictureBox;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox equipmentPictureBox;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button toGanttChartButton;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button addNewRow;
        private System.Windows.Forms.ComboBox rowsComboBox;
        private System.Windows.Forms.TextBox rowNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qtyDaysTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qtyDaysSumTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox firstTaskHourСomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.Label loginLabel;
    }
}