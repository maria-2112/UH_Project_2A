using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Magic_Software
{
    public partial class MDIParent1 : Form
    {
       

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.MdiParent = this;
            F1.Show();
        }
    }
}
