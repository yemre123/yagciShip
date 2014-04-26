namespace YAGCI_SHIPPING.Formlar
{
    partial class FormTasarim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTasarim));
            this.axOfficeViewer1 = new AxOfficeViewer.AxOfficeViewer();
            this.timerFormAc = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtRevizyon = new DevExpress.XtraEditors.TextEdit();
            this.editFormAdi = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnDisari = new DevExpress.XtraEditors.SimpleButton();
            this.btnYazdir = new DevExpress.XtraEditors.SimpleButton();
            this.btnIceri = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.axOfficeViewer1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRevizyon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editFormAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // axOfficeViewer1
            // 
            this.axOfficeViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axOfficeViewer1.Enabled = true;
            this.axOfficeViewer1.Location = new System.Drawing.Point(0, 27);
            this.axOfficeViewer1.Name = "axOfficeViewer1";
            this.axOfficeViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOfficeViewer1.OcxState")));
            this.axOfficeViewer1.Size = new System.Drawing.Size(912, 442);
            this.axOfficeViewer1.TabIndex = 1;
            // 
            // timerFormAc
            // 
            this.timerFormAc.Interval = 500;
            this.timerFormAc.Tick += new System.EventHandler(this.timerFormAc_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.txtRevizyon);
            this.panel1.Controls.Add(this.editFormAdi);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.btnDisari);
            this.panel1.Controls.Add(this.btnYazdir);
            this.panel1.Controls.Add(this.btnIceri);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 27);
            this.panel1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(634, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Revizyon No";
            // 
            // txtRevizyon
            // 
            this.txtRevizyon.Location = new System.Drawing.Point(700, 3);
            this.txtRevizyon.Name = "txtRevizyon";
            this.txtRevizyon.Size = new System.Drawing.Size(100, 20);
            this.txtRevizyon.TabIndex = 4;
            // 
            // editFormAdi
            // 
            this.editFormAdi.Location = new System.Drawing.Point(445, 3);
            this.editFormAdi.Name = "editFormAdi";
            this.editFormAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.editFormAdi.Size = new System.Drawing.Size(183, 20);
            this.editFormAdi.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(397, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Form Adi";
            // 
            // btnDisari
            // 
            this.btnDisari.Image = global::YAGCI_SHIPPING.Properties.Resources._1381684275_agt_update_misc;
            this.btnDisari.Location = new System.Drawing.Point(268, 2);
            this.btnDisari.Name = "btnDisari";
            this.btnDisari.Size = new System.Drawing.Size(94, 21);
            this.btnDisari.TabIndex = 0;
            this.btnDisari.Text = "Dışarı";
            this.btnDisari.Click += new System.EventHandler(this.btnDisari_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Image = global::YAGCI_SHIPPING.Properties.Resources._1382801332_print;
            this.btnYazdir.Location = new System.Drawing.Point(88, 2);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(94, 21);
            this.btnYazdir.TabIndex = 0;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnIceri
            // 
            this.btnIceri.Image = global::YAGCI_SHIPPING.Properties.Resources._1370996736_plus_32;
            this.btnIceri.Location = new System.Drawing.Point(183, 2);
            this.btnIceri.Name = "btnIceri";
            this.btnIceri.Size = new System.Drawing.Size(84, 21);
            this.btnIceri.TabIndex = 0;
            this.btnIceri.Text = "İçeri";
            this.btnIceri.Click += new System.EventHandler(this.btnIceri_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::YAGCI_SHIPPING.Properties.Resources._1370991738_3floppy_unmount;
            this.btnKaydet.Location = new System.Drawing.Point(3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(84, 21);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            // 
            // FormTasarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 469);
            this.Controls.Add(this.axOfficeViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "FormTasarim";
            this.Text = "FormTasarim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTasarim_FormClosing);
            this.Load += new System.EventHandler(this.FormTasarim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axOfficeViewer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRevizyon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editFormAdi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxOfficeViewer.AxOfficeViewer axOfficeViewer1;
        private System.Windows.Forms.Timer timerFormAc;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnYazdir;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit editFormAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtRevizyon;
        private DevExpress.XtraEditors.SimpleButton btnDisari;
        private DevExpress.XtraEditors.SimpleButton btnIceri;
    }
}

/*
 //Remove Office Viewer Component Title Bar and create a new Word document
     axOfficeViewer1.Titlebar = false;
     axOfficeViewer1.CreateNew(“Word.Document”);
     axOfficeViewer1.Activate();
     //Invoke Word properties
     oDoc = (Word.Document)axOfficeViewer1.ActiveDocument;
     oDoc.ActiveWindow.View.Type = Word.WdViewType.wdOutlineView;
     oDoc.ActiveWindow.DisplayRulers = false;
     oDoc.ActiveWindow.DisplayScreenTips = false;
     oDoc.ActiveWindow.DisplayHorizontalScrollBar = false;
     oDoc.ActiveWindow.DisplayVerticalRuler = false;
     oDoc.ActiveWindow.DisplayVerticalScrollBar = true;
 */