namespace exercici19;

// Assigna una paraula a una variable de text. Utilitza una funció per a obtenir la seva longitud i 
// imprimeix la paraula i el seu nombre de caràcters.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix una paraula: ");
        var paraula = Console.ReadLine();
        var longitud = paraula.Length;
        var imprimeix = paraula.Substring(0);


        Console.WriteLine($"La longitud de la parauala és {longitud} i la paraula és {imprimeix}");
    }
}
