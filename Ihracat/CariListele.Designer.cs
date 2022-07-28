namespace Ihracat
{
    partial class CariListele
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariListele));
            this.grdCariListele = new DevExpress.XtraGrid.GridControl();
            this.gridViewCariListele = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCariListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCariListele)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCariListele
            // 
            this.grdCariListele.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.grdCariListele.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdCariListele.Location = new System.Drawing.Point(0, 0);
            this.grdCariListele.MainView = this.gridViewCariListele;
            this.grdCariListele.Name = "grdCariListele";
            this.grdCariListele.Size = new System.Drawing.Size(800, 450);
            this.grdCariListele.TabIndex = 0;
            this.grdCariListele.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCariListele});
            // 
            // gridViewCariListele
            // 
            this.gridViewCariListele.GridControl = this.grdCariListele;
            this.gridViewCariListele.Name = "gridViewCariListele";
            this.gridViewCariListele.OptionsBehavior.Editable = false;
            this.gridViewCariListele.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewCariListele.OptionsView.ShowGroupPanel = false;
            this.gridViewCariListele.DoubleClick += new System.EventHandler(this.gridViewCariListele_DoubleClick_1);
            // 
            // CariListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdCariListele);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CariListele";
            this.Text = "CariListele";
            this.Load += new System.EventHandler(this.CariListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCariListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCariListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCariListele;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCariListele;
    }
}