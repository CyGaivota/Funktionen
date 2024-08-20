namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5 };
            string[] persons = { "Atifa", "Nadja", "Maren" };
            int[] arr2 = new int[3];
            Console.WriteLine(persons[1]);
            Console.WriteLine(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                if (arr[i] == 2)
                {
                    break;
                }
                Console.WriteLine(arr[i]);
            }
            foreach (string person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
