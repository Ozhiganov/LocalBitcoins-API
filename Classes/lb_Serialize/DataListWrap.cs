////////////////////////////////////////////////
// © https://github.com/badhitman - Telegram @fakegov
////////////////////////////////////////////////
using System.Runtime.Serialization;

namespace LocalBitcoinsAPI.Classes.lb_Serialize
{
    [DataContract]
    public class DataListWrap
    {
        [DataMember]
        public AdListItem[] ad_list;

        [DataMember]
        public int ad_count;
    }
}
