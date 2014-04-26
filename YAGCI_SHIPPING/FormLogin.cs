using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using YAGCI_SHIPPING.Kls;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace YAGCI_SHIPPING.Formlar
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();


            xpColFirms.Session = DB.XP.Crs;
            xpColKul.Session = DB.XP.Crs;
        }

    

     
        private void cmbusercode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPass.Focus();
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGiris_Click(null, null);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            lblMod.Caption = Properties.Settings.Default.ProgramMod > 0 ? "Server Mod" : "Client Mod";

            if (Properties.Settings.Default.ProgramMod < 1)
            {
                cmbGemiler.EditValue = Properties.Settings.Default.FIRMA;
                cmbGemiler.Enabled = false;
            }

            Kullanicilar();
        }

        private void Kullanicilar()
        {
            try
            {
                int by = (int)Properties.Settings.Default.ProgramMod;

                xpColKul.Criteria = CriteriaOperator.Parse(" KULTUR = (?) ", by);

                //xpView1.Reload();
            }
            catch (Exception exc)
            {
                Kls.Dlg.Hata(exc);
            }
        }
  

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (cmbKullanici.EditValue==null)
                return;

            int idx = (int)cmbKullanici.EditValue;
           
            try
            {
                if (cmbGemiler.EditValue == null)
                    throw new Exception(" Gemi adını seçiniz... ");

                
                Data.Tables.KULLANICI kul=
                cmbKullanici.Properties.GetDataSourceRowByKeyValue(cmbKullanici.EditValue) as Data.Tables.KULLANICI;
             
              
                if (kul == null || kul.PWORD!=txtPass.Text)
                    throw new Exception("Bilgiler dogru deil , kontrol ediniz..!");

                Gnl.AktifKullanici = kul;

               
                Data.Tables.FIRMALAR oo = cmbGemiler.Properties.GetDataSourceRowByKeyValue(cmbGemiler.EditValue)
                    as Data.Tables.FIRMALAR;

                Gnl.AktifFirma = oo;

                //if (frm == null)
                //    throw new Exception("Firma seçilmemiş , kontrol ediniz..!");

                //Gnl.AktifFirma = frm;


                DB.XP.DbUpdateSchema();                    

                DialogResult = DialogResult.OK;
            }
            catch (Exception exc)
            {
                Kls.Dlg.Hata(exc);          
            }            
        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
   
        }

        private void lkpFirma_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            //Data.Views.vLOGO_FIRMALAR fr = lkpFirma.GetSelectedDataRow() as Data.Views.vLOGO_FIRMALAR;

            //if (fr == null) return;

           // e.DisplayText = "(" + fr.NR.ToString().PadLeft(3, '0') + ")-(" + fr.DONEM.PadLeft(1, '0') + ")";
        }
    }
}
