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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        ProjeEntityEntities db = new ProjeEntityEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var kategoriler = db.TblKategori.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TblKategori t = new TblKategori();
            t.AD = textBox2.Text;
            db.TblKategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori eklendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TblKategori.Find(x);
            db.TblKategori.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("Kategori silindi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var ktgr = db.TblKategori.Find(x);
            ktgr.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme yapıldı");
        }
    }
}
