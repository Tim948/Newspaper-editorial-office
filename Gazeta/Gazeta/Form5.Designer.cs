namespace Gazeta
{
    partial class F5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F5));
            System.Windows.Forms.Label код_подрубрикиLabel;
            System.Windows.Forms.Label категорияLabel;
            System.Windows.Forms.Label текстLabel;
            System.Windows.Forms.Label дата_подачиLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label код_категорииLabel;
            this.gazetaDataSet = new Gazeta.GazetaDataSet();
            this.подача_обьявленияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.подача_обьявленияTableAdapter = new Gazeta.GazetaDataSetTableAdapters.Подача_обьявленияTableAdapter();
            this.tableAdapterManager = new Gazeta.GazetaDataSetTableAdapters.TableAdapterManager();
            this.подача_обьявленияBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.подача_обьявленияBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_подрубрикиComboBox = new System.Windows.Forms.ComboBox();
            this.категорияTextBox = new System.Windows.Forms.TextBox();
            this.текстTextBox = new System.Windows.Forms.TextBox();
            this.дата_подачиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.телефонMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.код_категорииComboBox = new System.Windows.Forms.ComboBox();
            this.подрубрикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.подрубрикиTableAdapter = new Gazeta.GazetaDataSetTableAdapters.ПодрубрикиTableAdapter();
            this.действияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.действияTableAdapter = new Gazeta.GazetaDataSetTableAdapters.ДействияTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            код_подрубрикиLabel = new System.Windows.Forms.Label();
            категорияLabel = new System.Windows.Forms.Label();
            текстLabel = new System.Windows.Forms.Label();
            дата_подачиLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            код_категорииLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gazetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подача_обьявленияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подача_обьявленияBindingNavigator)).BeginInit();
            this.подача_обьявленияBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.подрубрикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.действияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gazetaDataSet
            // 
            this.gazetaDataSet.DataSetName = "GazetaDataSet";
            this.gazetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // подача_обьявленияBindingSource
            // 
            this.подача_обьявленияBindingSource.DataMember = "Подача обьявления";
            this.подача_обьявленияBindingSource.DataSource = this.gazetaDataSet;
            // 
            // подача_обьявленияTableAdapter
            // 
            this.подача_обьявленияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Gazeta.GazetaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выпуск_газетыTableAdapter = null;
            this.tableAdapterManager.Выход_обьявленияTableAdapter = null;
            this.tableAdapterManager.ДействияTableAdapter = this.действияTableAdapter;
            this.tableAdapterManager.Подача_обьявленияTableAdapter = this.подача_обьявленияTableAdapter;
            this.tableAdapterManager.ПодрубрикиTableAdapter = this.подрубрикиTableAdapter;
            this.tableAdapterManager.РубрикиTableAdapter = null;
            this.tableAdapterManager.Тарифы_на_обьявленияTableAdapter = null;
            // 
            // подача_обьявленияBindingNavigator
            // 
            this.подача_обьявленияBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.подача_обьявленияBindingNavigator.BindingSource = this.подача_обьявленияBindingSource;
            this.подача_обьявленияBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.подача_обьявленияBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.подача_обьявленияBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.подача_обьявленияBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.подача_обьявленияBindingNavigatorSaveItem});
            this.подача_обьявленияBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.подача_обьявленияBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.подача_обьявленияBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.подача_обьявленияBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.подача_обьявленияBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.подача_обьявленияBindingNavigator.Name = "подача_обьявленияBindingNavigator";
            this.подача_обьявленияBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.подача_обьявленияBindingNavigator.Size = new System.Drawing.Size(375, 31);
            this.подача_обьявленияBindingNavigator.TabIndex = 0;
            this.подача_обьявленияBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // подача_обьявленияBindingNavigatorSaveItem
            // 
            this.подача_обьявленияBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.подача_обьявленияBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("подача_обьявленияBindingNavigatorSaveItem.Image")));
            this.подача_обьявленияBindingNavigatorSaveItem.Name = "подача_обьявленияBindingNavigatorSaveItem";
            this.подача_обьявленияBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.подача_обьявленияBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.подача_обьявленияBindingNavigatorSaveItem.Click += new System.EventHandler(this.подача_обьявленияBindingNavigatorSaveItem_Click);
            // 
            // код_подрубрикиLabel
            // 
            код_подрубрикиLabel.AutoSize = true;
            код_подрубрикиLabel.Location = new System.Drawing.Point(4, 44);
            код_подрубрикиLabel.Name = "код_подрубрикиLabel";
            код_подрубрикиLabel.Size = new System.Drawing.Size(116, 16);
            код_подрубрикиLabel.TabIndex = 1;
            код_подрубрикиLabel.Text = "Код подрубрики:";
            // 
            // код_подрубрикиComboBox
            // 
            this.код_подрубрикиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подача_обьявленияBindingSource, "Код подрубрики", true));
            this.код_подрубрикиComboBox.DataSource = this.подрубрикиBindingSource;
            this.код_подрубрикиComboBox.DisplayMember = "Код подрубрики";
            this.код_подрубрикиComboBox.FormattingEnabled = true;
            this.код_подрубрикиComboBox.Location = new System.Drawing.Point(126, 41);
            this.код_подрубрикиComboBox.Name = "код_подрубрикиComboBox";
            this.код_подрубрикиComboBox.Size = new System.Drawing.Size(200, 24);
            this.код_подрубрикиComboBox.TabIndex = 2;
            // 
            // категорияLabel
            // 
            категорияLabel.AutoSize = true;
            категорияLabel.Location = new System.Drawing.Point(42, 74);
            категорияLabel.Name = "категорияLabel";
            категорияLabel.Size = new System.Drawing.Size(78, 16);
            категорияLabel.TabIndex = 3;
            категорияLabel.Text = "Категория:";
            // 
            // категорияTextBox
            // 
            this.категорияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подача_обьявленияBindingSource, "Категория", true));
            this.категорияTextBox.Location = new System.Drawing.Point(126, 71);
            this.категорияTextBox.Name = "категорияTextBox";
            this.категорияTextBox.Size = new System.Drawing.Size(200, 22);
            this.категорияTextBox.TabIndex = 4;
            // 
            // текстLabel
            // 
            текстLabel.AutoSize = true;
            текстLabel.Location = new System.Drawing.Point(72, 102);
            текстLabel.Name = "текстLabel";
            текстLabel.Size = new System.Drawing.Size(48, 16);
            текстLabel.TabIndex = 5;
            текстLabel.Text = "Текст:";
            // 
            // текстTextBox
            // 
            this.текстTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подача_обьявленияBindingSource, "Текст", true));
            this.текстTextBox.Location = new System.Drawing.Point(126, 99);
            this.текстTextBox.Name = "текстTextBox";
            this.текстTextBox.Size = new System.Drawing.Size(200, 22);
            this.текстTextBox.TabIndex = 6;
            // 
            // дата_подачиLabel
            // 
            дата_подачиLabel.AutoSize = true;
            дата_подачиLabel.Location = new System.Drawing.Point(27, 131);
            дата_подачиLabel.Name = "дата_подачиLabel";
            дата_подачиLabel.Size = new System.Drawing.Size(93, 16);
            дата_подачиLabel.TabIndex = 7;
            дата_подачиLabel.Text = "Дата подачи:";
            // 
            // дата_подачиDateTimePicker
            // 
            this.дата_подачиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.подача_обьявленияBindingSource, "Дата подачи", true));
            this.дата_подачиDateTimePicker.Location = new System.Drawing.Point(126, 127);
            this.дата_подачиDateTimePicker.Name = "дата_подачиDateTimePicker";
            this.дата_подачиDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_подачиDateTimePicker.TabIndex = 8;
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(51, 158);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(69, 16);
            фамилияLabel.TabIndex = 9;
            фамилияLabel.Text = "Фамилия:";
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подача_обьявленияBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(126, 155);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(200, 22);
            this.фамилияTextBox.TabIndex = 10;
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(84, 186);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(36, 16);
            имяLabel.TabIndex = 11;
            имяLabel.Text = "Имя:";
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подача_обьявленияBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(126, 183);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(200, 22);
            this.имяTextBox.TabIndex = 12;
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(47, 214);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(73, 16);
            отчествоLabel.TabIndex = 13;
            отчествоLabel.Text = "Отчество:";
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подача_обьявленияBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(126, 211);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(200, 22);
            this.отчествоTextBox.TabIndex = 14;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(50, 242);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(70, 16);
            телефонLabel.TabIndex = 15;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонMaskedTextBox
            // 
            this.телефонMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подача_обьявленияBindingSource, "Телефон", true));
            this.телефонMaskedTextBox.Location = new System.Drawing.Point(126, 239);
            this.телефонMaskedTextBox.Mask = "00000000000";
            this.телефонMaskedTextBox.Name = "телефонMaskedTextBox";
            this.телефонMaskedTextBox.Size = new System.Drawing.Size(200, 22);
            this.телефонMaskedTextBox.TabIndex = 16;
            // 
            // код_категорииLabel
            // 
            код_категорииLabel.AutoSize = true;
            код_категорииLabel.Location = new System.Drawing.Point(15, 270);
            код_категорииLabel.Name = "код_категорииLabel";
            код_категорииLabel.Size = new System.Drawing.Size(105, 16);
            код_категорииLabel.TabIndex = 17;
            код_категорииLabel.Text = "Код категории:";
            // 
            // код_категорииComboBox
            // 
            this.код_категорииComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подача_обьявленияBindingSource, "Код категории", true));
            this.код_категорииComboBox.DataSource = this.действияBindingSource;
            this.код_категорииComboBox.DisplayMember = "Код категории";
            this.код_категорииComboBox.FormattingEnabled = true;
            this.код_категорииComboBox.Location = new System.Drawing.Point(126, 267);
            this.код_категорииComboBox.Name = "код_категорииComboBox";
            this.код_категорииComboBox.Size = new System.Drawing.Size(200, 24);
            this.код_категорииComboBox.TabIndex = 18;
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
            // действияBindingSource
            // 
            this.действияBindingSource.DataMember = "Действия";
            this.действияBindingSource.DataSource = this.gazetaDataSet;
            // 
            // действияTableAdapter
            // 
            this.действияTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_категорииLabel);
            this.Controls.Add(this.код_категорииComboBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонMaskedTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(дата_подачиLabel);
            this.Controls.Add(this.дата_подачиDateTimePicker);
            this.Controls.Add(текстLabel);
            this.Controls.Add(this.текстTextBox);
            this.Controls.Add(категорияLabel);
            this.Controls.Add(this.категорияTextBox);
            this.Controls.Add(код_подрубрикиLabel);
            this.Controls.Add(this.код_подрубрикиComboBox);
            this.Controls.Add(this.подача_обьявленияBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F5";
            this.Text = "Подача обьявления";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gazetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подача_обьявленияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подача_обьявленияBindingNavigator)).EndInit();
            this.подача_обьявленияBindingNavigator.ResumeLayout(false);
            this.подача_обьявленияBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.подрубрикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.действияBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GazetaDataSet gazetaDataSet;
        private System.Windows.Forms.BindingSource подача_обьявленияBindingSource;
        private GazetaDataSetTableAdapters.Подача_обьявленияTableAdapter подача_обьявленияTableAdapter;
        private GazetaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator подача_обьявленияBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton подача_обьявленияBindingNavigatorSaveItem;
        private GazetaDataSetTableAdapters.ПодрубрикиTableAdapter подрубрикиTableAdapter;
        private System.Windows.Forms.ComboBox код_подрубрикиComboBox;
        private System.Windows.Forms.TextBox категорияTextBox;
        private System.Windows.Forms.TextBox текстTextBox;
        private System.Windows.Forms.DateTimePicker дата_подачиDateTimePicker;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.MaskedTextBox телефонMaskedTextBox;
        private System.Windows.Forms.ComboBox код_категорииComboBox;
        private System.Windows.Forms.BindingSource подрубрикиBindingSource;
        private GazetaDataSetTableAdapters.ДействияTableAdapter действияTableAdapter;
        private System.Windows.Forms.BindingSource действияBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}