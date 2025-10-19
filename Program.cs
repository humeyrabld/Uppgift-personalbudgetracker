using System;

// Huvudprogrammet där användaren interagerar med menyn
class Program
{
    static void Main()
    {
        // Skapar en ny instans av BudgetManager
        BudgetManager manager = new BudgetManager();
        bool running = true;

        // Meny-loop: körs tills användaren väljer att avsluta
        while (running)
        {
            // Skriver ut menyval
            Console.WriteLine("=== Personal Budget Tracker ===");
            Console.WriteLine("1. ➕ Lägg till transaktion");
            Console.WriteLine("2. 📋 Visa alla transaktioner");
            Console.WriteLine("3. 💰 Visa total balans");
            Console.WriteLine("4. 🗑️ Ta bort transaktion");
            Console.WriteLine("5. 💾 Avsluta programmet");
            Console.Write("Ditt val: ");
            string choice = Console.ReadLine();

            // Hanterar användarens menyval med switch-sats
            switch (choice)
            {
                case "1":
                    manager.AddTransaction(); // Användaren lägger till en ny transaktion
                    break;
                case "2":
                    manager.ShowAll(); // Visar alla transaktioner
                    break;
                case "3":
                    manager.CalculateBalance(); // Räknar ut och visar balans
                    break;
                case "4":
                    manager.DeleteTransaction(); // Tar bort vald transaktion
                    break;
                case "5":
                    running = false; // Avslutar loopen (och programmet)
                    Console.WriteLine("Avslutar...");
                    break;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.\n");
                    break;
            }
        }
    }
}
