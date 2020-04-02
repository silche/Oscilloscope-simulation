namespace Oscilloscope
{
    partial class GeneratorSignals
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.garmon = new System.Windows.Forms.RadioButton();
            this.impul = new System.Windows.Forms.RadioButton();
            this.voltagegarm = new System.Windows.Forms.TextBox();
            this.freqgarm = new System.Windows.Forms.TextBox();
            this.voltageimp = new System.Windows.Forms.TextBox();
            this.freqimp = new System.Windows.Forms.TextBox();
            this.duratimp = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // garmon
            // 
            this.garmon.AutoSize = true;
            this.garmon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.garmon.ForeColor = System.Drawing.SystemColors.Window;
            this.garmon.Location = new System.Drawing.Point(13, 12);
            this.garmon.Name = "garmon";
            this.garmon.Size = new System.Drawing.Size(142, 17);
            this.garmon.TabIndex = 0;
            this.garmon.TabStop = true;
            this.garmon.Text = "Гармонический сигнал";
            this.garmon.UseVisualStyleBackColor = true;
            // 
            // impul
            // 
            this.impul.AutoSize = true;
            this.impul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.impul.ForeColor = System.Drawing.SystemColors.Window;
            this.impul.Location = new System.Drawing.Point(274, 12);
            this.impul.Name = "impul";
            this.impul.Size = new System.Drawing.Size(128, 17);
            this.impul.TabIndex = 1;
            this.impul.TabStop = true;
            this.impul.Text = "Импульсный сигнал";
            this.impul.UseVisualStyleBackColor = true;
            // 
            // voltagegarm
            // 
            this.voltagegarm.Location = new System.Drawing.Point(13, 35);
            this.voltagegarm.Name = "voltagegarm";
            this.voltagegarm.Size = new System.Drawing.Size(100, 20);
            this.voltagegarm.TabIndex = 2;
            // 
            // freqgarm
            // 
            this.freqgarm.Location = new System.Drawing.Point(13, 61);
            this.freqgarm.Name = "freqgarm";
            this.freqgarm.Size = new System.Drawing.Size(100, 20);
            this.freqgarm.TabIndex = 3;
            // 
            // voltageimp
            // 
            this.voltageimp.Location = new System.Drawing.Point(274, 35);
            this.voltageimp.Name = "voltageimp";
            this.voltageimp.Size = new System.Drawing.Size(100, 20);
            this.voltageimp.TabIndex = 4;
            // 
            // freqimp
            // 
            this.freqimp.Location = new System.Drawing.Point(274, 61);
            this.freqimp.Name = "freqimp";
            this.freqimp.Size = new System.Drawing.Size(100, 20);
            this.freqimp.TabIndex = 5;
            // 
            // duratimp
            // 
            this.duratimp.Location = new System.Drawing.Point(274, 87);
            this.duratimp.Name = "duratimp";
            this.duratimp.Size = new System.Drawing.Size(100, 20);
            this.duratimp.TabIndex = 6;
            // 
            // ok
            // 
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.Location = new System.Drawing.Point(116, 125);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 7;
            this.ok.Text = "Применить";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(206, 125);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 8;
            this.close.Text = "Отмена";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(158, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "- Напряжение -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(166, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "- Частота -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(131, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Длительность импульса -";
            // 
            // SignalGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.duratimp);
            this.Controls.Add(this.freqimp);
            this.Controls.Add(this.voltageimp);
            this.Controls.Add(this.freqgarm);
            this.Controls.Add(this.voltagegarm);
            this.Controls.Add(this.impul);
            this.Controls.Add(this.garmon);
            this.Name = "SignalGenerator";
            this.Size = new System.Drawing.Size(405, 157);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton garmon;
        public System.Windows.Forms.RadioButton impul;
        public System.Windows.Forms.TextBox voltagegarm;
        public System.Windows.Forms.TextBox freqgarm;
        public System.Windows.Forms.TextBox voltageimp;
        public System.Windows.Forms.TextBox freqimp;
        public System.Windows.Forms.TextBox duratimp;
        public System.Windows.Forms.Button ok;
        public System.Windows.Forms.Button close;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;

    }
}
