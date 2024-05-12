namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = One.MyIntStack();
            Console.WriteLine("The array values are:");
            for (int i =0; i < test.Length; i++)
            {
                if (test[i] != 0)
                {
                    Console.WriteLine(test[i]);
                }
            }
        }
    }
}
