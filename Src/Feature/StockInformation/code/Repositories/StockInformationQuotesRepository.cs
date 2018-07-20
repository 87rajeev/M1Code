using M1CP.Feature.StockInformation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace M1CP.Feature.StockInformation.Repositories
{
    public class StockInformationQuotesRepository : IStockInformationQuotesRepository
    {
        ///</summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static XmlDocument GetXmlDataFromUrl(string url)
        {

            //requesting the particular web page
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            //geting the response from the request url
            var response = (HttpWebResponse)httpRequest.GetResponse();
            //create a stream to hold the contents of the response (in this case it is the contents of the XML file
            var receiveStream = response.GetResponseStream();
            //creating XML document
            var mySourceDoc = new XmlDocument();
            //load the file from the stream
            mySourceDoc.Load(receiveStream);
            //close the stream
            receiveStream.Close();
            return mySourceDoc;
        }

        public Pricefeed GetStockInformationQuotes()
        {
            var url = Constants.URL.APIUrl;
            var xmlcontent = GetXmlDataFromUrl(url);

            var serializer = new XmlSerializer(typeof(Pricefeed));
            var result = (Pricefeed)serializer.Deserialize(new StringReader(xmlcontent.InnerXml));

            return result;
        }
    }
}