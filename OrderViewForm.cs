﻿using System;
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
    public partial class OrderViewForm : Form
    {
        public OrderViewForm()
        {
            InitializeComponent();
            this.orderViewDataGridView.Enabled = false;
        }

        private void OrderViewForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.OrderView". При необходимости она может быть перемещена или удалена.
            this.orderViewTableAdapter.Fill(this.libraryDataSet.OrderView);

        }
    }
}
