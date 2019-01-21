using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Models
{
    public class User
    {
        public DateTime Timestamp { get; set; }
        public string Username { get; set; }

        public Stat Overall { get; set; }
        public Stat Attack { get; set; }
        public Stat Defence { get; set; }
        public Stat Strength { get; set; }
        public Stat Hitpoints { get; set; }
        public Stat Ranged { get; set; }
        public Stat Prayer { get; set; }
        public Stat Magic { get; set; }
        public Stat Cooking { get; set; }
        public Stat Woodcutting { get; set; }
        public Stat Fletching { get; set; }
        public Stat Fishing { get; set; }
        public Stat Firemaking { get; set; }
        public Stat Crafting { get; set; }
        public Stat Smithing { get; set; }
        public Stat Mining { get; set; }
        public Stat Herblore { get; set; }
        public Stat Agility { get; set; }
        public Stat Theiving { get; set; }
        public Stat Slayer { get; set; }
        public Stat Farming { get; set; }
        public Stat Runecraft { get; set; }
        public Stat Hunter { get; set; }
        public Stat Construction { get; set; }

        //public Stat Clue_Scrolls_Easy { get; set; }
        //public Stat Clue_Scrolls_Medium { get; set; }
        //public Stat Clue_Scrolls_All { get; set; }
        //public Stat Bounty_Hunter { get; set; }
        //public Stat Bounty_Hunter_Rogues { get; set; }
        //public Stat Clue_Scrolls_Hard { get; set; }
        //public Stat LMS { get; set; }
        //public Stat Clue_Scrolls_Elite { get; set; }
        //public Stat Clue_Scrolls_Master { get; set; }

        public User(string username) {
            this.Timestamp = DateTime.Now;
            this.Username = username;
        }

        public void MapData(string data) {

            string[] parsedData = data.Split(',', '\n');

            //if we don't have the number of "stats" * 3 then something is wrong
            if (parsedData.Length < 24 * 3)
            {
                throw new Exception("Something went wrong obtaining your stats");
            }

            this.Overall = new Stat(parsedData[0], parsedData[1], parsedData[2]);
            this.Attack = new Stat(parsedData[3], parsedData[4], parsedData[5]);
            this.Defence = new Stat(parsedData[6], parsedData[7], parsedData[8]);
            this.Strength = new Stat(parsedData[9], parsedData[10], parsedData[11]);
            this.Hitpoints = new Stat(parsedData[12], parsedData[13], parsedData[14]);
            this.Ranged = new Stat(parsedData[15], parsedData[16], parsedData[17]);
            this.Prayer = new Stat(parsedData[18], parsedData[19], parsedData[20]);
            this.Magic = new Stat(parsedData[21], parsedData[22], parsedData[23]);
            this.Cooking = new Stat(parsedData[24], parsedData[25], parsedData[26]);
            this.Woodcutting = new Stat(parsedData[27], parsedData[28], parsedData[29]);
            this.Fletching = new Stat(parsedData[30], parsedData[31], parsedData[32]);
            this.Fishing = new Stat(parsedData[33], parsedData[34], parsedData[35]);
            this.Firemaking = new Stat(parsedData[36], parsedData[37], parsedData[38]);
            this.Crafting = new Stat(parsedData[39], parsedData[40], parsedData[41]);
            this.Smithing = new Stat(parsedData[42], parsedData[43], parsedData[44]);
            this.Mining = new Stat(parsedData[45], parsedData[46], parsedData[47]);
            this.Herblore = new Stat(parsedData[48], parsedData[49], parsedData[50]);
            this.Agility = new Stat(parsedData[51], parsedData[52], parsedData[53]);
            this.Theiving = new Stat(parsedData[54], parsedData[55], parsedData[56]);
            this.Slayer = new Stat(parsedData[57], parsedData[58], parsedData[59]);
            this.Farming = new Stat(parsedData[60], parsedData[61], parsedData[62]);
            this.Runecraft = new Stat(parsedData[63], parsedData[64], parsedData[65]);
            this.Hunter = new Stat(parsedData[66], parsedData[67], parsedData[68]);
            this.Construction = new Stat(parsedData[69], parsedData[70], parsedData[71]);
            //this.Clue_Scrolls_Easy = new Stat(parsedData[72], parsedData[73], parsedData[74]);
            //this.Clue_Scrolls_Medium = new Stat(parsedData[75], parsedData[76], parsedData[77]);
            //this.Clue_Scrolls_All = new Stat(parsedData[78], parsedData[79], parsedData[80]);
            //this.Bounty_Hunter = new Stat(parsedData[81], parsedData[82], parsedData[83]);
            //this.Bounty_Hunter_Rogues = new Stat(parsedData[84], parsedData[85], parsedData[86]);
            //this.Clue_Scrolls_Hard = new Stat(parsedData[87], parsedData[88], parsedData[89]);
            //this.LMS = new Stat(parsedData[90], parsedData[91], parsedData[92]);
            //this.Clue_Scrolls_Elite = new Stat(parsedData[93], parsedData[94], parsedData[95]);
            //this.Clue_Scrolls_Master = new Stat(parsedData[96], parsedData[97], parsedData[98]);
        }

        public string ToResponse() {
            var result = "";

            result += "Stats for user " + Username + "\n\n";

            result += "Overall:     " + this.Overall.Level + '\n';
            result += "Attack:      " + this.Attack.Level + '\n';
            result += "Defence:     " + this.Defence.Level + '\n';
            result += "Strength:    " + this.Strength.Level + '\n';
            result += "Hitpoints:   " + this.Hitpoints.Level + '\n';
            result += "Ranged:      " + this.Ranged.Level + '\n';
            result += "Prayer:      " + this.Prayer.Level + '\n';
            result += "Magic:       " + this.Magic.Level + '\n';
            result += "Cooking:     " + this.Cooking.Level + '\n';
            result += "Woodcutting: " + this.Woodcutting.Level + '\n';
            result += "Fletching:   " + this.Fletching.Level + '\n';
            result += "Fishing:     " + this.Fishing.Level + '\n';
            result += "Firemaking:  " + this.Firemaking.Level + '\n';
            result += "Crafting:    " + this.Crafting.Level + '\n';
            result += "Smithing:    " + this.Smithing.Level + '\n';
            result += "Mining:      " + this.Mining.Level + '\n';
            result += "Herblore:    " + this.Herblore.Level + '\n';
            result += "Agility:     " + this.Agility.Level + '\n';
            result += "Theiving:    " + this.Theiving.Level + '\n';
            result += "Slayer:      " + this.Slayer.Level + '\n';
            result += "Farming:     " + this.Farming.Level + '\n';
            result += "Runecraft:   " + this.Runecraft.Level + '\n';
            result += "Hunter:      " + this.Hunter.Level + '\n';
            result += "Construction:" + this.Construction.Level + '\n';

            return result;
        }
    }
}
