using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Models
{
    public class Stat
    {
        public int Rank { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }

        public Stat(string Rank, string Level, string Xp)
        {
            try
            {
                this.Rank = int.Parse(Rank);
                this.Level = int.Parse(Level);
                this.Xp = int.Parse(Xp);
            }
            catch (Exception e) {
                throw new Exception("Some of your stats did not return numerical values");
            }
        }
    }
}
