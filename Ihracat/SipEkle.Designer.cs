namespace Ihracat
{
    partial class SipEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SipEkle));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SipDate = new System.Windows.Forms.DateTimePicker();
            this.SipKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtTermin = new DevExpress.XtraEditors.TextEdit();
            this.txtCariIsim = new DevExpress.XtraEditors.TextEdit();
            this.txtSipNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grdSiparisList = new DevExpress.XtraGrid.GridControl();
            this.grdviewSipList = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTermin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSipNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSiparisList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewSipList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.SipDate);
            this.groupControl1.Controls.Add(this.SipKaydet);
            this.groupControl1.Controls.Add(this.txtTermin);
            this.groupControl1.Controls.Add(this.txtCariIsim);
            this.groupControl1.Controls.Add(this.txtSipNo);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(800, 279);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Sipariş Giriş";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(346, 74);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(28, 23);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "...";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // SipDate
            // 
            this.SipDate.Location = new System.Drawing.Point(103, 121);
            this.SipDate.Name = "SipDate";
            this.SipDate.Size = new System.Drawing.Size(227, 21);
            this.SipDate.TabIndex = 21;
            // 
            // SipKaydet
            // 
            this.SipKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SipKaydet.ImageOptions.Image")));
            this.SipKaydet.Location = new System.Drawing.Point(15, 201);
            this.SipKaydet.Name = "SipKaydet";
            this.SipKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.SipKaydet.Size = new System.Drawing.Size(108, 43);
            this.SipKaydet.TabIndex = 19;
            this.SipKaydet.Text = "KAYDET";
            this.SipKaydet.Click += new System.EventHandler(this.SipKaydet_Click_1);
            // 
            // txtTermin
            // 
            this.txtTermin.Location = new System.Drawing.Point(103, 160);
            this.txtTermin.Name = "txtTermin";
            this.txtTermin.Size = new System.Drawing.Size(227, 20);
            this.txtTermin.TabIndex = 18;
            // 
            // txtCariIsim
            // 
            this.txtCariIsim.Enabled = false;
            this.txtCariIsim.Location = new System.Drawing.Point(103, 76);
            this.txtCariIsim.Name = "txtCariIsim";
            this.txtCariIsim.Size = new System.Drawing.Size(227, 20);
            this.txtCariIsim.TabIndex = 17;
            // 
            // txtSipNo
            // 
            this.txtSipNo.Location = new System.Drawing.Point(103, 32);
            this.txtSipNo.Name = "txtSipNo";
            this.txtSipNo.Properties.MaxLength = 10;
            this.txtSipNo.Size = new System.Drawing.Size(227, 20);
            this.txtSipNo.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 167);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Termin";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Sipariş Tarih";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Cari";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Sipariş No";
            // 
            // grdSiparisList
            // 
            this.grdSiparisList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdSiparisList.Location = new System.Drawing.Point(0, 250);
            this.grdSiparisList.MainView = this.grdviewSipList;
            this.grdSiparisList.Name = "grdSiparisList";
            this.grdSiparisList.Size = new System.Drawing.Size(800, 200);
            this.grdSiparisList.TabIndex = 13;
            this.grdSiparisList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdviewSipList});
            // 
            // grdviewSipList
            // 
            this.grdviewSipList.GridControl = this.grdSiparisList;
            this.grdviewSipList.Name = "grdviewSipList";
            this.grdviewSipList.OptionsBehavior.Editable = false;
            this.grdviewSipList.OptionsView.ShowGroupPanel = false;
            // 
            // SipEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdSiparisList);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SipEkle";
            this.Text = "Sipariş Ekle";
            this.Load += new System.EventHandler(this.SipEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTermin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariIsim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSipNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSiparisList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewSipList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker SipDate;
        private DevExpress.XtraEditors.SimpleButton SipKaydet;
        private DevExpress.XtraEditors.TextEdit txtTermin;
        private DevExpress.XtraEditors.TextEdit txtCariIsim;
        private DevExpress.XtraEditors.TextEdit txtSipNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl grdSiparisList;
        private DevExpress.XtraGrid.Views.Grid.GridView grdviewSipList;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}