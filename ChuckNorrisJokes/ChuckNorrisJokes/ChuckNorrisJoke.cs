using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckNorrisJokes
{
    public class ChuckNorrisJoke : IJoke
    {
        //{"categories":[],
        //"created_at":"2020-01-05 13:42:30.177068",
        //"icon_url":"https://assets.chucknorris.host/img/avatar/chuck-norris.png",
        //"id":"B8JvPMwdQRCwnUpfg7AFzA",
        //"updated_at":"2020-01-05 13:42:30.177068",
        //"url":"https://api.chucknorris.io/jokes/B8JvPMwdQRCwnUpfg7AFzA",
        //"value":"When Chuck Norris goes swimming, Jaws hears the scary music"}
        public string Url { get => "https://api.chucknorris.io/jokes/random"; }

        public List<string> categories { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public string value { get; set; }
        

        public string GetJoke()
        {
            return value;
        }
        public string ImgUrl()
        {
            return icon_url;
        }
    }
}
