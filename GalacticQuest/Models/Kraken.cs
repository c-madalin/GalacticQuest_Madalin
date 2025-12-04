using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticQuest.Models
{
    internal class Kraken : Monster
    {
        public override int HP { get; set; } = 300;
        public override int Attack { get; set; } = 50;
        public override string Name { get; set; } = "Kraken";

        public override void BattleCry()
        {
            Console.WriteLine("Raaaarrrrgggghhh!");
        }

        public override void OnDeath()
        {
            Console.WriteLine("Im defeted");
        }

    }
}
