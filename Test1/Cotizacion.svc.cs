using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.Net;
using System.Windows.Forms;
using System.Resources;
using System.IO;

namespace ServiceCotizacion
{
    public class Cotizacion : ICotizacion
    {
        public Currency getInformationWeb(string typeCurrency)
        {
            Tools _tool = new Tools();
            if (_tool.CompareStrings(typeCurrency, "dolar"))
            {
                Context _context = new Context();
                _context.Strategy = new StrategyDolar();
                return _context.Response(); 
            }
            else 
            {
                if (_tool.CompareStrings(typeCurrency, "real"))
                {
                    Context _context = new Context();
                    _context.Strategy = new StrategyReal();
                    return _context.Response();
                }
                else
                {
                    if (_tool.CompareStrings(typeCurrency, "pesos"))
                    {
                        Context _context = new Context();
                        _context.Strategy = new StrategyPesos();
                        return _context.Response();
                    }
                    else
                    {
                        throw new WebFaultException(System.Net.HttpStatusCode.NotFound);
                    }
                }
            }
        }
    }
}
