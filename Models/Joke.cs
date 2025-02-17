using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public int JokesQuestion { get; set; }
        public int JokesAnswer { get; set; }

        public Joke()
        {
            
        }
    }
}