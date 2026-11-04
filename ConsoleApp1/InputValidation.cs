using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /// <summary>
    /// СОдержит методы для валидации строковых данных
    /// </summary>
    public class InputValidation
    {
        /// <summary>
        /// Пытается преобразовать строку в число
        /// </summary>
        /// <param name="input">строка ввода</param>
        /// <param name="result">результат</param>
        /// <returns>true если строка является числом, иначе false</returns>
        public static bool TryParseInt(string input, out int result)
        {
            return int.TryParse(input, out result);
        }
        /// <summary>
        /// Пытается преобразовать строку в булевое значение
        /// </summary>
        /// <param name="input">строка ввода</param>
        /// <param name="result">результат</param>
        /// <returns>true если строка является 1,2, иначе false</returns>
        public static bool TryParseBool(string input, out bool? result)
        {
            result = null;
            if (string.IsNullOrWhiteSpace(input)) return true;
            if (input == "1")
            {
                result = false; 
                return true;
            }
            if ( input=="2" )
            {
                result = true; 
                return true;
                
            }
            return false;
        }

        /// <summary>
        /// Проверяет, находится ли число в заданном диапазоне
        /// </summary>
        /// <param name="value">введенное число</param>
        /// <param name="min">минимальное значение</param>
        /// <param name="max">максимальное значение</param>
        /// <returns>true, если число в диапазоне, иначе false</returns>
        public static bool IsIntInRange(int value, int min, int max)
        {
            return value >= min && value <= max;
        }
    }
}
