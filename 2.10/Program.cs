namespace Ejercicio2_10
{
    public class Program
    {
        public static void Main()

        {
            double pulgada = 0.02545, metro;
            Console.WriteLine("Digite la cantidad de tela que necesita en metros ");
            metro = Convert.ToDouble(Console.ReadLine());


            pulgada = metro / pulgada;


            Console.WriteLine($"la cantidad de tela en pulgadas es:{pulgada}");



        }
    }
}