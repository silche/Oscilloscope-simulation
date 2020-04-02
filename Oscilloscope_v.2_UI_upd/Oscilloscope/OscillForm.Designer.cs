namespace Oscilloscope
{
    partial class OscillForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OscillForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.onoffradioBut = new System.Windows.Forms.RadioButton();
            this.onoff = new System.Windows.Forms.Button();
            this.voltage = new System.Windows.Forms.NumericUpDown();
            this.frequency = new System.Windows.Forms.NumericUpDown();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.genertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSignal1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createSignal2 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectChanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectChan1toolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.connectChan2toolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.заземлитьКаналыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.канал1GrouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groudChan1combo = new System.Windows.Forms.ToolStripComboBox();
            this.канал2GrouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groudChan2combo = new System.Windows.Forms.ToolStripComboBox();
            this.масштабРазвёрткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.канала1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleCh1combotoolStrip = new System.Windows.Forms.ToolStripComboBox();
            this.канала2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleCh2combotoolStrip = new System.Windows.Forms.ToolStripComboBox();
            this.ВремяРазвёрткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sweepcombo = new System.Windows.Forms.ToolStripComboBox();
            this.msmksTimeSweep = new System.Windows.Forms.ToolStripComboBox();
            this.SetCharDispToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SetCharXtoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SetCharXtoolStripCombo = new System.Windows.Forms.ToolStripComboBox();
            this.SetCharYtoolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SetCharYtoolStripCombo = new System.Windows.Forms.ToolStripComboBox();
            this.setColorsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AxesColToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.RisColToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.GridColToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SignalColToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DispColToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.display = new Oscilloscope.Display();
            this.signGener = new Oscilloscope.GeneratorSignals();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.onoffradioBut);
            this.flowLayoutPanel1.Controls.Add(this.onoff);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(804, 536);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(80, 27);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // onoffradioBut
            // 
            this.onoffradioBut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.onoffradioBut.AutoCheck = false;
            this.onoffradioBut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.onoffradioBut.Location = new System.Drawing.Point(3, 5);
            this.onoffradioBut.Name = "onoffradioBut";
            this.onoffradioBut.Size = new System.Drawing.Size(14, 17);
            this.onoffradioBut.TabIndex = 14;
            this.onoffradioBut.UseVisualStyleBackColor = true;
            // 
            // onoff
            // 
            this.onoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onoff.AutoSize = true;
            this.onoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onoff.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.onoff.Location = new System.Drawing.Point(23, 3);
            this.onoff.Name = "onoff";
            this.onoff.Size = new System.Drawing.Size(46, 22);
            this.onoff.TabIndex = 15;
            this.onoff.Text = "OFF";
            this.onoff.UseVisualStyleBackColor = true;
            this.onoff.Click += new System.EventHandler(this.onoff_Click);
            // 
            // voltage
            // 
            this.voltage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.voltage.Location = new System.Drawing.Point(762, -103);
            this.voltage.Name = "voltage";
            this.voltage.Size = new System.Drawing.Size(52, 20);
            this.voltage.TabIndex = 15;
            // 
            // frequency
            // 
            this.frequency.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.frequency.Location = new System.Drawing.Point(882, -103);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(52, 20);
            this.frequency.TabIndex = 16;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genertoolStripMenuItem,
            this.connectChanToolStripMenuItem,
            this.заземлитьКаналыToolStripMenuItem,
            this.масштабРазвёрткиToolStripMenuItem,
            this.ВремяРазвёрткиToolStripMenuItem,
            this.SetCharDispToolStrip,
            this.setColorsToolStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(908, 24);
            this.menuStrip.TabIndex = 35;
            this.menuStrip.Text = "menuStrip";
            // 
            // genertoolStripMenuItem
            // 
            this.genertoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSignal1,
            this.createSignal2});
            this.genertoolStripMenuItem.Image = global::Oscilloscope.Properties.Resources.icon5_1_;
            this.genertoolStripMenuItem.Name = "genertoolStripMenuItem";
            this.genertoolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.genertoolStripMenuItem.Text = "Сгенерировать сигнал";
            // 
            // createSignal1
            // 
            this.createSignal1.Name = "createSignal1";
            this.createSignal1.Size = new System.Drawing.Size(162, 22);
            this.createSignal1.Text = "Для 1-го канала";
            this.createSignal1.Click += new System.EventHandler(this.createSignal1_Click);
            // 
            // createSignal2
            // 
            this.createSignal2.Name = "createSignal2";
            this.createSignal2.Size = new System.Drawing.Size(162, 22);
            this.createSignal2.Text = "Для 2-го канала";
            this.createSignal2.Click += new System.EventHandler(this.createSignal2_Click);
            // 
            // connectChanToolStripMenuItem
            // 
            this.connectChanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectChan1toolStrip,
            this.connectChan2toolStrip});
            this.connectChanToolStripMenuItem.Image = global::Oscilloscope.Properties.Resources.icon_add;
            this.connectChanToolStripMenuItem.Name = "connectChanToolStripMenuItem";
            this.connectChanToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.connectChanToolStripMenuItem.Text = "Подключить канал";
            // 
            // connectChan1toolStrip
            // 
            this.connectChan1toolStrip.CheckOnClick = true;
            this.connectChan1toolStrip.Name = "connectChan1toolStrip";
            this.connectChan1toolStrip.Size = new System.Drawing.Size(153, 22);
            this.connectChan1toolStrip.Text = "Первый канал";
            this.connectChan1toolStrip.CheckedChanged += new System.EventHandler(this.connectChan1toolStrip_CheckedChanged);
            // 
            // connectChan2toolStrip
            // 
            this.connectChan2toolStrip.CheckOnClick = true;
            this.connectChan2toolStrip.Name = "connectChan2toolStrip";
            this.connectChan2toolStrip.Size = new System.Drawing.Size(153, 22);
            this.connectChan2toolStrip.Text = "Второй канал";
            this.connectChan2toolStrip.CheckedChanged += new System.EventHandler(this.connectChan2toolStrip_CheckedChanged);
            // 
            // заземлитьКаналыToolStripMenuItem
            // 
            this.заземлитьКаналыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.канал1GrouToolStripMenuItem,
            this.канал2GrouToolStripMenuItem});
            this.заземлитьКаналыToolStripMenuItem.Image = global::Oscilloscope.Properties.Resources.icon_settings_going_online;
            this.заземлитьКаналыToolStripMenuItem.Name = "заземлитьКаналыToolStripMenuItem";
            this.заземлитьКаналыToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.заземлитьКаналыToolStripMenuItem.Text = "Заземлить каналы";
            // 
            // канал1GrouToolStripMenuItem
            // 
            this.канал1GrouToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groudChan1combo});
            this.канал1GrouToolStripMenuItem.Name = "канал1GrouToolStripMenuItem";
            this.канал1GrouToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.канал1GrouToolStripMenuItem.Text = "Канал 1";
            // 
            // groudChan1combo
            // 
            this.groudChan1combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groudChan1combo.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.groudChan1combo.Items.AddRange(new object[] {
            "Земля",
            "AC/DC"});
            this.groudChan1combo.Name = "groudChan1combo";
            this.groudChan1combo.Size = new System.Drawing.Size(121, 23);
            this.groudChan1combo.SelectedIndexChanged += new System.EventHandler(this.groudChan1combo_SelectedIndexChanged);
            // 
            // канал2GrouToolStripMenuItem
            // 
            this.канал2GrouToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groudChan2combo});
            this.канал2GrouToolStripMenuItem.Name = "канал2GrouToolStripMenuItem";
            this.канал2GrouToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.канал2GrouToolStripMenuItem.Text = "Канал 2";
            // 
            // groudChan2combo
            // 
            this.groudChan2combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groudChan2combo.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.groudChan2combo.Items.AddRange(new object[] {
            "Земля",
            "AC/DC"});
            this.groudChan2combo.Name = "groudChan2combo";
            this.groudChan2combo.Size = new System.Drawing.Size(121, 23);
            this.groudChan2combo.SelectedIndexChanged += new System.EventHandler(this.groudChan2combo_SelectedIndexChanged);
            // 
            // масштабРазвёрткиToolStripMenuItem
            // 
            this.масштабРазвёрткиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.канала1ToolStripMenuItem,
            this.канала2ToolStripMenuItem});
            this.масштабРазвёрткиToolStripMenuItem.Image = global::Oscilloscope.Properties.Resources.iconMesh;
            this.масштабРазвёрткиToolStripMenuItem.Name = "масштабРазвёрткиToolStripMenuItem";
            this.масштабРазвёрткиToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.масштабРазвёрткиToolStripMenuItem.Text = "Масштаб развёртки";
            // 
            // канала1ToolStripMenuItem
            // 
            this.канала1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scaleCh1combotoolStrip});
            this.канала1ToolStripMenuItem.Name = "канала1ToolStripMenuItem";
            this.канала1ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.канала1ToolStripMenuItem.Text = "Первого канала";
            // 
            // scaleCh1combotoolStrip
            // 
            this.scaleCh1combotoolStrip.Name = "scaleCh1combotoolStrip";
            this.scaleCh1combotoolStrip.Size = new System.Drawing.Size(121, 23);
            this.scaleCh1combotoolStrip.Text = "Выбрать";
            this.scaleCh1combotoolStrip.SelectedIndexChanged += new System.EventHandler(this.scaleCh1combo_SelectedIndexChanged);
            // 
            // канала2ToolStripMenuItem
            // 
            this.канала2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scaleCh2combotoolStrip});
            this.канала2ToolStripMenuItem.Name = "канала2ToolStripMenuItem";
            this.канала2ToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.канала2ToolStripMenuItem.Text = "Второго канала";
            // 
            // scaleCh2combotoolStrip
            // 
            this.scaleCh2combotoolStrip.Name = "scaleCh2combotoolStrip";
            this.scaleCh2combotoolStrip.Size = new System.Drawing.Size(121, 23);
            this.scaleCh2combotoolStrip.Text = "Выбрать";
            this.scaleCh2combotoolStrip.SelectedIndexChanged += new System.EventHandler(this.scaleCh2combo_SelectedIndexChanged);
            // 
            // ВремяРазвёрткиToolStripMenuItem
            // 
            this.ВремяРазвёрткиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sweepcombo,
            this.msmksTimeSweep});
            this.ВремяРазвёрткиToolStripMenuItem.Image = global::Oscilloscope.Properties.Resources.iconCollada;
            this.ВремяРазвёрткиToolStripMenuItem.Name = "ВремяРазвёрткиToolStripMenuItem";
            this.ВремяРазвёрткиToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.ВремяРазвёрткиToolStripMenuItem.Text = "Время развёртки";
            // 
            // sweepcombo
            // 
            this.sweepcombo.Name = "sweepcombo";
            this.sweepcombo.Size = new System.Drawing.Size(121, 23);
            this.sweepcombo.SelectedIndexChanged += new System.EventHandler(this.sweepcombo_SelectedIndexChanged);
            // 
            // msmksTimeSweep
            // 
            this.msmksTimeSweep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.msmksTimeSweep.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.msmksTimeSweep.Items.AddRange(new object[] {
            "ms",
            "µs"});
            this.msmksTimeSweep.Name = "msmksTimeSweep";
            this.msmksTimeSweep.Size = new System.Drawing.Size(121, 23);
            this.msmksTimeSweep.SelectedIndexChanged += new System.EventHandler(this.msmksTimeSweep_SelectedIndexChanged);
            // 
            // SetCharDispToolStrip
            // 
            this.SetCharDispToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetCharXtoolStrip,
            this.SetCharYtoolStrip});
            this.SetCharDispToolStrip.Image = global::Oscilloscope.Properties.Resources.icon_dropdownbar;
            this.SetCharDispToolStrip.Name = "SetCharDispToolStrip";
            this.SetCharDispToolStrip.Size = new System.Drawing.Size(169, 20);
            this.SetCharDispToolStrip.Text = "Изменить сетку дисплея";
            // 
            // SetCharXtoolStrip
            // 
            this.SetCharXtoolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetCharXtoolStripCombo});
            this.SetCharXtoolStrip.Name = "SetCharXtoolStrip";
            this.SetCharXtoolStrip.Size = new System.Drawing.Size(123, 22);
            this.SetCharXtoolStrip.Text = "По оси X";
            // 
            // SetCharXtoolStripCombo
            // 
            this.SetCharXtoolStripCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SetCharXtoolStripCombo.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.SetCharXtoolStripCombo.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40",
            "42",
            "44",
            "46",
            "48",
            "50"});
            this.SetCharXtoolStripCombo.Name = "SetCharXtoolStripCombo";
            this.SetCharXtoolStripCombo.Size = new System.Drawing.Size(121, 23);
            this.SetCharXtoolStripCombo.SelectedIndexChanged += new System.EventHandler(this.SetCharXtoolStripCombo_SelectedIndexChanged);
            // 
            // SetCharYtoolStrip
            // 
            this.SetCharYtoolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetCharYtoolStripCombo});
            this.SetCharYtoolStrip.Name = "SetCharYtoolStrip";
            this.SetCharYtoolStrip.Size = new System.Drawing.Size(123, 22);
            this.SetCharYtoolStrip.Text = "По оси Y";
            // 
            // SetCharYtoolStripCombo
            // 
            this.SetCharYtoolStripCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SetCharYtoolStripCombo.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.SetCharYtoolStripCombo.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40",
            "42",
            "44",
            "46",
            "48",
            "50"});
            this.SetCharYtoolStripCombo.Name = "SetCharYtoolStripCombo";
            this.SetCharYtoolStripCombo.Size = new System.Drawing.Size(121, 23);
            this.SetCharYtoolStripCombo.SelectedIndexChanged += new System.EventHandler(this.SetCharYtoolStripCombo_SelectedIndexChanged);
            // 
            // setColorsToolStrip
            // 
            this.setColorsToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AxesColToolStrip,
            this.RisColToolStrip,
            this.GridColToolStrip,
            this.SignalColToolStrip,
            this.DispColToolStrip});
            this.setColorsToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("setColorsToolStrip.Image")));
            this.setColorsToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.setColorsToolStrip.Name = "setColorsToolStrip";
            this.setColorsToolStrip.Size = new System.Drawing.Size(116, 20);
            this.setColorsToolStrip.Text = "Изменить цвет";
            // 
            // AxesColToolStrip
            // 
            this.AxesColToolStrip.Name = "AxesColToolStrip";
            this.AxesColToolStrip.Size = new System.Drawing.Size(151, 22);
            this.AxesColToolStrip.Text = "Осей";
            this.AxesColToolStrip.Click += new System.EventHandler(this.AxesColToolStrip_Click);
            // 
            // RisColToolStrip
            // 
            this.RisColToolStrip.Name = "RisColToolStrip";
            this.RisColToolStrip.Size = new System.Drawing.Size(151, 22);
            this.RisColToolStrip.Text = "Рисок";
            this.RisColToolStrip.Click += new System.EventHandler(this.RisColToolStrip_Click);
            // 
            // GridColToolStrip
            // 
            this.GridColToolStrip.Name = "GridColToolStrip";
            this.GridColToolStrip.Size = new System.Drawing.Size(151, 22);
            this.GridColToolStrip.Text = "Сетки";
            this.GridColToolStrip.Click += new System.EventHandler(this.GridColToolStrip_Click);
            // 
            // SignalColToolStrip
            // 
            this.SignalColToolStrip.Name = "SignalColToolStrip";
            this.SignalColToolStrip.Size = new System.Drawing.Size(151, 22);
            this.SignalColToolStrip.Text = "Сигнала";
            this.SignalColToolStrip.Click += new System.EventHandler(this.SignalColToolStrip_Click);
            // 
            // DispColToolStrip
            // 
            this.DispColToolStrip.Name = "DispColToolStrip";
            this.DispColToolStrip.Size = new System.Drawing.Size(151, 22);
            this.DispColToolStrip.Text = "Фона дисплея";
            this.DispColToolStrip.Click += new System.EventHandler(this.DispColToolStrip_Click);
            // 
            // display
            // 
            this.display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.display.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.display.BackColorGrid = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.display.ColorAxes = System.Drawing.Color.Black;
            this.display.ColorGrid = System.Drawing.Color.Black;
            this.display.ColorStrokes = System.Drawing.Color.Black;
            this.display.Cursor = System.Windows.Forms.Cursors.Cross;
            this.display.Location = new System.Drawing.Point(12, 12);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(884, 562);
            this.display.TabIndex = 31;
            this.toolTip.SetToolTip(this.display, "Для смещения сигналов на дисплее используйте мышь.");
            this.display.XSize = 16;
            this.display.YSize = 12;
            this.display.Paint += new System.Windows.Forms.PaintEventHandler(this.display_Paint);
            this.display.MouseDown += new System.Windows.Forms.MouseEventHandler(this.display_MouseDown);
            this.display.MouseMove += new System.Windows.Forms.MouseEventHandler(this.display_MouseMove);
            this.display.MouseUp += new System.Windows.Forms.MouseEventHandler(this.display_MouseUp);
            // 
            // signGener
            // 
            this.signGener.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.signGener.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.signGener.Location = new System.Drawing.Point(215, 60);
            this.signGener.Name = "signGener";
            this.signGener.Size = new System.Drawing.Size(405, 157);
            this.signGener.TabIndex = 29;
            this.signGener.Visible = false;
            this.signGener.VisibleChanged += new System.EventHandler(this.signGener_VisibleChanged);
            // 
            // OscillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(908, 586);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.signGener);
            this.Controls.Add(this.frequency);
            this.Controls.Add(this.voltage);
            this.Controls.Add(this.display);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "OscillForm";
            this.Text = "Oscilloscope";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton onoffradioBut;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown voltage;
        private System.Windows.Forms.NumericUpDown frequency;
        private GeneratorSignals signGener;
        private System.Windows.Forms.Button onoff;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem setColorsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem AxesColToolStrip;
        private System.Windows.Forms.ToolStripMenuItem RisColToolStrip;
        private System.Windows.Forms.ToolStripMenuItem GridColToolStrip;
        private System.Windows.Forms.ToolStripMenuItem SignalColToolStrip;
        private System.Windows.Forms.ToolStripMenuItem DispColToolStrip;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripMenuItem SetCharDispToolStrip;
        private System.Windows.Forms.ToolStripMenuItem connectChanToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem connectChan1toolStrip;
        public System.Windows.Forms.ToolStripMenuItem connectChan2toolStrip;
        private System.Windows.Forms.ToolStripMenuItem genertoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetCharXtoolStrip;
        private System.Windows.Forms.ToolStripComboBox SetCharXtoolStripCombo;
        private System.Windows.Forms.ToolStripMenuItem SetCharYtoolStrip;
        private System.Windows.Forms.ToolStripComboBox SetCharYtoolStripCombo;
        private System.Windows.Forms.ToolStripMenuItem масштабРазвёрткиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSignal1;
        private System.Windows.Forms.ToolStripMenuItem createSignal2;
        private System.Windows.Forms.ToolStripMenuItem канала1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem канала2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox scaleCh1combotoolStrip;
        private System.Windows.Forms.ToolStripComboBox scaleCh2combotoolStrip;
        private System.Windows.Forms.ToolStripMenuItem заземлитьКаналыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem канал1GrouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem канал2GrouToolStripMenuItem;
        public System.Windows.Forms.ToolStripComboBox groudChan1combo;
        public System.Windows.Forms.ToolStripComboBox groudChan2combo;
        private System.Windows.Forms.ToolStripMenuItem ВремяРазвёрткиToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox sweepcombo;
        private System.Windows.Forms.ToolStripComboBox msmksTimeSweep;
        private System.Windows.Forms.ToolTip toolTip;
        private Display display;

    }
}

