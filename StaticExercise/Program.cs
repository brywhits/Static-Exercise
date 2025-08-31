namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var calcius = TempConverter.FahrenheitToCelcius(68);
            
            var farhenheit = TempConverter.CelciusToFahrenheit(20);
            
            Console.WriteLine($"Celecius = {calcius}.");
            Console.WriteLine($"Farhenheit = {farhenheit}.");
            
            
        }
    }
}
