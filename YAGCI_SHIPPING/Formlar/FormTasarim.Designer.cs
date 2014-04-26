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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTasarim));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.axOfficeViewer1 = new AxOfficeViewer.AxOfficeViewer();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axOfficeViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(912, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::YAGCI_SHIPPING.Properties.Resources._1322486893_preferences_desktop_color;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // axOfficeViewer1
            // 
            this.axOfficeViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axOfficeViewer1.Enabled = true;
            this.axOfficeViewer1.Location = new System.Drawing.Point(0, 25);
            this.axOfficeViewer1.Name = "axOfficeViewer1";
            this.axOfficeViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOfficeViewer1.OcxState")));
            this.axOfficeViewer1.Size = new System.Drawing.Size(912, 444);
            this.axOfficeViewer1.TabIndex = 1;
            // 
            // FormTasarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 469);
            this.Controls.Add(this.axOfficeViewer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormTasarim";
            this.Text = "FormTasarim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTasarim_FormClosing);
            this.Load += new System.EventHandler(this.FormTasarim_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axOfficeViewer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private AxOfficeViewer.AxOfficeViewer axOfficeViewer1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
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