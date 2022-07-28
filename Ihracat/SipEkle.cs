using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ihracat
{
    public partial class SipEkle : Form
    {
        public SipEkle()
        {
            InitializeComponent();
        }

        CariListele cariListele = new CariListele();
        static string Cari_Id;
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //CariListele.cari_id = "";
            //CariListele.cari_ulke = "";
            //CariListele.cari_isim = "";
            //cariListele.ShowDialog();
            //txtCariIsim.Text = CariListele.cari_isim;
            //Cari_Id = CariListele.cari_id;
        }

        private void SipKaydet_Click(object sender, EventArgs e)
        {
            //string sonuc = ClassDatabase.insSiparisEkle(txtSipNo.Text, SipDate.Value.Date, Convert.ToInt32(Cari_Id), txtTermin.Text);
            //if (sonuc != "basarili")
            //{
            //    MessageBox.Show(sonuc);
            //}
            //else
            //{        
            //    txtSipNo.Text = "";
            //    txtCariIsim.Text = "";
            //    txtTermin.Text = "";
            //    MessageBox.Show("BAŞARIYLA EKLENDİ!");
            //    grdSiparisList.DataSource = ClassDatabase.dtSiparisListe();
            //}
            
        }

        private void SipEkle_Load(object sender, EventArgs e)
        {
            grdSiparisList.DataSource = ClassDatabase.dtSiparisListe();
           // grdviewSipList.BestFitColumns();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            CariListele.cari_id = "";
            CariListele.cari_ulke = "";
            CariListele.cari_isim = "";
            cariListele.ShowDialog();
            txtCariIsim.Text = CariListele.cari_isim;
            Cari_Id = CariListele.cari_id;
        }

        private void SipKaydet_Click_1(object sender, EventArgs e)
        {
            string sonuc = ClassDatabase.insSiparisEkle(txtSipNo.Text, SipDate.Value.Date, Convert.ToInt32(Cari_Id), txtTermin.Text);
            if (sonuc != "basarili")
            {
                MessageBox.Show(sonuc);
            }
            else
            {
                txtSipNo.Text = "";
                txtCariIsim.Text = "";
                txtTermin.Text = "";
                MessageBox.Show("BAŞARIYLA EKLENDİ!");
                grdSiparisList.DataSource = ClassDatabase.dtSiparisListe();
            }
        }
    }
}
