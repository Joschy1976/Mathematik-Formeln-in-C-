using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Willkommen bei den Mathematik-Formeln!");

        // Bruchrechnung
        Console.WriteLine("\n** Bruchrechnung **");
        Console.WriteLine("Summe von Brüchen: 1/3 + 1/4 = " + AddFractions(1, 3, 1, 4));

        // Geometrie
        Console.WriteLine("\n** Geometrie **");
        Console.WriteLine("Fläche eines Rechtecks mit Seitenlängen 5 und 8: " + CalculateRectangleArea(5, 8));

        Console.WriteLine("\nFormelberechnungen abgeschlossen!");
    }

    // Funktion zur Addition von Brüchen
    static string AddFractions(int num1, int denom1, int num2, int denom2)
    {
        int resultNum = num1 * denom2 + num2 * denom1;
        int resultDenom = denom1 * denom2;
        return $"{resultNum}/{resultDenom}";
    }

    // Funktion zur Berechnung der Fläche eines Rechtecks
    static int CalculateRectangleArea(int length, int width)
    {
        return length * width;
    }
}