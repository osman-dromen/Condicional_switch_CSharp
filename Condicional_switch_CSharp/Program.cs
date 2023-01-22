internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejemplo 1 del Condicional SWITCH");

        Console.WriteLine("Elige medio de transporte (coche, tren, avion)");

        string medioTransporte = Console.ReadLine();

        switch (medioTransporte)
        {

            case "coche":
                Console.WriteLine("Velocidad media: 100 km/hr");
                break;

            case "tren":
                Console.WriteLine("Velocidad media: 250 km/hr");
                break;

            case "avion":
                Console.WriteLine("Velocidad media: 800 km/hr");
                break;

            default:
                Console.WriteLine("Argumentos no válidos");
                break;
        }

        Console.WriteLine("Ejemplo 2 de Condicional SWITCH");

        Console.WriteLine("Introduce n° de mes para cálculo de la comisión");

        int nMes = Int32.Parse(Console.ReadLine());

        switch (nMes)
        {
            case 1:
                Console.WriteLine("Mes escogido: Enero");
                break;

            case 2:
                Console.WriteLine("Mes escogido: Febrero");
                break;

            case 3:
                Console.WriteLine("Mes escogido: Marzo");
                break;

            case 4:
                Console.WriteLine("Mes escogido: Abril");
                break;

            case 5:
                Console.WriteLine("Mes escogido: Mayo");
                break;

            case 6:
                Console.WriteLine("Mes escogido: Junio");
                break;

            case 7:
                Console.WriteLine("Mes escogido: Julio");
                break;

            case 8:
                Console.WriteLine("Mes escogido: Agosto");
                break;

            case 9:
                Console.WriteLine("Mes escogido: Septiembre");
                break;

            case 10:
                Console.WriteLine("Mes escogido: Octubre");
                break;

            case 11:
                Console.WriteLine("Mes escogido: Noviembre");
                break;

            case 12:
                Console.WriteLine("Mes escogido: Dicimebre");
                break;

            default:
                Console.WriteLine("Número de mes inválido");
                break;
        }

        Console.WriteLine("Ha términado el programa");
    }
}