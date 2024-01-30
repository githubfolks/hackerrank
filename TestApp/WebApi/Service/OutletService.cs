using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using WebApi.Models;

namespace WebApi.Service
{
    public class OutletService : IOutletService
    {
        public ResponseModel Get(string city, int page)
        {
            var endPoint = "https://jsonmock.hackerrank.com/api/food_outlets?city=" + city + "&page=" + page;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(endPoint);
            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "GET";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var strResponse = string.Empty;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                strResponse = streamReader.ReadToEnd();
            }
            if (!string.IsNullOrEmpty(strResponse))
            {
                return JsonConvert.DeserializeObject<ResponseModel>(strResponse);
            }

            return null;
        }
    }
}
