namespace CursovSAOD
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxNameEquipmentSearch = new System.Windows.Forms.TextBox();
            this.buttonSearchEquipment = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSearchShop = new System.Windows.Forms.Button();
            this.textBoxNameShopSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDeleteStatic = new System.Windows.Forms.Button();
            this.buttonAddStatic = new System.Windows.Forms.Button();
            this.CountEquipment = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameEquipment = new System.Windows.Forms.TextBox();
            this.dataGridViewStaticList = new System.Windows.Forms.DataGridView();
            this.sizeList = new System.Windows.Forms.NumericUpDown();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameShop = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxShops = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaticList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Enabled = false;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить...";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonDeleteStatic);
            this.groupBox1.Controls.Add(this.buttonAddStatic);
            this.groupBox1.Controls.Add(this.CountEquipment);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNameEquipment);
            this.groupBox1.Controls.Add(this.dataGridViewStaticList);
            this.groupBox1.Controls.Add(this.sizeList);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxNameShop);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.listBoxShops);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 477);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цеха и обородувания";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(196, 17);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.Text = "Вывод цехов в обратном порядке";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(187, 17);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Вывод цехов в прямом порядке";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxNameEquipmentSearch);
            this.groupBox3.Controls.Add(this.buttonSearchEquipment);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(201, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 99);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск оборудования";
            // 
            // textBoxNameEquipmentSearch
            // 
            this.textBoxNameEquipmentSearch.Location = new System.Drawing.Point(9, 32);
            this.textBoxNameEquipmentSearch.MaxLength = 20;
            this.textBoxNameEquipmentSearch.Name = "textBoxNameEquipmentSearch";
            this.textBoxNameEquipmentSearch.Size = new System.Drawing.Size(158, 20);
            this.textBoxNameEquipmentSearch.TabIndex = 23;
            this.textBoxNameEquipmentSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameEquipment_KeyPress);
            // 
            // buttonSearchEquipment
            // 
            this.buttonSearchEquipment.Location = new System.Drawing.Point(9, 58);
            this.buttonSearchEquipment.Name = "buttonSearchEquipment";
            this.buttonSearchEquipment.Size = new System.Drawing.Size(171, 26);
            this.buttonSearchEquipment.TabIndex = 20;
            this.buttonSearchEquipment.Text = "Поиск оборудования";
            this.buttonSearchEquipment.UseVisualStyleBackColor = true;
            this.buttonSearchEquipment.Click += new System.EventHandler(this.buttonSearchEquipment_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Наименование оборудования";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonSearchShop);
            this.groupBox2.Controls.Add(this.textBoxNameShopSearch);
            this.groupBox2.Location = new System.Drawing.Point(6, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 99);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск цеха";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Номер цеха";
            // 
            // buttonSearchShop
            // 
            this.buttonSearchShop.Location = new System.Drawing.Point(6, 61);
            this.buttonSearchShop.Name = "buttonSearchShop";
            this.buttonSearchShop.Size = new System.Drawing.Size(162, 26);
            this.buttonSearchShop.TabIndex = 19;
            this.buttonSearchShop.Text = "Поиск цеха";
            this.buttonSearchShop.UseVisualStyleBackColor = true;
            this.buttonSearchShop.Click += new System.EventHandler(this.buttonSearchShop_Click);
            // 
            // textBoxNameShopSearch
            // 
            this.textBoxNameShopSearch.Location = new System.Drawing.Point(6, 35);
            this.textBoxNameShopSearch.MaxLength = 6;
            this.textBoxNameShopSearch.Name = "textBoxNameShopSearch";
            this.textBoxNameShopSearch.Size = new System.Drawing.Size(165, 20);
            this.textBoxNameShopSearch.TabIndex = 21;
            this.textBoxNameShopSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameShop_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Количество оборудования";
            // 
            // buttonDeleteStatic
            // 
            this.buttonDeleteStatic.Location = new System.Drawing.Point(201, 442);
            this.buttonDeleteStatic.Name = "buttonDeleteStatic";
            this.buttonDeleteStatic.Size = new System.Drawing.Size(203, 26);
            this.buttonDeleteStatic.TabIndex = 17;
            this.buttonDeleteStatic.Text = "Удалить оборудование";
            this.buttonDeleteStatic.UseVisualStyleBackColor = true;
            this.buttonDeleteStatic.Click += new System.EventHandler(this.buttonDeleteStatic_Click);
            // 
            // buttonAddStatic
            // 
            this.buttonAddStatic.Location = new System.Drawing.Point(201, 156);
            this.buttonAddStatic.Name = "buttonAddStatic";
            this.buttonAddStatic.Size = new System.Drawing.Size(182, 38);
            this.buttonAddStatic.TabIndex = 16;
            this.buttonAddStatic.Text = "Добавить оборудование";
            this.buttonAddStatic.UseVisualStyleBackColor = true;
            this.buttonAddStatic.Click += new System.EventHandler(this.buttonAddStatic_Click);
            // 
            // CountEquipment
            // 
            this.CountEquipment.Location = new System.Drawing.Point(201, 130);
            this.CountEquipment.Name = "CountEquipment";
            this.CountEquipment.Size = new System.Drawing.Size(105, 20);
            this.CountEquipment.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Количество единиц";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Наименование оборудования";
            // 
            // textBoxNameEquipment
            // 
            this.textBoxNameEquipment.Location = new System.Drawing.Point(201, 91);
            this.textBoxNameEquipment.MaxLength = 20;
            this.textBoxNameEquipment.Name = "textBoxNameEquipment";
            this.textBoxNameEquipment.Size = new System.Drawing.Size(182, 20);
            this.textBoxNameEquipment.TabIndex = 11;
            this.textBoxNameEquipment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameEquipment_KeyPress);
            // 
            // dataGridViewStaticList
            // 
            this.dataGridViewStaticList.AllowUserToAddRows = false;
            this.dataGridViewStaticList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaticList.Location = new System.Drawing.Point(201, 302);
            this.dataGridViewStaticList.MultiSelect = false;
            this.dataGridViewStaticList.Name = "dataGridViewStaticList";
            this.dataGridViewStaticList.Size = new System.Drawing.Size(203, 134);
            this.dataGridViewStaticList.TabIndex = 10;
            // 
            // sizeList
            // 
            this.sizeList.Location = new System.Drawing.Point(6, 130);
            this.sizeList.Name = "sizeList";
            this.sizeList.Size = new System.Drawing.Size(120, 20);
            this.sizeList.TabIndex = 9;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(6, 442);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(177, 26);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Удалить цех";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер цеха";
            // 
            // textBoxNameShop
            // 
            this.textBoxNameShop.Location = new System.Drawing.Point(6, 91);
            this.textBoxNameShop.MaxLength = 6;
            this.textBoxNameShop.Name = "textBoxNameShop";
            this.textBoxNameShop.Size = new System.Drawing.Size(177, 20);
            this.textBoxNameShop.TabIndex = 2;
            this.textBoxNameShop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameShop_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 156);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(177, 38);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить цех";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxShops
            // 
            this.listBoxShops.DisplayMember = "WorkshopName";
            this.listBoxShops.FormattingEnabled = true;
            this.listBoxShops.Location = new System.Drawing.Point(6, 302);
            this.listBoxShops.Name = "listBoxShops";
            this.listBoxShops.Size = new System.Drawing.Size(177, 134);
            this.listBoxShops.TabIndex = 0;
            this.listBoxShops.SelectedIndexChanged += new System.EventHandler(this.listBoxShops_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaticList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameShop;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxShops;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.NumericUpDown sizeList;
        private System.Windows.Forms.Button buttonDeleteStatic;
        private System.Windows.Forms.Button buttonAddStatic;
        private System.Windows.Forms.NumericUpDown CountEquipment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameEquipment;
        private System.Windows.Forms.DataGridView dataGridViewStaticList;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxNameEquipmentSearch;
        private System.Windows.Forms.Button buttonSearchEquipment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSearchShop;
        private System.Windows.Forms.TextBox textBoxNameShopSearch;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

