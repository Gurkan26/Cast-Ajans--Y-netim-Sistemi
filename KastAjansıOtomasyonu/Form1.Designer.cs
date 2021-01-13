namespace KastAjansıOtomasyonu
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.toolbarFormControl1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormControl();
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.lblForgotPassword = new DevExpress.XtraEditors.LabelControl();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkEdit1
            // 
            resources.ApplyResources(this.checkEdit1, "checkEdit1");
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = resources.GetString("checkEdit1.Properties.Caption");
            // 
            // textEdit1
            // 
            resources.ApplyResources(this.textEdit1, "textEdit1");
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.textEdit1.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("textEdit1.Properties.Appearance.Font")));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit1.Properties.NullValuePrompt = resources.GetString("textEdit1.Properties.NullValuePrompt");
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            this.textEdit1.Enter += new System.EventHandler(this.textEdit1_Enter);
            this.textEdit1.Leave += new System.EventHandler(this.textEdit1_Leave);
            // 
            // toolbarFormControl1
            // 
            resources.ApplyResources(this.toolbarFormControl1, "toolbarFormControl1");
            this.toolbarFormControl1.Manager = this.toolbarFormManager1;
            this.toolbarFormControl1.Name = "toolbarFormControl1";
            this.toolbarFormControl1.TabStop = false;
            this.toolbarFormControl1.ToolbarForm = this;
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textEdit2
            // 
            resources.ApplyResources(this.textEdit2, "textEdit2");
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("textEdit2.Properties.Appearance.Font")));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEdit2.Properties.NullValuePrompt = resources.GetString("textEdit2.Properties.NullValuePrompt");
            this.textEdit2.Properties.UseSystemPasswordChar = true;
            // 
            // lblForgotPassword
            // 
            resources.ApplyResources(this.lblForgotPassword, "lblForgotPassword");
            this.lblForgotPassword.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            this.lblForgotPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelControl1_MouseClick);
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.BackColor = System.Drawing.Color.LawnGreen;
            this.btnGiris.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnGiris.Appearance.Font")));
            this.btnGiris.Appearance.Options.UseBackColor = true;
            this.btnGiris.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnGiris, "btnGiris");
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.toolbarFormControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Login.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ToolbarFormControl = this.toolbarFormControl1;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormControl toolbarFormControl1;
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl lblForgotPassword;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}

