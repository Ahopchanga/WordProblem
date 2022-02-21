using System;
namespace Reduction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа має рахувати кількість редукцій у набраному слові,
            //що може скаладатися з літер a, A, b, та B
            Console.WriteLine("If element a has inverse A and element b has inverse B");
            Console.WriteLine("enter a word which can consist of letters a, A, b, B");
            Console.WriteLine("For example: AaBb");
            var word = Console.ReadLine();
            var array = word.ToCharArray();

            List<char> list = new List<char>(array);
            var count = 0;

            //Для кожної літери слова, починаючи з першої
            for (int i = 0; i < list.Count; i++)
            {
                var indicator = false;

                //Визначаємо конкатенацію цієї літери із наступною
                var pair = list[i].ToString() + list[i + 1].ToString();

                //Якщо конкатенація дає aA, Aa, bB або Bb
                if (pair == "aA" ||
                    pair == "Aa" ||
                    pair == "bB" ||
                    pair == "Bb")
                {
                    //Сповіщаємо про це змінну indicator
                    indicator =  true;
                }

                //Якщо індикатор має значення true
                if (indicator)
                {
                    //То маємо редукцію, додаємо одиничку до змінної count, тобто записуємо, що отримали одну редукцію
                    count++;

                    //та рухаємося не до наступної правої літери, а через одну
                    i++;
                }
            }

            Console.WriteLine($"Amount of reductions is {count}");
            Console.ReadLine();
        }
    }
}