    public class AdminCodes1
    {
        public string ISO3166_2 { get; set; }
    }

    public class Geoname
    {
        public string adminCode1 { get; set; }
        public string lng { get; set; }
        public string distance { get; set; }
        public int geonameId { get; set; }
        public string toponymName { get; set; }
        public string countryId { get; set; }
        public string fcl { get; set; }
        public int population { get; set; }
        public string countryCode { get; set; }
        public string name { get; set; }
        public string fclName { get; set; }
        public AdminCodes1 adminCodes1 { get; set; }
        public string countryName { get; set; }
        public string fcodeName { get; set; }
        public string adminName1 { get; set; }
        public string lat { get; set; }
        public string fcode { get; set; }
    }

    public class Root2
    {
        public List<Geoname> geonames { get; set; }
    }