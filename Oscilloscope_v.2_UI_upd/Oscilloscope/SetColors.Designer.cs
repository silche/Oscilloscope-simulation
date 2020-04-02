namespace Oscilloscope
{
    partial class SetColors
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
            this.colorgroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signradioBut = new System.Windows.Forms.RadioButton();
            this.setColorcheckB = new System.Windows.Forms.CheckBox();
            this.formradioBut = new System.Windows.Forms.RadioButton();
            this.dispradioBut = new System.Windows.Forms.RadioButton();
            this.gridradioBut = new System.Windows.Forms.RadioButton();
            this.risradioBut = new System.Windows.Forms.RadioButton();
            this.axradioBut = new System.Windows.Forms.RadioButton();
            this.redtrack = new System.Windows.Forms.TrackBar();
            this.greentrack = new System.Windows.Forms.TrackBar();
            this.bluetrack = new System.Windows.Forms.TrackBar();
            this.OK = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.colorgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redtrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greentrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluetrack)).BeginInit();
            this.SuspendLayout();
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
            this.colorgroupBox.Location = new System.Drawing.Point(3, 3);
            this.colorgroupBox.Name = "colorgroupBox";
            this.colorgroupBox.Size = new System.Drawing.Size(220, 321);
            this.colorgroupBox.TabIndex = 33;
            this.colorgroupBox.TabStop = false;
            this.colorgroupBox.Text = "Изменение цвета элементов (RGB)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DodgerBlue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(26, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Синий цвет:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LimeGreen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(26, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Зелёный цвет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(26, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Красный цвет:";
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
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(29, 330);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 34;
            this.OK.Text = "Применить";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(123, 330);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 35;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // SetColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.colorgroupBox);
            this.Name = "SetColors";
            this.Size = new System.Drawing.Size(227, 360);
            this.colorgroupBox.ResumeLayout(false);
            this.colorgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redtrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greentrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluetrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox colorgroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton signradioBut;
        private System.Windows.Forms.CheckBox setColorcheckB;
        private System.Windows.Forms.RadioButton formradioBut;
        private System.Windows.Forms.RadioButton dispradioBut;
        private System.Windows.Forms.RadioButton gridradioBut;
        private System.Windows.Forms.RadioButton risradioBut;
        private System.Windows.Forms.RadioButton axradioBut;
        private System.Windows.Forms.TrackBar redtrack;
        private System.Windows.Forms.TrackBar greentrack;
        private System.Windows.Forms.TrackBar bluetrack;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button cancel;
    }
}
