namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Cuantos cm tiene un costado del cuadrado? ");
        var cm = Console.ReadLine();
        int cmcuadrado = Convert.ToInt16(cm);

        var perimetro = (cmcuadrado * 4);

        Console.WriteLine($"El perimetro del cuadrado son {perimetro} cm");
    }
}
