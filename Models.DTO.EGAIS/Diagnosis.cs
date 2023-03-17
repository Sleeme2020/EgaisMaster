using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO.EGAIS
{

    public class Diagnosis
    {

        public CERTIFICATE Value { get; set; }


        // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class CERTIFICATE
        {

            private string cField;

            private string stField;

            private string lField;

            private string oField;

            private string ouField;

            private ulong cnField;

            private string eMAILADDRESSField;

            /// <remarks/>
            public string C
            {
                get
                {
                    return this.cField;
                }
                set
                {
                    this.cField = value;
                }
            }

            /// <remarks/>
            public string ST
            {
                get
                {
                    return this.stField;
                }
                set
                {
                    this.stField = value;
                }
            }

            /// <remarks/>
            public string L
            {
                get
                {
                    return this.lField;
                }
                set
                {
                    this.lField = value;
                }
            }

            /// <remarks/>
            public string O
            {
                get
                {
                    return this.oField;
                }
                set
                {
                    this.oField = value;
                }
            }

            /// <remarks/>
            public string OU
            {
                get
                {
                    return this.ouField;
                }
                set
                {
                    this.ouField = value;
                }
            }

            /// <remarks/>
            public ulong CN
            {
                get
                {
                    return this.cnField;
                }
                set
                {
                    this.cnField = value;
                }
            }

            /// <remarks/>
            public string EMAILADDRESS
            {
                get
                {
                    return this.eMAILADDRESSField;
                }
                set
                {
                    this.eMAILADDRESSField = value;
                }
            }
        }



    }
}
