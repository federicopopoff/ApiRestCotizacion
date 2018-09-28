using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceCotizacion
{
    public class StrategyDolar : StrategyPattern
    {
        public override Currency Response()
        {
            Tools _tool = new Tools();
            return _tool.getData("https://www.bancoprovincia.com.ar/Principal/Dolar");
        }
    }
}