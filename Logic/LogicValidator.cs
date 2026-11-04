using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogic
{
    /// <summary>
    /// содержит методы для валидации данных миньона
    /// </summary>
    public class LogicValidator
    {
        /// <summary>
        /// проверяет, что имя не пустое и не состоит из пробелов
        /// </summary>
        /// <param name="name">имя</param>
        /// <exception cref="ArgumentException">если имя пустое</exception>
        public static void NameValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Имя не может быть пустым");
        }

        /// <summary>
        /// проверяет, что рост находится в допустимом диапазоне
        /// </summary>
        /// <param name="height">рост</param>
        /// <exception cref="ArgumentException">если рост не в диапазоне</exception>
        public static void HeightValid(int height)
        {
            if (height < HeightCategories.MinHeight || height > HeightCategories.MaxHeight)
                throw new ArgumentException($"Рост должен быть в диапазоне от {HeightCategories.MinHeight} до {HeightCategories.MaxHeight}");
        }
    }
}
