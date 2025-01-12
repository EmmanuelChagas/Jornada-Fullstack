using System.Text.Json.Serialization;

namespace Fina.Core.Responses
{
    public class Response<TData>
    {
        //Http status code
        private int _code = Configuration.defaultStatusCode;
        
        [JsonConstructor]
        public Response()
            => _code = Configuration.defaultStatusCode;
        

        public Response(
            TData? data,
            int code = Configuration.defaultStatusCode,
            string? message = null)
            {
                Data = data;
                _code = code;
                Message = message;
            }        

        public TData? Data { get; set; }

        public string? Message { get; set; }

        [JsonIgnore]
        public bool IsSuccess => _code is >= 200 and <= 299;
    }
}