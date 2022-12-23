using System;
using System.Net.Http;
using System.Runtime.Serialization;

namespace meal_service.Controllers
{
    [Serializable]
    internal class HttpResponseException : Exception
    {
        private HttpResponseMessage resp;

        public HttpResponseException(System.Net.HttpStatusCode notFound)
        {
        }

        public HttpResponseException(HttpResponseMessage resp)
        {
            this.resp = resp;
        }

        public HttpResponseException(string message) : base(message)
        {
        }

        public HttpResponseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected HttpResponseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}