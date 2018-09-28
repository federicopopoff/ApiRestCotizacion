using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceCotizacion
{
    public abstract class StrategyPattern
    {
        public abstract Currency Response(); 
    }
}