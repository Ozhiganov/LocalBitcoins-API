////////////////////////////////////////////////
// © https://github.com/badhitman
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace LocalBitcoinsAPI.Classes.lb_Serialize
{
    [DataContract]
    public class DataPlaces
    {
        [DataMember]
        public int place_count;

        [DataMember]
        public PlaceItem[] places;
    }
}
