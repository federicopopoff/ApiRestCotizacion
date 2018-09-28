using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServiceCotizacion
{
    [DataContract]
    public class Currency
    {
        [DataMember]
        public string PricePurchase { get; set; }
        [DataMember]
        public string PriceSale { get; set; }
        [DataMember]
        public string Update { get; set; }

        public Currency(string pricePurchase, string priceSale, string update)
        {
            this.PricePurchase = pricePurchase;
            this.PriceSale = priceSale;
            this.Update = update;
        }
    }
}