namespace Oscilloscope
{
    partial class Oscilloscope
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oscilloscope));
            this.picbox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioBut = new System.Windows.Forms.RadioButton();
            this.onoff = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.voltage = new System.Windows.Forms.NumericUpDown();
            this.frequency = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.display1 = new Oscilloscope.Display();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display1)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox
            // 
            this.picbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.picbox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picbox.Location = new System.Drawing.Point(12, 12);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(695, 506);
            this.picbox.TabIndex = 8;
            this.picbox.TabStop = false;
            this.picbox.Paint += new System.Windows.Forms.PaintEventHandler(this.picbox_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.62687F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.37313F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.exit, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(730, 419);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.35644F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 33);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.radioBut);
            this.flowLayoutPanel1.Controls.Add(this.onoff);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(117, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(80, 27);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // radioBut
            // 
            this.radioBut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioBut.AutoCheck = false;
            this.radioBut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioBut.Location = new System.Drawing.Point(3, 5);
            this.radioBut.Name = "radioBut";
            this.radioBut.Size = new System.Drawing.Size(14, 17);
            this.radioBut.TabIndex = 14;
            this.radioBut.UseVisualStyleBackColor = true;
            // 
            // onoff
            // 
            this.onoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onoff.AutoSize = true;
            this.onoff.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.onoff.Location = new System.Drawing.Point(23, 3);
            this.onoff.Name = "onoff";
            this.onoff.Size = new System.Drawing.Size(46, 22);
            this.onoff.TabIndex = 15;
            this.onoff.Text = "OFF";
            this.onoff.UseVisualStyleBackColor = true;
            this.onoff.Click += new System.EventHandler(this.onoff_Click);
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit.AutoSize = true;
            this.exit.Location = new System.Drawing.Point(214, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(40, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(744, 331);
            this.trackBar1.Maximum = 15;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(226, 45);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.trackBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar2.Location = new System.Drawing.Point(744, 280);
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar2.Size = new System.Drawing.Size(226, 45);
            this.trackBar2.TabIndex = 13;
            this.trackBar2.Value = 7;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // voltage
            // 
            this.voltage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.voltage.Location = new System.Drawing.Point(812, 13);
            this.voltage.Name = "voltage";
            this.voltage.Size = new System.Drawing.Size(52, 20);
            this.voltage.TabIndex = 15;
            // 
            // frequency
            // 
            this.frequency.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.frequency.Location = new System.Drawing.Point(932, 13);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(52, 20);
            this.frequency.TabIndex = 16;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.Window;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(770, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(62, 19);
            this.label.TabIndex = 17;
            this.label.Text = "Подать:";
            // 
            // display1
            // 
            this.display1.center = ((System.Drawing.PointF)(resources.GetObject("display1.center")));
            this.display1.Indent = 0;
            this.display1.Location = new System.Drawing.Point(318, 243);
            this.display1.Name = "display1";
            this.display1.Rect = new System.Drawing.Rectangle(0, 0, 100, 50);
            this.display1.SetkaBackColor = System.Drawing.SystemColors.WindowFrame;
            this.display1.SetkaColor = System.Drawing.Color.Black;
            this.display1.SetkaThickness = 1;
            this.display1.Size = new System.Drawing.Size(100, 50);
            this.display1.TabIndex = 18;
            this.display1.TabStop = false;
            this.display1.XSetkaSize = 10;
            this.display1.YSetkaSize = 10;
            // 
            // Oscilloscope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(975, 530);
            this.Controls.Add(this.display1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.frequency);
            this.Controls.Add(this.voltage);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.picbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Oscilloscope";
            this.Text = "Oscilloscope";
            this.Load += new System.EventHandler(this.Oscilloscope_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Oscilloscope_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.RadioButton radioBut;
        private System.Windows.Forms.Button onoff;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown voltage;
        private System.Windows.Forms.NumericUpDown frequency;
        private System.Windows.Forms.Label label;
        private Display display1;

    }
}

