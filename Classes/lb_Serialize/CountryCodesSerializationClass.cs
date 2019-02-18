////////////////////////////////////////////////
// © https://github.com/badhitman
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace LocalBitcoinsAPI.Classes.lb_Serialize
{
    [DataContract]
    public class CountryCodesSerializationClass
    {
        [DataMember]
        public DataCountryCodes data;
    }
}
