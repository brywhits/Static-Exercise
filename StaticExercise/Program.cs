namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.FahrenheitToCelsius(20);

            Console.WriteLine($"Celcius is: {celsius}!");
            Console.WriteLine($"Fahrenheit is: {fahrenheit}!");
        }
    }
}
