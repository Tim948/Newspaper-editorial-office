namespace Gazeta
{
    partial class F11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F11));
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label дата_введения_тарифаLabel;
            this.gazetaDataSet = new Gazeta.GazetaDataSet();
            this.тарифы_на_обьявленияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тарифы_на_обьявленияTableAdapter = new Gazeta.GazetaDataSetTableAdapters.Тарифы_на_обьявленияTableAdapter();
            this.tableAdapterManager = new Gazeta.GazetaDataSetTableAdapters.TableAdapterManager();
            this.тарифы_на_обьявленияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.тарифы_на_обьявленияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.дата_введения_тарифаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            описаниеLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            дата_введения_тарифаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gazetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифы_на_обьявленияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифы_на_обьявленияBindingNavigator)).BeginInit();
            this.тарифы_на_обьявленияBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gazetaDataSet
            // 
            this.gazetaDataSet.DataSetName = "GazetaDataSet";
            this.gazetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тарифы_на_обьявленияBindingSource
            // 
            this.тарифы_на_обьявленияBindingSource.DataMember = "Тарифы на обьявления";
            this.тарифы_на_обьявленияBindingSource.DataSource = this.gazetaDataSet;
            // 
            // тарифы_на_обьявленияTableAdapter
            // 
            this.тарифы_на_обьявленияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Gazeta.GazetaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выпуск_газетыTableAdapter = null;
            this.tableAdapterManager.Выход_обьявленияTableAdapter = null;
            this.tableAdapterManager.ДействияTableAdapter = null;
            this.tableAdapterManager.Подача_обьявленияTableAdapter = null;
            this.tableAdapterManager.ПодрубрикиTableAdapter = null;
            this.tableAdapterManager.РубрикиTableAdapter = null;
            this.tableAdapterManager.Тарифы_на_обьявленияTableAdapter = this.тарифы_на_обьявленияTableAdapter;
            // 
            // тарифы_на_обьявленияBindingNavigator
            // 
            this.тарифы_на_обьявленияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.тарифы_на_обьявленияBindingNavigator.BindingSource = this.тарифы_на_обьявленияBindingSource;
            this.тарифы_на_обьявленияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.тарифы_на_обьявленияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.тарифы_на_обьявленияBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.тарифы_на_обьявленияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.тарифы_на_обьявленияBindingNavigatorSaveItem});
            this.тарифы_на_обьявленияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.тарифы_на_обьявленияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.тарифы_на_обьявленияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.тарифы_на_обьявленияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.тарифы_на_обьявленияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.тарифы_на_обьявленияBindingNavigator.Name = "тарифы_на_обьявленияBindingNavigator";
            this.тарифы_на_обьявленияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.тарифы_на_обьявленияBindingNavigator.Size = new System.Drawing.Size(431, 27);
            this.тарифы_на_обьявленияBindingNavigator.TabIndex = 0;
            this.тарифы_на_обьявленияBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
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
            // тарифы_на_обьявленияBindingNavigatorSaveItem
            // 
            this.тарифы_на_обьявленияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.тарифы_на_обьявленияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("тарифы_на_обьявленияBindingNavigatorSaveItem.Image")));
            this.тарифы_на_обьявленияBindingNavigatorSaveItem.Name = "тарифы_на_обьявленияBindingNavigatorSaveItem";
            this.тарифы_на_обьявленияBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.тарифы_на_обьявленияBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.тарифы_на_обьявленияBindingNavigatorSaveItem.Click += new System.EventHandler(this.тарифы_на_обьявленияBindingNavigatorSaveItem_Click);
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(22, 54);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(75, 16);
            описаниеLabel.TabIndex = 1;
            описаниеLabel.Text = "Описание:";
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тарифы_на_обьявленияBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(194, 54);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(200, 22);
            this.описаниеTextBox.TabIndex = 2;
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(22, 86);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(43, 16);
            ценаLabel.TabIndex = 3;
            ценаLabel.Text = "Цена:";
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тарифы_на_обьявленияBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(194, 83);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(200, 22);
            this.ценаTextBox.TabIndex = 4;
            // 
            // дата_введения_тарифаLabel
            // 
            дата_введения_тарифаLabel.AutoSize = true;
            дата_введения_тарифаLabel.Location = new System.Drawing.Point(22, 111);
            дата_введения_тарифаLabel.Name = "дата_введения_тарифаLabel";
            дата_введения_тарифаLabel.Size = new System.Drawing.Size(161, 16);
            дата_введения_тарифаLabel.TabIndex = 5;
            дата_введения_тарифаLabel.Text = "Дата введения тарифа:";
            // 
            // дата_введения_тарифаDateTimePicker
            // 
            this.дата_введения_тарифаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.тарифы_на_обьявленияBindingSource, "Дата введения тарифа", true));
            this.дата_введения_тарифаDateTimePicker.Location = new System.Drawing.Point(194, 111);
            this.дата_введения_тарифаDateTimePicker.Name = "дата_введения_тарифаDateTimePicker";
            this.дата_введения_тарифаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_введения_тарифаDateTimePicker.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(431, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(дата_введения_тарифаLabel);
            this.Controls.Add(this.дата_введения_тарифаDateTimePicker);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(this.тарифы_на_обьявленияBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F11";
            this.Text = "Добавление тарифа";
            this.Load += new System.EventHandler(this.F11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gazetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифы_на_обьявленияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тарифы_на_обьявленияBindingNavigator)).EndInit();
            this.тарифы_на_обьявленияBindingNavigator.ResumeLayout(false);
            this.тарифы_на_обьявленияBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GazetaDataSet gazetaDataSet;
        private System.Windows.Forms.BindingSource тарифы_на_обьявленияBindingSource;
        private GazetaDataSetTableAdapters.Тарифы_на_обьявленияTableAdapter тарифы_на_обьявленияTableAdapter;
        private GazetaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator тарифы_на_обьявленияBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton тарифы_на_обьявленияBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.DateTimePicker дата_введения_тарифаDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}