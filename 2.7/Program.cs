namespace Ejercicio2_7
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Digite la cantidad de litros de leche ");
            double litros, galon;
            double preciogal;
            double pagafinal;
            litros = Convert.ToDouble(Console.ReadLine());
            galon = litros / 3.785;
            Console.WriteLine("La cantidad de galones de leche es:{0} ", galon);
            Console.WriteLine("Precio del galon de leche");
            preciogal = Convert.ToDouble(Console.ReadLine());
            pagafinal = galon * preciogal;
            Console.WriteLine("El precio a pagar es: {0}", pagafinal);
        }
    }
}

