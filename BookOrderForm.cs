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
    public partial class BookOrderForm : Form
    {
        bool isAdmin;
        public BookOrderForm(bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
            if (!isAdmin)
            {
                this.dateDateTimePicker.Enabled = false;
                this.bookComboBox.Enabled = false;
                this.clientComboBox.Enabled = false;
                this.emploeyrComboBox.Enabled = false;
                this.bookOrderBindingNavigatorSaveItem.Enabled = false;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void bookOrderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookOrderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void BookOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Employer". При необходимости она может быть перемещена или удалена.
            this.employerTableAdapter.Fill(this.libraryDataSet.Employer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.libraryDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.libraryDataSet.Book);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.BookOrder". При необходимости она может быть перемещена или удалена.
            this.bookOrderTableAdapter.Fill(this.libraryDataSet.BookOrder);

        }
    }
}
