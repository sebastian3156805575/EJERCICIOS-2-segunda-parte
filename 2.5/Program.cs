namespace Ejercicio2_5
{
    class program
    {
        static void Main()
        {
            double A, B, C, A1, A2, AT;
            Console.WriteLine("Digite A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite C");
            C = Convert.ToInt32(Console.ReadLine());
            A1 = ((A - C) * B) / 2;
            A2 = B * C;
            AT = A1 + A2;
            Console.WriteLine("El area de su terreno es:{0}", AT);


        }

    }


}
