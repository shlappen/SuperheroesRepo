using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperheroCreator.Models
{
    public class Superhero
    {
        public int SuperheroId { get; set; }
        public string Name { get; set; }
        public string AlterEgo { get; set; }
        public string PrimarySuperAbility { get; set; }
        public string SecondarySuperAbility { get; set; }
        public string Catchphrase { get; set; }
    }
}
