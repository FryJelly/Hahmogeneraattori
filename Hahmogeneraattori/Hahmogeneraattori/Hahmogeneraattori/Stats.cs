using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahmogeneraattori
{
    public class Stats
    {
            public int Str { get; set; }
            public int Dex { get; set; }
            public int Con { get; set; }
            public int Int { get; set; }
            public int Wis { get; set; }
            public int Cha { get; set; }

        public static List<Stats> RollStats()
        {
            List<Stats> stats = new List<Stats>();
            Random r = new Random();
            Stats a = new Stats() { Str = r.Next(1, 20), Dex = r.Next(1, 20), Con = r.Next(1, 20), Int = r.Next(1, 20), Wis = r.Next(1, 20), Cha = r.Next(1, 20)};
            stats.Add(a);
            return stats;
        }

 
    }




}
