namespace WeatherSimulationProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weather Simulation Project");
            Console.WriteLine("Enter a number of days to simulate Weather");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }
            //Getting Max Value from array
            //temperature.Max();
            //getting min value from array
            //temperature.Min();

            Console.WriteLine($"Average temperature is: {CalculateAverage(temperature)}");
            Console.WriteLine($"The max temperature was: {temperature.Max()}");
            Console.WriteLine($"The min temeperatur was: {temperature.Min()}");
            Console.WriteLine($"Most common condition is: {MostCommonCondition(weatherConditions)}");


            Console.ReadKey();

        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i =0; i <conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++) { 
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                }
                if(tempCount > count)
                {
                    count = tempCount;
                    mostCommon = conditions[i];
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

            double average = sum / temperature.Length;

            return average;
        }


        //Min and Max value using own Method

        static int MinTemperature(int[] temperature)
        {
            int min = temperature[0];

            foreach (int temp in temperature)
            {
                if (temp < min)
                {
                    min = temp;
                }
            }
            return min;
        }

    }
}
