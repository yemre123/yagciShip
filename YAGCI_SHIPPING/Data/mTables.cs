using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using System.Xml.Serialization;
using Data;

namespace YAGCI_SHIPPING.Data.Tables
{


     [DeferredDeletion(false), OptimisticLocking(false)]
    public class FORMHAREKET : XPObject
    {

        public string FORM_TURU { get; set; }
        public string FORM_BASLIK { get; set; }
        public string FORM_NAME { get; set; }

        public bool DOLDUMU { get; set; }


        public FORMHAREKET(Session session) : base(session) { }
        public FORMHAREKET() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    [DeferredDeletion(false),OptimisticLocking(false)]
    public class FORMGENERIC : XPObject
    {
        public string FORMNAME { get; set; }
        public int KULLANICIID { get; set; }
        public DateTime TARIH { get; set; }
       
        [Size(4096)]
        public string Values { get; set; }

        public int FIRMAID { get; set; }

        //public int FORMID { get; set; }

        [PersistentAlias("Iif(FORM is null, 0, FORM.USTID)")]
        public int USTFORMID
        {
            get
            {
                try
                {
                    if (!IsLoading)
                        return Convert.ToInt32(EvaluateAlias("USTFORMID"));
                    //if (!IsLoading && fFORMLAR != null)
                    //    return fFORMLAR.Oid;
                }
                catch (ObjectDisposedException) { }
                catch (Exception) { }
                return 0;
            }
            set
            {
            }
        }

        FORMLAR fFORMLAR;
        [XmlIgnore(), Association(@"FORMGENERIC.FORMLAR.FORM"), NoForeignKey, Persistent("FORMID")]
        public FORMLAR FORM
        {
            get { return fFORMLAR; }
            set { SetPropertyValue<FORMLAR>("FORM", ref fFORMLAR, value); }
        }
        
        //[PersistentAlias("Iif(FORM is null, 0, FORM.Oid)")]
        [NonPersistent]
        public int FORMID
        {
            get
            {
                try
                {
                    //if (!IsLoading)
                    //    return Convert.ToInt32(EvaluateAlias("FORMID"));
                    if (!IsLoading && fFORMLAR != null)
                        return fFORMLAR.Oid;
                }
                catch (ObjectDisposedException) { }
                catch (Exception) { }
                return 0;
            }
            set
            {
                SetPropertyValue<FORMLAR>("FORM", ref fFORMLAR, Session.GetObjectByKey<FORMLAR>(value));
            }
        }

        public bool AKTARILDI { get; set; }

        public FORMGENERIC(Session session) : base(session) { }
        public FORMGENERIC() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    [Persistent("TASARIMLAR"), DeferredDeletion(false), OptimisticLocking(false), PersAliasType]
    public class TASARIMLAR : XPObject
    {
        public string REVIZYONNO { get; set; }
        public string FORMADI { get; set; }
        
        public int KULID { get; set; }
        public int MENUID { get; set; }

        [Size(3)]
        public string GEMINO { get; set; }

        public DateTime CDATE { get; set; }
        public bool DURUM { get; set; }
        public byte[] DOSYA { get; set; }


        public TASARIMLAR(Session session) : base(session) { }
        public TASARIMLAR() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    [Persistent("ARSIV"), DeferredDeletion(false), OptimisticLocking(false), PersAliasType]
    public class ARSIV : XPObject
    {
        public int  TASARIMID { get; set; }        
        public int KULID { get; set; }
  
        [Size(3)]
        public string GEMINO { get; set; }

        public DateTime CDATE { get; set; }       
        public byte[] DOSYA { get; set; }


        public ARSIV(Session session) : base(session) { }
        public ARSIV() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}