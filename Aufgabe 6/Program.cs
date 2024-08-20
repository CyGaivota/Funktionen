namespace Aufgabe_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 8;
            int ggT = MyMath.Calc_ggT(a, b);
            int kgV = MyMath.Calc_kgV(a, b);
            ShowResult("ggT", a, b, ggT);
            ShowResult("kgV", a, b, kgV);
            Console.WriteLine(kgV);
            int eingabe = ReadInt();
            Console.WriteLine(eingabe);
        }
    }
}
