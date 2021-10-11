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
    public partial class BookViewForm : Form
    {
        public BookViewForm()
        {
            InitializeComponent();
            this.bookViewDataGridView.Enabled = false;
        }

        private void BookViewForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.BookView". При необходимости она может быть перемещена или удалена.
            this.bookViewTableAdapter.Fill(this.libraryDataSet.BookView);

        }
    }
}
