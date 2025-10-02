namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Com et dius? ");
        var nom = Console.ReadLine();

        Console.Write("Quin anys vas neixer? ");
        var anyneixement = Console.ReadLine();
        int any = Convert.ToInt16(anyneixement);

        var edat = 2025 - any  ;

        Console.WriteLine($"Hola {nom}! Ja tens {edat} anys?");
    }
}
