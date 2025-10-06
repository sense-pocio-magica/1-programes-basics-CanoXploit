namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Cuantos minutos? ");
        var minutos = Console.ReadLine();
        int totalminutos = Convert.ToInt16(minutos);

        int horas = (totalminutos / 60);

        int minuts = totalminutos % 60 ;

        Console.WriteLine($"Son {horas} horas y {minuts} minutos");
    }
}
