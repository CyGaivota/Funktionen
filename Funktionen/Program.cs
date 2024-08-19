namespace Funktionen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5; 
            int b = 8;
            int ggT = MyMath.Calc_ggT(a, b);
            int kgV = MyMath.Calc_kgV(a, b);
            Console.WriteLine(ggT);
            Console.WriteLine(kgV);
        }
    }
}
