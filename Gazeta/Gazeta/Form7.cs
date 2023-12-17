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
    public partial class F7 : Form
    {
        public F7()
        {
            InitializeComponent();
        }

        private void рубрикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рубрикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gazetaDataSet);

        }

        private void F7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gazetaDataSet.Рубрики". При необходимости она может быть перемещена или удалена.
            this.рубрикиTableAdapter.Fill(this.gazetaDataSet.Рубрики);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
