using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticQuest.Models
{
    abstract class Monster
    {
        public virtual int HP { get; set; } = 100;
        public virtual int Attack { get; set; } = 10;

        public virtual string Name { get; set; } = "Generic Monster";

        public Monster()
        {
            BattleCry();
        }
        public abstract void BattleCry();
        public abstract void OnDeath();


    }
}
