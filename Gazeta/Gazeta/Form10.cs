﻿using System;
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
    public partial class F10 : Form
    {
        public F10()
        {
            InitializeComponent();
        }

        private void тарифы_на_обьявленияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тарифы_на_обьявленияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gazetaDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazetaDataSet.Выход_обьявления". При необходимости она может быть перемещена или удалена.
            this.выход_обьявленияTableAdapter.Fill(this.gazetaDataSet.Выход_обьявления);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazetaDataSet.Тарифы_на_обьявления". При необходимости она может быть перемещена или удалена.
            this.тарифы_на_обьявленияTableAdapter.Fill(this.gazetaDataSet.Тарифы_на_обьявления);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //перебирает все ячейки таблицы и
            //устанавливает в них белый цвет фона и чёрный цвет текста, то есть,
            //отменяет результаты предыдущего поиска
            for (int i = 0; i < тарифы_на_обьявленияDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < тарифы_на_обьявленияDataGridView.RowCount - 1; j++)
                {
                    тарифы_на_обьявленияDataGridView[i, j].Style.BackColor = Color.White;
                    тарифы_на_обьявленияDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            //перебирает все ячейки таблицы и если они
            //содержат текст, введённый в поле ввода (TextBox1), то устанавливает в них
            //голубой цвет фона и синий цвет текста, чем выделяет искомые ячейки.
            for (int i = 0; i < тарифы_на_обьявленияDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < тарифы_на_обьявленияDataGridView.RowCount - 1; j++)
                {
                    if (тарифы_на_обьявленияDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        тарифы_на_обьявленияDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        тарифы_на_обьявленияDataGridView[i, j].Style.ForeColor = Color.Blue;
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
                    COL = dataGridViewTextBoxColumn4;
                    break;
                

            }
            //Блок If выполняет следующую операцию: если включён

            //переключатель «Сортировка по возрастанию» (RadioButton1), то отсортировать
            //таблицу по полю, заданному в переменной Col по возрастанию
            //(studentsDataGridView.Sort (Col, System.ComponentModel.ListSortDirection.
            //Ascending)), иначе по убыванию (studentsDataGridView.Sort (Col, System.
            //ComponentModel.ListSortDirection. Descending)).
            if (radioButton1.Checked) тарифы_на_обьявленияDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Ascending);
            else тарифы_на_обьявленияDataGridView.Sort(COL, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            тарифы_на_обьявленияBindingSource.Filter = "Цена='" + comboBox1.Text + "'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            тарифы_на_обьявленияBindingSource.Filter = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private F10 a;
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            a = new F10();
            a.Visible = true;
        }
        private F11 ga;
        private void button5_Click(object sender, EventArgs e)
        {
            ga = new F11();
            ga.Visible = true;
        }
    }
}
