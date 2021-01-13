namespace KastAjansıOtomasyonu
{
    partial class OyuncuIslemForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuIslemForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaylarıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabloyuYenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qRCODEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1217, 736);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.detaylarıGösterToolStripMenuItem,
            this.tabloyuYenileToolStripMenuItem,
            this.qRCODEToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(228, 114);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ekleToolStripMenuItem.Image")));
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("silToolStripMenuItem.Image")));
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // detaylarıGösterToolStripMenuItem
            // 
            this.detaylarıGösterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detaylarıGösterToolStripMenuItem.Image")));
            this.detaylarıGösterToolStripMenuItem.Name = "detaylarıGösterToolStripMenuItem";
            this.detaylarıGösterToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.detaylarıGösterToolStripMenuItem.Text = "Güncelle/Detayları Görüntüle";
            this.detaylarıGösterToolStripMenuItem.Click += new System.EventHandler(this.detaylarıGösterToolStripMenuItem_Click);
            // 
            // tabloyuYenileToolStripMenuItem
            // 
            this.tabloyuYenileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tabloyuYenileToolStripMenuItem.Image")));
            this.tabloyuYenileToolStripMenuItem.Name = "tabloyuYenileToolStripMenuItem";
            this.tabloyuYenileToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.tabloyuYenileToolStripMenuItem.Text = "Tabloyu Yenile";
            this.tabloyuYenileToolStripMenuItem.Click += new System.EventHandler(this.tabloyuYenileToolStripMenuItem_Click);
            // 
            // qRCODEToolStripMenuItem
            // 
            this.qRCODEToolStripMenuItem.Image = global::KastAjansıOtomasyonu.Properties.Resources.index;
            this.qRCODEToolStripMenuItem.Name = "qRCODEToolStripMenuItem";
            this.qRCODEToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.qRCODEToolStripMenuItem.Text = "QR-CODE";
            this.qRCODEToolStripMenuItem.Click += new System.EventHandler(this.qRCODEToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // OyuncuIslemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 736);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OyuncuIslemForm";
            this.Text = "Oyuncu Listesi";
            this.Load += new System.EventHandler(this.OyuncuIslemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaylarıGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabloyuYenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qRCODEToolStripMenuItem;
    }
}