using CinemaTicket.EndPoint.API;
using System.Net;

namespace OnlineVoting.EndPoint.Exceptions
{
    public class DontAllowAccessException : ApplicationException
    {
        public DontAllowAccessException() : base(Resource.ApplicationExceptionMessage, HttpStatusCode.Unauthorized, false)
        {
        }
    }
}
