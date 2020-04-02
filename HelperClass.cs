using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqresAPITests
{
    public class HelperClass
    {
        public RestClient _restClient;
        public RestRequest _restRequest;
        public string _baseUrl = "https://reqres.in/";

        public RestClient SetUrl(string resourceUrl)
        {
            var url = Path.Combine(_baseUrl, resourceUrl);
            var _restClient = new RestClient(url);
            return _restClient;
        }

        public RestRequest CreatePostRequest(string jsonString)
        {
            _restRequest = new RestRequest(Method.POST);
            _restRequest.AddHeader("Accept",  "application/json");
            _restRequest.AddParameter("application/json", jsonString, ParameterType.RequestBody);
            return _restRequest;
        }

        public RestRequest CreateGetRequest(string jsonString)
        {
            _restRequest = new RestRequest("/api/users?page=2", Method.GET);
            _restRequest.AddHeader("Accept", "application/json");
            return _restRequest;
        }

 //       public Users GetUsers()
 //       {
 //           _restRequest = new RestRequest(Method.GET);
 //           _restRequest.AddHeader("Accept", "application/json");
 //           return _restRequest;
 //       }
        public IRestResponse GetResponse(RestClient restClient, RestRequest restRequest)
        {
            return restClient.Execute(restRequest);
        }
    }
}
