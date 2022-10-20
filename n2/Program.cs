namespace n2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, s, d, h;
            Console.WriteLine("a < b");
            Console.Write("a= ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("alfa большего основания: ");
            int alfa = Convert.ToInt32(Console.ReadLine());

            double tg = Math.Tan(alfa); 
            d = (b - a) / 2; 
            h = tg * d; 

            Console.WriteLine(d * h + a * h);
        }
    }
}