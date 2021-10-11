using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_CursVar_HZ
{
    public partial class BookForm : Form
    {
        bool isAdmin;
        public BookForm(bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
            if (!isAdmin)
            {
                this.priceNumericUpDown.Enabled = false;
                this.titleTextBox.Enabled = false;
                this.comboBox1.Enabled = false;
                this.yearNumericUpDown.Enabled = false;
                this.numberMaskedTextBox.Enabled = false;
                this.bookBindingNavigatorSaveItem.Enabled = false;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
            }
            this.bookOrderDataGridView.Enabled = false;
        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bookBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.libraryDataSet);
                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }

        private void bookBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.BookAuthor". При необходимости она может быть перемещена или удалена.
            this.bookAuthorTableAdapter.Fill(this.libraryDataSet.BookAuthor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.BookOrder". При необходимости она может быть перемещена или удалена.
            this.bookOrderTableAdapter.Fill(this.libraryDataSet.BookOrder);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.libraryDataSet.Book);

        }
    }
}
