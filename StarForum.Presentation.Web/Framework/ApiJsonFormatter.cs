using System;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace StarForum.Presentation.Web.Framework
{
    public class ApiJsonFormatter : JsonMediaTypeFormatter
    {
        public ApiJsonFormatter()
        {
            this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            this.SerializerSettings.Formatting = Formatting.Indented;
            this.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }

        public override void SetDefaultContentHeaders(Type type, 
                                                      HttpContentHeaders headers, 
                                                      MediaTypeHeaderValue mediaType)
        {
            base.SetDefaultContentHeaders(type, headers, mediaType);
            headers.ContentType = new MediaTypeHeaderValue("application/json");
        }
    }
}