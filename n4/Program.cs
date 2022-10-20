namespace n4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1; double y, z, t;
            y = Math.Sqrt(Math.Abs(Math.Pow(Math.Cos(x), 2))); //1-sin^2(x) = cos^2(x)
            z = Math.Cos((2* Math.PI)/3);
            t = Math.Pow(Math.E, 4* Math.Sqrt(x));
            Console.WriteLine($"y= {Math.Pow(x, 2) - (y / z) * t}");
        }
    }
}