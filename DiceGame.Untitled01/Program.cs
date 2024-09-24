
 using System;

 class Program
 {
    static int Rolldice()
    {
        Random rand = new Random();
        return rand.Next(1, 7);
    }

    static void Main(string[] args)
    {
        string val;
        int totalSumma = 0;

        while (true)
        {
            Console.WriteLine("Vill du kasta tärningen eller stanna? (skriv 'kasta' eller 'stanna'):");
            val = Console.ReadLine();

            if (val == "kasta")
            {
                int kast = Rolldice();
                totalSumma += kast;
                Console.WriteLine("Du kastade: " + kast);
                Console.WriteLine("Din totala summa är nu: " + totalSumma);
            }
            else if (val == "stanna")
            {
                Console.WriteLine("Du valde att stanna. Din slutliga summa är: " + totalSumma);
                break;
            }
            else
            {
                Console.WriteLine("Skriv 'kasta' eller 'stanna' oi.");
            }
            


        }
          Console.WriteLine("\nNu är det dealerns tur...");
            int totalSummaDealer = 0;

            while (totalSummaDealer < 17)
            {
                int kastDealer = Rolldice();
                totalSummaDealer += kastDealer;
                Console.WriteLine("Dealern slog: " + kastDealer + ", dealern har nu " + totalSummaDealer + " poäng");
            }

            Console.WriteLine("\nSlutresultat:");
            Console.WriteLine("Spelarens slutliga poäng: " + totalSumma);
            Console.WriteLine("Dealerns slutliga poäng: " + totalSummaDealer);

            if (totalSumma > 21)
            {
                Console.WriteLine("Du förlorade! Du gick över 21.");
            }
            else if (totalSummaDealer > 21)
            {
                Console.WriteLine("Dealern gick över 21, du vann!");
            }
            else if (totalSumma > totalSummaDealer)
            {
                Console.WriteLine("Grattis! Du vann mot dealern.");
            }
            else if (totalSumma < totalSummaDealer)
            {
                Console.WriteLine("Tyvärr, dealern vann.");
            }
            else
            {
                Console.WriteLine("Det är oavgjort!");
            }
    }
 }
