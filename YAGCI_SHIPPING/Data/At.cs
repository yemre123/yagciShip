using System;
using System.EnterpriseServices;

namespace Data
{

    [AttributeUsage(AttributeTargets.All)]
    public class PersAliasType : System.Attribute
    {
        public PersAliasType() { }
        public PersAliasType(bool autoGenerate) { }

         
        public bool AutoGenerate { get; set; }

    }

    [AttributeUsage(AttributeTargets.All)]
    public class Capt : System.Attribute
    {
        public readonly string Txt;

        public string Str               // Topic is a named parameter
        {
            get
            {
                return str;
            }
            set
            {

                str = value;
            }
        }

        public Capt(string xstr)  // url is a positional parameter
        {
            this.Txt = xstr;
        }

        private string str;
    }
}