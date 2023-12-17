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
    public partial class F2 : Form
    {
        public F2()
        {
            InitializeComponent();
        }

        private void выпуск_газетыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выпуск_газетыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gazetaDataSet);

        }

        private void F2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazetaDataSet.Выход_обьявления". При необходимости она может быть перемещена или удалена.
           // this.выход_обьявленияTableAdapter.Fill(this.gazetaDataSet.Выход_обьявления);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazetaDataSet.Выпуск_газеты". При необходимости она может быть перемещена или удалена.
            this.выпуск_газетыTableAdapter.Fill(this.gazetaDataSet.Выпуск_газеты);

        }
        private F3 gazeta;
        private void button6_Click(object sender, EventArgs e)
        {
            gazeta = new F3();
            gazeta.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private F2 gazet;
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            gazet = new F2();
            gazet.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < выпуск_газетыDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < выпуск_газетыDataGridView.RowCount - 1; j++)
                {
                    выпуск_газетыDataGridView[i, j].Style.BackColor = Color.White;
                    выпуск_газетыDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < выпуск_газетыDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < выпуск_газетыDataGridView.RowCount - 1; j++)
                {
                    if (выпуск_газетыDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        выпуск_газетыDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        выпуск_газетыDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
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
                    COL = dataGridViewTextBoxColumn2;
                    break;
                
            }
            //Блок If выполняет следующую операцию: если включён

            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю, заданному в переменной Col по возрастанию
            //(studentsDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (studentsDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked) выпуск_газетыDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else выпуск_газетыDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
