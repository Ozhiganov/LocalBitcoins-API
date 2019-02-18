////////////////////////////////////////////////
// © https://github.com/badhitman
////////////////////////////////////////////////
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LocalBitcoinsAPI.Classes.lb_Serialize
{
    [DataContract]
    public class OrdersSerializationClass
    {
        [DataMember]
        public List<string[]> bids;

        [DataMember]
        public List<string[]> asks;
    }
}
