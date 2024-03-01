namespace CodedByKay.BondBridge.Models.Models.Responses
{
    public class LogResponse
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
        public string ExceptionMessage { get; set; }
        public string StackTrace { get; set; }
    }

}
