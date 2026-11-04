using System;
using System.Collections.Generic;
using System.Text;
using BuisnessLogic;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    /// <summary>
    /// Определяет, какие картинки соответствуют параметрам миньона
    /// </summary>
    public class ImageSelector
    {
        /// <summary>
        /// Возвращает изображение тела в зависимости от роста
        /// </summary>
        public static Image BodyImage(int height)
        {
            var category = HeightCategories.categories.FirstOrDefault(c => c.IsMatch(height));
            switch (category.Name)
            {
                case "Низкий": return Resources.Short;
                case "Средний": return Resources.Medium;
                case "Высокий": return Resources.High;
                default: return Resources.Short;
            }
        }
        /// <summary>
        /// Возвращает изображение глаз
        /// </summary>
        public static Image EyesImage(bool twoeyes)
        {
            if (twoeyes) { return Resources.TwoEyes; }
            return Resources.OneEye;
        }
    }
}
