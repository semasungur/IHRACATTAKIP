namespace Ihracat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnCari = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSip = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSevk = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnYon = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnList = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRap = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barBtnCari,
            this.barBtnSip,
            this.barBtnSevk,
            this.barBtnYon,
            this.barBtnList,
            this.barBtnRap});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(800, 150);
            // 
            // barBtnCari
            // 
            this.barBtnCari.Caption = "CARİ";
            this.barBtnCari.Id = 1;
            this.barBtnCari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnCari.ImageOptions.Image")));
            this.barBtnCari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnCari.ImageOptions.LargeImage")));
            this.barBtnCari.Name = "barBtnCari";
            this.barBtnCari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barBtnSip
            // 
            this.barBtnSip.Caption = "SİPARİŞ";
            this.barBtnSip.Id = 2;
            this.barBtnSip.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSip.ImageOptions.Image")));
            this.barBtnSip.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSip.ImageOptions.LargeImage")));
            this.barBtnSip.Name = "barBtnSip";
            this.barBtnSip.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSip_ItemClick);
            // 
            // barBtnSevk
            // 
            this.barBtnSevk.Caption = "SEVKİYAT";
            this.barBtnSevk.Id = 3;
            this.barBtnSevk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnSevk.ImageOptions.Image")));
            this.barBtnSevk.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnSevk.ImageOptions.LargeImage")));
            this.barBtnSevk.Name = "barBtnSevk";
            this.barBtnSevk.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSevk_ItemClick);
            // 
            // barBtnYon
            // 
            this.barBtnYon.Caption = "YÖNETİM";
            this.barBtnYon.Id = 4;
            this.barBtnYon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnYon.ImageOptions.Image")));
            this.barBtnYon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnYon.ImageOptions.LargeImage")));
            this.barBtnYon.Name = "barBtnYon";
            this.barBtnYon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnYon_ItemClick);
            // 
            // barBtnList
            // 
            this.barBtnList.Caption = "İHRACAT LİSTESİ";
            this.barBtnList.Id = 5;
            this.barBtnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnList.ImageOptions.Image")));
            this.barBtnList.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnList.ImageOptions.LargeImage")));
            this.barBtnList.Name = "barBtnList";
            this.barBtnList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnList_ItemClick);
            // 
            // barBtnRap
            // 
            this.barBtnRap.Caption = "RAPOR";
            this.barBtnRap.Id = 6;
            this.barBtnRap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnRap.ImageOptions.Image")));
            this.barBtnRap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnRap.ImageOptions.LargeImage")));
            this.barBtnRap.Name = "barBtnRap";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "İHRACAT TAKİP";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnCari);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Cari";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnSip);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnSevk);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnYon);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Sipariş";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnList);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Liste";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "İhracat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barBtnCari;
        private DevExpress.XtraBars.BarButtonItem barBtnSip;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barBtnSevk;
        private DevExpress.XtraBars.BarButtonItem barBtnYon;
        private DevExpress.XtraBars.BarButtonItem barBtnList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barBtnRap;
    }
}

