using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ChuckNorrisJokes
{
    public class CatFacts : IJoke
    {
        public string Url => "https://cat-fact.herokuapp.com/facts/random";
        public string text { get; set; }
        public string GetJoke()
        {
            return text;
        }
    }
}
