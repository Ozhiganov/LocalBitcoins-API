﻿////////////////////////////////////////////////
// © https://github.com/badhitman
////////////////////////////////////////////////

using System.Runtime.Serialization;

namespace LocalBitcoinsAPI.Classes.lb_Serialize
{
    [DataContract]
    public class AdListItem
    {
        [DataMember]
        public AdSerializationClass data;

        [DataMember]
        public ActionsClass actions;
    }
}