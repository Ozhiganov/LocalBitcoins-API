////////////////////////////////////////////////
// © https://github.com/badhitman - @fakegov
////////////////////////////////////////////////

using System;
using System.Runtime.Serialization;

namespace LocalBitcoinsAPI.Classes.lb_Serialize
{
    [DataContract]
    public class AdSerializationClass
    {
        [DataMember]
        public UserProfileSerializationClass profile;

        [DataMember]
        public int require_feedback_score;

        [DataMember]
        public bool hidden_by_opening_hours;

        [DataMember]
        public string trade_type;

        [DataMember]
        public int ad_id;

        [DataMember]
        public string temp_price;

        [DataMember]
        public string bank_name;

        [DataMember]
        public int payment_window_minutes;

        [DataMember]
        public bool trusted_required;

        [DataMember]
        public string min_amount;

        [DataMember]
        public bool visible;

        [DataMember]
        public bool require_trusted_by_advertiser;

        [DataMember]
        public string temp_price_usd;

        [DataMember]
        public string lat;

        [DataMember]
        public string lon;

        [DataMember]
        public string age_days_coefficient_limit;

        [DataMember]
        public bool is_local_office;

        [DataMember]
        public string first_time_limit_btc;

        [DataMember]
        public string atm_model;

        [DataMember]
        public string city;

        [DataMember]
        public string location_string;
        
        [DataMember]
        public string countrycode;

        [DataMember]
        public string currency;

        [DataMember]
        public string limit_to_fiat_amounts;

        [DataMember]
        public string created_at;

        [DataMember]
        public string max_amount;

        [DataMember]
        public bool is_low_risk;

        [DataMember]
        public bool sms_verification_required;

        [DataMember]
        public double require_trade_volume;

        [DataMember]
        public string online_provider;

        [DataMember]
        public string max_amount_available;

        [DataMember]
        public string msg;

        [DataMember]
        public bool require_identification;

        [DataMember]
        public string email;

        [DataMember]
        public string volume_coefficient_btc;

        public double get_min_amount_as_double()
        {
            return Convert.ToDouble(min_amount);
        }

        public double get_max_amount_as_double()
        {
            return Convert.ToDouble(max_amount);
        }
    }
}
