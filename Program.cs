using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Metrics;

namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of days you want to simulate:");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 30);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            // double averageTemp = CalculateAverage(temperature);
            // The above comment is an example that you can use the method "CalculateAverage" inside the Main Method

            Console.WriteLine($"The average temperature is: {CalculateAverage(temperature)}");
            Console.WriteLine($"The max temp was: {temperature.Max()}");
            Console.WriteLine($"The min temp was: {temperature.Min()}");
            //Console.WriteLine($"The min temp was: {MinTemperature(temperature)}");
            Console.WriteLine($"The most common condition was: {MostCommonCondition(weather)}");
            
            Console.ReadKey();
        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {   // 1st Iteration "Sunny"
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[i] == conditions[j])
                    {
                        tempCount++;
                    }
                    if (tempCount > count)
                    {
                        count = tempCount;
                        mostCommon = conditions[i]; 
                    }
                }
            }
            return mostCommon;
        }


        static double CalculateAverage(int[] temperature)
        {
            double sum = 0;

            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }

            //  foreach (int i in temperature)
            //  {
            //      sum += i;
            //  }

            // temperature.Length is the amount of items inside of temperature
            double average = sum / temperature.Length;
            return average;
        }

        static int MinTemperature(int[] temperature) // How to manually calculate the minimum temperature yourself
        {
            int min = temperature[0];
            foreach (int temp in temperature)
            {
                if (temp < min)
                    min = temp;
            }
            return min;
        }

    }
}
