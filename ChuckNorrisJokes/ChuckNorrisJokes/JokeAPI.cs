using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace ChuckNorrisJokes
{
    class JokeAPI : IJoke
    {
        public string Url { get => "https://sv443.net/jokeapi/v2/joke/Any?type=single"; }
        public bool error { get; set; }
        public string category { get; set; }
        public string type { get; set; }
        public string joke { get; set; }

        public string GetJoke()
        {
            return joke;
        }
    }
}
