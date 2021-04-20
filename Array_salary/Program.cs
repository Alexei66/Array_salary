using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] income = new int[12];
            int[] expenses = new int[12];
            int[] profit = new int[12];

            Console.Write("\nМесяц: Доход: Расход: Прибыль:");
            for (int i = 0; i < income.Length; i++)
            {
                income[i] = random.Next(1, 11);
                expenses[i] = random.Next(1, 11);
                profit[i] = income[i] - expenses[i];

                Console.Write($"\n{i + 1,3}{income[i] * 100,8}{expenses[i] * 100,8}{profit[i] * 100,8} ");

            }
            Console.WriteLine();

            int[] copy = new int[12];

            Array.Copy(profit, copy, profit.Length);

            Array.Sort(copy);

            int[] unique_element = copy.Distinct().ToArray();   //создаем массив с уникальными элементами массива "copy"


            //int result = Array.FindIndex(profit, i => i == unique_element[0]); 
            //int result1 = Array.FindIndex(profit, i => i == unique_element[1]);
            //int result2 = Array.FindIndex(profit, i => i == unique_element[2]);
            //Console.WriteLine(result);

            
            Console.WriteLine("\nХудшая прибыль в месяцах:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < profit.Length; j++)
                {
                    if (profit[j] == unique_element[i])
                    {
                        Console.Write(j + "   ");
                    }                  
                }
            }
            Console.WriteLine($"\n {unique_element[0] * 100,3} {unique_element[1] * 100,3} {unique_element[2] * 100,3}");

            int count = 0;
            for (int y = 0; y < copy.Length; y++)
            {                    
               if (copy[y] > 0) count++;    
               
            }
            Console.WriteLine("\nМесяцев с положительной прибылью: " + count);

           
            Console.WriteLine();


        }
    }
}
