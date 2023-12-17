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
    public partial class F4 : Form
    {
        public F4()
        {
            InitializeComponent();
        }

        private void выход_обьявленияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выход_обьявленияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gazetaDataSet);

        }

        private void F4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazetaDataSet.Подача_обьявления". При необходимости она может быть перемещена или удалена.
            this.подача_обьявленияTableAdapter.Fill(this.gazetaDataSet.Подача_обьявления);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazetaDataSet.Выход_обьявления". При необходимости она может быть перемещена или удалена.
            this.выход_обьявленияTableAdapter.Fill(this.gazetaDataSet.Выход_обьявления);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < подача_обьявленияDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < подача_обьявленияDataGridView.RowCount - 1; j++)
                {
                    подача_обьявленияDataGridView[i, j].Style.BackColor = Color.White;
                    подача_обьявленияDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < подача_обьявленияDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < подача_обьявленияDataGridView.RowCount - 1; j++)
                {
                    if (подача_обьявленияDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        подача_обьявленияDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        подача_обьявленияDataGridView[i, j].Style.ForeColor = Color.Blue;
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
                    COL = dataGridViewTextBoxColumn3;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn5;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn6;
                    break;
                case 3:
                    COL = dataGridViewTextBoxColumn7;
                    break;
                case 4:
                    COL = dataGridViewTextBoxColumn8;
                    break;

            }
            //Блок If выполняет следующую операцию: если включён

            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю, заданному в переменной Col по возрастанию
            //(studentsDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (studentsDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked) подача_обьявленияDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else подача_обьявленияDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            подача_обьявленияBindingSource.Filter = "Фамилия='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            подача_обьявленияBindingSource.Filter = "";
        }
        private F5 a;
        private void button5_Click(object sender, EventArgs e)
        {
            a = new F5();
            a.Visible = true;
        }
        private F4 avt;
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            avt = new F4();
            avt.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
