using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace ChuckNorrisJokes
{
    public class ServiceLayer
    {
        public ServiceLayer()
        {
        }
        public T GetJoke<T>() where T : IJoke, new()
        {
            T joke = new T();
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(joke.Url);
                joke = JsonSerializer.Deserialize<T>(json);
            }
            return joke;
        }
    }
}