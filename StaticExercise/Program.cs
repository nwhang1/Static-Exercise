namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 100.1;
            double celsiusConverted = TempConverter.FahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{fahrenheit} Fahrenheit is equal to {celsiusConverted} Celsius");

            double celsius = 100.09;
            double fahrenheitConverted = TempConverter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius} Celsius is equal to {fahrenheitConverted} Fahrenheit");
        }
    }
}
