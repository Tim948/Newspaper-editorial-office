namespace Gazeta
{
    partial class F7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F7));
            System.Windows.Forms.Label название_рубрикиLabel;
            this.gazetaDataSet = new Gazeta.GazetaDataSet();
            this.рубрикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рубрикиTableAdapter = new Gazeta.GazetaDataSetTableAdapters.РубрикиTableAdapter();
            this.tableAdapterManager = new Gazeta.GazetaDataSetTableAdapters.TableAdapterManager();
            this.рубрикиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.рубрикиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.название_рубрикиTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            название_рубрикиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gazetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рубрикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рубрикиBindingNavigator)).BeginInit();
            this.рубрикиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gazetaDataSet
            // 
            this.gazetaDataSet.DataSetName = "GazetaDataSet";
            this.gazetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Gazeta.GazetaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выпуск_газетыTableAdapter = null;
            this.tableAdapterManager.Выход_обьявленияTableAdapter = null;
            this.tableAdapterManager.ДействияTableAdapter = null;
            this.tableAdapterManager.Подача_обьявленияTableAdapter = null;
            this.tableAdapterManager.ПодрубрикиTableAdapter = null;
            this.tableAdapterManager.РубрикиTableAdapter = this.рубрикиTableAdapter;
            this.tableAdapterManager.Тарифы_на_обьявленияTableAdapter = null;
            // 
            // рубрикиBindingNavigator
            // 
            this.рубрикиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.рубрикиBindingNavigator.BindingSource = this.рубрикиBindingSource;
            this.рубрикиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.рубрикиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.рубрикиBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.рубрикиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.рубрикиBindingNavigatorSaveItem});
            this.рубрикиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.рубрикиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.рубрикиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.рубрикиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.рубрикиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.рубрикиBindingNavigator.Name = "рубрикиBindingNavigator";
            this.рубрикиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.рубрикиBindingNavigator.Size = new System.Drawing.Size(359, 31);
            this.рубрикиBindingNavigator.TabIndex = 0;
            this.рубрикиBindingNavigator.Text = "bindingNavigator1";
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
            // рубрикиBindingNavigatorSaveItem
            // 
            this.рубрикиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.рубрикиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("рубрикиBindingNavigatorSaveItem.Image")));
            this.рубрикиBindingNavigatorSaveItem.Name = "рубрикиBindingNavigatorSaveItem";
            this.рубрикиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.рубрикиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.рубрикиBindingNavigatorSaveItem.Click += new System.EventHandler(this.рубрикиBindingNavigatorSaveItem_Click);
            // 
            // название_рубрикиLabel
            // 
            название_рубрикиLabel.AutoSize = true;
            название_рубрикиLabel.Location = new System.Drawing.Point(28, 64);
            название_рубрикиLabel.Name = "название_рубрикиLabel";
            название_рубрикиLabel.Size = new System.Drawing.Size(134, 16);
            название_рубрикиLabel.TabIndex = 1;
            название_рубрикиLabel.Text = "Название рубрики:";
            // 
            // название_рубрикиTextBox
            // 
            this.название_рубрикиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.рубрикиBindingSource, "Название рубрики", true));
            this.название_рубрикиTextBox.Location = new System.Drawing.Point(168, 61);
            this.название_рубрикиTextBox.Name = "название_рубрикиTextBox";
            this.название_рубрикиTextBox.Size = new System.Drawing.Size(143, 22);
            this.название_рубрикиTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(359, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(название_рубрикиLabel);
            this.Controls.Add(this.название_рубрикиTextBox);
            this.Controls.Add(this.рубрикиBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F7";
            this.Text = "Добавим рубрику";
            this.Load += new System.EventHandler(this.F7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gazetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рубрикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рубрикиBindingNavigator)).EndInit();
            this.рубрикиBindingNavigator.ResumeLayout(false);
            this.рубрикиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GazetaDataSet gazetaDataSet;
        private System.Windows.Forms.BindingSource рубрикиBindingSource;
        private GazetaDataSetTableAdapters.РубрикиTableAdapter рубрикиTableAdapter;
        private GazetaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator рубрикиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton рубрикиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox название_рубрикиTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}