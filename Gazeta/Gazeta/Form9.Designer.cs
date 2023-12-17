namespace Gazeta
{
    partial class F9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F9));
            System.Windows.Forms.Label подрубрикаLabel;
            System.Windows.Forms.Label рубрикаLabel;
            System.Windows.Forms.Label код_рубрикиLabel;
            this.gazetaDataSet = new Gazeta.GazetaDataSet();
            this.подрубрикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.подрубрикиTableAdapter = new Gazeta.GazetaDataSetTableAdapters.ПодрубрикиTableAdapter();
            this.tableAdapterManager = new Gazeta.GazetaDataSetTableAdapters.TableAdapterManager();
            this.подрубрикиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.подрубрикиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.подрубрикаTextBox = new System.Windows.Forms.TextBox();
            this.рубрикаTextBox = new System.Windows.Forms.TextBox();
            this.код_рубрикиComboBox = new System.Windows.Forms.ComboBox();
            this.рубрикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рубрикиTableAdapter = new Gazeta.GazetaDataSetTableAdapters.РубрикиTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            подрубрикаLabel = new System.Windows.Forms.Label();
            рубрикаLabel = new System.Windows.Forms.Label();
            код_рубрикиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gazetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подрубрикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подрубрикиBindingNavigator)).BeginInit();
            this.подрубрикиBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.рубрикиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gazetaDataSet
            // 
            this.gazetaDataSet.DataSetName = "GazetaDataSet";
            this.gazetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // подрубрикиBindingSource
            // 
            this.подрубрикиBindingSource.DataMember = "Подрубрики";
            this.подрубрикиBindingSource.DataSource = this.gazetaDataSet;
            // 
            // подрубрикиTableAdapter
            // 
            this.подрубрикиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Gazeta.GazetaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выпуск_газетыTableAdapter = null;
            this.tableAdapterManager.Выход_обьявленияTableAdapter = null;
            this.tableAdapterManager.ДействияTableAdapter = null;
            this.tableAdapterManager.Подача_обьявленияTableAdapter = null;
            this.tableAdapterManager.ПодрубрикиTableAdapter = this.подрубрикиTableAdapter;
            this.tableAdapterManager.РубрикиTableAdapter = this.рубрикиTableAdapter;
            this.tableAdapterManager.Тарифы_на_обьявленияTableAdapter = null;
            // 
            // подрубрикиBindingNavigator
            // 
            this.подрубрикиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.подрубрикиBindingNavigator.BindingSource = this.подрубрикиBindingSource;
            this.подрубрикиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.подрубрикиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.подрубрикиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.подрубрикиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.подрубрикиBindingNavigatorSaveItem});
            this.подрубрикиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.подрубрикиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.подрубрикиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.подрубрикиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.подрубрикиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.подрубрикиBindingNavigator.Name = "подрубрикиBindingNavigator";
            this.подрубрикиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.подрубрикиBindingNavigator.Size = new System.Drawing.Size(370, 31);
            this.подрубрикиBindingNavigator.TabIndex = 0;
            this.подрубрикиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // подрубрикиBindingNavigatorSaveItem
            // 
            this.подрубрикиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.подрубрикиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("подрубрикиBindingNavigatorSaveItem.Image")));
            this.подрубрикиBindingNavigatorSaveItem.Name = "подрубрикиBindingNavigatorSaveItem";
            this.подрубрикиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.подрубрикиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.подрубрикиBindingNavigatorSaveItem.Click += new System.EventHandler(this.подрубрикиBindingNavigatorSaveItem_Click);
            // 
            // подрубрикаLabel
            // 
            подрубрикаLabel.AutoSize = true;
            подрубрикаLabel.Location = new System.Drawing.Point(23, 56);
            подрубрикаLabel.Name = "подрубрикаLabel";
            подрубрикаLabel.Size = new System.Drawing.Size(91, 16);
            подрубрикаLabel.TabIndex = 1;
            подрубрикаLabel.Text = "Подрубрика:";
            // 
            // подрубрикаTextBox
            // 
            this.подрубрикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подрубрикиBindingSource, "Подрубрика", true));
            this.подрубрикаTextBox.Location = new System.Drawing.Point(121, 53);
            this.подрубрикаTextBox.Name = "подрубрикаTextBox";
            this.подрубрикаTextBox.Size = new System.Drawing.Size(183, 22);
            this.подрубрикаTextBox.TabIndex = 2;
            // 
            // рубрикаLabel
            // 
            рубрикаLabel.AutoSize = true;
            рубрикаLabel.Location = new System.Drawing.Point(49, 84);
            рубрикаLabel.Name = "рубрикаLabel";
            рубрикаLabel.Size = new System.Drawing.Size(66, 16);
            рубрикаLabel.TabIndex = 3;
            рубрикаLabel.Text = "Рубрика:";
            // 
            // рубрикаTextBox
            // 
            this.рубрикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подрубрикиBindingSource, "Рубрика", true));
            this.рубрикаTextBox.Location = new System.Drawing.Point(121, 81);
            this.рубрикаTextBox.Name = "рубрикаTextBox";
            this.рубрикаTextBox.Size = new System.Drawing.Size(183, 22);
            this.рубрикаTextBox.TabIndex = 4;
            // 
            // код_рубрикиLabel
            // 
            код_рубрикиLabel.AutoSize = true;
            код_рубрикиLabel.Location = new System.Drawing.Point(23, 111);
            код_рубрикиLabel.Name = "код_рубрикиLabel";
            код_рубрикиLabel.Size = new System.Drawing.Size(92, 16);
            код_рубрикиLabel.TabIndex = 5;
            код_рубрикиLabel.Text = "Код рубрики:";
            // 
            // код_рубрикиComboBox
            // 
            this.код_рубрикиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подрубрикиBindingSource, "Код рубрики", true));
            this.код_рубрикиComboBox.DataSource = this.рубрикиBindingSource;
            this.код_рубрикиComboBox.DisplayMember = "Код рубрики";
            this.код_рубрикиComboBox.FormattingEnabled = true;
            this.код_рубрикиComboBox.Location = new System.Drawing.Point(122, 108);
            this.код_рубрикиComboBox.Name = "код_рубрикиComboBox";
            this.код_рубрикиComboBox.Size = new System.Drawing.Size(182, 24);
            this.код_рубрикиComboBox.TabIndex = 6;
            // 
            // рубрикиBindingSource
            // 
            this.рубрикиBindingSource.DataMember = "Рубрики";
            this.рубрикиBindingSource.DataSource = this.gazetaDataSet;
            // 
            // рубрикиTableAdapter
            // 
            this.рубрикиTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(370, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_рубрикиLabel);
            this.Controls.Add(this.код_рубрикиComboBox);
            this.Controls.Add(рубрикаLabel);
            this.Controls.Add(this.рубрикаTextBox);
            this.Controls.Add(подрубрикаLabel);
            this.Controls.Add(this.подрубрикаTextBox);
            this.Controls.Add(this.подрубрикиBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F9";
            this.Text = "Добавление подрубрики";
            this.Load += new System.EventHandler(this.F9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gazetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подрубрикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подрубрикиBindingNavigator)).EndInit();
            this.подрубрикиBindingNavigator.ResumeLayout(false);
            this.подрубрикиBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.рубрикиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GazetaDataSet gazetaDataSet;
        private System.Windows.Forms.BindingSource подрубрикиBindingSource;
        private GazetaDataSetTableAdapters.ПодрубрикиTableAdapter подрубрикиTableAdapter;
        private GazetaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator подрубрикиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton подрубрикиBindingNavigatorSaveItem;
        private GazetaDataSetTableAdapters.РубрикиTableAdapter рубрикиTableAdapter;
        private System.Windows.Forms.TextBox подрубрикаTextBox;
        private System.Windows.Forms.TextBox рубрикаTextBox;
        private System.Windows.Forms.ComboBox код_рубрикиComboBox;
        private System.Windows.Forms.BindingSource рубрикиBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}