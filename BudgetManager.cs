using System;
using System.Collections.Generic;

// Denna klass hanterar alla transaktioner och innehåller logiken
public class BudgetManager
{
    // Lista som lagrar alla transaktioner i minnet
    private List<Transaction> transactions = new List<Transaction>();

    // Metod för att lägga till en ny transaktion
    public void AddTransaction()
    {
        Console.Write("Beskrivning: ");
        string description = Console.ReadLine();

        Console.Write("Belopp (positivt = inkomst, negativt = utgift): ");
        decimal amount;

        // Validerar att beloppet är ett decimaltal
        while (!decimal.TryParse(Console.ReadLine(), out amount))
        {
            Console.Write("Ogiltigt belopp. Försök igen: ");
        }

        Console.Write("Kategori: ");
        string category = Console.ReadLine();

        Console.Write("Datum (yyyy-mm-dd): ");
        string date = Console.ReadLine();

        // Skapar ett nytt Transaction-objekt och lägger till det i listan
        transactions.Add(new Transaction
        {
            Description = description,
            Amount = amount,
            Category = category,
            Date = date
        });

        Console.WriteLine("Transaktion tillagd!\n");
    }

    // Visar alla transaktioner i listan
    public void ShowAll()
    {
        if (transactions.Count == 0)
        {
            Console.WriteLine("Inga transaktioner att visa.");
            return;
        }

        Console.WriteLine("\n--- Alla Transaktioner ---");

        // Går igenom varje transaktion och visar info
        for (int i = 0; i < transactions.Count; i++)
        {
            Console.Write($"[{i}] ");
            transactions[i].ShowInfo();
        }

        Console.WriteLine();
    }

    // Räknar ut den totala balansen
    public void CalculateBalance()
    {
        decimal balance = 0;

        // Summerar alla belopp
        foreach (var t in transactions)
        {
            balance += t.Amount;
        }

        // Skriver ut resultatet
        Console.WriteLine($"\n💰 Aktuell balans: {balance} kr\n");
    }

    // Tar bort en transaktion baserat på index
    public void DeleteTransaction()
    {
        ShowAll(); // Visar alla först

        Console.Write("Ange index på transaktionen du vill ta bort (börjar på 0): ");
        int index;

        // Validerar att index är giltigt
        while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= transactions.Count)
        {
            Console.Write("Felaktigt index. Försök igen: ");
        }

        // Tar bort den valda transaktionen
        transactions.RemoveAt(index);
        Console.WriteLine("Transaktion borttagen.\n");
    }
}
//Denna klass representerar en transaktion: t.ex. lön eller utgift