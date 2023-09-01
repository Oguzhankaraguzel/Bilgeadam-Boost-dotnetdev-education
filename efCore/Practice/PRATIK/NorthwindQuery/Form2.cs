using NorthwindQuery.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindQuery
{
    public partial class Form2 : Form
    {
        public DataGridView MyDataGridView
        {
            get { return dataGridView1; }
            set { dataGridView1 = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
