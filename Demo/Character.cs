using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Character
    {
        public int Health { get; private set; } = 100;
        public bool IsDead { get; private set; }
        public int DamageResistance { get; set; }
        public string Race { get; set; }

        public void Hit(int damage)
        {
            var raceResistance = 0;

            if (Race == "Elf")
            {
                raceResistance = 20;
            }

            var totalDamageTaken = Math.Max(damage - raceResistance - DamageResistance, 0);

            Health -= totalDamageTaken;

            if (Health <= 0)
            {
                IsDead = true;
            }
        }
    }
}
