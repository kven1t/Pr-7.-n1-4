namespace n3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, a, b, c;
            Console.Write("a= ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c= ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("r= ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"a = {r*r * (2 + Math.Cos(a + b - c))}");
        }
    }
}