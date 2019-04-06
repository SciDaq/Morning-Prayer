using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AaronsDayStarter.Models
{
    public class Passage
    {
        public string copyright { get; set; }
        public string text { get; set; }
        public string end_verse_id { get; set; }
        public string version { get; set; }
        public string path { get; set; }
        public string version_abbreviation { get; set; }
        public string start_verse_id { get; set; }
        public string display { get; set; }
    }

    public class Result
    {
        public List<Passage> passages { get; set; }
        public string type { get; set; }
    }

    public class Search
    {
        public Result result { get; set; }
    }

    public class Meta
    {
        public string fums_js_include { get; set; }
        public string fums_noscript { get; set; }
        public string fums_js { get; set; }
        public string fums_tid { get; set; }
        public string fums { get; set; }
    }

    public class Response
    {
        public Search search { get; set; }
        public Meta meta { get; set; }
    }

    public class RootObject
    {
        public Response response { get; set; }
    }

    public static class APIInterface
    {
        public static FormattedString GetPassage(String book, Int32 chapterFrom, Int32 verseFrom,Int32 chapterTo,  Int32 verseTo, String version = "eng-CEV", String translation = "NLT")
        {
            String url = $"http://labs.bible.org/api/?passage={book}%20{chapterFrom}:{verseFrom}-{chapterTo}:{verseTo}&formatting=para";
            //String url = $"https://bibles.org/v2/passages.js?q[]={book}+{chapterFrom}:{verseFrom}-{chapterTo}{verseTo}&version={version}";
            String response = "";
            Task.WaitAll(Task.Run(async() => response = await GetDataFromServer(url)));
            //response = response.Replace("<p class=\"poetry\">", "");
            return AaronsDayStarter.Services.Formatter.HtmlToText(response);
        }


        public static Uri GetPassageURL(String book, Int32 chapterFrom, Int32 chapterTo, Int32 verseFrom, Int32 verseTo, String version = "eng-CEV", String translation = "NLT")
        {
            String url = $"https://biblia.com/bible/{translation}/{book}{chapterFrom}.{verseFrom}-{book}{chapterTo}.{verseTo}";
            return new Uri(url);
        }


        private static async Task<String> GetDataFromServer(string URL)
        {

            try
            {
                var message = new HttpRequestMessage(HttpMethod.Post, URL);
                HttpClient httpClient = new HttpClient();
                var byteArray = Encoding.ASCII.GetBytes("n4sie0lbmxRdmU26SQPGjIUaXZmPDuOlRL7Vg0F6");
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("bearer", Convert.ToBase64String(byteArray));


                HttpResponseMessage response = await httpClient.GetAsync(new Uri(URL));

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var passage = content; // JsonConvert.DeserializeObject<Result>(content);

                    return passage;
                } else
                {
                    List<Passage> pass = new List<Passage>();
                    pass.Add(new Passage()
                    {
                        text = response.ReasonPhrase,
                    });
                    return response.ReasonPhrase;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
