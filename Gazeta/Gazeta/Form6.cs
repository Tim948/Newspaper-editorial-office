using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazeta
{
    public partial class F6 : Form
    {
        public F6()
        {
            InitializeComponent();
        }

        private void рубрикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рубрикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gazetaDataSet);

        }

        private void F6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazetaDataSet.Рубрики". При необходимости она может быть перемещена или удалена.
            this.рубрикиTableAdapter.Fill(this.gazetaDataSet.Рубрики);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < рубрикиDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < рубрикиDataGridView.RowCount - 1; j++)
                {
                    рубрикиDataGridView[i, j].Style.BackColor = Color.White;
                    рубрикиDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < рубрикиDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < рубрикиDataGridView.RowCount - 1; j++)
                {
                    if (рубрикиDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        рубрикиDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        рубрикиDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
        private System.Windows.Forms.DataGridViewColumn COL;
        private void button2_Click(object sender, EventArgs e)
        {
            //создает переменную COL для хранения имени выбранного столбца таблицы
            COL = new System.Windows.Forms.DataGridViewColumn();
            //блок switch, записывающий в
            //переменную Col имя выбранного столбца таблицы в зависимости от номера
            //выбранного пункта списка (ListBox1.SelectedIndex).
            //Нумерация пунктов списка начинается с нуля, а нумерация столбцов с единицы.
            //Первый столбец в списке ListBox1 - «Фамилия» носит в таблице имя
            // DataGridViewTextBoxColumn3, указанное в свойствах полей
            //в Меню действий таблицы.
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn1;
                    break;

            }
            //Блок If выполняет следующую операцию: если включён

            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю, заданному в переменной Col по возрастанию
            //(studentsDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (studentsDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked) рубрикиDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else рубрикиDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private F6 gazet;
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            gazet = new F6();
            gazet.Visible = true;
        }
        private F7 gazetа;
        private void button6_Click(object sender, EventArgs e)
        {
            gazetа = new F7();
            gazetа.Visible = true;
        }
        private F8 gaze;
        private void button3_Click(object sender, EventArgs e)
        {
            gaze = new F8();
            gaze.Visible = true;
        }
    }
}
