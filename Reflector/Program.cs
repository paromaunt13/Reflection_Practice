/*
Используя Visual Studio, создайте проект по шаблону Windows Forms Application.
Создайте программу-рефлектор, которая позволит получить информацию о сборке и
входящих в ее состав типах. Для основы можно использовать программу-рефлектор из
урока */

using System.Reflection;
using TemperatureConverter;

namespace Reflector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TempConverter tempConverter = new();
            Type type = tempConverter.GetType();

            GetMethodInfo(tempConverter);
            GetFieldInfo(tempConverter);
            GetInterfaceInfo(tempConverter);
            GetConstructorInfo(tempConverter);
            GetPropertyInfo(tempConverter);

        }
        static void GetMethodInfo(TempConverter tempConverter)
        {
            Type type = tempConverter.GetType();
            var methodInfo = type.GetMethods(
                      BindingFlags.Instance
                    | BindingFlags.Static
                    | BindingFlags.Public
                    | BindingFlags.NonPublic
                    | BindingFlags.DeclaredOnly);

            foreach (var method in methodInfo)
            {
                Console.WriteLine("Метод: " + method.Name);
            }
        }
        static void GetFieldInfo(TempConverter tempConverter)
        {
            Type type = tempConverter.GetType();
            var fieldsInfo =
              type.GetFields(
                    BindingFlags.Instance
                  | BindingFlags.Static
                  | BindingFlags.Public
                  | BindingFlags.NonPublic);

            foreach (var fieldInfo in fieldsInfo)
            {
                Console.WriteLine("Поле: " + fieldInfo.Name);
            }
        }
        public static void GetPropertyInfo(TempConverter tempConverter)
        {
            Type type = tempConverter.GetType();
            var propertyInfo = type.GetProperties();

            foreach (var property in propertyInfo)
            {
                Console.WriteLine("Свойство: " + property.Name);
            }
        }

        public static void GetInterfaceInfo(TempConverter tempConverter)
        {
            Type type = tempConverter.GetType();
            var interfaceInfo = type.GetInterfaces();

            foreach (var interfaceType in interfaceInfo)
            {
                Console.WriteLine("Интерфейс: " + interfaceType);
            }
        }

        public static void GetConstructorInfo(TempConverter tempConverter)
        {
            Type type = tempConverter.GetType();
            var constructorInfo = type.GetConstructors();

            foreach (var constructor in constructorInfo)
            {
                Console.WriteLine("Конструктор: " + constructor.Name);
            }
        }
    }
}