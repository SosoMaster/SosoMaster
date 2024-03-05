using System;

namespace Application {
    class Program {
        static void Main(string[] args) {
            char[] chars = Console.ReadLine().ToCharArray();
            int[] nums = new int[chars.Length];
            for (int i = 0; i < chars.Length; i++) {
                if (chars[i] == 'A') {
                    nums[i] = 10;
                }
                else if (chars[i] == 'B') {
                    nums[i] = 11;
                }
                else if (chars[i] == 'C') {
                    nums[i] = 12;
                }
                else if (chars[i] == 'D') {
                    nums[i] = 13;
                }
                else if (chars[i] == 'E') {
                    nums[i] = 14;
                }
                else if (chars[i] == 'F') {
                    nums[i] = 15;
                }
                else {
                    nums[i] = int.Parse(chars[i].ToString());
                }
            }
            double myNum = 0;
            for (int i = nums.Length - 1; i >= 0; i--) {
                myNum += nums[nums.Length - 1 - i] * Math.Pow(16, i);
            }
            Console.WriteLine(myNum);
        }
    }
}