namespace Ihracat
{
    partial class IhrListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IhrListele));
            this.grdIhrList = new DevExpress.XtraGrid.GridControl();
            this.grdviewIhrList = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdIhrList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewIhrList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdIhrList
            // 
            this.grdIhrList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdIhrList.Location = new System.Drawing.Point(0, 0);
            this.grdIhrList.MainView = this.grdviewIhrList;
            this.grdIhrList.Name = "grdIhrList";
            this.grdIhrList.Size = new System.Drawing.Size(800, 450);
            this.grdIhrList.TabIndex = 0;
            this.grdIhrList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdviewIhrList});
            // 
            // grdviewIhrList
            // 
            this.grdviewIhrList.GridControl = this.grdIhrList;
            this.grdviewIhrList.Name = "grdviewIhrList";
            this.grdviewIhrList.OptionsBehavior.Editable = false;
            this.grdviewIhrList.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Classic;
            this.grdviewIhrList.OptionsView.ShowFooter = true;
            this.grdviewIhrList.OptionsView.ShowGroupPanel = false;
            this.grdviewIhrList.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.grdviewIhrList_RowCellStyle);
            // 
            // IhrListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdIhrList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IhrListele";
            this.Text = "IhrListele";
            this.Load += new System.EventHandler(this.IhrListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdIhrList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewIhrList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdIhrList;
        private DevExpress.XtraGrid.Views.Grid.GridView grdviewIhrList;
    }
}