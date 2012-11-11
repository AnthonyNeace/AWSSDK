using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AW;

namespace SampleBot
{
    class SampleBot
    {
        int citnum;
        string ppw;


        static void Main(string[] args)
        {
            var bot = new Bot
            {
                Name = "Samantha",
                Citnum = 888,
                PPW = "myppw"
            }.Login().Goto("Droog 0n 0e");
            bot.Say("Hello!");
            bot.Exit();
            
        }
    }

    class Bot
    {
        public string Name;
        public int Citnum;
        public string PPW;
        public Bot Login()
        {
            return this;
        }

        public Bot Goto(string loc)
        {
            return this;
        }
    }
}
