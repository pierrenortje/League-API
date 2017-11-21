using RestSharp;
using System.Net;
using System.Threading.Tasks;

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

        #region Protected Methods
        protected async Task<TResponseType> ExecuteGet<TResponseType>(IRestRequest request, bool customDeserialize = false)
        {
            request.AddHeader("X-Riot-Token", this.apiKey);

            var response = await restClient.ExecuteTaskAsync<TResponseType>(request);

            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;

            if (customDeserialize)
                return Newtonsoft.Json.JsonConvert.DeserializeObject<TResponseType>(response.Content);
            return response.Data;
        }
        #endregion
    }
}
