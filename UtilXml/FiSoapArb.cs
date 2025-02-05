using OrakYazilimLib.DataContainer;
using System;
using System.IO;
using System.Net;
using System.Xml;

namespace OrakYazilimLib.UtilXml
{
    public static class FiSoapArb
    {
        public static Fdr Execute(string txXmlContent,string txUrl)
        {
            Fdr fdrMain = new Fdr();

            try
            {
                HttpWebRequest request = CreateWebRequest(txUrl);
                XmlDocument soapEnvelopeXml = new XmlDocument();
                soapEnvelopeXml.LoadXml(txXmlContent); //AddNamespace(txXmlContent) //txXmlContent

                using (Stream stream = request.GetRequestStream())
                {
                    soapEnvelopeXml.Save(stream);
                }

                //request.Method = "GET";
                using (HttpWebResponse response = (HttpWebResponse) request.GetResponse())
                {

                    using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                    {
                        string soapResult = rd.ReadToEnd();
                        fdrMain.txMessage = soapResult;
                        Console.WriteLine(soapResult);

                        int statusCode = (int)response.StatusCode;
                        fdrMain.lnStatusCode = statusCode;
                        fdrMain.boResult = true;
                        Console.WriteLine($"HTTP Durum Kodu: {statusCode}");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                fdrMain.txMessage = ex.Message;
                fdrMain.boResult = false;
            }

            return fdrMain;
        }

        private static HttpWebRequest CreateWebRequest(string url)
        {
            //string url = "";
            HttpWebRequest webRequest = null;

            try
            {
                webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Headers.Add(@"SOAPAction","LoginRequest");
                webRequest.ContentType = "text/xml;charset=\"utf-8\"";
                webRequest.Accept = "text/xml";
                webRequest.Method = "POST";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return webRequest;
        }

        private static string AddNamespace(string XML)
        {
            string result = string.Empty;
            try
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(XML);

                XmlElement temproot = xdoc.CreateElement("ws", "Request", "http://example.com/");
                temproot.InnerXml = xdoc.DocumentElement.InnerXml;
                result = temproot.OuterXml;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }

        private static string AppendEnvelope(string data)
        {
            string txHead = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" ><soapenv:Header/><soapenv:Body>";
            string txEnd = @"</soapenv:Body></soapenv:Envelope>";
            return txHead + data + txEnd;
        }
    }

}