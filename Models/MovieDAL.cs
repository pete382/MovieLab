using Newtonsoft.Json;
using System.Net;


namespace MovieLab.Models
{
    public class MovieDAL
    {
        public static MModel GetMovie(string m)
        {
            string url = $"http://www.omdbapi.com/?apikey=b370ce39&t={m}";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //adjust
            //Convert to c#
            //Install Newtonsoft.json
            MModel result = JsonConvert.DeserializeObject<MModel>(JSON);
            return (result);



        }


    }
}
