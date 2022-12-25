using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCounter
{
    class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        public int Roll;
        public decimal MagicMultipier = 1M;
        public int Flaming_Damage = 0;
        public int Damage;

        public void CalculateDamage() {
            Damage = (int)(Roll * MagicMultipier) + BASE_DAMAGE + Flaming_Damage;
        }

        public void SetMagic(bool isMAgic) {
            if (isMAgic)
            {
                MagicMultipier = 1.75M;
            }
            else {
                MagicMultipier = 1.0M;
            }
            CalculateDamage();
        }

        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if (isFlaming)
            {
                Damage += FLAME_DAMAGE;
            }
        }
    }
}
