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
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (axOfficeViewer1.IsOpened)
            {
                //axOfficeViewer1.PrintOut();
                //axOfficeViewer1.ShowDialog(OfficeViewer.ShowDialogType.DialogPrint);
                //axOfficeViewer1.ShowDialog(OfficeViewer.ShowDialogType.DialogPageSetup);
                axOfficeViewer1.ShowDialog(OfficeViewer.ShowDialogType.DialogPrint);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            axOfficeViewer1.Open(@"D:\Projeler\Calismalar\YAGCI_SHIPPING\yagciShip\YAGCI_SHIPPING\bin\gemi.doc");
        }
    }
}
