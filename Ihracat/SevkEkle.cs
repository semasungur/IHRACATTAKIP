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
    public partial class SevkEkle : Form
    {
        public SevkEkle()
        {
            InitializeComponent();
        }
        public static string Sip_No;
        public static string Sip_Tarih;
        public static string Cari_Isim;
        public static string Kont_Adet;
        public static string Kont_No;
        public static string Lojistik_Firma;
        public static string Teslimat_Sekli;
        public static string Navlun;
        private void SevkEkle_Load(object sender, EventArgs e)
        {
            grdSipSevk.DataSource = ClassDatabase.dtSiparisListe1();
            // grdviewSipSevk.BestFitColumns();
           
        }
        private void grdviewSipSevk_DoubleClick(object sender, EventArgs e)
        {
            Sip_No = grdviewSipSevk.GetRowCellValue(grdviewSipSevk.FocusedRowHandle, "Sip_No").ToString();
            Sip_Tarih = grdviewSipSevk.GetRowCellValue(grdviewSipSevk.FocusedRowHandle, "Sip_Tarih").ToString();
            Cari_Isim = grdviewSipSevk.GetRowCellValue(grdviewSipSevk.FocusedRowHandle, "Cari_Isim").ToString();
            Kont_Adet = grdviewSipSevk.GetRowCellValue(grdviewSipSevk.FocusedRowHandle, "Kont_Adet").ToString();
            Kont_No = grdviewSipSevk.GetRowCellValue(grdviewSipSevk.FocusedRowHandle, "Kont_No").ToString();
            Lojistik_Firma = grdviewSipSevk.GetRowCellValue(grdviewSipSevk.FocusedRowHandle, "Lojistik_Firma").ToString();
            Teslimat_Sekli = grdviewSipSevk.GetRowCellValue(grdviewSipSevk.FocusedRowHandle, "Teslimat_Sekli").ToString();
            Navlun = grdviewSipSevk.GetRowCellValue(grdviewSipSevk.FocusedRowHandle, "Navlun").ToString();

            txtCar.Text = Cari_Isim;
            txtSip.Text = Sip_No;
            dtTar.Text = Sip_Tarih; 
            txtKontAdet.Text = Kont_Adet;
            txtKontNo.Text= Kont_No;
            txtLogFirm.Text = Lojistik_Firma;
            txtTesSek.Text = Teslimat_Sekli;
            txtNavlun.Text = Navlun;
        }

        private void btnSevkGün_Click(object sender, EventArgs e)
        {
            if (txtSip.Text != String.Empty) { 
            string sonuc = ClassDatabase.updSevkGuncelle(txtSip.Text, txtKontAdet.Text,txtKontNo.Text,txtLogFirm.Text,txtTesSek.Text,txtNavlun.Text);
            if (sonuc != "basarili")
            {
                MessageBox.Show(sonuc);
            }
            else
            {
                MessageBox.Show("Sevk Detayları Girildi!");
                txtSip.Text = "";
                txtCar.Text = "";
                dtTar.Text = "";
                txtKontAdet.Text = "";
                txtKontNo.Text = "";
                txtLogFirm.Text = "";
                txtTesSek.Text = "";
                txtNavlun.Text = "";
                dtSevkTar.Text = "";
                grdSipSevk.DataSource = ClassDatabase.dtSiparisListe1();
                }
            }
            else { MessageBox.Show("Lütfen Kayıt Seçiniz"); }
        }
    }
}
