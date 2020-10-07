using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckNorrisJokes
{
    class RandomCat : IJoke
    {
        public string Url => "https://aws.random.cat/meow";
        public string file { get; set; }
        public string GetJoke()
        {
            return "Meow";
        }
        public string ImgUrl()
        {
            return file;
        }
    }
}
