using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace test_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Girls gr = new Girls(); // Экземпляр класса Girls 
            int number;

            do      // Проверям ввели строку или число ,если строку выкидываем сообщение об ошибке 
            {

                try
                {
                    Console.WriteLine("Enter The Number of athletes :");
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not string,only number!");
                }
            }
            while (true);

            
            
            for (int i = 0; i < number; i++) // Повторям метод количество раз которое ввел пользователь 
            {
                gr.GirlsPerformance();
            }
            }
    }



   
    
    class Girls {

        public void GirlsPerformance() {

            Console.WriteLine("Enter the Name");
            string str = Console.ReadLine();

            Random random = new Random(); // переменная класса Random 
            
            int[] refereePoints = { random.Next(0, 6), random.Next(0, 6), random.Next(0, 6) }; // массив случайных оценок суддей 
            Console.WriteLine("Points for " + str);
            for (int i = 0; i < refereePoints.Length; i++)
            {
                int refsNumber = 1+i;
                Console.WriteLine($"Referee {refsNumber} give : "+refereePoints[i]+" points");
            }

            Console.WriteLine("Average point is : " + Math.Round(refereePoints.Average()));

        }



    }
   
}
