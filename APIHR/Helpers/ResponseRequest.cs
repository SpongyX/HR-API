namespace APIHR.Helpers
{
    public class ResponseRequest
    {
        public bool Succeeded { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public object Response { get; set; }

        public ResponseRequest(bool Succeeded, string Code, string Message, object Response = null)
        {
            this.Succeeded = Succeeded;
            this.Code = Code;
            this.Message = Message;
            this.Response = Response;
        }

        public ResponseRequest(string code, string message, object response)
        {
            Code = code;
            Message = message;
            Response = response;
        }

        public static ResponseRequest PerformSuccess(object Response = null, string Code = null, string Message = null)
        {
            var result = new ResponseRequest(Code, Message, Response);
            result.Succeeded = true;
            return result;
        }
        public static ResponseRequest PerformError(object Response = null, string Code = null, string Message = null)
        {
            var result = new ResponseRequest(Code, Message, null);
            result.Succeeded = false;
            return result;
        }
    }
}
