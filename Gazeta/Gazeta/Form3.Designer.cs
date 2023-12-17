namespace Gazeta
{
    partial class F3
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
            System.Windows.Forms.Label датаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F3));
            this.gazetaDataSet = new Gazeta.GazetaDataSet();
            this.выпуск_газетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выпуск_газетыTableAdapter = new Gazeta.GazetaDataSetTableAdapters.Выпуск_газетыTableAdapter();
            this.tableAdapterManager = new Gazeta.GazetaDataSetTableAdapters.TableAdapterManager();
            this.выпуск_газетыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выпуск_газетыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            датаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gazetaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпуск_газетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпуск_газетыBindingNavigator)).BeginInit();
            this.выпуск_газетыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(33, 63);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(42, 16);
            датаLabel.TabIndex = 3;
            датаLabel.Text = "Дата:";
            // 
            // gazetaDataSet
            // 
            this.gazetaDataSet.DataSetName = "GazetaDataSet";
            this.gazetaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // выпуск_газетыBindingSource
            // 
            this.выпуск_газетыBindingSource.DataMember = "Выпуск газеты";
            this.выпуск_газетыBindingSource.DataSource = this.gazetaDataSet;
            // 
            // выпуск_газетыTableAdapter
            // 
            this.выпуск_газетыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Gazeta.GazetaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Выпуск_газетыTableAdapter = this.выпуск_газетыTableAdapter;
            this.tableAdapterManager.Выход_обьявленияTableAdapter = null;
            this.tableAdapterManager.ДействияTableAdapter = null;
            this.tableAdapterManager.Подача_обьявленияTableAdapter = null;
            this.tableAdapterManager.ПодрубрикиTableAdapter = null;
            this.tableAdapterManager.РубрикиTableAdapter = null;
            this.tableAdapterManager.Тарифы_на_обьявленияTableAdapter = null;
            // 
            // выпуск_газетыBindingNavigator
            // 
            this.выпуск_газетыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.выпуск_газетыBindingNavigator.BindingSource = this.выпуск_газетыBindingSource;
            this.выпуск_газетыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.выпуск_газетыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.выпуск_газетыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.выпуск_газетыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.выпуск_газетыBindingNavigatorSaveItem});
            this.выпуск_газетыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.выпуск_газетыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.выпуск_газетыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.выпуск_газетыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.выпуск_газетыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.выпуск_газетыBindingNavigator.Name = "выпуск_газетыBindingNavigator";
            this.выпуск_газетыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.выпуск_газетыBindingNavigator.Size = new System.Drawing.Size(348, 31);
            this.выпуск_газетыBindingNavigator.TabIndex = 0;
            this.выпуск_газетыBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // выпуск_газетыBindingNavigatorSaveItem
            // 
            this.выпуск_газетыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.выпуск_газетыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("выпуск_газетыBindingNavigatorSaveItem.Image")));
            this.выпуск_газетыBindingNavigatorSaveItem.Name = "выпуск_газетыBindingNavigatorSaveItem";
            this.выпуск_газетыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.выпуск_газетыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.выпуск_газетыBindingNavigatorSaveItem.Click += new System.EventHandler(this.выпуск_газетыBindingNavigatorSaveItem_Click);
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.выпуск_газетыBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(91, 63);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.датаDateTimePicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Перед закрытием не забудте сохранить изменения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(348, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(this.выпуск_газетыBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F3";
            this.Text = "Добавление даты выпуска";
            this.Load += new System.EventHandler(this.F3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gazetaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпуск_газетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выпуск_газетыBindingNavigator)).EndInit();
            this.выпуск_газетыBindingNavigator.ResumeLayout(false);
            this.выпуск_газетыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GazetaDataSet gazetaDataSet;
        private System.Windows.Forms.BindingSource выпуск_газетыBindingSource;
        private GazetaDataSetTableAdapters.Выпуск_газетыTableAdapter выпуск_газетыTableAdapter;
        private GazetaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator выпуск_газетыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton выпуск_газетыBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}