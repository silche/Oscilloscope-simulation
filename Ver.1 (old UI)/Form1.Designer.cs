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
            this.exit = new System.Windows.Forms.Button();
            this.radioBut = new System.Windows.Forms.RadioButton();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.onoff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
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
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.radioBut, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.exit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.trackBar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.onoff, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(713, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(144, 350);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(3, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(36, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // radioBut
            // 
            this.radioBut.AutoCheck = false;
            this.radioBut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioBut.Location = new System.Drawing.Point(3, 178);
            this.radioBut.Name = "radioBut";
            this.radioBut.Size = new System.Drawing.Size(14, 17);
            this.radioBut.TabIndex = 8;
            this.radioBut.UseVisualStyleBackColor = true;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(75, 178);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(66, 45);
            this.trackBar.TabIndex = 9;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // onoff
            // 
            this.onoff.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.onoff.Location = new System.Drawing.Point(75, 3);
            this.onoff.Name = "onoff";
            this.onoff.Size = new System.Drawing.Size(66, 23);
            this.onoff.TabIndex = 10;
            this.onoff.Text = "OFF";
            this.onoff.UseVisualStyleBackColor = true;
            this.onoff.Click += new System.EventHandler(this.onoff_Click);
            // 
            // Oscilloscope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(976, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.picbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Oscilloscope";
            this.Text = "Oscilloscope";
            this.ClientSizeChanged += new System.EventHandler(this.Oscilloscope_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioBut;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button onoff;

    }
}

