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
    public partial class F11 : Form
    {
        public F11()
        {
            InitializeComponent();
        }

        private void тарифы_на_обьявленияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тарифы_на_обьявленияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gazetaDataSet);

        }

        private void F11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazetaDataSet.Тарифы_на_обьявления". При необходимости она может быть перемещена или удалена.
            this.тарифы_на_обьявленияTableAdapter.Fill(this.gazetaDataSet.Тарифы_на_обьявления);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
