namespace OnlineVoting.EndPoint.Filters
{
    public class MyResponse
    {
        public MyResponse(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}
