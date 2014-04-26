using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YAGCI_SHIPPING.Formlar
{
    public partial class FormTasarim : Gui.BaseForm
    {
        public FormTasarim()
        {
            InitializeComponent();
        }

        public Formlar.FormAnaEkran FrmAnaEkran { get; set; }

        private void FormTasarim_Load(object sender, EventArgs e)
        {
            axOfficeViewer1.set_EnableFileCommand(OfficeViewer.FileCommandType.FileOpen, false);
            axOfficeViewer1.Toolbars = false;
            axOfficeViewer1.MenuAccelerators = false;
            
            Kill();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (axOfficeViewer1.IsOpened)
            {
                axOfficeViewer1.PrintPreview();
                //axOfficeViewer1.PrintOut();
                //axOfficeViewer1.ShowDialog(OfficeViewer.ShowDialogType.DialogPrint);
                //axOfficeViewer1.ShowDialog(OfficeViewer.ShowDialogType.DialogPageSetup);
                //axOfficeViewer1.ShowDialog(OfficeViewer.ShowDialogType.DialogPrint);
                //OfficeViewer1.EnableFileCommand(FilePrint) = False                
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            axOfficeViewer1.Open(@"D:\Projeler\Calismalar\YAGCI_SHIPPING\yagciShip\YAGCI_SHIPPING\bin\gemi.doc");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            axOfficeViewer1.PrintPreviewExit();
        }

        private void FormTasarim_FormClosing(object sender, FormClosingEventArgs e)
        {
            Kill();
        }

        private static void Kill()
        {
            System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcessesByName("WINWORD.EXE");
            foreach (System.Diagnostics.Process p in proc)
            {
                p.Kill();
            }
        }
    }
}
