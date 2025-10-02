namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 8

Nota de pràctiques: 10
Nota de l’examen: 5
La nota final és 6.5 o sigui un 7 
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix la nota de pràctiques: ");
        int notapractiques = Convert.ToInt16(Console.ReadLine());

        Console.Write("Introdueix la nota de l'examen: ");
        int notaexamen = Convert.ToInt16(Console.ReadLine());

        double notafinal = (notapractiques * 0.3) + (notaexamen * 0.7);
        int notaArrodonida = (int) notafinal;


        Console.WriteLine($"La nota final és {notafinal} o sigui {notaArrodonida}");       
    }
}
