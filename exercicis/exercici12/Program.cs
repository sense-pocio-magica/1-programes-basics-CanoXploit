namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra el primer numero: ");
        var numero1 = Console.ReadLine();
        int operacio1 = Convert.ToInt16(numero1);

        Console.Write("Entra el segon numero: ");
        var numero2 = Console.ReadLine();
        int operacio2 = Convert.ToInt16(numero2);

        var suma = operacio1 + operacio2;
        var resta = operacio1 - operacio2;
        var multiplicació = operacio1 * operacio2;
        var divisio = operacio1 / operacio2;

        var sobrantedivision = divisio % operacio2;

        Console.WriteLine($"Els resultats són: Suma: {suma} Resta: {resta} Multplicacio: {multiplicació} Divisio: {divisio} i en sobre {sobrantedivision}");
    }
}
