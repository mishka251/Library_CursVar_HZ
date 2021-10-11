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
    public partial class ClientForm : Form
    {
        bool isAdmin = false;
        public ClientForm(bool isAdmin=false)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
            if (!isAdmin)
            {
                this.nameTextBox.Enabled = false;
                this.documentMaskedTextBox.Enabled = false;
                this.birthdayDateTimePicker.Enabled = false;
                this.phoneTextBox.Enabled = false;
                this.clientBindingNavigatorSaveItem.Enabled = false;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
            }
            this.bookOrderDataGridView.Enabled = false;
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.BookOrder". При необходимости она может быть перемещена или удалена.
            this.bookOrderTableAdapter.Fill(this.libraryDataSet.BookOrder);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.libraryDataSet.Client);

        }
    }
}
