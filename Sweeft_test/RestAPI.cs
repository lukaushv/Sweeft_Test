using Azure.Core;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sweeft_test
{
    public class RestAPI
    {
        public static async void GenerateCountryDataFiles()
        {
            
            using (WebClient client = new WebClient())
            {
                string jsonString = client.DownloadString("https://restcountries.com/v3.1/all");

                
                JsonDocument doc = JsonDocument.Parse(jsonString);
                string folderpath = @"E:\here";
                if (!Directory.Exists(folderpath))
                {
                    Directory.CreateDirectory(folderpath);
                }

                foreach (JsonElement element in doc.RootElement.EnumerateArray())
                {
                    string name = element.GetProperty("name").GetProperty("common").GetString();
                    string region = element.GetProperty("region").GetString();
                    string subregion = "";
                    if (element.TryGetProperty("subregion", out JsonElement subregionElement))
                    {
                        subregion = subregionElement.GetString();
                    }
                    string latlng = JsonSerializer.Serialize(element.GetProperty("latlng"));
                    string area = element.GetProperty("area").ToString();
                    string population = element.GetProperty("population").ToString();


                    string file = $"{name}.txt";
                    string path = Path.Combine(folderpath, file);

                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        writer.WriteLine($"Region: {region}");
                        writer.WriteLine($"Subregion: {subregion}");
                        writer.WriteLine($"Latlng: {latlng}");
                        writer.WriteLine($"Area: {area}");
                        writer.WriteLine($"Population: {population}");
                    }
                }
            }

        }

    }
}
