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
    public partial class GetBookOrderForm : Form
    {
        public GetBookOrderForm()
        {
            InitializeComponent();
            this.getBookOrdersDataGridView.Enabled = false;
        }

        private void selectRouteBuses()
        {
            if (this.bookComboBox.SelectedValue == null)
            {
                return;
            }

            try
            {
                int selectedRouteId = (int)this.bookComboBox.SelectedValue;
                this.getBookOrdersTableAdapter.Fill(this.libraryDataSet.GetBookOrders, selectedRouteId);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void GetBookOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Book". При необходимости она может быть перемещена или удалена.
            this.bookTableAdapter.Fill(this.libraryDataSet.Book);
            this.selectRouteBuses();

        }

        private void bookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selectRouteBuses();
        }
    }
}
