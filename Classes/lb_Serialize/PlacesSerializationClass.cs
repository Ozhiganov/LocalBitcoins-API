////////////////////////////////////////////////
// © https://github.com/badhitman - Telegram @fakegov
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
