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
    public partial class UrunFormu : Form
    {
        public UrunFormu()
        {
            InitializeComponent();
        }

        private void UrunFormu_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TblKategori
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }).ToList();
            cmbKategori.ValueMember = "ID";
            cmbKategori.DisplayMember = "AD";
            cmbKategori.DataSource = kategoriler;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TblUrun tUrun = new TblUrun();
            tUrun.URUNAD = txtAd.Text;
            tUrun.MARKA = txtMarka.Text;
            tUrun.STOK = short.Parse(txtStok.Text);
            tUrun.KATEGORİ = int.Parse(cmbKategori.SelectedValue.ToString());
            tUrun.FİYAT = decimal.Parse(txtFiyat.Text);
            tUrun.DURUM = true;
            db.TblUrun.Add(tUrun);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Kaydedildi");
        }
        ProjeEntityEntities db = new ProjeEntityEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TblUrun
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FİYAT,
                                            x.DURUM,
                                            x.TblKategori.AD
                                        }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(txtId.Text);
            var urun = db.TblUrun.Find(s);
            db.SaveChanges();
            MessageBox.Show("Ürün silindi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int g = Convert.ToInt32(txtId.Text);
            var urun = db.TblUrun.Find(g);
            urun.URUNAD = txtAd.Text;
            urun.STOK = short.Parse(txtStok.Text);
            urun.MARKA = txtMarka.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün güncellendi");
        }
    }
}
