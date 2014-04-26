using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            axOfficeViewer1.Menubar = false;
            axOfficeViewer1.MenuAccelerators = false;
            Kill();
            timerFormAc.Start();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (axOfficeViewer1.IsOpened)
            {
                axOfficeViewer1.PrintOut();
                //axOfficeViewer1.PrintPreview();
                //axOfficeViewer1.ShowDialog(OfficeViewer.ShowDialogType.DialogPrint);
                //axOfficeViewer1.ShowDialog(OfficeViewer.ShowDialogType.DialogPageSetup);
                //axOfficeViewer1.ShowDialog(OfficeViewer.ShowDialogType.DialogPrint);
                //OfficeViewer1.EnableFileCommand(FilePrint) = False                
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (axOfficeViewer1.IsOpened)
            {
                if (!axOfficeViewer1.IsDirty)
                {
                    if (Kls.Dlg.Soru("Bilgi girilmedi yinede kaydedilsin mi?") == System.Windows.Forms.DialogResult.No)
                        return;
                }

            }
        }

        private void FormTasarim_FormClosing(object sender, FormClosingEventArgs e)
        {
            //object SalakObje = System.Reflection.Missing.Value;
            //axOfficeViewer1.Close();
            //((Microsoft.Office.Interop.Word.ApplicationClass)axOfficeViewer1.Application).Quit();
            Kill();
        }

        private static void Kill()
        {
            try
            {
                System.Diagnostics.Process[] proc = System.Diagnostics.Process.GetProcesses();
                foreach (System.Diagnostics.Process p in proc)
                {
                    System.Diagnostics.Trace.WriteLine(p.ProcessName);
                    if (p.ProcessName.Equals("WINWORD"))
                        p.Kill();
                }
            }
            catch
            {
            }
        }

        private void timerFormAc_Tick(object sender, EventArgs e)
        {
            try
            {
                timerFormAc.Enabled = false;
                FileStream fout = new FileStream(Application.StartupPath + "\\gemi.doc", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fout);
                bw.Write(Properties.Resources.bos);
                bw.Flush();
                bw.Close();
                axOfficeViewer1.Open(Application.StartupPath + "\\gemi.doc");

                Microsoft.Office.Interop.Word.DocumentClass doc = axOfficeViewer1.ActiveDocument as Microsoft.Office.Interop.Word.DocumentClass;
                if (doc != null)
                {
                    foreach (Microsoft.Office.Interop.Word.Paragraph p in doc.Paragraphs)
                    {
                        System.Diagnostics.Trace.WriteLine(p.ToString());
                        if (p.Range != null)
                        {
                            System.Diagnostics.Trace.WriteLine(p.Range.Text.ToString());
                        }
                    }

                    if (doc.Paragraphs.Count > 1)
                        doc.Paragraphs[2].Range.Text = "KL Form No:00-Rev 0"; // index 0 dan baslamiyor 1 den basliyor
                    
                    System.Diagnostics.Trace.WriteLine(axOfficeViewer1.Application.GetType().ToString());
                    
                    doc.Content.InsertAfter("deneme");
                }
                
                //Microsoft.Office.Interop.Word.DocumentClass

                //axOfficeViewer1.CreateNew("Word.Document");
                //OfficeViewer1. CreateNew "Excel.Sheet" 

            }
            catch (Exception exc)
            {
                Kls.Dlg.Hata(exc.Message);
            }
        }

        private void btnDisari_Click(object sender, EventArgs e)
        {
            if (axOfficeViewer1.IsOpened)
            {
                axOfficeViewer1.ShowDialog(OfficeViewer.ShowDialogType.DialogSaveCopy);
            }
        }

        private void btnIceri_Click(object sender, EventArgs e)
        {
            axOfficeViewer1.ShowDialog(OfficeViewer.ShowDialogType.DialogOpen);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (axOfficeViewer1.IsOpened)
                axOfficeViewer1.ShowDialog(OfficeViewer.ShowDialogType.DialogPrint);
        }

    }
}
