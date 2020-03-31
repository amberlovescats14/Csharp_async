using System;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace asyncawait
{
    public class async
    {
        public List<Book> books { get; set; }
        public async Task exampleAsync()
        {
            // code before
            try
            {
                using (var http = new HttpClient())
                {
                    var req = await http.GetAsync($"http://localhost:3000/books");
                    var res = await req.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<IEnumerable<Books>>(res);
                    this.books = data;
                }
            }
            catch (Exception ex)
            {

            }
            // code after
        }


    }


}
