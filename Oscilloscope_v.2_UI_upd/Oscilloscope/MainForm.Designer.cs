namespace Oscilloscope
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.windMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createwind = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.arrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Create = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // windMenu
            // 
            this.windMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createwind,
            this.toolStripSeparator1,
            this.cascade,
            this.tileVertical,
            this.tileHorizontal,
            this.toolStripSeparator2,
            this.arrangeIcons,
            this.closeAll});
            this.windMenu.Name = "windMenu";
            this.windMenu.Size = new System.Drawing.Size(47, 20);
            this.windMenu.Text = "&Окна";
            // 
            // createwind
            // 
            this.createwind.Name = "createwind";
            this.createwind.Size = new System.Drawing.Size(185, 22);
            this.createwind.Text = "Создать &Новое окно";
            this.createwind.Click += new System.EventHandler(this.CreateNew);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // cascade
            // 
            this.cascade.Name = "cascade";
            this.cascade.Size = new System.Drawing.Size(185, 22);
            this.cascade.Text = "&Каскадом";
            this.cascade.Click += new System.EventHandler(this.Cascade_Click);
            // 
            // tileVertical
            // 
            this.tileVertical.Name = "tileVertical";
            this.tileVertical.Size = new System.Drawing.Size(185, 22);
            this.tileVertical.Text = "С&лева направо";
            this.tileVertical.Click += new System.EventHandler(this.TileVertical_Click);
            // 
            // tileHorizontal
            // 
            this.tileHorizontal.Name = "tileHorizontal";
            this.tileHorizontal.Size = new System.Drawing.Size(185, 22);
            this.tileHorizontal.Text = "С&верху вниз";
            this.tileHorizontal.Click += new System.EventHandler(this.TileHorizontal_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // arrangeIcons
            // 
            this.arrangeIcons.Name = "arrangeIcons";
            this.arrangeIcons.Size = new System.Drawing.Size(185, 22);
            this.arrangeIcons.Text = "&Упорядочить";
            this.arrangeIcons.Click += new System.EventHandler(this.ArrangeIcons_Click);
            // 
            // closeAll
            // 
            this.closeAll.Name = "closeAll";
            this.closeAll.Size = new System.Drawing.Size(185, 22);
            this.closeAll.Text = "&Закрыть все";
            this.closeAll.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.windMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1104, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Create,
            this.Open,
            this.toolStripSeparator3,
            this.Save_as,
            this.toolStripSeparator4,
            this.Exit});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(48, 20);
            this.fileMenu.Text = "&Файл";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(190, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(190, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(193, 22);
            this.Exit.Text = "В&ыход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Create
            // 
            this.Create.Image = ((System.Drawing.Image)(resources.GetObject("Create.Image")));
            this.Create.ImageTransparentColor = System.Drawing.Color.Black;
            this.Create.Name = "Create";
            this.Create.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Create.Size = new System.Drawing.Size(193, 22);
            this.Create.Text = "&Создать";
            this.Create.Click += new System.EventHandler(this.CreateNew);
            // 
            // Open
            // 
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.ImageTransparentColor = System.Drawing.Color.Black;
            this.Open.Name = "Open";
            this.Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Open.Size = new System.Drawing.Size(193, 22);
            this.Open.Text = "&Открыть";
            this.Open.Click += new System.EventHandler(this.OpenFile);
            // 
            // Save_as
            // 
            this.Save_as.Image = ((System.Drawing.Image)(resources.GetObject("Save_as.Image")));
            this.Save_as.ImageTransparentColor = System.Drawing.Color.Black;
            this.Save_as.Name = "Save_as";
            this.Save_as.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Save_as.Size = new System.Drawing.Size(193, 22);
            this.Save_as.Text = "Сохранить &как";
            this.Save_as.Click += new System.EventHandler(this.Save_as_click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 661);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Virtual Oscilloscope version 2";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStripMenuItem windMenu;
        private System.Windows.Forms.ToolStripMenuItem createwind;
        private System.Windows.Forms.ToolStripMenuItem cascade;
        private System.Windows.Forms.ToolStripMenuItem tileVertical;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem closeAll;
        private System.Windows.Forms.ToolStripMenuItem arrangeIcons;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Create;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Save_as;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        public System.Windows.Forms.ToolStripMenuItem fileMenu;
    }
}



