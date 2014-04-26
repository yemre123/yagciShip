using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace YAGCI_SHIPPING.Kls
{
    class Islemler
    {
        public string BuyutTemizle(string STR)
        {
            return STR
                .Replace(",", "")
                .Replace("'", "")
                .ToUpper().Trim();
        }


        public static object CloneObj(object src, object trgt)
        {
            if (src == null || trgt == null) return trgt;

            PropertyInfo[] src_ps = src.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            PropertyInfo[] trgt_ps = trgt.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo srcp in src_ps)
            {
                PropertyInfo trg = trgt_ps.Where(x => x.Name == srcp.Name).First();

                if (!trg.CanWrite) continue;
                trg.SetValue(trgt, srcp.GetValue(src, null), null);
            }

            return trgt;
        }


        public static int TasarimEkle(string Path, string FormName)
        {
            int xRevNo = 0;

            var snc = new XPCollection<Data.Tables.TASARIMLAR>
            (DB.XP.Crs,
             CriteriaOperator.Parse(" FORMADI = (?) ", FormName));

            if (snc.Count() > 0)
                xRevNo = snc.First().REVIZYONNO;

            xRevNo = xRevNo + 1;

            Data.Tables.TASARIMLAR ts = new Data.Tables.TASARIMLAR(DB.XP.Crs);
            ts.FORMADI = FormName;
            ts.GEMINO = Gnl.AktifFirma.FRMCODE;
            ts.DURUM = true;
            ts.DOSYA = Gnl.FileZip(Path);
            ts.CDATE = Gnl.GetDate;
            ts.KULID = Gnl.AktifKullanici.Oid;
            ts.REVIZYONNO = xRevNo;
            ts.Save();

            var snc1 = new XPCollection<Data.Tables.TASARIMLAR>
                 (DB.XP.Crs,
                  CriteriaOperator.Parse(" FORMADI = (?) AND Oid != (?) ", FormName, ts.Oid));

            foreach (Data.Tables.TASARIMLAR dbt in snc1)
            {
                dbt.DURUM = false;
                dbt.Save();
            }

            return ts.REVIZYONNO;
        }

    }

    public enum Hareketler
    {
        MalKabul = 1,
        Yukleme = 2,
        Satis = 3,
    }

    
}
