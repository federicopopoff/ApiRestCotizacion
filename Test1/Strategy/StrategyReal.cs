using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace ServiceCotizacion
{
    public class StrategyReal : StrategyPattern
    {
        public override Currency Response()
        {
            throw new WebFaultException(System.Net.HttpStatusCode.Unauthorized);
        }
    }
}