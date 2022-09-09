using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    internal class Rasnita
    {
        public static string coffeeOrigin;
        private static int nrCafele = 0;

        public Rasnita()
        {
            
        }

        //Getter nr cafele
        public static int getNrCafele()
        {
            return Rasnita.nrCafele;
        }

        //Getter setter coffeeOrigin
        public static string getCoffeeOrigin()
        {
            return Rasnita.coffeeOrigin;
        }
        public static void setCoffeeOrigin(string coffeeOrigin)
        {
            if(coffeeOrigin == "Brazilia" || coffeeOrigin == "Columbia" || coffeeOrigin == "Ethiopia")
            {
                Rasnita.coffeeOrigin = coffeeOrigin;
            }
            else
            {
                Console.Error.WriteLine("Originea cafelei nu corespunde.");
            }
        }

        //Metoda preparareCappucino

        public static Coffee preparaCappucino()
        {
            Rasnita.nrCafele++;
            Coffee coffee = new Coffee("ABC1 " + Rasnita.nrCafele.ToString(), coffeeOrigin);
            coffee.retetaCappucino();
            return coffee;
        }

        //Metoda preparare flatWhite

        public static Coffee preparareFlatWhite()
        {
            Rasnita.nrCafele++;
            Coffee coffee = new Coffee("EBCD " + Rasnita.nrCafele.ToString(), coffeeOrigin);
            coffee.retetaFlatWhite();
            return coffee;
        }

        //Metoda preparare Espresso
        public static Coffee preparareEspresso()
        {
            Rasnita.nrCafele++;
            Coffee coffee = new Coffee("MNB " + Rasnita.nrCafele.ToString(), coffeeOrigin);
            coffee.retetaEspresso();
            return coffee;
        }

        //Metoda afisare cafele realizate in total

        //Metoda care intoarce nr de cafele mentionate ca parametru(ex: cappucino/flatWhite/Espresso)

        /*public static int nrCafeleCerute()
        {
            int nrCafeleCerute = 0;
            Coffee coffee = new Coffee();
            for (int i = 0; i < nrCafele; i++)
            {
                if (CoffeeType.Espresso)
                {
                    nrCafeleCerute++;
                }
            }
        }*/

        



    }
}
