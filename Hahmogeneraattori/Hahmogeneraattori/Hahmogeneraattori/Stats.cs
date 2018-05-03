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
        public int StrModifier { get; set; }
        public int DexModifier { get; set; }
        public int ConModifier { get; set; }
        public int IntModifier { get; set; }
        public int WisModifier { get; set; }
        public int ChaModifier { get; set; }

        public static Stats RollStats()
        {
            Random r = new Random();
            Stats stats = new Stats() { Str = r.Next(6, 18), Dex = r.Next(6, 19), Con = r.Next(6, 19), Int = r.Next(6, 19), Wis = r.Next(6, 19), Cha = r.Next(6, 19)};
            stats.StrModifier = stats.Str / 2 - 5;
            stats.DexModifier = stats.Dex / 2 - 5;
            stats.ConModifier = stats.Con / 2 - 5;
            stats.IntModifier = stats.Int / 2 - 5;
            stats.WisModifier = stats.Wis / 2 - 5;
            stats.ChaModifier = stats.Cha / 2 - 5;
            return stats;
        }

 
    }




}
