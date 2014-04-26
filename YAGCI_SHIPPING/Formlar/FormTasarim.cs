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
    public partial class FormTasarim : Form
    {
        public FormTasarim()
        {
            InitializeComponent();
        }

        private void FormTasarim_Load(object sender, EventArgs e)
        {
            axOfficeViewer1.Open(@"D:\Projeler\Calismalar\YAGCI_SHIPPING\yagciShip\YAGCI_SHIPPING\bin\Kitap1.xls");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            axOfficeViewer1.PrintPreview();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            axOfficeViewer1.Save();
        }
    }
}
