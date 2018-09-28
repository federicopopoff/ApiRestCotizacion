using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceCotizacion
{
    public class Context
    {
        public StrategyPattern Strategy { get; set; }

        public Context() { }

        public Currency Response()
        {
            return Strategy.Response();
        } 

    }
}