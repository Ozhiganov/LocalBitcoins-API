////////////////////////////////////////////////
// © https://github.com/badhitman
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace LocalBitcoinsAPI.Classes.lb_Serialize
{
    [DataContract]
    public class RatesClass
    {
        [DataMember]
        public string last;
    }
}
