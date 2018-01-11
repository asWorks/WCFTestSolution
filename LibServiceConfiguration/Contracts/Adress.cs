using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace LibServiceConfiguration.Contracts
{
    [DataContract]
   public sealed class Adress
    {

        //public Adress()
        //{


        //}

        [DataMember]
        public string Street
        {
            get; set;
        }
        [DataMember]
        public string StreetNumber
        {
            get; set;
        }
        [DataMember]
        public string PostalCode
        {
            get; set;
        }
        [DataMember]
        public string City
        {
            get; set;
        }


    }
}
