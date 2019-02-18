////////////////////////////////////////////////
// © https://github.com/badhitman
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace LocalBitcoinsAPI.Classes.lb_Serialize
{
    [DataContract]
    public class PlacesSerializationClass
    {
        [DataMember]
        public DataPlaces data;
    }
}
