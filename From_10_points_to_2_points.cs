namespace Attempt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            int deci = int.Parse(Console.ReadLine());

            List<int> binaryDigits = new List<int>();

            if (deci == 0)
            {
                binaryDigits.Add(0);
            }
            else
            {
                while (deci > 0)
                {
                    binaryDigits.Add(deci % 2);
                    deci /= 2;
                }
            }

            Console.Write("Binary representation: ");
            for (int i = binaryDigits.Count - 1; i >= 0; i--)
            {
                Console.Write(binaryDigits[i]);
            }
            Console.WriteLine(); ;
        }
    }
}
