using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Metrics;

namespace WeatherStationSimulator
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of days you want to forecast:");
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

            Console.WriteLine($"The average temperature is coming out as {CalculateAverage(temperature)}");
            Console.ReadKey();
        }

        static double CalculateAverage(int[] temperature)
        {
            double sum = 0;

            for (int i = 0; i < temperature.Length; i++)
            {
                sum += temperature[i];
            }

            //foreach (int i in temperature)
            //{
            //    sum += i;
            //}


            // temperatuer.Length is the amount of items inside of temperature
            double average = sum / temperature.Length;
            Console.WriteLine("Average is supposed to be " + average);

            return average;
        }

    }
}
