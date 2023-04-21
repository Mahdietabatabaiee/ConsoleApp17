namespace math2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter x : ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter y : ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(clculator(x, y));

        }
        private static double clculator(double x, double y)

        {
            return Math.Sqrt(Math.Abs(x)) + Math.Pow(y, 2);
        }
    }
}
