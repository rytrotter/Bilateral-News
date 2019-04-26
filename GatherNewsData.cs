using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;


namespace BilateralNews
{
    class GatherNewsData
    {
        public static List<JsonData> ReturnBadNewsData()
        {
            List<JsonData> badNewsList = new List<JsonData>();
            string url = "https://www.reddit.com/r/news/controversial.json?sort=controversial";
            string badNewsJsonRaw = WebHandle.client.DownloadString(url);

            RedditJson.RootObject usableJsonObject = JsonConvert.DeserializeObject<RedditJson.RootObject>(badNewsJsonRaw);

            for (int i = 0; i < usableJsonObject.data.children.Count; i++)
            {
                badNewsList.Add(new JsonData
                {
                    Title = usableJsonObject.data.children[i].data.title,
                    NewsURL = usableJsonObject.data.children[i].data.url,
                    Domain = usableJsonObject.data.children[i].data.domain,
                });


            }

            return badNewsList;
        }

        public static List<JsonData> ReturnGoodNewsData()
        {
            List<JsonData> goodNewsList = new List<JsonData>();
            string url = "https://www.reddit.com/r/UpliftingNews/hot.json?sort=hot";
            string goodNewsJsonRaw = WebHandle.client.DownloadString(url);

            RedditJson.RootObject usableJsonObject = JsonConvert.DeserializeObject<RedditJson.RootObject>(goodNewsJsonRaw);

            for (int i = 0; i < usableJsonObject.data.children.Count; i++)
            {
                goodNewsList.Add(new JsonData
                {
                    Title = usableJsonObject.data.children[i].data.title,
                    NewsURL = usableJsonObject.data.children[i].data.url,
                    Domain = usableJsonObject.data.children[i].data.domain,

                });
            }
            return goodNewsList;
        }
    }

    public class JsonData
    {
        public string Title { get; set; }
        public string NewsURL { get; set; }
        public string Domain { get; set; }
    }

    public class WebHandle
    {
        public static WebClient client = new WebClient();
    }
}