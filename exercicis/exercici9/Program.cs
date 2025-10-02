namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Cuantos metros quieres pasar a pies? ");
        var totalmetros = Console.ReadLine();
        float metros = Convert.ToSingle(totalmetros);

        var pies =(metros * 3.28084);

        Console.WriteLine($"El valor de metros es {pies} pies ");

    }
}
