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
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axOfficeViewer1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // axOfficeViewer1
            // 
            this.axOfficeViewer1.Enabled = true;
            this.axOfficeViewer1.Location = new System.Drawing.Point(222, 203);
            this.axOfficeViewer1.Name = "axOfficeViewer1";
            this.axOfficeViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOfficeViewer1.OcxState")));
            this.axOfficeViewer1.Size = new System.Drawing.Size(690, 266);
            this.axOfficeViewer1.TabIndex = 1;
            // 
            // timerFormAc
            // 
            this.timerFormAc.Interval = 500;
            this.timerFormAc.Tick += new System.EventHandler(this.timerFormAc_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.lookUpEdit1);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 29);
            this.panel1.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::YAGCI_SHIPPING.Properties.Resources._1382801332_print;
            this.simpleButton2.Location = new System.Drawing.Point(93, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(89, 31);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Yazdır";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::YAGCI_SHIPPING.Properties.Resources._1370991738_3floppy_unmount;
            this.simpleButton1.Location = new System.Drawing.Point(3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(89, 31);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Kaydet";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(262, 3);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DataSource = this.xpCollection1;
            this.lookUpEdit1.Properties.DisplayMember = "ADI";
            this.lookUpEdit1.Properties.ValueMember = "Oid";
            this.lookUpEdit1.Size = new System.Drawing.Size(154, 20);
            this.lookUpEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(193, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Form Adi";
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(YAGCI_SHIPPING.Data.Tables.KULLANICI);
            // 
            // FormTasarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axOfficeViewer1);
            this.Name = "FormTasarim";
            this.Text = "FormTasarim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTasarim_FormClosing);
            this.Load += new System.EventHandler(this.FormTasarim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axOfficeViewer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxOfficeViewer.AxOfficeViewer axOfficeViewer1;
        private System.Windows.Forms.Timer timerFormAc;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.Xpo.XPCollection xpCollection1;
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