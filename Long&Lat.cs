public class IssPosition
    {
        public string longitude { get; set; }
        public string latitude { get; set; }
    }

    public class Root
    {
        public IssPosition iss_position { get; set; }
        public string message { get; set; }
        public int timestamp { get; set; }
    }