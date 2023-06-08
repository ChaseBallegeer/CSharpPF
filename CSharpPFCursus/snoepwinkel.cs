using System;

namespace HelloWorld;

class Program
{
    static void Main(string[] args) {

        wisselgeldBerekenen();



        void wisselgeldBerekenen()
        {
            int[] muntstukken = { 200, 100, 50, 20, 10, 5, 2, 1 };
            Console.WriteLine("hoeveel kost jou artikel?");
            int invoer = 200;
            int gekozenPrijs = Convert.ToInt32(Console.ReadLine());

            while (gekozenPrijs > 200 || gekozenPrijs < 0)
            {
                Console.WriteLine("het maximale bedrag is 200 en minimaal bedrag is 0");
                gekozenPrijs = Convert.ToInt32(Console.ReadLine());

            }



            Console.WriteLine($"jouw invoer is {invoer} cent\nen je gekozen artikel kost {gekozenPrijs}cent");
            int aantalGeldTerug = invoer - gekozenPrijs;
            Console.WriteLine($"het aantal geld die je terug moet krijgen is {aantalGeldTerug} cent");
            
            for (int i = 0; i < muntstukken.Length; i++)
            {
                int aantalMuntstukken = aantalGeldTerug / muntstukken[i];
                aantalGeldTerug = aantalGeldTerug - (aantalMuntstukken * muntstukken[i]);
                Console.WriteLine($"{muntstukken[i]} : {aantalMuntstukken}");

            }

        }

    }
}

    




