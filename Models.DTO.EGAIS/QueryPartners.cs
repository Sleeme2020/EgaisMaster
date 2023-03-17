using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO.EGAIS
{

    public class ReplyPartners
    {



        // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fsrar.ru/WEGAIS/WB_DOC_SINGLE_01")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://fsrar.ru/WEGAIS/WB_DOC_SINGLE_01", IsNullable = false)]
        public partial class Documents
        {

            private DocumentsOwner ownerField;

            private DocumentsDocument documentField;

            /// <remarks/>
            public DocumentsOwner Owner
            {
                get
                {
                    return this.ownerField;
                }
                set
                {
                    this.ownerField = value;
                }
            }

            /// <remarks/>
            public DocumentsDocument Document
            {
                get
                {
                    return this.documentField;
                }
                set
                {
                    this.documentField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fsrar.ru/WEGAIS/WB_DOC_SINGLE_01")]
        public partial class DocumentsOwner
        {

            private uint fSRAR_IDField;

            /// <remarks/>
            public uint FSRAR_ID
            {
                get
                {
                    return this.fSRAR_IDField;
                }
                set
                {
                    this.fSRAR_IDField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fsrar.ru/WEGAIS/WB_DOC_SINGLE_01")]
        public partial class DocumentsDocument
        {

            private DocumentsDocumentReplyClient replyClientField;

            /// <remarks/>
            public DocumentsDocumentReplyClient ReplyClient
            {
                get
                {
                    return this.replyClientField;
                }
                set
                {
                    this.replyClientField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fsrar.ru/WEGAIS/WB_DOC_SINGLE_01")]
        public partial class DocumentsDocumentReplyClient
        {

            private ClientsClient[] clientsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://fsrar.ru/WEGAIS/ReplyClient")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Client", IsNullable = false)]
            public ClientsClient[] Clients
            {
                get
                {
                    return this.clientsField;
                }
                set
                {
                    this.clientsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fsrar.ru/WEGAIS/ReplyClient")]
        public partial class ClientsClient
        {

            private ulong clientRegIdField;

            private ulong iNNField;

            private uint kPPField;

            private string fullNameField;

            private string shortNameField;

            private address addressField;

            private string stateField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fsrar.ru/WEGAIS/ClientRef")]
            public ulong ClientRegId
            {
                get
                {
                    return this.clientRegIdField;
                }
                set
                {
                    this.clientRegIdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fsrar.ru/WEGAIS/ClientRef")]
            public ulong INN
            {
                get
                {
                    return this.iNNField;
                }
                set
                {
                    this.iNNField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fsrar.ru/WEGAIS/ClientRef")]
            public uint KPP
            {
                get
                {
                    return this.kPPField;
                }
                set
                {
                    this.kPPField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fsrar.ru/WEGAIS/ClientRef")]
            public string FullName
            {
                get
                {
                    return this.fullNameField;
                }
                set
                {
                    this.fullNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fsrar.ru/WEGAIS/ClientRef")]
            public string ShortName
            {
                get
                {
                    return this.shortNameField;
                }
                set
                {
                    this.shortNameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fsrar.ru/WEGAIS/ClientRef")]
            public address address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fsrar.ru/WEGAIS/ClientRef")]
            public string State
            {
                get
                {
                    return this.stateField;
                }
                set
                {
                    this.stateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fsrar.ru/WEGAIS/ClientRef")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://fsrar.ru/WEGAIS/ClientRef", IsNullable = false)]
        public partial class address
        {

            private ushort countryField;

            private byte regionCodeField;

            private string descriptionField;

            /// <remarks/>
            public ushort Country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }

            /// <remarks/>
            public byte RegionCode
            {
                get
                {
                    return this.regionCodeField;
                }
                set
                {
                    this.regionCodeField = value;
                }
            }

            /// <remarks/>
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fsrar.ru/WEGAIS/ReplyClient")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://fsrar.ru/WEGAIS/ReplyClient", IsNullable = false)]
        public partial class Clients
        {

            private ClientsClient[] clientField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Client")]
            public ClientsClient[] Client
            {
                get
                {
                    return this.clientField;
                }
                set
                {
                    this.clientField = value;
                }
            }
        }



    }




    public class QueryPartners
    {
        public static string INN { get;  } = "ИНН";
        public static string FSRARID { get; } = "СИО";

        public Documents Value { get; set; }



        // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fsrar.ru/WEGAIS/WB_DOC_SINGLE_01")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://fsrar.ru/WEGAIS/WB_DOC_SINGLE_01", IsNullable = false)]
        public partial class Documents
        {

            private DocumentsOwner ownerField;

            private DocumentsDocument documentField;

            private decimal versionField;

            /// <remarks/>
            public DocumentsOwner Owner
            {
                get
                {
                    return this.ownerField;
                }
                set
                {
                    this.ownerField = value;
                }
            }

            /// <remarks/>
            public DocumentsDocument Document
            {
                get
                {
                    return this.documentField;
                }
                set
                {
                    this.documentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal Version
            {
                get
                {
                    return this.versionField;
                }
                set
                {
                    this.versionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fsrar.ru/WEGAIS/WB_DOC_SINGLE_01")]
        public partial class DocumentsOwner
        {

            private ulong fSRAR_IDField;

            /// <remarks/>
            public ulong FSRAR_ID
            {
                get
                {
                    return this.fSRAR_IDField;
                }
                set
                {
                    this.fSRAR_IDField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fsrar.ru/WEGAIS/WB_DOC_SINGLE_01")]
        public partial class DocumentsDocument
        {

            private DocumentsDocumentQueryClients queryClientsField;

            /// <remarks/>
            public DocumentsDocumentQueryClients QueryClients
            {
                get
                {
                    return this.queryClientsField;
                }
                set
                {
                    this.queryClientsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fsrar.ru/WEGAIS/WB_DOC_SINGLE_01")]
        public partial class DocumentsDocumentQueryClients
        {

            private Parameters parametersField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fsrar.ru/WEGAIS/QueryParameters")]
            public Parameters Parameters
            {
                get
                {
                    return this.parametersField;
                }
                set
                {
                    this.parametersField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fsrar.ru/WEGAIS/QueryParameters")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://fsrar.ru/WEGAIS/QueryParameters", IsNullable = false)]
        public partial class Parameters
        {

            private ParametersParameter parameterField;

            /// <remarks/>
            public ParametersParameter Parameter
            {
                get
                {
                    return this.parameterField;
                }
                set
                {
                    this.parameterField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fsrar.ru/WEGAIS/QueryParameters")]
        public partial class ParametersParameter
        {

            private string nameField;

            private ulong valueField;

            /// <remarks/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            public ulong Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }


    }
}
