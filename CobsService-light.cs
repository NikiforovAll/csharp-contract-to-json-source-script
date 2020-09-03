using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace DomainBellaNS.API
{

    namespace CobsService
    {
        [DataContract]
        public class CobsDslSubmitOrderRequest
        {

            [DataMember]
            public CobsDslOrderDto order { get; set; }

            public CobsDslSubmitOrderRequest() { }

        }

        [DataContract]
        public class CobsDslOrderDto
        {

            [DataMember]
            public CobsDslHeaderDto header { get; set; }
            /*[DataMember]
            public DataExistingLineDto dataExistingLine { get; set; }
            [DataMember]
            public DslDelieveryAddressDto delieveryAddress { get; set; }
            [DataMember]
            public DslOrderLineDto[] orderLines { get; set; }*/

            public CobsDslOrderDto() { }

        }

        [DataContract]
        public class CobsDslHeaderDto
        {

            //[DataMember]
            //public CobsDslOrderType orderType { get; set; }
            [DataMember]
            public string[] orderStatusEmailList { get; set; }
            [DataMember]
            public string resellerName { get; set; }
            [DataMember]
            public string productTypeCode { get; set; }
            [DataMember]
            public DateTime orderWishDate { get; set; }
            [DataMember]
            public DateTime noChargeCancelDueDate { get; set; }
            [DataMember]
            public string orderNrReseller { get; set; }
            [DataMember]
            public string orderNrBaByXl { get; set; }
            [DataMember]
            public string prodInstNrReserller { get; set; }
            [DataMember]
            public string prodInstNrBaByXl { get; set; }
            [DataMember]
            public string customerCodeIsp { get; set; }
            [DataMember]
            public string password { get; set; }
            [DataMember]
            public string kpnServiceId { get; set; }
            [DataMember]
            public int addNewContractPeriod { get; set; }
            [DataMember]
            public bool newLineEnigeBewoner { get; set; }

            public CobsDslHeaderDto() { }

        }

    }
}
