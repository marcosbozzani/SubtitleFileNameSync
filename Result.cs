namespace SubtitleFileNameSync
{
    public class Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public static Result Ok(string message)
        {
            return new Result() { Success = true, Message = message };
        }

        public static Result Failed(string message)
        {
            return new Result() { Success = false, Message = message };
        }
    }
}
