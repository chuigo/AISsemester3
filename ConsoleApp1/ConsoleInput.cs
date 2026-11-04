using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// Содержит методы, которые блокируют дальнейшую работу с приложением, пока не будет введено верное значение
    /// </summary>
    public class ConsoleInput
    {
        /// <summary>
        /// Запрашивает у пользователя целое число в заданном диапазоне
        /// </summary>
        /// <param name="min">Минимальное число</param>
        /// <param name="max">Максимальное число</param>
        /// <returns>Введенное корректное число</returns>
        public static int IntCheck(int min, int max)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (InputValidation.TryParseInt(input, out int result) && InputValidation.IsIntInRange(result, min, max))
                {
                    return result;
                }
                Console.WriteLine($"Введенное значение должно быть числом в диапазоне от {min} до {max}:");
                
            }
        }
        /// <summary>
        /// Запрашивает у пользователя целое число
        /// </summary>
        /// <returns>Введенное корректное число</returns>
        public static int IntCheck()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (InputValidation.TryParseInt(input,out int result))
                {
                    return result;
                }
                Console.WriteLine("Введенное значение должно быть числом");
            }
        }
        /// <summary>
        /// Запрашивает у пользователя целое число или пустую строку
        /// </summary>
        /// <returns>Введенное число или null</returns>
        public static int? IntCheckOrNull()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) return null;
                if (InputValidation.TryParseInt(input, out var value)) return value;

                Console.WriteLine("Введенное значение должно быть числом или пустой строкой:");
            }

        }

        /// <summary>
        /// Запрашивает у пользователя значение 1, 2 или пустую строку
        /// </summary>
        /// <returns>Введенное булевое значение или null</returns>
        public static bool? BoolCheckOrNull()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (InputValidation.TryParseBool(input, out var result))
                    return result;

                Console.WriteLine("Введите 1, 2 или Enter:");
            }
        }
    }
}
