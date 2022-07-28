namespace Ihracat
{
    partial class CariEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIsim = new DevExpress.XtraEditors.TextEdit();
            this.TxtUlke = new DevExpress.XtraEditors.TextEdit();
            this.TxtYetkili = new DevExpress.XtraEditors.TextEdit();
            this.BtnCKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.grdCariListe = new DevExpress.XtraGrid.GridControl();
            this.grdviewCariListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnGuncel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIsim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUlke.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCariListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewCariListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ülke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yetkili";
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(91, 31);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(279, 20);
            this.TxtIsim.TabIndex = 3;
            // 
            // TxtUlke
            // 
            this.TxtUlke.Location = new System.Drawing.Point(91, 87);
            this.TxtUlke.Name = "TxtUlke";
            this.TxtUlke.Size = new System.Drawing.Size(279, 20);
            this.TxtUlke.TabIndex = 4;
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.Location = new System.Drawing.Point(91, 152);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Size = new System.Drawing.Size(279, 20);
            this.TxtYetkili.TabIndex = 5;
            // 
            // BtnCKaydet
            // 
            this.BtnCKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCKaydet.ImageOptions.Image")));
            this.BtnCKaydet.Location = new System.Drawing.Point(26, 193);
            this.BtnCKaydet.Name = "BtnCKaydet";
            this.BtnCKaydet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.BtnCKaydet.Size = new System.Drawing.Size(100, 36);
            this.BtnCKaydet.TabIndex = 6;
            this.BtnCKaydet.Text = "KAYDET";
            this.BtnCKaydet.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // grdCariListe
            // 
            this.grdCariListe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdCariListe.Location = new System.Drawing.Point(0, 250);
            this.grdCariListe.MainView = this.grdviewCariListe;
            this.grdCariListe.Name = "grdCariListe";
            this.grdCariListe.Size = new System.Drawing.Size(800, 200);
            this.grdCariListe.TabIndex = 7;
            this.grdCariListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdviewCariListe});
            // 
            // grdviewCariListe
            // 
            this.grdviewCariListe.GridControl = this.grdCariListe;
            this.grdviewCariListe.Name = "grdviewCariListe";
            this.grdviewCariListe.OptionsBehavior.Editable = false;
            this.grdviewCariListe.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.grdviewCariListe.OptionsView.ShowGroupPanel = false;
            this.grdviewCariListe.DoubleClick += new System.EventHandler(this.grdviewCariListe_DoubleClick);
            // 
            // btnGuncel
            // 
            this.btnGuncel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnGuncel.Location = new System.Drawing.Point(147, 191);
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGuncel.Size = new System.Drawing.Size(94, 39);
            this.btnGuncel.TabIndex = 8;
            this.btnGuncel.Text = "GÜNCELLE";
            this.btnGuncel.Click += new System.EventHandler(this.btnGuncel_Click);
            // 
            // CariEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuncel);
            this.Controls.Add(this.grdCariListe);
            this.Controls.Add(this.BtnCKaydet);
            this.Controls.Add(this.TxtYetkili);
            this.Controls.Add(this.TxtUlke);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CariEkle";
            this.Text = "Cari Ekle";
            this.Load += new System.EventHandler(this.CariEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtIsim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUlke.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtYetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCariListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewCariListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit TxtIsim;
        private DevExpress.XtraEditors.TextEdit TxtUlke;
        private DevExpress.XtraEditors.TextEdit TxtYetkili;
        private DevExpress.XtraEditors.SimpleButton BtnCKaydet;
        private DevExpress.XtraGrid.GridControl grdCariListe;
        private DevExpress.XtraGrid.Views.Grid.GridView grdviewCariListe;
        private DevExpress.XtraEditors.SimpleButton btnGuncel;
    }
}