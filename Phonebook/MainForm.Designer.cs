namespace PhoneBook
{
    partial class MainForm
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
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.HouseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FlatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Quantity_ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.QuantityToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Number_ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NumberToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.абонентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоФИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоАдресуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоНомеруТелефонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.поВозрастаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поОтчествуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУлицеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДомуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКвартиреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поТелефонуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФамилииToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поИмениToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поОтчествуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поУлицеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поДомуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поКвартиреToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поТелефонуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.HouseNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlatNumericUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviousButton
            // 
            this.PreviousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousButton.Location = new System.Drawing.Point(119, 318);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(48, 34);
            this.PreviousButton.TabIndex = 0;
            this.PreviousButton.Text = "<";
            this.PreviousButton.UseVisualStyleBackColor = false;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(194, 318);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(48, 34);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(43, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Улица";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(43, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дом";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(43, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Квартира";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(43, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Телефон";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Enabled = false;
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTextBox.Location = new System.Drawing.Point(181, 48);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(147, 26);
            this.LastNameTextBox.TabIndex = 9;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(181, 85);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(147, 26);
            this.NameTextBox.TabIndex = 10;
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Enabled = false;
            this.PatronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicTextBox.Location = new System.Drawing.Point(181, 120);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(147, 26);
            this.PatronymicTextBox.TabIndex = 11;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Enabled = false;
            this.StreetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetTextBox.Location = new System.Drawing.Point(181, 158);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(147, 26);
            this.StreetTextBox.TabIndex = 12;
            // 
            // HouseNumericUpDown
            // 
            this.HouseNumericUpDown.Enabled = false;
            this.HouseNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HouseNumericUpDown.Location = new System.Drawing.Point(181, 194);
            this.HouseNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.HouseNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HouseNumericUpDown.Name = "HouseNumericUpDown";
            this.HouseNumericUpDown.Size = new System.Drawing.Size(147, 26);
            this.HouseNumericUpDown.TabIndex = 13;
            this.HouseNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FlatNumericUpDown
            // 
            this.FlatNumericUpDown.Enabled = false;
            this.FlatNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlatNumericUpDown.Location = new System.Drawing.Point(181, 230);
            this.FlatNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.FlatNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FlatNumericUpDown.Name = "FlatNumericUpDown";
            this.FlatNumericUpDown.Size = new System.Drawing.Size(147, 26);
            this.FlatNumericUpDown.TabIndex = 14;
            this.FlatNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Enabled = false;
            this.PhoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(181, 267);
            this.PhoneMaskedTextBox.Mask = "(999) 000-0000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(147, 26);
            this.PhoneMaskedTextBox.TabIndex = 15;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Quantity_ToolStripStatusLabel,
            this.QuantityToolStripStatusLabel,
            this.Number_ToolStripStatusLabel,
            this.NumberToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(378, 24);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Quantity_ToolStripStatusLabel
            // 
            this.Quantity_ToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Quantity_ToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.Quantity_ToolStripStatusLabel.Name = "Quantity_ToolStripStatusLabel";
            this.Quantity_ToolStripStatusLabel.Size = new System.Drawing.Size(123, 19);
            this.Quantity_ToolStripStatusLabel.Text = "Количество записей";
            // 
            // QuantityToolStripStatusLabel
            // 
            this.QuantityToolStripStatusLabel.AutoSize = false;
            this.QuantityToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.QuantityToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.QuantityToolStripStatusLabel.Name = "QuantityToolStripStatusLabel";
            this.QuantityToolStripStatusLabel.Size = new System.Drawing.Size(30, 19);
            this.QuantityToolStripStatusLabel.Text = "0";
            // 
            // Number_ToolStripStatusLabel
            // 
            this.Number_ToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Number_ToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.Number_ToolStripStatusLabel.Name = "Number_ToolStripStatusLabel";
            this.Number_ToolStripStatusLabel.Size = new System.Drawing.Size(90, 19);
            this.Number_ToolStripStatusLabel.Text = "Номер записи";
            // 
            // NumberToolStripStatusLabel
            // 
            this.NumberToolStripStatusLabel.AutoSize = false;
            this.NumberToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.NumberToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.NumberToolStripStatusLabel.Name = "NumberToolStripStatusLabel";
            this.NumberToolStripStatusLabel.Size = new System.Drawing.Size(30, 19);
            this.NumberToolStripStatusLabel.Text = "0";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.абонентToolStripMenuItem,
            this.файлToolStripMenuItem,
            this.сортировкаToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(378, 24);
            this.MainMenu.TabIndex = 17;
            this.MainMenu.Text = "menuStrip1";
            // 
            // абонентToolStripMenuItem
            // 
            this.абонентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.абонентToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.абонентToolStripMenuItem.Name = "абонентToolStripMenuItem";
            this.абонентToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.абонентToolStripMenuItem.Text = "Абонент";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.ДобавитьToolStripMenuItem_Click_1);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискПоФИОToolStripMenuItem,
            this.поискПоАдресуToolStripMenuItem,
            this.поискПоНомеруТелефонаToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // поискПоФИОToolStripMenuItem
            // 
            this.поискПоФИОToolStripMenuItem.Name = "поискПоФИОToolStripMenuItem";
            this.поискПоФИОToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.поискПоФИОToolStripMenuItem.Text = "Поиск по ФИО";
            this.поискПоФИОToolStripMenuItem.Click += new System.EventHandler(this.ПоискПоФИОToolStripMenuItem_Click);
            // 
            // поискПоАдресуToolStripMenuItem
            // 
            this.поискПоАдресуToolStripMenuItem.Name = "поискПоАдресуToolStripMenuItem";
            this.поискПоАдресуToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.поискПоАдресуToolStripMenuItem.Text = "Поиск по адресу";
            this.поискПоАдресуToolStripMenuItem.Click += new System.EventHandler(this.ПоискПоАдресуToolStripMenuItem_Click);
            // 
            // поискПоНомеруТелефонаToolStripMenuItem
            // 
            this.поискПоНомеруТелефонаToolStripMenuItem.Name = "поискПоНомеруТелефонаToolStripMenuItem";
            this.поискПоНомеруТелефонаToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.поискПоНомеруТелефонаToolStripMenuItem.Text = "Поиск по номеру телефона";
            this.поискПоНомеруТелефонаToolStripMenuItem.Click += new System.EventHandler(this.ПоискПоНомеруТелефонаToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.ИзменитьToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поВозрастаниюToolStripMenuItem,
            this.поУбываниюToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Текстовые файлы|*.txt|Xml  файлы|*.xml";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Текстовые файлы|*.txt|Xml  файлы|*.xml";
            // 
            // поВозрастаниюToolStripMenuItem
            // 
            this.поВозрастаниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поФамилииToolStripMenuItem,
            this.поИмениToolStripMenuItem,
            this.поОтчествуToolStripMenuItem,
            this.поУлицеToolStripMenuItem,
            this.поДомуToolStripMenuItem,
            this.поКвартиреToolStripMenuItem,
            this.поТелефонуToolStripMenuItem});
            this.поВозрастаниюToolStripMenuItem.Name = "поВозрастаниюToolStripMenuItem";
            this.поВозрастаниюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поВозрастаниюToolStripMenuItem.Text = "По возрастанию";
            // 
            // поУбываниюToolStripMenuItem
            // 
            this.поУбываниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поФамилииToolStripMenuItem1,
            this.поИмениToolStripMenuItem1,
            this.поОтчествуToolStripMenuItem1,
            this.поУлицеToolStripMenuItem1,
            this.поДомуToolStripMenuItem1,
            this.поКвартиреToolStripMenuItem1,
            this.поТелефонуToolStripMenuItem1});
            this.поУбываниюToolStripMenuItem.Name = "поУбываниюToolStripMenuItem";
            this.поУбываниюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поУбываниюToolStripMenuItem.Text = "По убыванию";
            // 
            // поФамилииToolStripMenuItem
            // 
            this.поФамилииToolStripMenuItem.Name = "поФамилииToolStripMenuItem";
            this.поФамилииToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поФамилииToolStripMenuItem.Text = "По фамилии";
            this.поФамилииToolStripMenuItem.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem_Click);
            // 
            // поИмениToolStripMenuItem
            // 
            this.поИмениToolStripMenuItem.Name = "поИмениToolStripMenuItem";
            this.поИмениToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поИмениToolStripMenuItem.Text = "По имени";
            this.поИмениToolStripMenuItem.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem6_Click);
            // 
            // поОтчествуToolStripMenuItem
            // 
            this.поОтчествуToolStripMenuItem.Name = "поОтчествуToolStripMenuItem";
            this.поОтчествуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поОтчествуToolStripMenuItem.Text = "По отчеству";
            this.поОтчествуToolStripMenuItem.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem1_Click);
            // 
            // поУлицеToolStripMenuItem
            // 
            this.поУлицеToolStripMenuItem.Name = "поУлицеToolStripMenuItem";
            this.поУлицеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поУлицеToolStripMenuItem.Text = "По улице";
            this.поУлицеToolStripMenuItem.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem2_Click);
            // 
            // поДомуToolStripMenuItem
            // 
            this.поДомуToolStripMenuItem.Name = "поДомуToolStripMenuItem";
            this.поДомуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поДомуToolStripMenuItem.Text = "По дому";
            this.поДомуToolStripMenuItem.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem3_Click);
            // 
            // поКвартиреToolStripMenuItem
            // 
            this.поКвартиреToolStripMenuItem.Name = "поКвартиреToolStripMenuItem";
            this.поКвартиреToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поКвартиреToolStripMenuItem.Text = "По квартире";
            this.поКвартиреToolStripMenuItem.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem4_Click);
            // 
            // поТелефонуToolStripMenuItem
            // 
            this.поТелефонуToolStripMenuItem.Name = "поТелефонуToolStripMenuItem";
            this.поТелефонуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поТелефонуToolStripMenuItem.Text = "По телефону";
            this.поТелефонуToolStripMenuItem.Click += new System.EventHandler(this.поВозрастаниюToolStripMenuItem5_Click);
            // 
            // поФамилииToolStripMenuItem1
            // 
            this.поФамилииToolStripMenuItem1.Name = "поФамилииToolStripMenuItem1";
            this.поФамилииToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.поФамилииToolStripMenuItem1.Text = "По фамилии";
            this.поФамилииToolStripMenuItem1.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem_Click);
            // 
            // поИмениToolStripMenuItem1
            // 
            this.поИмениToolStripMenuItem1.Name = "поИмениToolStripMenuItem1";
            this.поИмениToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.поИмениToolStripMenuItem1.Text = "По имени";
            this.поИмениToolStripMenuItem1.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem6_Click);
            // 
            // поОтчествуToolStripMenuItem1
            // 
            this.поОтчествуToolStripMenuItem1.Name = "поОтчествуToolStripMenuItem1";
            this.поОтчествуToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.поОтчествуToolStripMenuItem1.Text = "По отчеству";
            this.поОтчествуToolStripMenuItem1.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem1_Click);
            // 
            // поУлицеToolStripMenuItem1
            // 
            this.поУлицеToolStripMenuItem1.Name = "поУлицеToolStripMenuItem1";
            this.поУлицеToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.поУлицеToolStripMenuItem1.Text = "По улице";
            this.поУлицеToolStripMenuItem1.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem2_Click);
            // 
            // поДомуToolStripMenuItem1
            // 
            this.поДомуToolStripMenuItem1.Name = "поДомуToolStripMenuItem1";
            this.поДомуToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.поДомуToolStripMenuItem1.Text = "По дому";
            this.поДомуToolStripMenuItem1.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem3_Click);
            // 
            // поКвартиреToolStripMenuItem1
            // 
            this.поКвартиреToolStripMenuItem1.Name = "поКвартиреToolStripMenuItem1";
            this.поКвартиреToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.поКвартиреToolStripMenuItem1.Text = "По квартире";
            this.поКвартиреToolStripMenuItem1.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem4_Click);
            // 
            // поТелефонуToolStripMenuItem1
            // 
            this.поТелефонуToolStripMenuItem1.Name = "поТелефонуToolStripMenuItem1";
            this.поТелефонуToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.поТелефонуToolStripMenuItem1.Text = "По телефону";
            this.поТелефонуToolStripMenuItem1.Click += new System.EventHandler(this.поУбываниюToolStripMenuItem5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 483);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.FlatNumericUpDown);
            this.Controls.Add(this.HouseNumericUpDown);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Телефонный справочник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.HouseNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlatNumericUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.NumericUpDown HouseNumericUpDown;
        private System.Windows.Forms.NumericUpDown FlatNumericUpDown;
        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Quantity_ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel QuantityToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Number_ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel NumberToolStripStatusLabel;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem абонентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоФИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоАдресуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоНомеруТелефонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИмениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поОтчествуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУлицеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДомуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКвартиреToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поТелефонуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФамилииToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поИмениToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поОтчествуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поУлицеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поДомуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поКвартиреToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поТелефонуToolStripMenuItem1;
    }
}

