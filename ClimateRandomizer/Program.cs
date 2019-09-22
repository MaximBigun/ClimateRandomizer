using System;
using System.IO;

namespace ClimateRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I'm climate randomizer =)");
            Random rand = new Random();
            int temperature = 20;
            int pressure = 742;
            int humidity = 50;
            int illuminance = 300;
            while (true)
            {
                temperature = rand.Next(temperature - 1 > 17 ? temperature - 1 : 17, temperature + 1 < 24 ? temperature + 3 : 24);
                pressure = rand.Next(pressure - 1 > 741 ? pressure - 1 : 741, pressure + 1 < 745 ? pressure + 3 : 745);
                humidity = rand.Next(humidity - 2 > 30 ? humidity - 2 : 30, humidity + 2 < 60 ? humidity + 3 : 60);
                illuminance = rand.Next(illuminance - 2 > 210 ? illuminance - 2 : 210, illuminance + 2 < 440 ? illuminance + 3 : 440);
                using (StreamWriter sw = new StreamWriter(DateTime.Now.Date.ToString("yyyy-MM-dd") + ".txt", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + " " + temperature + " " + pressure + " " + humidity + " " + illuminance);
                }
                System.Threading.Thread.Sleep(1000 * 60 * 10);
            }
        }
    }
}
