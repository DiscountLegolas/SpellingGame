using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellingGame.Classes
{
    public class World
    {
        public string word { get; set; }
        public int score { get; set; }
        public List<string> tags { get; set; }
    }

    public class Root
    {
        public List<World> worlds { get; set; }
    }

}
