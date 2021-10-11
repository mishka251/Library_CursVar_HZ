
namespace Library_CursVar_HZ
{
    partial class BookOrderForm
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
            System.Windows.Forms.Label bookIdLabel;
            System.Windows.Forms.Label clientIdLabel;
            System.Windows.Forms.Label employerIdLabel;
            System.Windows.Forms.Label dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookOrderForm));
            this.libraryDataSet = new Library_CursVar_HZ.LibraryDataSet();
            this.bookOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookOrderTableAdapter = new Library_CursVar_HZ.LibraryDataSetTableAdapters.BookOrderTableAdapter();
            this.tableAdapterManager = new Library_CursVar_HZ.LibraryDataSetTableAdapters.TableAdapterManager();
            this.bookOrderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bookOrderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bookComboBox = new System.Windows.Forms.ComboBox();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new Library_CursVar_HZ.LibraryDataSetTableAdapters.BookTableAdapter();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Library_CursVar_HZ.LibraryDataSetTableAdapters.ClientTableAdapter();
            this.emploeyrComboBox = new System.Windows.Forms.ComboBox();
            this.employerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employerTableAdapter = new Library_CursVar_HZ.LibraryDataSetTableAdapters.EmployerTableAdapter();
            bookIdLabel = new System.Windows.Forms.Label();
            clientIdLabel = new System.Windows.Forms.Label();
            employerIdLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookOrderBindingNavigator)).BeginInit();
            this.bookOrderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookIdLabel
            // 
            bookIdLabel.AutoSize = true;
            bookIdLabel.Location = new System.Drawing.Point(39, 42);
            bookIdLabel.Name = "bookIdLabel";
            bookIdLabel.Size = new System.Drawing.Size(47, 13);
            bookIdLabel.TabIndex = 1;
            bookIdLabel.Text = "Book Id:";
            // 
            // clientIdLabel
            // 
            clientIdLabel.AutoSize = true;
            clientIdLabel.Location = new System.Drawing.Point(41, 87);
            clientIdLabel.Name = "clientIdLabel";
            clientIdLabel.Size = new System.Drawing.Size(48, 13);
            clientIdLabel.TabIndex = 3;
            clientIdLabel.Text = "Client Id:";
            // 
            // employerIdLabel
            // 
            employerIdLabel.AutoSize = true;
            employerIdLabel.Location = new System.Drawing.Point(47, 128);
            employerIdLabel.Name = "employerIdLabel";
            employerIdLabel.Size = new System.Drawing.Size(65, 13);
            employerIdLabel.TabIndex = 5;
            employerIdLabel.Text = "Employer Id:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(37, 168);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 7;
            dateLabel.Text = "Date:";
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookOrderBindingSource
            // 
            this.bookOrderBindingSource.DataMember = "BookOrder";
            this.bookOrderBindingSource.DataSource = this.libraryDataSet;
            // 
            // bookOrderTableAdapter
            // 
            this.bookOrderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookAuthorTableAdapter = null;
            this.tableAdapterManager.BookOrderTableAdapter = this.bookOrderTableAdapter;
            this.tableAdapterManager.BookReturnTableAdapter = null;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.EmployerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library_CursVar_HZ.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // bookOrderBindingNavigator
            // 
            this.bookOrderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookOrderBindingNavigator.BindingSource = this.bookOrderBindingSource;
            this.bookOrderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookOrderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookOrderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bookOrderBindingNavigatorSaveItem});
            this.bookOrderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookOrderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookOrderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookOrderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookOrderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookOrderBindingNavigator.Name = "bookOrderBindingNavigator";
            this.bookOrderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookOrderBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.bookOrderBindingNavigator.TabIndex = 0;
            this.bookOrderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bookOrderBindingNavigatorSaveItem
            // 
            this.bookOrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookOrderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookOrderBindingNavigatorSaveItem.Image")));
            this.bookOrderBindingNavigatorSaveItem.Name = "bookOrderBindingNavigatorSaveItem";
            this.bookOrderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bookOrderBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.bookOrderBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookOrderBindingNavigatorSaveItem_Click);
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookOrderBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(76, 164);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 8;
            // 
            // bookComboBox
            // 
            this.bookComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bookOrderBindingSource, "BookId", true));
            this.bookComboBox.DataSource = this.bookBindingSource;
            this.bookComboBox.DisplayMember = "Title";
            this.bookComboBox.FormattingEnabled = true;
            this.bookComboBox.Location = new System.Drawing.Point(92, 42);
            this.bookComboBox.Name = "bookComboBox";
            this.bookComboBox.Size = new System.Drawing.Size(171, 21);
            this.bookComboBox.TabIndex = 9;
            this.bookComboBox.ValueMember = "Id";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.libraryDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // clientComboBox
            // 
            this.clientComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bookOrderBindingSource, "ClientId", true));
            this.clientComboBox.DataSource = this.clientBindingSource;
            this.clientComboBox.DisplayMember = "Name";
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(92, 83);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(171, 21);
            this.clientComboBox.TabIndex = 10;
            this.clientComboBox.ValueMember = "Id";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.libraryDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // emploeyrComboBox
            // 
            this.emploeyrComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bookOrderBindingSource, "EmployerId", true));
            this.emploeyrComboBox.DataSource = this.employerBindingSource;
            this.emploeyrComboBox.DisplayMember = "Name";
            this.emploeyrComboBox.FormattingEnabled = true;
            this.emploeyrComboBox.Location = new System.Drawing.Point(142, 124);
            this.emploeyrComboBox.Name = "emploeyrComboBox";
            this.emploeyrComboBox.Size = new System.Drawing.Size(121, 21);
            this.emploeyrComboBox.TabIndex = 11;
            this.emploeyrComboBox.ValueMember = "Id";
            // 
            // employerBindingSource
            // 
            this.employerBindingSource.DataMember = "Employer";
            this.employerBindingSource.DataSource = this.libraryDataSet;
            // 
            // employerTableAdapter
            // 
            this.employerTableAdapter.ClearBeforeFill = true;
            // 
            // BookOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emploeyrComboBox);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.bookComboBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(employerIdLabel);
            this.Controls.Add(clientIdLabel);
            this.Controls.Add(bookIdLabel);
            this.Controls.Add(this.bookOrderBindingNavigator);
            this.Name = "BookOrderForm";
            this.Text = "BookOrderForm";
            this.Load += new System.EventHandler(this.BookOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookOrderBindingNavigator)).EndInit();
            this.bookOrderBindingNavigator.ResumeLayout(false);
            this.bookOrderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource bookOrderBindingSource;
        private LibraryDataSetTableAdapters.BookOrderTableAdapter bookOrderTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookOrderBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bookOrderBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.ComboBox bookComboBox;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LibraryDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private LibraryDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.ComboBox emploeyrComboBox;
        private System.Windows.Forms.BindingSource employerBindingSource;
        private LibraryDataSetTableAdapters.EmployerTableAdapter employerTableAdapter;
    }
}