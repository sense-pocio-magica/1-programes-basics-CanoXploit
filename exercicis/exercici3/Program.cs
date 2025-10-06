namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Que producto buscas?");
        var producte = Console.ReadLine();
        Console.WriteLine("A que precio?");
        var preu = Console.ReadLine();
        Console.WriteLine("Hay estoc?");
        var stock = Console.ReadLine();
        bool ok;

        if (stock == "si")
        {

            ok = true;
        }
        else
        {

            ok = false;
        }

        if (ok == true)
        {

            Console.WriteLine($"Has seleccionat el producte: {producte}, te un preu de: {preu}, Si hay estoc");
        }
        else
        {

            Console.WriteLine($"Has seleccionat el producte: {producte}, te un preu de: {preu}, No hay estoc");
        }
       
        
    }
}
