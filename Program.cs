namespace ConsoleApp30 {
    internal class Program {
        static void Main(string[] args) 
        {
            string comand1 = Console.ReadLine();
            string comand2 = Console.ReadLine();
            string comand3 = Console.ReadLine();


            string[] Char = { comand1,  comand2, comand3,}; ;

            for(int i = 0; i < Char.Length; i++) 
            {
                Console.WriteLine(Char[i]);
            }
        }
    }
}