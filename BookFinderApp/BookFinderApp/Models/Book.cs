using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BookFinderApp.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate  { get; set; }
        public string Date { get; set; }
        public List<Book> ListBooks { get; set; }

        HttpClient client = new HttpClient();
        const string urlApi = "https://api-book-finder.conveyor.cloud/api/books";
        public async Task<List<Book>> GenerateBooks()
        {
            string jsonString = await client.GetStringAsync(urlApi);
            var jsonDeserialize = JsonConvert.DeserializeObject<List<Book>>(jsonString);
            foreach (var item in jsonDeserialize)
            {
                item.Date = item.PublishedDate.ToShortDateString();
            }
            ListBooks = new List<Book>(jsonDeserialize);
            return ListBooks;
        }
    }
}
