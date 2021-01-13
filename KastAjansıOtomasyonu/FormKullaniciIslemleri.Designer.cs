namespace KastAjansıOtomasyonu
{
    partial class FormKullaniciIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKullaniciIslemleri));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tblKullanıcıIslemleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.castAjansVeriTabaniDataSet5 = new KastAjansıOtomasyonu.CastAjansVeriTabaniDataSet5();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colkullaniciAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tblKullanıcıIslemleriTableAdapter = new KastAjansıOtomasyonu.CastAjansVeriTabaniDataSet5TableAdapters.tblKullanıcıIslemleriTableAdapter();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanıcıIslemleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.castAjansVeriTabaniDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblKullanıcıIslemleriBindingSource;
            this.gridControl1.EmbeddedNavigator.Enabled = false;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(200, 69);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tblKullanıcıIslemleriBindingSource
            // 
            this.tblKullanıcıIslemleriBindingSource.DataMember = "tblKullanıcıIslemleri";
            this.tblKullanıcıIslemleriBindingSource.DataSource = this.castAjansVeriTabaniDataSet5;
            // 
            // castAjansVeriTabaniDataSet5
            // 
            this.castAjansVeriTabaniDataSet5.DataSetName = "CastAjansVeriTabaniDataSet5";
            this.castAjansVeriTabaniDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkullaniciAdı});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colkullaniciAdı
            // 
            this.colkullaniciAdı.FieldName = "kullaniciAdı";
            this.colkullaniciAdı.Name = "colkullaniciAdı";
            this.colkullaniciAdı.Visible = true;
            this.colkullaniciAdı.VisibleIndex = 0;
            // 
            // tblKullanıcıIslemleriTableAdapter
            // 
            this.tblKullanıcıIslemleriTableAdapter.ClearBeforeFill = true;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(98, 117);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yeni Şifreniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eski Şifreniz: ";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(98, 92);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(100, 20);
            this.textEdit2.TabIndex = 4;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(98, 143);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(100, 20);
            this.textEdit3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tekrar girin: ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(61, 169);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(109, 38);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Değiştir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FormKullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KastAjansıOtomasyonu.Properties.Resources.maviarkaplan1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(227, 251);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormKullaniciIslemleri";
            this.Text = "Şifre Değiştir";
            this.Load += new System.EventHandler(this.FormKullaniciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanıcıIslemleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.castAjansVeriTabaniDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private CastAjansVeriTabaniDataSet5 castAjansVeriTabaniDataSet5;
        private System.Windows.Forms.BindingSource tblKullanıcıIslemleriBindingSource;
        private CastAjansVeriTabaniDataSet5TableAdapters.tblKullanıcıIslemleriTableAdapter tblKullanıcıIslemleriTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colkullaniciAdı;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}