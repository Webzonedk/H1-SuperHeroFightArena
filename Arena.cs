using System;
using System.Collections.Generic;
using System.Text;

namespace H1_SuperHeroFightArena
{
    class Arena
    {
        #region Fields
        Superhero player1;
        Superhero player2;
        #endregion

        #region Properties
        public Superhero Player1
        {
            get { return player1; }
            set { player1 = value; }
        }
        public Superhero Player2
        {
            get { return player2; }
            set { player2 = value; }
        }


        Random random = new Random();
        #endregion


        #region Constructor
        public Arena(Superhero player1, Superhero player2)
        {
            this.player1 = player1;
            this.player2 = player2;

        }
        #endregion




        #region Methods
        public void PickFighters(List<Superhero> superheroes)
        {
            int player1Index = random.Next(0, superheroes.Count);
            player1 = superheroes[player1Index];
            superheroes.RemoveAt(player1Index);

            int player2Index = random.Next(0, superheroes.Count);
            player2 = superheroes[player2Index];
            superheroes.RemoveAt(player2Index);



        }



        public void Fight(Superhero player1, Superhero player2)
        {
            for (int i = 0; i < 100; i++)
            {
                //player1 attacks

                //player2 attacks
            }
        }
        #endregion
        public Superhero ChooseFighter(List<Superhero> superheroes)
        {
            Superhero pickedHero = null;
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1':
                    pickedHero = superheroes[0];
                    break;

                case '2':
                    pickedHero = superheroes[1];
                    break;

                case '3':
                    pickedHero = superheroes[2];
                    break;

                case '4':
                    pickedHero = superheroes[3];
                    break;

                case '5':
                    pickedHero = superheroes[4];
                    break;

                case '6':
                    pickedHero = superheroes[5];
                    break;

                case '7':
                    pickedHero = superheroes[6];
                    break;

                case '8':
                    pickedHero = superheroes[7];
                    break;


            }

            return pickedHero;
        }

        //    public void Fight()
        //    {
        //        for (int i = 0; i < length; i++)
        //        {

        //        }
        //    }
    }

}