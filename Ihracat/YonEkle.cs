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
    public partial class YonEkle : Form
    {
        public YonEkle()
        {
            InitializeComponent();
        }
        public static string YSip_No;
        public static string YSip_Tarih;
        public static string YCari_Isim;
        public static string YLojistik_Firma;
        public static string YTeslimat_Sekli;
        public static string YNavlun;
        public static string Mus;
        public static string Diib;
        public static string Nak;
        public static string Tev;
        public static string Tnt;
        public static string Kom;
        public static string Note;
        private void YonEkle_Load(object sender, EventArgs e)
        {
            grdYonetim.DataSource = ClassDatabase.dtSiparisListe2();
        }
        
        private void grdviewYonetim_DoubleClick(object sender, EventArgs e)
        {
            YSip_No = grdviewYonetim.GetRowCellValue(grdviewYonetim.FocusedRowHandle, "Sip_No").ToString();
            YSip_Tarih = grdviewYonetim.GetRowCellValue(grdviewYonetim.FocusedRowHandle, "Sip_Tarih").ToString();
            YCari_Isim = grdviewYonetim.GetRowCellValue(grdviewYonetim.FocusedRowHandle, "Cari_Isim").ToString();
            YLojistik_Firma = grdviewYonetim.GetRowCellValue(grdviewYonetim.FocusedRowHandle, "Lojistik_Firma").ToString();
            YTeslimat_Sekli = grdviewYonetim.GetRowCellValue(grdviewYonetim.FocusedRowHandle, "Teslimat_Sekli").ToString();
            YNavlun = grdviewYonetim.GetRowCellValue(grdviewYonetim.FocusedRowHandle, "Navlun").ToString();
            Mus = grdviewYonetim.GetRowCellValue(grdviewYonetim.FocusedRowHandle, "Mus").ToString();
            Diib = grdviewYonetim.GetRowCellValue(grdviewYonetim.FocusedRowHandle, "Diib").ToString();
            Nak = grdviewYonetim.GetRowCellValue(grdviewYonetim.FocusedRowHandle, "Nak").ToString();
            Tev = grdviewYonetim.GetRowCellValue(grdviewYonetim.FocusedRowHandle, "Tev").ToString();
            Tnt = grdviewYonetim.GetRowCellValue(grdviewYonetim.FocusedRowHandle, "Tnt").ToString();
            Kom = grdviewYonetim.GetRowCellValue(grdviewYonetim.FocusedRowHandle, "Kom").ToString();
            Note = grdviewYonetim.GetRowCellValue(grdviewYonetim.FocusedRowHandle, "Note").ToString();
            
            txtSip.Text = YSip_No;
            txtCar.Text = YCari_Isim;
            dtTar.Text = YSip_Tarih;
            txtLoj.Text = YLojistik_Firma;
            txtTes.Text = YTeslimat_Sekli;
            txtNav.Text = YNavlun;
            txtMus.Text = Mus;
            txtDiib.Text = Diib;
            txtNak.Text = Nak;
            txtTev.Text = Tev;
            txtTnt.Text = Tnt;
            txtKom.Text = Kom;
            txtNot.Text = Note;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (txtSip.Text != String.Empty)
            {
                string sonuc = ClassDatabase.updYonGuncelle(txtSip.Text, txtMus.Text, Convert.ToString(txtDiib.Text), txtNak.Text, txtTev.Text, txtTnt.Text,txtKom.Text,txtNot.Text);
                if (sonuc != "basarili")
                {
                    MessageBox.Show(sonuc);
                }
                else
                {
                    MessageBox.Show("Evrak Detayları Girildi!");
                    txtSip.Text = "";
                    txtCar.Text = "";
                    dtTar.Text = "";
                    txtLoj.Text = "";
                    txtTes.Text = "";
                    txtNav.Text = "";
                    txtMus.Text = "";
                    txtDiib.Text = "";
                    txtNak.Text = "";
                    txtTev.Text = "";
                    txtTnt.Text = "";
                    txtKom.Text = "";
                    txtNot.Text = "";
                    grdYonetim.DataSource = ClassDatabase.dtSiparisListe2();
                }
            }
            else { MessageBox.Show("Lütfen Kayıt Seçiniz"); }
        }
    }
}
