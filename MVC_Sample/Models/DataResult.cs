using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace MVC_Sample.Models
{
    public class DataResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }

    public class DataResult<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Status { get; set; }
        public T Body { get; set; }
        public string Message { get; set; }
    }
}