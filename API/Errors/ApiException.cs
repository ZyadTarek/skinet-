using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiException : ApiResponse
    {
        public string Details { get; set; }
        // public string Message { get; set; }
        // public int StatusCode { get; set; }

        public ApiException(int statusCode, string message = null, string details = null)
        : base(statusCode,message)
        {
            Details = details;
            // Message = message;
            // StatusCode = statusCode;
        }

    }
}