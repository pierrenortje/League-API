using RestSharp;
using System.Net;

namespace League.of.Legends.API.Requests
{
    public class RequestBase
    {
        #region Protected Fields
        protected readonly IRestClient restClient;
        protected readonly string apiKey;
        #endregion

        #region Constructor
        public RequestBase(IRestClient restClient, string apiKey)
        {
            this.restClient = restClient;
            this.apiKey = apiKey;
        }
        #endregion

        #region Public Properties
        public HttpStatusCode StatusCode { get; set; }
        public string StatusDescription { get; set; }
        #endregion
    }
}
