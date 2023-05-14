using TemperatureConverter;
using System.Reflection;

namespace ConverterToCelcium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TempConverter tempConverter = new();
            Type type = typeof(TempConverter);
            MethodInfo convertMethod = type.GetMethod("ToFarenheit", BindingFlags.Instance | BindingFlags.NonPublic);

            Console.WriteLine("Введите значение температуры по шкале Цельсия:");
            float temp = float.Parse(Console.ReadLine());

            var farenheitTemp = convertMethod.Invoke(tempConverter, new object[] {temp} );
            Console.WriteLine($"Значение температуры по шкале Фаренгейта: {farenheitTemp}");
        }      
    }
}