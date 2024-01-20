using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPprac
{
    public class Hero
    {
        public string heroName;
        public float moveSpeed;
        public float healthPoint;
        public float physicDame;
        private float spellDame = 10;
        public float manaPoint;


        public float MoveSpeed
        {
            get
            {
                return moveSpeed;
            }
            set
            {
                moveSpeed = value;
            }
        }

        public float SpellDame
        {
            get
            {
                return spellDame;
            }
        }
        public Hero()
        {

        }

        public Hero(float moveSpeed, float healthPoint, float physicDame, float manaPoint)
        {
            this.moveSpeed = moveSpeed;
            this.healthPoint = healthPoint;
            this.physicDame = physicDame;
            this.manaPoint = manaPoint;
        }

        public void LevelUP()
        {
            this.healthPoint += 100;
            this.manaPoint += 50;
            this.spellDame *= 1.5f;
        }
    }
}