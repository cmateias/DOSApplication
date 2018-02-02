using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;

namespace DOSApplication.Controllers.Api
{
    public class DistanceCalculator : ApiController
    {

        private string _key = WebConfigurationManager.AppSettings["MatrixKey"];

        // POST api/<controller>
        public Dtl.DistanceMatrix Calculate(Models.DistanceRequest request)
        {
            try
            {
                using (var objClient = new WebClient())
                {
                    var objReturn = new Dtl.DistanceMatrix();
                    var strUrl = string.Format("https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins={0}&destinations={1}&mode={2}&key={3}", HttpUtility.UrlEncode(request.Origin), HttpUtility.UrlEncode(request.Destination), HttpUtility.UrlEncode(request.Mode), _key);
                    var result = objClient.DownloadString(strUrl);
                    objReturn = JsonConvert.DeserializeObject<Dtl.DistanceMatrix>(result);

                    return objReturn;
                }
            }
            catch (Exception)
            {
                return null;
            }


        }
       
    }
}