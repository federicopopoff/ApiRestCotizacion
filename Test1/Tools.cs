using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace ServiceCotizacion
{
    public class Tools
    {
        public Currency getData(string sUrlRequest)
        {
            var dataBank = new WebClient().DownloadString(sUrlRequest);
            string[] data = dataBank.Split('"');
            Currency Divisa = new Currency(Convert.ToString(data[1]), Convert.ToString(data[3]), Convert.ToString(data[5]));
            return Divisa;
        }

        public bool CompareStrings(string currency, string divisa)
        {
            return divisa.Equals(currency, StringComparison.OrdinalIgnoreCase);
        }
        
    }
}