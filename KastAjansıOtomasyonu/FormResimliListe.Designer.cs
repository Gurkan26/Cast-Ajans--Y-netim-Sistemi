namespace KastAjansıOtomasyonu
{
    partial class FormResimliListe
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tblOyuncuBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.castAjansVeriTabaniDataSet3 = new KastAjansıOtomasyonu.CastAjansVeriTabaniDataSet3();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colAd = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colAd = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colSoyad = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colSoyad = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colDogumTarihi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colDogumTarihi = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colFotograf = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colFotograf = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.castAjansVeriTabaniDataSet2 = new KastAjansıOtomasyonu.CastAjansVeriTabaniDataSet2();
            this.castAjansVeriTabaniDataSet1 = new KastAjansıOtomasyonu.CastAjansVeriTabaniDataSet1();
            this.tblOyuncuBilgiTableAdapter = new KastAjansıOtomasyonu.CastAjansVeriTabaniDataSet1TableAdapters.tblOyuncuBilgiTableAdapter();
            this.tblOyuncuBilgiTableAdapter1 = new KastAjansıOtomasyonu.CastAjansVeriTabaniDataSet2TableAdapters.tblOyuncuBilgiTableAdapter();
            this.tblOyuncuBilgiTableAdapter2 = new KastAjansıOtomasyonu.CastAjansVeriTabaniDataSet3TableAdapters.tblOyuncuBilgiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOyuncuBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.castAjansVeriTabaniDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSoyad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDogumTarihi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFotograf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.castAjansVeriTabaniDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.castAjansVeriTabaniDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.BackgroundImage = global::KastAjansıOtomasyonu.Properties.Resources.Blue_Vector_Backgrounds_wallpaper_1099327;
            this.gridControl1.DataSource = this.tblOyuncuBilgiBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1231, 743);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // tblOyuncuBilgiBindingSource
            // 
            this.tblOyuncuBilgiBindingSource.DataMember = "tblOyuncuBilgi";
            this.tblOyuncuBilgiBindingSource.DataSource = this.castAjansVeriTabaniDataSet3;
            // 
            // castAjansVeriTabaniDataSet3
            // 
            this.castAjansVeriTabaniDataSet3.DataSetName = "CastAjansVeriTabaniDataSet3";
            this.castAjansVeriTabaniDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutView1
            // 
            this.layoutView1.Appearance.CardCaption.BackColor = System.Drawing.Color.Silver;
            this.layoutView1.Appearance.CardCaption.BorderColor = System.Drawing.Color.Silver;
            this.layoutView1.Appearance.CardCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.layoutView1.Appearance.CardCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutView1.Appearance.CardCaption.Options.UseBackColor = true;
            this.layoutView1.Appearance.CardCaption.Options.UseBorderColor = true;
            this.layoutView1.Appearance.CardCaption.Options.UseFont = true;
            this.layoutView1.Appearance.CardCaption.Options.UseForeColor = true;
            this.layoutView1.Appearance.FieldCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.layoutView1.Appearance.FieldCaption.BackColor2 = System.Drawing.Color.GhostWhite;
            this.layoutView1.Appearance.FieldCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutView1.Appearance.FieldCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutView1.Appearance.FieldCaption.Options.UseBackColor = true;
            this.layoutView1.Appearance.FieldCaption.Options.UseFont = true;
            this.layoutView1.Appearance.FieldCaption.Options.UseForeColor = true;
            this.layoutView1.Appearance.FieldValue.BackColor = System.Drawing.Color.White;
            this.layoutView1.Appearance.FieldValue.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutView1.Appearance.FieldValue.ForeColor = System.Drawing.Color.Black;
            this.layoutView1.Appearance.FieldValue.Options.UseBackColor = true;
            this.layoutView1.Appearance.FieldValue.Options.UseFont = true;
            this.layoutView1.Appearance.FieldValue.Options.UseForeColor = true;
            this.layoutView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.layoutView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.layoutView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.layoutView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.layoutView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.layoutView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.layoutView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.layoutView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.layoutView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.layoutView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.layoutView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.layoutView1.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.layoutView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.layoutView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.layoutView1.Appearance.FocusedCardCaption.BackColor = System.Drawing.Color.Navy;
            this.layoutView1.Appearance.FocusedCardCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.layoutView1.Appearance.FocusedCardCaption.BorderColor = System.Drawing.Color.Navy;
            this.layoutView1.Appearance.FocusedCardCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutView1.Appearance.FocusedCardCaption.ForeColor = System.Drawing.Color.White;
            this.layoutView1.Appearance.FocusedCardCaption.Options.UseBackColor = true;
            this.layoutView1.Appearance.FocusedCardCaption.Options.UseBorderColor = true;
            this.layoutView1.Appearance.FocusedCardCaption.Options.UseFont = true;
            this.layoutView1.Appearance.FocusedCardCaption.Options.UseForeColor = true;
            this.layoutView1.Appearance.HideSelectionCardCaption.BackColor = System.Drawing.Color.Gray;
            this.layoutView1.Appearance.HideSelectionCardCaption.BorderColor = System.Drawing.Color.Gray;
            this.layoutView1.Appearance.HideSelectionCardCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutView1.Appearance.HideSelectionCardCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.layoutView1.Appearance.HideSelectionCardCaption.Options.UseBackColor = true;
            this.layoutView1.Appearance.HideSelectionCardCaption.Options.UseBorderColor = true;
            this.layoutView1.Appearance.HideSelectionCardCaption.Options.UseFont = true;
            this.layoutView1.Appearance.HideSelectionCardCaption.Options.UseForeColor = true;
            this.layoutView1.Appearance.SelectedCardCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.layoutView1.Appearance.SelectedCardCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutView1.Appearance.SelectedCardCaption.ForeColor = System.Drawing.Color.White;
            this.layoutView1.Appearance.SelectedCardCaption.Options.UseBackColor = true;
            this.layoutView1.Appearance.SelectedCardCaption.Options.UseFont = true;
            this.layoutView1.Appearance.SelectedCardCaption.Options.UseForeColor = true;
            this.layoutView1.Appearance.SeparatorLine.BackColor = System.Drawing.Color.Silver;
            this.layoutView1.Appearance.SeparatorLine.Options.UseBackColor = true;
            this.layoutView1.Appearance.ViewBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.layoutView1.Appearance.ViewBackground.Options.UseBackColor = true;
            this.layoutView1.CardHorzInterval = 7;
            this.layoutView1.CardMinSize = new System.Drawing.Size(336, 220);
            this.layoutView1.CardVertInterval = 5;
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colAd,
            this.colSoyad,
            this.colDogumTarihi,
            this.colFotograf});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.Editable = false;
            this.layoutView1.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.layoutView1.OptionsView.AllowHotTrackFields = false;
            this.layoutView1.OptionsView.ShowCardCaption = false;
            this.layoutView1.OptionsView.ShowCardExpandButton = false;
            this.layoutView1.OptionsView.ShowCardLines = false;
            this.layoutView1.OptionsView.ShowFieldHints = false;
            this.layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.layoutView1.OptionsView.ShowHeaderPanel = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
            this.layoutView1.PaintStyleName = "Office2003";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.LayoutViewField = this.layoutViewField_colAd;
            this.colAd.Name = "colAd";
            // 
            // layoutViewField_colAd
            // 
            this.layoutViewField_colAd.EditorPreferredWidth = 241;
            this.layoutViewField_colAd.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colAd.Name = "layoutViewField_colAd";
            this.layoutViewField_colAd.Size = new System.Drawing.Size(336, 30);
            this.layoutViewField_colAd.TextSize = new System.Drawing.Size(66, 13);
            // 
            // colSoyad
            // 
            this.colSoyad.FieldName = "Soyad";
            this.colSoyad.LayoutViewField = this.layoutViewField_colSoyad;
            this.colSoyad.Name = "colSoyad";
            // 
            // layoutViewField_colSoyad
            // 
            this.layoutViewField_colSoyad.EditorPreferredWidth = 241;
            this.layoutViewField_colSoyad.Location = new System.Drawing.Point(0, 30);
            this.layoutViewField_colSoyad.Name = "layoutViewField_colSoyad";
            this.layoutViewField_colSoyad.Size = new System.Drawing.Size(336, 30);
            this.layoutViewField_colSoyad.TextSize = new System.Drawing.Size(66, 13);
            // 
            // colDogumTarihi
            // 
            this.colDogumTarihi.FieldName = "DogumTarihi";
            this.colDogumTarihi.LayoutViewField = this.layoutViewField_colDogumTarihi;
            this.colDogumTarihi.Name = "colDogumTarihi";
            // 
            // layoutViewField_colDogumTarihi
            // 
            this.layoutViewField_colDogumTarihi.EditorPreferredWidth = 241;
            this.layoutViewField_colDogumTarihi.Location = new System.Drawing.Point(0, 60);
            this.layoutViewField_colDogumTarihi.Name = "layoutViewField_colDogumTarihi";
            this.layoutViewField_colDogumTarihi.Size = new System.Drawing.Size(336, 30);
            this.layoutViewField_colDogumTarihi.TextSize = new System.Drawing.Size(66, 13);
            // 
            // colFotograf
            // 
            this.colFotograf.FieldName = "Fotograf";
            this.colFotograf.LayoutViewField = this.layoutViewField_colFotograf;
            this.colFotograf.Name = "colFotograf";
            // 
            // layoutViewField_colFotograf
            // 
            this.layoutViewField_colFotograf.EditorPreferredWidth = 261;
            this.layoutViewField_colFotograf.Location = new System.Drawing.Point(0, 90);
            this.layoutViewField_colFotograf.Name = "layoutViewField_colFotograf";
            this.layoutViewField_colFotograf.Size = new System.Drawing.Size(336, 130);
            this.layoutViewField_colFotograf.StartNewLine = true;
            this.layoutViewField_colFotograf.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutViewField_colFotograf.TextSize = new System.Drawing.Size(46, 13);
            this.layoutViewField_colFotograf.TextToControlDistance = 5;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.GroupBordersVisible = false;
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colAd,
            this.layoutViewField_colSoyad,
            this.layoutViewField_colDogumTarihi,
            this.layoutViewField_colFotograf});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // castAjansVeriTabaniDataSet2
            // 
            this.castAjansVeriTabaniDataSet2.DataSetName = "CastAjansVeriTabaniDataSet2";
            this.castAjansVeriTabaniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // castAjansVeriTabaniDataSet1
            // 
            this.castAjansVeriTabaniDataSet1.DataSetName = "CastAjansVeriTabaniDataSet1";
            this.castAjansVeriTabaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOyuncuBilgiTableAdapter
            // 
            this.tblOyuncuBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // tblOyuncuBilgiTableAdapter1
            // 
            this.tblOyuncuBilgiTableAdapter1.ClearBeforeFill = true;
            // 
            // tblOyuncuBilgiTableAdapter2
            // 
            this.tblOyuncuBilgiTableAdapter2.ClearBeforeFill = true;
            // 
            // FormResimliListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 743);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.Image = global::KastAjansıOtomasyonu.Properties.Resources.projepng;
            this.Name = "FormResimliListe";
            this.Text = "Resimli Liste";
            this.Load += new System.EventHandler(this.FormResimliListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOyuncuBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.castAjansVeriTabaniDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSoyad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDogumTarihi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFotograf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.castAjansVeriTabaniDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.castAjansVeriTabaniDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private CastAjansVeriTabaniDataSet1 castAjansVeriTabaniDataSet1;
        private CastAjansVeriTabaniDataSet1TableAdapters.tblOyuncuBilgiTableAdapter tblOyuncuBilgiTableAdapter;
        private CastAjansVeriTabaniDataSet2 castAjansVeriTabaniDataSet2;
        private CastAjansVeriTabaniDataSet2TableAdapters.tblOyuncuBilgiTableAdapter tblOyuncuBilgiTableAdapter1;
        private CastAjansVeriTabaniDataSet3 castAjansVeriTabaniDataSet3;
        private System.Windows.Forms.BindingSource tblOyuncuBilgiBindingSource;
        private CastAjansVeriTabaniDataSet3TableAdapters.tblOyuncuBilgiTableAdapter tblOyuncuBilgiTableAdapter2;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colAd;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colSoyad;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colDogumTarihi;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colFotograf;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colAd;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colSoyad;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDogumTarihi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colFotograf;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}