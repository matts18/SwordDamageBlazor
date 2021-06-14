using System;
namespace BlazorSwordDamage
{
    class SwordDamage
    {
        /// <summary>
        /// Base damage used in the CalculateDamage method
        /// </summary>
        public const int BASE_DAMAGE = 3;

        /// <summary>
        /// Flame damage used in the CalculateDamange method
        /// </summary>
        public const int FLAME_DAMAGE = 2;

        public int Damage { get; private set; }

        private int roll;
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        private bool flaming;
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        private bool magic;
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }


        public SwordDamage(int roll)
        {
            this.roll = roll;
        }

        private void CalculateDamage()
        {
            double magicMultiplier = 1;

            if (Magic) magicMultiplier = 1.75;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }   


    }
}
