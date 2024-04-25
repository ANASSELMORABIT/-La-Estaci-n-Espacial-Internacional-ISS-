using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    
    {
        int intervalo=10000;
        while (true)

        {

            string url = "http://api.open-notify.org/iss-now";
            HttpClient client = new HttpClient();

            HttpResponseMessage response = client.GetAsync(url).Result;
            string jsonResponse = response.Content.ReadAsStringAsync().Result;

            var ApiObject = JsonConvert.DeserializeObject<Root>(jsonResponse);

            string longitude = ApiObject.iss_position.longitude;
            string latitude = ApiObject.iss_position.latitude;

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Longitude:");
            System.Console.WriteLine(longitude);
            Console.WriteLine("Latitude:");
            System.Console.WriteLine(latitude);
            
            string url2=$"http://api.geonames.org/findNearbyPlaceNameJSON?lat={latitude}&lng={longitude}&username=elmorabit";
            Console.WriteLine("EL URL ES: ");
            Console.WriteLine(url2);

            HttpClient client2 = new HttpClient();

            HttpResponseMessage response2 = client2.GetAsync(url2).Result;
            string jsonResponse2 = response2.Content.ReadAsStringAsync().Result;

            var ApiObject2 = JsonConvert.DeserializeObject<Root2>(jsonResponse2);
            List<Geoname> geonames = ApiObject2.geonames;



            if(geonames.Count >= 1){
                Console.WriteLine("COUNTRY NAME: ");
                Console.WriteLine(ApiObject2.geonames[0].countryName);
            }
            else{
                Console.WriteLine("No se encontraron resultados");
            }
            

            
            Thread.Sleep(intervalo);
            
        }


        
    }

}