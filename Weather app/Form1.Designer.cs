namespace Weather_app
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Settings = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.SettingsTextBox2 = new System.Windows.Forms.TextBox();
            this.SettingsTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingsCancel = new System.Windows.Forms.Button();
            this.SettingsOK = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.temp = new System.Windows.Forms.Label();
            this.main = new System.Windows.Forms.Label();
            this.WeatherCondition = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.wind = new System.Windows.Forms.Label();
            this.visibility = new System.Windows.Forms.Label();
            this.windArrow = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.Label();
            this.sunset = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.webrequest = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherCondition)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.Settings, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.header, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SettingsPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(431, 241);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Settings
            // 
            this.Settings.BackgroundImage = global::Weather_app.Properties.Resources.menu;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Settings.Location = new System.Drawing.Point(394, 3);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(34, 44);
            this.Settings.TabIndex = 2;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            this.Settings.MouseHover += new System.EventHandler(this.button_mousehover);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(391, 50);
            this.header.TabIndex = 1;
            this.header.Text = "Kiev, UA, date";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.SettingsPanel, 2);
            this.SettingsPanel.Controls.Add(this.SettingsTextBox2);
            this.SettingsPanel.Controls.Add(this.SettingsTextBox1);
            this.SettingsPanel.Controls.Add(this.label2);
            this.SettingsPanel.Controls.Add(this.label1);
            this.SettingsPanel.Controls.Add(this.SettingsCancel);
            this.SettingsPanel.Controls.Add(this.SettingsOK);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(3, 53);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(425, 100);
            this.SettingsPanel.TabIndex = 3;
            this.SettingsPanel.Visible = false;
            // 
            // SettingsTextBox2
            // 
            this.SettingsTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsTextBox2.Location = new System.Drawing.Point(288, 84);
            this.SettingsTextBox2.Name = "SettingsTextBox2";
            this.SettingsTextBox2.Size = new System.Drawing.Size(84, 29);
            this.SettingsTextBox2.TabIndex = 5;
            // 
            // SettingsTextBox1
            // 
            this.SettingsTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsTextBox1.Location = new System.Drawing.Point(137, 31);
            this.SettingsTextBox1.Name = "SettingsTextBox1";
            this.SettingsTextBox1.Size = new System.Drawing.Size(235, 29);
            this.SettingsTextBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(57, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Country code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "City:";
            // 
            // SettingsCancel
            // 
            this.SettingsCancel.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsCancel.Location = new System.Drawing.Point(266, 132);
            this.SettingsCancel.Name = "SettingsCancel";
            this.SettingsCancel.Size = new System.Drawing.Size(106, 38);
            this.SettingsCancel.TabIndex = 1;
            this.SettingsCancel.Text = "Cancel";
            this.SettingsCancel.UseVisualStyleBackColor = true;
            this.SettingsCancel.Click += new System.EventHandler(this.SettingsCancel_Click);
            // 
            // SettingsOK
            // 
            this.SettingsOK.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsOK.Location = new System.Drawing.Point(61, 132);
            this.SettingsOK.Name = "SettingsOK";
            this.SettingsOK.Size = new System.Drawing.Size(106, 38);
            this.SettingsOK.TabIndex = 0;
            this.SettingsOK.Text = "OK";
            this.SettingsOK.UseVisualStyleBackColor = true;
            this.SettingsOK.Click += new System.EventHandler(this.SettingsOK_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 159);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(425, 79);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.temp, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.main, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.WeatherCondition, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(233, 79);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.SetColumnSpan(this.temp, 2);
            this.temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temp.Font = new System.Drawing.Font("Monospac821 BT", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.temp.Location = new System.Drawing.Point(0, 80);
            this.temp.Margin = new System.Windows.Forms.Padding(0);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(233, 86);
            this.temp.TabIndex = 0;
            this.temp.Text = "+33°";
            this.temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main
            // 
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.main.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.main.Location = new System.Drawing.Point(90, 0);
            this.main.Margin = new System.Windows.Forms.Padding(0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(143, 80);
            this.main.TabIndex = 1;
            this.main.Text = "456";
            this.main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeatherCondition
            // 
            this.WeatherCondition.BackColor = System.Drawing.SystemColors.Control;
            this.WeatherCondition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WeatherCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeatherCondition.Location = new System.Drawing.Point(0, 0);
            this.WeatherCondition.Margin = new System.Windows.Forms.Padding(0);
            this.WeatherCondition.Name = "WeatherCondition";
            this.WeatherCondition.Size = new System.Drawing.Size(90, 80);
            this.WeatherCondition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WeatherCondition.TabIndex = 2;
            this.WeatherCondition.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.wind, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.visibility, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.windArrow, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.sunrise, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.sunset, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.humidity, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.pressure, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox2, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox4, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox5, 0, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(233, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(192, 79);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // wind
            // 
            this.wind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.wind.AutoSize = true;
            this.wind.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.wind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wind.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.wind.Location = new System.Drawing.Point(30, 26);
            this.wind.Margin = new System.Windows.Forms.Padding(0);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(54, 13);
            this.wind.TabIndex = 2;
            this.wind.Text = "wind";
            this.wind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // visibility
            // 
            this.visibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.visibility.AutoSize = true;
            this.visibility.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.visibility.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.visibility.Location = new System.Drawing.Point(30, 39);
            this.visibility.Margin = new System.Windows.Forms.Padding(0);
            this.visibility.Name = "visibility";
            this.visibility.Size = new System.Drawing.Size(82, 13);
            this.visibility.TabIndex = 3;
            this.visibility.Text = "visibility";
            this.visibility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windArrow
            // 
            this.windArrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.windArrow.AutoSize = true;
            this.windArrow.Font = new System.Drawing.Font("AcadEref", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windArrow.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.windArrow.Location = new System.Drawing.Point(5, 26);
            this.windArrow.Margin = new System.Windows.Forms.Padding(0);
            this.windArrow.Name = "windArrow";
            this.windArrow.Size = new System.Drawing.Size(25, 13);
            this.windArrow.TabIndex = 6;
            this.windArrow.Text = "1";
            this.windArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sunrise
            // 
            this.sunrise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sunrise.AutoSize = true;
            this.sunrise.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sunrise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sunrise.Location = new System.Drawing.Point(30, 52);
            this.sunrise.Margin = new System.Windows.Forms.Padding(0);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(71, 12);
            this.sunrise.TabIndex = 4;
            this.sunrise.Text = "sunrise";
            this.sunrise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sunset
            // 
            this.sunset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sunset.AutoSize = true;
            this.sunset.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sunset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sunset.Location = new System.Drawing.Point(30, 64);
            this.sunset.Margin = new System.Windows.Forms.Padding(0);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(66, 15);
            this.sunset.TabIndex = 5;
            this.sunset.Text = "sunset";
            // 
            // humidity
            // 
            this.humidity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.humidity.AutoSize = true;
            this.humidity.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.humidity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.humidity.Location = new System.Drawing.Point(30, 13);
            this.humidity.Margin = new System.Windows.Forms.Padding(0);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(89, 13);
            this.humidity.TabIndex = 1;
            this.humidity.Text = "humidity";
            this.humidity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pressure
            // 
            this.pressure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pressure.AutoSize = true;
            this.pressure.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.pressure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pressure.Location = new System.Drawing.Point(30, 0);
            this.pressure.Margin = new System.Windows.Forms.Padding(0);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(83, 13);
            this.pressure.TabIndex = 0;
            this.pressure.Text = "pressure";
            this.pressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Weather_app.Properties.Resources._44;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 13);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Weather_app.Properties.Resources.icon_visibility23;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(0, 39);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 13);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 13);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Weather_app.Properties.Resources.Weather_Sunrise_icon;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(0, 52);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 12);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Weather_app.Properties.Resources.Weather_Sunset_icon;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(0, 64);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 15);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // webrequest
            // 
            this.webrequest.Enabled = true;
            this.webrequest.Interval = 1000;
            this.webrequest.Tick += new System.EventHandler(this.webrequest_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 241);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 280);
            this.MinimumSize = new System.Drawing.Size(447, 277);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherCondition)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label wind;
        private System.Windows.Forms.Label visibility;
        private System.Windows.Forms.Label sunrise;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label main;
        private System.Windows.Forms.Timer webrequest;
        private System.Windows.Forms.Label sunset;
        private System.Windows.Forms.Label windArrow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox WeatherCondition;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.TextBox SettingsTextBox2;
        private System.Windows.Forms.TextBox SettingsTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SettingsCancel;
        private System.Windows.Forms.Button SettingsOK;
    }
}

