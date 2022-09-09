using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    public enum CoffeeType { Cappucino, FlatWhite, Espresso };
    internal class Coffee
    {
        private const int SHOT = 50;
        private CoffeeType coffeType;
        private string nameOnTheCup;
        private int milkQuantity;
        private int coffeeQuantity;
        private readonly string id;
        private bool foam;
        private int quantity;
        private string coffeeOrigin;

        //Constructor implicit
        public Coffee()
        {
            this.nameOnTheCup = "Costi";
            this.coffeeQuantity = 7;
        }

        //Constructor id
        public Coffee(string id)
        {
            this.id = id;
        }

        //Constructor id && coffeeOrigin
        public Coffee(string id, string coffeeOrigin)
        {
            this.id = id;
            this.coffeeOrigin = coffeeOrigin;
        }

        //Getters

        //CoffeeType
        public CoffeeType getCoffeeType()
        {
            return this.coffeType;
        }

        //nameOnTheCup
        public string getNameOnTheCup()
        {
            return this.nameOnTheCup;
        }

        //milkQuantity
        public int getMilkQuantity()
        {
            return this.milkQuantity;
        }

        //coffeeQuantity
        public int getCoffeeQuantity()
        {
            return this.coffeeQuantity;
        }

        //id
        public string getId()
        {
            return this.id;
        }

        //foam
        public bool getFoam()
        {
            return this.foam;
        }

        //quantity
        public int getQuantity()
        {
            return this.quantity;
        }

        //coffeeOrigin
        public string getCoffeeOrigin()
        {
            return this.coffeeOrigin;
        }

        //Setter pentru nameOnTheCup
        public void setNameOnTheCup(string nameOnTheCup)
        {
            this.nameOnTheCup = nameOnTheCup;
        }

        //Metoda calcul milkQuantity + coffeeQuantity
        private void calculareCantitate()
        {
            this.quantity = this.milkQuantity + this.coffeeQuantity;
        }

        //Reteta cappucino
        public void retetaCappucino()
        {
            this.coffeType = CoffeeType.Cappucino;
            this.milkQuantity = Coffee.SHOT * 2;
            this.coffeeQuantity = Coffee.SHOT;
            this.foam = true;
            calculareCantitate();
        }

        //Reteta flatWhite
        public void retetaFlatWhite()
        {
            this.coffeType = CoffeeType.FlatWhite;
            this.milkQuantity = Coffee.SHOT;
            this.coffeeQuantity = Coffee.SHOT * 2;
            this.foam = true;
            calculareCantitate();
        }

        //Reteta Espresso
        public void retetaEspresso()
        {
            this.coffeType = CoffeeType.Espresso;
            this.milkQuantity = Coffee.SHOT * 0;
            this.coffeeQuantity = Coffee.SHOT * 2;
            this.foam = false;
            calculareCantitate();
        }

        //Metoda adaugare extra shot cafea
        public void adaugareExtraShotCafea()
        {
            this.coffeeQuantity = coffeeQuantity + Coffee.SHOT;
            calculareCantitate();
        }

        //Metoda adaugareLapte
        public void adaugareLapte(int milkQuantityToAdd)
        {
            this.milkQuantity = milkQuantity + milkQuantityToAdd;
            calculareCantitate();
        }

        //Metoda afisare
        public override string ToString()
        {
            return "Name on the cup: " + nameOnTheCup + " Cantitate: " + quantity + " Origine: " + coffeeOrigin + " Tipul cafelei: " + coffeType;
        }

    }
}
