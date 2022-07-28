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
    public partial class CariListele : Form
    {
        public static string cari_id;
        public static string cari_isim;
        public static string cari_ulke;
        
        public CariListele()
        {
            InitializeComponent();
        }

        private void CariListele_Load(object sender, EventArgs e)
        {
            grdCariListele.DataSource = ClassDatabase.dtCariListe();
            gridViewCariListele.BestFitColumns();
        }

        private void gridViewCariListele_DoubleClick(object sender, EventArgs e)
        {
           // cari_id = gridViewCariListele.GetRowCellValue(gridViewCariListele.FocusedRowHandle, "Cari_ID").ToString();
           // cari_ulke = gridViewCariListele.GetRowCellValue(gridViewCariListele.FocusedRowHandle, "Cari_Ulke").ToString();
           // cari_isim = gridViewCariListele.GetRowCellValue(gridViewCariListele.FocusedRowHandle, "Cari_Isim").ToString();

           //this.Close();
        }

        private void gridViewCariListele_DoubleClick_1(object sender, EventArgs e)
        {
            cari_id = gridViewCariListele.GetRowCellValue(gridViewCariListele.FocusedRowHandle, "Cari_ID").ToString();
            cari_ulke = gridViewCariListele.GetRowCellValue(gridViewCariListele.FocusedRowHandle, "Cari_Ulke").ToString();
            cari_isim = gridViewCariListele.GetRowCellValue(gridViewCariListele.FocusedRowHandle, "Cari_Isim").ToString();

            this.Close();
        }
    }
}
