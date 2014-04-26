using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using Ionic.Zip;

namespace YAGCI_SHIPPING.Kls
{
    class Gnl
    {
        //test
        static IniFile _ini = null;
        public static IniFile IniData
        {
            get
            {
                if (_ini == null)
                {
                    _ini = new IniFile();
                }
                return _ini;
            }
        }

        static serv.serv _serv = null;
        public static serv.serv Servis
        {
            get
            {
                if (_serv == null)
                {
                    _serv = new serv.serv();
                    if (!string.IsNullOrEmpty(Kls.Gnl.IniData.Read("WebUrl", "")))
                        _serv.Url = Kls.Gnl.IniData.Read("WebUrl", "");
                }
                return _serv;
            }
        }

        static Islemler _isl = null;
        public static Islemler Isl
        {
            get
            {
                if (_isl == null) 
                    _isl = new Islemler();

                return _isl;
            }
        }

        public static object SelectedRow { get; set; }



        public static Data.Tables.KULLANICIGRUPDETAYLARI[] AktifKullaniciYetkileri = null;
        public static Data.Tables.KULLANICI AktifKullanici = null;
        public static Data.Tables.FIRMALAR AktifFirma = null;

        public static DevExpress.LookAndFeel.DefaultLookAndFeel DefLookFeel1 = null;    
        public static DevExpress.XtraBars.Bar TaskBar = null;


        public static byte[] FileZip(string pppth)
        {
            FileInfo fl = new FileInfo(pppth);
            
            if (!fl.Exists)
                throw new Exception("Dosya buluamadı..");

            string p = "";

            using (ZipFile zip = new ZipFile())
            {
                p = fl.FullName.Replace(fl.Name, fl.Name.Replace(fl.Extension, ".zip"));
                zip.AddFile(fl.FullName, @"\");
                zip.Save(p);
            }

            FileInfo zfl = new FileInfo(p);

            if (!zfl.Exists)
                throw new Exception("dosya arşivlenemedi");

            return File.ReadAllBytes(zfl.FullName);
        }


        public static DateTime GetDate {

            get {

                return (DateTime)DB.XP.Crs.ExecuteScalar("select getdate()");
            
            }
        
        }

        public static void Write(string str)
        {
            try
            {
                string modul = (new System.Diagnostics.StackTrace()).GetFrame(1).GetMethod().ToString();
                System.Diagnostics.Trace.WriteLine(DateTime.Now.ToString() + "\t" + str + "\t" + modul);
            }
            catch
            {
                ;
            }
        }

        public static void LogYaz(string STR)
        {
            try
            {

                string Folder = Application.StartupPath + "\\Loglar";

                if (!System.IO.File.Exists(Folder))
                    System.IO.Directory.CreateDirectory(Folder);

                string pth = Folder + "\\" + DateTime.Now.ToString("yyMMdd") + ".log";
                System.IO.StreamWriter sw = new System.IO.StreamWriter(pth, true);
                sw.WriteLine("[" + DateTime.Now.ToString("HH:mm:ss") + "] -> " + STR);
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }

    }

    public enum DockType : byte
    {
        Top = 1,
        Bottom = 2,
        Left = 3,
        Right = 4,
        Fill = 5,
        None = 0
    }

    class Dlg {



        public static void Hata(string ee)
        {           
            DevExpress.XtraEditors.XtraMessageBox.Show(ee, "Dikkat..!", MessageBoxButtons.OK, MessageBoxIcon.Error);        
        }

        public static void Hata(Exception ee)
        {
            //MessageBox.Show(str, "DİKKAT!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            //MesajEkrani(str, MikrobarPC.Util.Mesaj.MesajTip.HATA);
            Gnl.LogYaz(ee.Message + "\r" + ee.StackTrace);
            DevExpress.XtraEditors.XtraMessageBox.Show(ee.Message+"\n"+ee.StackTrace, "Dikkat..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Write(str);
        }

        public static void Bilgi(string str)
        {
            //MessageBox.Show(str, "DİKKAT!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            //MesajEkrani(str, MikrobarPC.Util.Mesaj.MesajTip.BILGI);
            DevExpress.XtraEditors.XtraMessageBox.Show(str, "Bilgi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Write(str);
        }

        public static void Uyari(string str)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(str, "Dikkat..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult Soru(string str)
        {
            return DevExpress.XtraEditors.XtraMessageBox.Show(str, "Soru..!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    
    }
}
