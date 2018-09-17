using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsLibrary
{
    public abstract class Weapon
    {
        public int baseDamage;
        public int baseRange;
        public int actionPoints;
        public int criticalDamage;

        void poke()
        {
            //does 1 damage
        }
    }

    public class Ranged:Weapon
    {

    }

    public class Melee:Weapon
    {

    }
}
