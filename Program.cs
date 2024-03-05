using System.Linq;

namespace ConsoleApp22 {
    internal class Program {
        static void Main(string[] args) {
            string text = Console.ReadLine();
            char[] array = new char[text.Length];
            double sum = 0;

            for (int i = 0; i < array.Length; i++) {
                array[i] = text[i];
                Console.WriteLine(array[i]);
            }

            int useIndex = array.Length;
            for (int i = 0; i < array.Length; i++) {
                useIndex --;
                sum += Math.Pow(16, useIndex) * array[i];
            }
            Console.WriteLine(sum);



        }
    }
}