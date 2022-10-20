namespace Pr__7._n1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            Console.WriteLine("x - трехзначное число");
            Console.Write("x= ");
            x = Convert.ToInt32(Console.ReadLine());
            y = x / 100 * 100 + x % 10 * 10 + x % 100 / 10;
            Console.WriteLine("{0}",y);
        } 
    }
}