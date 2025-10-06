namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix el teu nom d'usuari: ");
        var nomusuari = Console.ReadLine();

        Console.Write("Introdueix un domini ex:(@gmail.com) ");
        var domini = Console.ReadLine();

        Console.WriteLine($"La teva adreça de correu es: {nomusuari}{domini}");
    }
}
