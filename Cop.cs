using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAloneTjuvOchPolis
{
    internal class Cop : Person
    {
        public List<string> LostAndFound { get; set; } //= man kan också skriva: new List<string>();

        public Cop()
        {
            LostAndFound = new List<string>();
        }

        public void Arrest(Thief thief)
        {
            LostAndFound.AddRange(thief.StoldItems);
            thief.StoldItems.Clear();
            thief.Arrested = true;
        }
    }
}
