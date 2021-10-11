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
    public partial class MenuForm : Form
    {

        bool isAdmin;

        public MenuForm(bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookForm bf = new BookForm(this.isAdmin);
            bf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookAuthorForm brf = new BookAuthorForm(this.isAdmin);
            brf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientForm cmf = new ClientForm(this.isAdmin);
            cmf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployerForm cmf = new EmployerForm(this.isAdmin);
            cmf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BookOrderForm rf = new BookOrderForm(this.isAdmin);
            rf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           BookReturnForm sf = new BookReturnForm(this.isAdmin);
            sf.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           // StationInRouteForm srf = new StationInRouteForm(this.isAdmin);
           // srf.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BookViewForm bv = new BookViewForm();
            bv.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
             OrderViewForm rsv = new OrderViewForm();
             rsv.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GetBookOrderForm rb = new GetBookOrderForm();
            rb.Show();
        }
    }
}
