using System;
namespace Reduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If element a has inverse A and element b has inverse B");
            Console.WriteLine("enter a word which can consist of letters a, A, b, B");
            Console.WriteLine("For example: AaBb");
            var word = Console.ReadLine();
            var array = word.ToCharArray();

            while (!WordIsCorrect(array))
            {
                Console.WriteLine("Error! You entered invalid word. Try again.");
                word = Console.ReadLine();
                array = word.ToCharArray();
            }

            List<char> list = new List<char>(array);
            var count = 0;

            //Для кожної літери, починаючи з першої
            for (int i = 0; i < list.Count; i++)
            {
                //Якщо наступна літера після даної є її інверсією
                if (IsAReduction(list, i))
                {
                    //То маємо редукцію, записуємо це у змінну count 
                    count++;

                    //та рухаємося не до наступної правої літери, а через одну
                    i++;
                }
            }

            Console.WriteLine($"Amount of reductions is {count}");
            Console.ReadLine();
        }

        public static bool IsAReduction(List<char> list, int i)
        {
            var pair = list[i].ToString() + list[i + 1].ToString();
            if (pair == "aA" ||
                pair == "Aa" ||
                pair == "bB" ||
                pair == "Bb")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool WordIsCorrect(char[] charArray)
        {
            var a = "a";
            var A = "A";
            var b = "b";
            var B = "B";

            foreach (var c in charArray)
            {
                var stringChar = c.ToString();
                if (stringChar != a &&
                    stringChar != A &&
                    stringChar != b &&
                    stringChar != B)
                {
                    return false;
                }
            }

            return true;
        }
    }
}