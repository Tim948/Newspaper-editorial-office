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
    public partial class F3 : Form
    {
        public F3()
        {
            InitializeComponent();
        }

        private void выпуск_газетыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.выпуск_газетыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gazetaDataSet);

        }

        private void F3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazetaDataSet.Выпуск_газеты". При необходимости она может быть перемещена или удалена.
            this.выпуск_газетыTableAdapter.Fill(this.gazetaDataSet.Выпуск_газеты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
