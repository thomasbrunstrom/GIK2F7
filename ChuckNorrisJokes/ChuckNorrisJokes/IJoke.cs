using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckNorrisJokes
{
    public interface IJoke
    {
        string Url { get; }
        string GetJoke();

    }
}
