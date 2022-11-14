namespace Ejercicio2_9
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Digite la cantidad de horas que trabajo en la semana");
            decimal horas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite que precio tiene la hora en su empresa ");
            decimal preciohora = Convert.ToDecimal(Console.ReadLine());
            decimal paga = horas * preciohora;
            Console.WriteLine("Su salario semanal es de: {0}", paga);


        }

    }
}
