using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbum
{
    public class Logic
    {

        //declarations
        public int album = -1;
        public string url = "https://jsonplaceholder.typicode.com/photos?albumId=";
        public HttpClient client = new();

        //methods
        public async Task<string> GetJson()
        {
            HttpResponseMessage response = await client.GetAsync(url + album.ToString());
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public List<Photo> ConvertJson(String responseBody)
        {
            return JsonConvert.DeserializeObject<List<Photo>>(responseBody);
        }

        public void DisplayAlbumNumber(List<Photo> photos)
        {
            Console.WriteLine("Album : " + photos[0].albumId.ToString());
            Console.WriteLine("\n");
        }

        public bool CheckUserInput (String input)
        {
            if (!int.TryParse(input, out album) || album < 0 || album > 100)
            {
                return false;
            }

            else return true;
        }

        public void DisplayPhotos(List<Photo> photos)
        {
            foreach (Photo p in photos)
            {
                Console.WriteLine("ID : " + p.id.ToString());
                Console.WriteLine("Title : " + p.title);
                Console.WriteLine("\n");
            }
        }
    }
}
