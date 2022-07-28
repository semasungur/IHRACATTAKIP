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
    public partial class IhrListele : Form
    {
        public IhrListele()
        {
            InitializeComponent();
          
        }

        private void IhrListele_Load(object sender, EventArgs e)
        {
            grdIhrList.DataSource = ClassDatabase.dtSiparisListe2();
           
        }
        
        private void grdviewIhrList_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

            //string note = grdviewIhrList.GetRowCellValue(grdviewIhrList.FocusedRowHandle, "Note").ToString();
            //if (note == "TAMAMLANDI")
            //{
            //    e.Appearance.BackColor = Color.Red;
            //}
            //else
            //{
            //    e.Appearance.BackColor = Color.Gray;
            //}
        }
    }
}
