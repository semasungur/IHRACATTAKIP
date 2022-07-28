using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ihracat
{
    public partial class CariEkle : Form
    {
        public CariEkle()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {            
            string sonuc = ClassDatabase.insCariEkle(TxtIsim.Text, TxtUlke.Text, TxtYetkili.Text);
            if (sonuc != "basarili")
            {
                MessageBox.Show(sonuc);
            }
            else
            {  
                TxtIsim.Text = "";
                TxtUlke.Text = "";
                TxtYetkili.Text = "";
                MessageBox.Show("BAŞARIYLA EKLENDİ!");
                grdCariListe.DataSource = ClassDatabase.dtCariListe();
                this.grdviewCariListe.Columns["Cari_ID"].Visible = false;
            }
        }

        private void CariEkle_Load(object sender, EventArgs e)
        {
            grdCariListe.DataSource = ClassDatabase.dtCariListe();
            this.grdviewCariListe.Columns["Cari_ID"].Visible = false;
            grdviewCariListe.BestFitColumns();
        }
        public static string CCari_ID;
        public static string CCari_Isim;
        public static string CCari_Ulke;
        public static string CCari_Yetkili;
        private void grdviewCariListe_DoubleClick(object sender, EventArgs e)
        {
            CCari_ID = grdviewCariListe.GetRowCellValue(grdviewCariListe.FocusedRowHandle, "Cari_ID").ToString();
            CCari_Isim = grdviewCariListe.GetRowCellValue(grdviewCariListe.FocusedRowHandle, "Cari_Isim").ToString();
            CCari_Ulke = grdviewCariListe.GetRowCellValue(grdviewCariListe.FocusedRowHandle, "Cari_Ulke").ToString();
            CCari_Yetkili = grdviewCariListe.GetRowCellValue(grdviewCariListe.FocusedRowHandle, "Cari_Yetkili").ToString();

            TxtIsim.Text = CCari_Isim;
            TxtUlke.Text = CCari_Ulke;
            TxtYetkili.Text = CCari_Yetkili;
        }

        private void btnGuncel_Click(object sender, EventArgs e)
        {
            if (TxtIsim.Text != String.Empty)
            {
                string sonuc = ClassDatabase.updCariGuncelle(TxtIsim.Text, TxtUlke.Text, TxtYetkili.Text);
                if (sonuc != "basarili")
                {
                    MessageBox.Show(sonuc);
                }
                else
                {
                    MessageBox.Show("Cari Güncellendi!");
                    TxtIsim.Text = "";
                    TxtUlke.Text = "";
                    TxtYetkili.Text = "";
                    
                    grdCariListe.DataSource = ClassDatabase.dtCariListe();
                }
            }
            else { MessageBox.Show("Lütfen Kayıt Seçiniz"); }
        }
    }
}
