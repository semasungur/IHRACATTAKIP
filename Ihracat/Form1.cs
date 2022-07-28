using DevExpress.XtraEditors;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        CariEkle cariEkle = new CariEkle();
        SipEkle sipEkle = new SipEkle();
        SevkEkle sevkEkle = new SevkEkle();
        YonEkle yonEkle = new YonEkle();
        IhrListele ihrListele = new IhrListele();
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cariEkle.ShowDialog();
        }

        private void barBtnSip_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sipEkle.ShowDialog();   
        }

        private void barBtnSevk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sevkEkle.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        { 
                if (XtraMessageBox.Show("Programdan çıkış yapmak mı istiyorsun?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    e.Cancel = false;
                }  
        }

        private void barBtnYon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            yonEkle.ShowDialog();
        }

        private void barBtnList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ihrListele.ShowDialog();
        }
    }
}
