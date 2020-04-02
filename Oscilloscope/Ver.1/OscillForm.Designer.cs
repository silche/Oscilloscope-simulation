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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OscillForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.exit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.onoffradioBut = new System.Windows.Forms.RadioButton();
            this.onoff = new System.Windows.Forms.Button();
            this.bluetrack = new System.Windows.Forms.TrackBar();
            this.greentrack = new System.Windows.Forms.TrackBar();
            this.voltage = new System.Windows.Forms.NumericUpDown();
            this.frequency = new System.Windows.Forms.NumericUpDown();
            this.podatlabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.sweepcombo = new System.Windows.Forms.ComboBox();
            this.sweepgroupBox = new System.Windows.Forms.GroupBox();
            this.smeschXtrack = new System.Windows.Forms.TrackBar();
            this.smeschXlabel = new System.Windows.Forms.Label();
            this.msmksTimeSweep = new System.Windows.Forms.ComboBox();
            this.genergroupBox = new System.Windows.Forms.GroupBox();
            this.createSignal2 = new System.Windows.Forms.Button();
            this.createSignal1 = new System.Windows.Forms.Button();
            this.channel1check = new System.Windows.Forms.CheckBox();
            this.channel2check = new System.Windows.Forms.CheckBox();
            this.channelsgroupBox = new System.Windows.Forms.GroupBox();
            this.podkllabel = new System.Windows.Forms.Label();
            this.controlChangroupBox = new System.Windows.Forms.GroupBox();
            this.channel2groupBox = new System.Windows.Forms.GroupBox();
            this.scaleCh2combo = new System.Windows.Forms.ComboBox();
            this.channel2track = new System.Windows.Forms.TrackBar();
            this.groudChan2combo = new System.Windows.Forms.ComboBox();
            this.channel1groupBox = new System.Windows.Forms.GroupBox();
            this.scaleCh1combo = new System.Windows.Forms.ComboBox();
            this.channel1track = new System.Windows.Forms.TrackBar();
            this.groudChan1combo = new System.Windows.Forms.ComboBox();
            this.colorgroupBox = new System.Windows.Forms.GroupBox();
            this.signradioBut = new System.Windows.Forms.RadioButton();
            this.setColorcheckB = new System.Windows.Forms.CheckBox();
            this.formradioBut = new System.Windows.Forms.RadioButton();
            this.dispradioBut = new System.Windows.Forms.RadioButton();
            this.gridradioBut = new System.Windows.Forms.RadioButton();
            this.risradioBut = new System.Windows.Forms.RadioButton();
            this.axradioBut = new System.Windows.Forms.RadioButton();
            this.redtrack = new System.Windows.Forms.TrackBar();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signGener = new Oscilloscope.GeneratorSignals();
            this.display = new Oscilloscope.Display();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bluetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greentrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.sweepgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smeschXtrack)).BeginInit();
            this.genergroupBox.SuspendLayout();
            this.channelsgroupBox.SuspendLayout();
            this.controlChangroupBox.SuspendLayout();
            this.channel2groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channel2track)).BeginInit();
            this.channel1groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channel1track)).BeginInit();
            this.colorgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redtrack)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.62687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.37313F));
            this.tableLayoutPanel1.Controls.Add(this.exit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(827, 499);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.35644F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 33);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Location = new System.Drawing.Point(164, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(49, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.onoffradioBut);
            this.flowLayoutPanel1.Controls.Add(this.onoff);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
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
            // bluetrack
            // 
            this.bluetrack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bluetrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bluetrack.LargeChange = 2;
            this.bluetrack.Location = new System.Drawing.Point(6, 270);
            this.bluetrack.Maximum = 255;
            this.bluetrack.Name = "bluetrack";
            this.bluetrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bluetrack.Size = new System.Drawing.Size(208, 45);
            this.bluetrack.TabIndex = 12;
            this.bluetrack.Scroll += new System.EventHandler(this.bluetrack_Scroll);
            // 
            // greentrack
            // 
            this.greentrack.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.greentrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greentrack.Location = new System.Drawing.Point(3, 211);
            this.greentrack.Maximum = 255;
            this.greentrack.Name = "greentrack";
            this.greentrack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.greentrack.Size = new System.Drawing.Size(208, 45);
            this.greentrack.TabIndex = 13;
            this.greentrack.Scroll += new System.EventHandler(this.greentrack_Scroll);
            // 
            // voltage
            // 
            this.voltage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.voltage.Location = new System.Drawing.Point(907, -110);
            this.voltage.Name = "voltage";
            this.voltage.Size = new System.Drawing.Size(52, 20);
            this.voltage.TabIndex = 15;
            // 
            // frequency
            // 
            this.frequency.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.frequency.Location = new System.Drawing.Point(1027, -110);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(52, 20);
            this.frequency.TabIndex = 16;
            // 
            // podatlabel
            // 
            this.podatlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.podatlabel.AutoSize = true;
            this.podatlabel.BackColor = System.Drawing.SystemColors.Window;
            this.podatlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.podatlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.podatlabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.podatlabel.Location = new System.Drawing.Point(6, 16);
            this.podatlabel.Name = "podatlabel";
            this.podatlabel.Size = new System.Drawing.Size(49, 15);
            this.podatlabel.TabIndex = 17;
            this.podatlabel.Text = "Подать:";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GrayText;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1053, 24);
            this.menuStrip.TabIndex = 20;
            this.menuStrip.Text = "menuStrip";
            // 
            // sweepcombo
            // 
            this.sweepcombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sweepcombo.FormattingEnabled = true;
            this.sweepcombo.Location = new System.Drawing.Point(878, 60);
            this.sweepcombo.Name = "sweepcombo";
            this.sweepcombo.Size = new System.Drawing.Size(94, 21);
            this.sweepcombo.TabIndex = 21;
            this.sweepcombo.SelectedIndexChanged += new System.EventHandler(this.sweepcombo_SelectedIndexChanged);
            // 
            // sweepgroupBox
            // 
            this.sweepgroupBox.Controls.Add(this.smeschXtrack);
            this.sweepgroupBox.Controls.Add(this.smeschXlabel);
            this.sweepgroupBox.Controls.Add(this.msmksTimeSweep);
            this.sweepgroupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.sweepgroupBox.Location = new System.Drawing.Point(833, 41);
            this.sweepgroupBox.Name = "sweepgroupBox";
            this.sweepgroupBox.Size = new System.Drawing.Size(220, 127);
            this.sweepgroupBox.TabIndex = 24;
            this.sweepgroupBox.TabStop = false;
            this.sweepgroupBox.Text = "Развёртка";
            // 
            // smeschXtrack
            // 
            this.smeschXtrack.Location = new System.Drawing.Point(6, 76);
            this.smeschXtrack.Maximum = 50;
            this.smeschXtrack.Minimum = -50;
            this.smeschXtrack.Name = "smeschXtrack";
            this.smeschXtrack.Size = new System.Drawing.Size(208, 45);
            this.smeschXtrack.TabIndex = 32;
            this.smeschXtrack.Scroll += new System.EventHandler(this.smeschXtrack_Scroll);
            // 
            // smeschXlabel
            // 
            this.smeschXlabel.AutoSize = true;
            this.smeschXlabel.BackColor = System.Drawing.SystemColors.Window;
            this.smeschXlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.smeschXlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.smeschXlabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.smeschXlabel.Location = new System.Drawing.Point(20, 53);
            this.smeschXlabel.Name = "smeschXlabel";
            this.smeschXlabel.Size = new System.Drawing.Size(148, 15);
            this.smeschXlabel.TabIndex = 28;
            this.smeschXlabel.Text = "Смещение по горизонтали:";
            // 
            // msmksTimeSweep
            // 
            this.msmksTimeSweep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.msmksTimeSweep.FormattingEnabled = true;
            this.msmksTimeSweep.Items.AddRange(new object[] {
            "ms",
            "µs"});
            this.msmksTimeSweep.Location = new System.Drawing.Point(142, 19);
            this.msmksTimeSweep.Name = "msmksTimeSweep";
            this.msmksTimeSweep.Size = new System.Drawing.Size(36, 21);
            this.msmksTimeSweep.TabIndex = 31;
            this.msmksTimeSweep.SelectedIndexChanged += new System.EventHandler(this.msmksTimeSweep_SelectedIndexChanged);
            // 
            // genergroupBox
            // 
            this.genergroupBox.Controls.Add(this.createSignal2);
            this.genergroupBox.Controls.Add(this.createSignal1);
            this.genergroupBox.Controls.Add(this.podatlabel);
            this.genergroupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.genergroupBox.Location = new System.Drawing.Point(12, 41);
            this.genergroupBox.Name = "genergroupBox";
            this.genergroupBox.Size = new System.Drawing.Size(251, 78);
            this.genergroupBox.TabIndex = 25;
            this.genergroupBox.TabStop = false;
            this.genergroupBox.Text = "Генератор электрических сигналов";
            // 
            // createSignal2
            // 
            this.createSignal2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createSignal2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.createSignal2.Location = new System.Drawing.Point(62, 45);
            this.createSignal2.Name = "createSignal2";
            this.createSignal2.Size = new System.Drawing.Size(152, 23);
            this.createSignal2.TabIndex = 19;
            this.createSignal2.Text = "Сигнал на второй канал";
            this.createSignal2.UseVisualStyleBackColor = true;
            this.createSignal2.Click += new System.EventHandler(this.createSignal2_Click);
            // 
            // createSignal1
            // 
            this.createSignal1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createSignal1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.createSignal1.Location = new System.Drawing.Point(62, 16);
            this.createSignal1.Name = "createSignal1";
            this.createSignal1.Size = new System.Drawing.Size(152, 23);
            this.createSignal1.TabIndex = 18;
            this.createSignal1.Text = "Сигнал на первый канал";
            this.createSignal1.UseVisualStyleBackColor = true;
            this.createSignal1.Click += new System.EventHandler(this.createSignal1_Click);
            // 
            // channel1check
            // 
            this.channel1check.AutoSize = true;
            this.channel1check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.channel1check.Location = new System.Drawing.Point(95, 17);
            this.channel1check.Name = "channel1check";
            this.channel1check.Size = new System.Drawing.Size(66, 17);
            this.channel1check.TabIndex = 26;
            this.channel1check.Text = "Канал 1";
            this.channel1check.UseVisualStyleBackColor = true;
            this.channel1check.CheckedChanged += new System.EventHandler(this.channel1check_CheckedChanged);
            // 
            // channel2check
            // 
            this.channel2check.AutoSize = true;
            this.channel2check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.channel2check.Location = new System.Drawing.Point(167, 16);
            this.channel2check.Name = "channel2check";
            this.channel2check.Size = new System.Drawing.Size(66, 17);
            this.channel2check.TabIndex = 27;
            this.channel2check.Text = "Канал 2";
            this.channel2check.UseVisualStyleBackColor = true;
            this.channel2check.CheckedChanged += new System.EventHandler(this.channel2check_CheckedChanged);
            // 
            // channelsgroupBox
            // 
            this.channelsgroupBox.Controls.Add(this.podkllabel);
            this.channelsgroupBox.Controls.Add(this.channel2check);
            this.channelsgroupBox.Controls.Add(this.channel1check);
            this.channelsgroupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.channelsgroupBox.Location = new System.Drawing.Point(12, 127);
            this.channelsgroupBox.Name = "channelsgroupBox";
            this.channelsgroupBox.Size = new System.Drawing.Size(251, 41);
            this.channelsgroupBox.TabIndex = 28;
            this.channelsgroupBox.TabStop = false;
            this.channelsgroupBox.Text = "Подключение каналов";
            // 
            // podkllabel
            // 
            this.podkllabel.AutoSize = true;
            this.podkllabel.BackColor = System.Drawing.SystemColors.Window;
            this.podkllabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.podkllabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.podkllabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.podkllabel.Location = new System.Drawing.Point(6, 17);
            this.podkllabel.Name = "podkllabel";
            this.podkllabel.Size = new System.Drawing.Size(74, 15);
            this.podkllabel.TabIndex = 18;
            this.podkllabel.Text = "Подключить:";
            // 
            // controlChangroupBox
            // 
            this.controlChangroupBox.Controls.Add(this.channel2groupBox);
            this.controlChangroupBox.Controls.Add(this.channel1groupBox);
            this.controlChangroupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.controlChangroupBox.Location = new System.Drawing.Point(13, 175);
            this.controlChangroupBox.Name = "controlChangroupBox";
            this.controlChangroupBox.Size = new System.Drawing.Size(250, 357);
            this.controlChangroupBox.TabIndex = 30;
            this.controlChangroupBox.TabStop = false;
            this.controlChangroupBox.Text = "Управление каналами";
            // 
            // channel2groupBox
            // 
            this.channel2groupBox.Controls.Add(this.label3);
            this.channel2groupBox.Controls.Add(this.scaleCh2combo);
            this.channel2groupBox.Controls.Add(this.channel2track);
            this.channel2groupBox.Controls.Add(this.groudChan2combo);
            this.channel2groupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.channel2groupBox.Location = new System.Drawing.Point(128, 19);
            this.channel2groupBox.Name = "channel2groupBox";
            this.channel2groupBox.Size = new System.Drawing.Size(116, 332);
            this.channel2groupBox.TabIndex = 1;
            this.channel2groupBox.TabStop = false;
            this.channel2groupBox.Text = "Канал 2";
            // 
            // scaleCh2combo
            // 
            this.scaleCh2combo.FormattingEnabled = true;
            this.scaleCh2combo.Location = new System.Drawing.Point(52, 281);
            this.scaleCh2combo.Name = "scaleCh2combo";
            this.scaleCh2combo.Size = new System.Drawing.Size(52, 21);
            this.scaleCh2combo.TabIndex = 5;
            this.scaleCh2combo.SelectedIndexChanged += new System.EventHandler(this.scaleCh2combo_SelectedIndexChanged);
            // 
            // channel2track
            // 
            this.channel2track.Location = new System.Drawing.Point(7, 44);
            this.channel2track.Maximum = 70;
            this.channel2track.Minimum = -70;
            this.channel2track.Name = "channel2track";
            this.channel2track.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.channel2track.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.channel2track.Size = new System.Drawing.Size(45, 280);
            this.channel2track.TabIndex = 4;
            this.channel2track.ValueChanged += new System.EventHandler(this.channel2track_ValueChanged);
            // 
            // groudChan2combo
            // 
            this.groudChan2combo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groudChan2combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groudChan2combo.FormattingEnabled = true;
            this.groudChan2combo.Items.AddRange(new object[] {
            "Земля",
            "AC/DC"});
            this.groudChan2combo.Location = new System.Drawing.Point(7, 19);
            this.groudChan2combo.Name = "groudChan2combo";
            this.groudChan2combo.Size = new System.Drawing.Size(103, 21);
            this.groudChan2combo.TabIndex = 0;
            this.groudChan2combo.SelectedIndexChanged += new System.EventHandler(this.groudChan2combo_SelectedIndexChanged);
            // 
            // channel1groupBox
            // 
            this.channel1groupBox.Controls.Add(this.label1);
            this.channel1groupBox.Controls.Add(this.scaleCh1combo);
            this.channel1groupBox.Controls.Add(this.channel1track);
            this.channel1groupBox.Controls.Add(this.groudChan1combo);
            this.channel1groupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.channel1groupBox.Location = new System.Drawing.Point(6, 19);
            this.channel1groupBox.Name = "channel1groupBox";
            this.channel1groupBox.Size = new System.Drawing.Size(116, 332);
            this.channel1groupBox.TabIndex = 0;
            this.channel1groupBox.TabStop = false;
            this.channel1groupBox.Text = "Канал 1";
            // 
            // scaleCh1combo
            // 
            this.scaleCh1combo.FormattingEnabled = true;
            this.scaleCh1combo.Location = new System.Drawing.Point(46, 281);
            this.scaleCh1combo.Name = "scaleCh1combo";
            this.scaleCh1combo.Size = new System.Drawing.Size(50, 21);
            this.scaleCh1combo.TabIndex = 4;
            this.scaleCh1combo.SelectedIndexChanged += new System.EventHandler(this.scaleCh1combo_SelectedIndexChanged);
            // 
            // channel1track
            // 
            this.channel1track.Location = new System.Drawing.Point(6, 44);
            this.channel1track.Maximum = 70;
            this.channel1track.Minimum = -70;
            this.channel1track.Name = "channel1track";
            this.channel1track.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.channel1track.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.channel1track.Size = new System.Drawing.Size(45, 280);
            this.channel1track.TabIndex = 3;
            this.channel1track.ValueChanged += new System.EventHandler(this.channel1track_ValueChanged);
            // 
            // groudChan1combo
            // 
            this.groudChan1combo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groudChan1combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groudChan1combo.FormattingEnabled = true;
            this.groudChan1combo.Items.AddRange(new object[] {
            "Земля",
            "AC/DC"});
            this.groudChan1combo.Location = new System.Drawing.Point(6, 19);
            this.groudChan1combo.Name = "groudChan1combo";
            this.groudChan1combo.Size = new System.Drawing.Size(104, 21);
            this.groudChan1combo.TabIndex = 2;
            this.groudChan1combo.SelectedIndexChanged += new System.EventHandler(this.groudChan1combo_SelectedIndexChanged);
            // 
            // colorgroupBox
            // 
            this.colorgroupBox.Controls.Add(this.label5);
            this.colorgroupBox.Controls.Add(this.label4);
            this.colorgroupBox.Controls.Add(this.label2);
            this.colorgroupBox.Controls.Add(this.signradioBut);
            this.colorgroupBox.Controls.Add(this.setColorcheckB);
            this.colorgroupBox.Controls.Add(this.formradioBut);
            this.colorgroupBox.Controls.Add(this.dispradioBut);
            this.colorgroupBox.Controls.Add(this.gridradioBut);
            this.colorgroupBox.Controls.Add(this.risradioBut);
            this.colorgroupBox.Controls.Add(this.axradioBut);
            this.colorgroupBox.Controls.Add(this.redtrack);
            this.colorgroupBox.Controls.Add(this.greentrack);
            this.colorgroupBox.Controls.Add(this.bluetrack);
            this.colorgroupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.colorgroupBox.Location = new System.Drawing.Point(827, 175);
            this.colorgroupBox.Name = "colorgroupBox";
            this.colorgroupBox.Size = new System.Drawing.Size(220, 321);
            this.colorgroupBox.TabIndex = 32;
            this.colorgroupBox.TabStop = false;
            this.colorgroupBox.Text = "Изменение цвета элементов (RGB)";
            // 
            // signradioBut
            // 
            this.signradioBut.AutoSize = true;
            this.signradioBut.Location = new System.Drawing.Point(110, 61);
            this.signradioBut.Name = "signradioBut";
            this.signradioBut.Size = new System.Drawing.Size(67, 17);
            this.signradioBut.TabIndex = 22;
            this.signradioBut.TabStop = true;
            this.signradioBut.Text = "Сигнала";
            this.signradioBut.UseVisualStyleBackColor = true;
            // 
            // setColorcheckB
            // 
            this.setColorcheckB.AutoSize = true;
            this.setColorcheckB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setColorcheckB.Location = new System.Drawing.Point(20, 19);
            this.setColorcheckB.Name = "setColorcheckB";
            this.setColorcheckB.Size = new System.Drawing.Size(103, 17);
            this.setColorcheckB.TabIndex = 21;
            this.setColorcheckB.Text = "Изменить цвет";
            this.setColorcheckB.UseVisualStyleBackColor = true;
            this.setColorcheckB.CheckedChanged += new System.EventHandler(this.setColorcheckB_CheckedChanged);
            // 
            // formradioBut
            // 
            this.formradioBut.AutoSize = true;
            this.formradioBut.Location = new System.Drawing.Point(20, 107);
            this.formradioBut.Name = "formradioBut";
            this.formradioBut.Size = new System.Drawing.Size(175, 17);
            this.formradioBut.TabIndex = 19;
            this.formradioBut.TabStop = true;
            this.formradioBut.Text = "Фона Элементов управления";
            this.formradioBut.UseVisualStyleBackColor = true;
            // 
            // dispradioBut
            // 
            this.dispradioBut.AutoSize = true;
            this.dispradioBut.Location = new System.Drawing.Point(20, 84);
            this.dispradioBut.Name = "dispradioBut";
            this.dispradioBut.Size = new System.Drawing.Size(102, 17);
            this.dispradioBut.TabIndex = 18;
            this.dispradioBut.TabStop = true;
            this.dispradioBut.Text = "Фона Дисплея";
            this.dispradioBut.UseVisualStyleBackColor = true;
            // 
            // gridradioBut
            // 
            this.gridradioBut.AutoSize = true;
            this.gridradioBut.Location = new System.Drawing.Point(20, 61);
            this.gridradioBut.Name = "gridradioBut";
            this.gridradioBut.Size = new System.Drawing.Size(55, 17);
            this.gridradioBut.TabIndex = 17;
            this.gridradioBut.TabStop = true;
            this.gridradioBut.Text = "Сетки";
            this.gridradioBut.UseVisualStyleBackColor = true;
            // 
            // risradioBut
            // 
            this.risradioBut.AutoSize = true;
            this.risradioBut.Location = new System.Drawing.Point(110, 38);
            this.risradioBut.Name = "risradioBut";
            this.risradioBut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.risradioBut.Size = new System.Drawing.Size(56, 17);
            this.risradioBut.TabIndex = 16;
            this.risradioBut.TabStop = true;
            this.risradioBut.Text = "Рисок";
            this.risradioBut.UseVisualStyleBackColor = true;
            // 
            // axradioBut
            // 
            this.axradioBut.AutoSize = true;
            this.axradioBut.Location = new System.Drawing.Point(20, 38);
            this.axradioBut.Name = "axradioBut";
            this.axradioBut.Size = new System.Drawing.Size(51, 17);
            this.axradioBut.TabIndex = 15;
            this.axradioBut.TabStop = true;
            this.axradioBut.Text = "Осей";
            this.axradioBut.UseVisualStyleBackColor = true;
            // 
            // redtrack
            // 
            this.redtrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redtrack.Location = new System.Drawing.Point(6, 151);
            this.redtrack.Maximum = 255;
            this.redtrack.Name = "redtrack";
            this.redtrack.Size = new System.Drawing.Size(208, 45);
            this.redtrack.TabIndex = 14;
            this.redtrack.Scroll += new System.EventHandler(this.redtrack_Scroll);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(55, 51);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(18, 223);
            this.label1.TabIndex = 28;
            this.label1.Text = "М\r\nа\r\nс\r\nш\r\nт\r\nа\r\nб\r\n\r\nР\r\nа\r\nз\r\nв\r\nё\r\nр\r\nт\r\nк\r\nи:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(58, 51);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(18, 223);
            this.label3.TabIndex = 29;
            this.label3.Text = "М\r\nа\r\nс\r\nш\r\nт\r\nа\r\nб\r\n\r\nР\r\nа\r\nз\r\nв\r\nё\r\nр\r\nт\r\nк\r\nи:";
            // 
            // signGener
            // 
            this.signGener.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.signGener.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.signGener.Location = new System.Drawing.Point(269, 27);
            this.signGener.Name = "signGener";
            this.signGener.Size = new System.Drawing.Size(405, 157);
            this.signGener.TabIndex = 29;
            this.signGener.Visible = false;
            this.signGener.VisibleChanged += new System.EventHandler(this.signGener_VisibleChanged);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.display.BackColorGrid = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.display.ColorAxes = System.Drawing.Color.Black;
            this.display.ColorGrid = System.Drawing.Color.Black;
            this.display.ColorStrokes = System.Drawing.Color.Black;
            this.display.Location = new System.Drawing.Point(269, 27);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(555, 505);
            this.display.TabIndex = 31;
            this.display.Paint += new System.Windows.Forms.PaintEventHandler(this.display_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(26, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Красный цвет:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(26, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Зелёный цвет:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(26, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Синий цвет:";
            // 
            // OscillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1053, 538);
            this.Controls.Add(this.colorgroupBox);
            this.Controls.Add(this.controlChangroupBox);
            this.Controls.Add(this.sweepcombo);
            this.Controls.Add(this.signGener);
            this.Controls.Add(this.channelsgroupBox);
            this.Controls.Add(this.genergroupBox);
            this.Controls.Add(this.sweepgroupBox);
            this.Controls.Add(this.frequency);
            this.Controls.Add(this.voltage);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "OscillForm";
            this.Text = "Virtual Oscilloscope";
            this.ClientSizeChanged += new System.EventHandler(this.Oscilloscope_ClientSizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bluetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greentrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.sweepgroupBox.ResumeLayout(false);
            this.sweepgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smeschXtrack)).EndInit();
            this.genergroupBox.ResumeLayout(false);
            this.genergroupBox.PerformLayout();
            this.channelsgroupBox.ResumeLayout(false);
            this.channelsgroupBox.PerformLayout();
            this.controlChangroupBox.ResumeLayout(false);
            this.channel2groupBox.ResumeLayout(false);
            this.channel2groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channel2track)).EndInit();
            this.channel1groupBox.ResumeLayout(false);
            this.channel1groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channel1track)).EndInit();
            this.colorgroupBox.ResumeLayout(false);
            this.colorgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redtrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TrackBar bluetrack;
        private System.Windows.Forms.TrackBar greentrack;
        private System.Windows.Forms.RadioButton onoffradioBut;
        private System.Windows.Forms.Button onoff;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown voltage;
        private System.Windows.Forms.NumericUpDown frequency;
        private System.Windows.Forms.Label podatlabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ComboBox sweepcombo;
        private System.Windows.Forms.GroupBox sweepgroupBox;
        private System.Windows.Forms.GroupBox genergroupBox;
        private System.Windows.Forms.Button createSignal2;
        private System.Windows.Forms.Button createSignal1;
        private System.Windows.Forms.CheckBox channel1check;
        private System.Windows.Forms.CheckBox channel2check;
        private System.Windows.Forms.GroupBox channelsgroupBox;
        private System.Windows.Forms.Label podkllabel;
        private GeneratorSignals signGener;
        private System.Windows.Forms.GroupBox controlChangroupBox;
        private System.Windows.Forms.GroupBox channel2groupBox;
        private System.Windows.Forms.GroupBox channel1groupBox;
        private System.Windows.Forms.ComboBox groudChan1combo;
        private System.Windows.Forms.ComboBox groudChan2combo;
        private System.Windows.Forms.TrackBar channel2track;
        private System.Windows.Forms.TrackBar channel1track;
        private System.Windows.Forms.ComboBox msmksTimeSweep;
        private System.Windows.Forms.ComboBox scaleCh2combo;
        private System.Windows.Forms.ComboBox scaleCh1combo;
        private System.Windows.Forms.TrackBar smeschXtrack;
        private System.Windows.Forms.Label smeschXlabel;
        private Display display;
        private System.Windows.Forms.GroupBox colorgroupBox;
        private System.Windows.Forms.TrackBar redtrack;
        private System.Windows.Forms.RadioButton formradioBut;
        private System.Windows.Forms.RadioButton dispradioBut;
        private System.Windows.Forms.RadioButton gridradioBut;
        private System.Windows.Forms.RadioButton risradioBut;
        private System.Windows.Forms.RadioButton axradioBut;
        private System.Windows.Forms.CheckBox setColorcheckB;
        private System.Windows.Forms.RadioButton signradioBut;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;

    }
}

