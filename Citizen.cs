using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAloneTjuvOchPolis
{
    internal class Citizen : Person
    {
        public List<string> Belognings { get; set; }
        public Citizen()
        {
            Belognings = new List<string>()
            {
                "Mobile", "Keys", "Wallet", "Jewelry", "Purse"
            };
        }
    }
}
