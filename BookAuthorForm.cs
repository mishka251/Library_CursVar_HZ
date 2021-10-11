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
    public partial class BookAuthorForm : Form
    {
        bool isAdmin;
        public BookAuthorForm(bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
            if (!isAdmin)
            {
                this.nameTextBox.Enabled = false;
                this.surnameTextBox.Enabled = false;
                this.lastNameTextBox.Enabled = false;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
            }
            this.bookDataGridView.Enabled = false;
        }

        private void bookAuthorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bookAuthorBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.libraryDataSet);
                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }

        private void BookAuthorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.libraryDataSet.Book);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.BookAuthor". При необходимости она может быть перемещена или удалена.
            this.bookAuthorTableAdapter.Fill(this.libraryDataSet.BookAuthor);

        }
    }
}
