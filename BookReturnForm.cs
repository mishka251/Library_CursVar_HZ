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
    public partial class BookReturnForm : Form
    {
        bool isAdmin;
        public BookReturnForm(bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
            if (!isAdmin)
            {
                this.dateDateTimePicker.Enabled = false;
                this.orderComboBox.Enabled = false;
                this.bookReturnBindingNavigatorSaveItem.Enabled = false;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void bookReturnBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bookReturnBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.libraryDataSet);
                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }

        private void BookReturnForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.BookOrder". При необходимости она может быть перемещена или удалена.
            this.bookOrderTableAdapter.Fill(this.libraryDataSet.BookOrder);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.BookReturn". При необходимости она может быть перемещена или удалена.
            this.bookReturnTableAdapter.Fill(this.libraryDataSet.BookReturn);

        }
    }
}
