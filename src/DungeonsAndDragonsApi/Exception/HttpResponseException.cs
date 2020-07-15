using System;
using System.Runtime.Serialization;

namespace DungeonsAndDragonsApi.Exception
{
    [Serializable]
    public class HttpResponseException : System.Exception
    {
        public int Status { get; set; } = 500;

        public object Value { get; set; }

        public HttpResponseException()
        {
        }

        public HttpResponseException(string message) : base(message)
        {
        }

        public HttpResponseException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected HttpResponseException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
            Status = serializationInfo.GetInt32("Status");
            Value = serializationInfo.GetValue("Value", typeof(object));
        }
    }
}
