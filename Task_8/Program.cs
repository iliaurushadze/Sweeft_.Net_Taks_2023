using Newtonsoft.Json.Linq;
using System.Diagnostics.Metrics;

namespace Task_8
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Country files will be created at  - 'Project_name'\bin\Debug\net6.0\Countries

            string apiUrl = "https://restcountries.com/v3.1/all";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Send a GET request to the API
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Parse the JSON response
                        JArray countriesArray = JArray.Parse(responseBody);
                        var countryObj = new Country();

                        foreach (JObject country in countriesArray)
                        {
                            countryObj.Name = country["name"]["common"].ToString();
                            countryObj.Region = country["region"].ToString();
                            countryObj.Subregion = (country["subregion"] != null)
                                ? country["subregion"].ToString() : " ";
                            countryObj.LatlngArray = country["latlng"].ToObject<JArray>();
                            countryObj.Latitude = countryObj.LatlngArray[0].ToObject<double>();
                            countryObj.Longitude = countryObj.LatlngArray[1].ToObject<double>();
                            countryObj.Area = country["area"].ToObject<double>();
                            countryObj.Population = country["population"].ToObject<long>();

                            // Create a text document for the country
                            string fileName = $"Countries\\{countryObj.Name}.txt";

                            string documentContent = $"Region: {countryObj.Region}\nSubregion: {countryObj.Subregion}" +
                                $"\nLatitude: {countryObj.Latitude}\nLongitude: {countryObj.Longitude}" +
                                $"\nArea: {countryObj.Area}\nPopulation: {countryObj.Population}";

                            File.WriteAllText(fileName, documentContent);

                            Console.WriteLine($"Created {fileName}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}