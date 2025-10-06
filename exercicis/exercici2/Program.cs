namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix el teu carrer: ");
        var carrer = Console.ReadLine();
        Console.Write("Introdueix el número del carrer: ");
        var numero = Console.ReadLine();
        int numerocarrer = Convert.ToInt16(numero);
        Console.Write("Introdueix el teu codi postal: ");
        var codi = Console.ReadLine();
        int codipostal = Convert.ToInt16(codi);
        Console.Write("Introdueix la teva població: ");
        var població = Console.ReadLine();

        Console.WriteLine($"Vius al {carrer} nº{numero}, {codi}, {població}");
    }
}
