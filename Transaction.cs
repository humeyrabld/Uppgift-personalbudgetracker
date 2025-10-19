using System;
using System.Diagnostics;

// Denna klass representerar en transaktion: t.ex. lön eller utgift
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class Transaction
{
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public string Category { get; set; }
    public string Date { get; set; }

    // Här skrivs transaktionen och återställer färgen beroende på om det är en inkomst eller utgift
    public void ShowInfo()
    {
        Console.ForegroundColor = Amount >= 0 ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine($"{Date} - {Description} | {Category} | {Amount} kr");
        Console.ResetColor();
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
