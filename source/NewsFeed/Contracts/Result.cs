namespace NewsFeed.Contracts
{
    public class Result
    {
        public int Code { get; set; }
        public string Description { get; set; }

        public Result(int code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}
