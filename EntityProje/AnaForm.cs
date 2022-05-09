using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProje
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategori fr = new Kategori();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunFormu fr = new UrunFormu();
            fr.Show();
        }
    }
}
