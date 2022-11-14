namespace ejemplo2_11
{
    public class program
    {
        static void Main(string[] args)
        {
            double alto, ancho, largo, pago, precio_por_m3;
            double volumen_en_m3;
            Console.Write("Ingresa el valor de alto en m: ");
            alto = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de ancho en m: ");
            ancho = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de largo en m: ");
            largo = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de precio por m3: ");
            precio_por_m3 = double.Parse(Console.ReadLine());
            volumen_en_m3 = alto * largo * ancho;
            pago = volumen_en_m3 * precio_por_m3;
            Console.WriteLine("Valor del pago: " + pago);
            Console.WriteLine("Valor del volumen en m3: " + volumen_en_m3);
            Console.WriteLine();
        }
    }
}
