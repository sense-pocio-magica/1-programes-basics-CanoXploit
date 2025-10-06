namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Insereix un numero de 3 xifres: ");
        int numero = Convert.ToInt16(Console.ReadLine());
        // string numerostring = numero.ToString();
        // var numeroreves1 = numerostring[2];
        // var numeroreves2 = numerostring[1];
        // var numeroreves3 = numerostring[0];

        int centenes = numero / 100;
        int unitats = numero % 10;
        int desenes = numero % 100 / 10;

        // Console.WriteLine($"{numeroreves1}{numeroreves2}{numeroreves3}");
        Console.WriteLine($"{unitats}{desenes}{centenes}");

    }
}
