using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class Response<T>
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Response(T data, string? message = null, bool suceeded = true)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            Succeeded = suceeded;
#pragma warning disable CS8601 // Possible null reference assignment.
            Message = message;
#pragma warning restore CS8601 // Possible null reference assignment.
            Data = data;
        }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Response(string? message)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            Succeeded = false;
#pragma warning disable CS8601 // Possible null reference assignment.
            Message = message;
#pragma warning restore CS8601 // Possible null reference assignment.
        }
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }
    }
}
