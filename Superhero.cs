using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime;
using System.Text;

namespace H1_SuperHeroFightArena
{
    class Superhero
    {
        #region Fields

        private string name;
       // private byte attack = 2;
        private byte minAttack = 2;
        private byte maxAttack = 2;

        private byte defence = 5;
        private byte minDefence = 5;
        private byte maxDefence = 5;
        private byte hitpoint = 120;
#endregion

        #region Properties



        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       //public byte Attack
        //{
        //    get { return attack; }
        //    set { minAttack = value; }
        //}
        public byte MinAttack
        {
            get { return minAttack; }
            set { minAttack = value; }
        }
        public byte MaxAttack
        {
            get { return maxAttack; }
            set { maxAttack = value; }
        }


        public byte Defence
        {
            get { return defence; }
            set { defence = value; }
        }
        public byte MinDefence
        {
            get { return minDefence; }
            set { minDefence = value; }
        }
        public byte MaxDefence
        {
            get { return maxDefence; }
            set { maxDefence = value; }
        }

        public byte HitPoint
        {
            get { return hitpoint; }
            set { hitpoint = value; }
        }

        #endregion

        #region Constructor
        public Superhero()
        {

        }
        public Superhero(string name, byte minAttack, byte maxAttack, byte minDefence, byte maxDefence, byte hitpoint)
        {
            this.name = name;
           // this.attack = attack;
            this.minAttack = minAttack;
            this.maxAttack = maxAttack;
            this.minDefence = minDefence;
            this.maxDefence = maxDefence;
            this.hitpoint = hitpoint;
        }
        #endregion

        #region Methods

        #endregion
    }


}
