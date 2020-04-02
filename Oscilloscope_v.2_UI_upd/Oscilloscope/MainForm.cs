using System;
using System.Drawing;
using System.Windows.Forms;

namespace Oscilloscope
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        OscillForm childForm;

        private void CreateNew(object sender, EventArgs e)
        {
            childForm = new OscillForm();// при нажатии на кнопку "создать" создается новая форма для работы с фигурами
            childForm.MdiParent = this;
            childForm.Text = "Окно Осциллографа " + Application.OpenForms.Count;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)//проверяется, созданы ли дочерние формы
                CreateNew(sender, e);//если нет, создаётся

            childForm.onoff_Click(sender, e);//включение осциллографа на созданной форме

            DialogResult result = MessageBox.Show("Открыть сохранёный сигнал на первом канале?",
                "Выбор канала", MessageBoxButtons.YesNoCancel);

            //выбор канала, на который отобразится открываемый сигнал
            if (result == DialogResult.Cancel)
                return;
            else if (result == DialogResult.Yes)
            {
                childForm.connectChan1toolStrip.Checked = true;
                childForm.groudChan1combo.SelectedIndex = 1;//активируется открытый ход
            }
            else if (result == DialogResult.No)
            {
                childForm.connectChan2toolStrip.Checked = true;
                childForm.groudChan2combo.SelectedIndex = 1;
            }
            childForm.открытьToolStripMenu_Click(sender, e);
        }

        private void Save_as_click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count != 1)//проверяется, созданы ли формы
                childForm.сохранитьToolStripMenu_Click(sender, e);
            else
                MessageBox.Show("Для сохранения сигналов сначала создайте их",
                "Ошибка", MessageBoxButtons.OK);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();// закрытие приложения
        }

        private void Cascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);// функция для построения открытых окон каскадом
        }

        private void TileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);// функция для построения открытых окон в вертикальном порядке
        }

        private void TileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);// функция для построения открытых окон в горизонтальном порядке
        }

        private void ArrangeIcons_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
    }
}
