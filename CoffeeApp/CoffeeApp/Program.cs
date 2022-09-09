namespace CoffeeApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rasnita.setCoffeeOrigin("Columbia");
            Coffee coffee1 = Rasnita.preparareFlatWhite();
            coffee1.setNameOnTheCup("Alex");

            Coffee coffee2 = Rasnita.preparareEspresso();
            coffee2.setNameOnTheCup("Costi");

            Console.WriteLine(coffee1.ToString());
            Console.WriteLine(coffee2.ToString());

            Rasnita.setCoffeeOrigin("Ethiopia");
            Coffee coffee3 = Rasnita.preparaCappucino();
            coffee3.setNameOnTheCup("Andrei");
            coffee3.adaugareExtraShotCafea();
            coffee3.adaugareExtraShotCafea();
            Console.WriteLine(coffee3.ToString());

            Console.WriteLine(coffee1.ToString());
            Console.WriteLine(coffee2.ToString());

            Coffee coffee4 = Rasnita.preparaCappucino();
            coffee4.adaugareLapte(200);
            Console.WriteLine(coffee4.ToString());

            Console.WriteLine(coffee1.getId());
            Console.WriteLine(coffee2.getId());
            Console.WriteLine(coffee3.getId());
            Console.WriteLine(coffee4.getId());

            Console.WriteLine(Rasnita.getNrCafele());
        }
    }
}
