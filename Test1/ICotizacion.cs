using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceCotizacion
{
    [ServiceContract]
    public interface ICotizacion
    {
        //Cotizacion moneda
        [OperationContract]
        [WebInvoke(Method="GET",UriTemplate="/{tipoMoneda}/",BodyStyle=WebMessageBodyStyle.Bare,ResponseFormat=WebMessageFormat.Xml)]
        Currency getInformationWeb(string tipoMoneda);

        //[OperationContract]
        //[WebInvoke(Method = "GET", UriTemplate = "/test/{tipoMoneda}/{variabilidad}", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Xml)]
        //Currency getInformationWebTest(string tipoMoneda, string variabilidad);
    }
}
