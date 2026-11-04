using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BuisnessLogic
{
    /// <summary>
    /// Описывает категорию роста миньона
    /// </summary>
    public class HeightCategory
    {
        public string Name { get; }
        public int MinHeight { get; }
        public int MaxHeight { get; }

        public HeightCategory(string name, int minHeight, int maxHeight)
        {
            Name = name;
            MinHeight = minHeight;
            MaxHeight = maxHeight;
        }

        /// <summary>
        /// Проверяет, попадает ли рост в категорию
        /// </summary>
        /// <param name="height">рост миньона</param>
        /// <returns>true если в диапазоне</returns>
        public bool IsMatch(int height)
        {
            return height >= MinHeight && height < MaxHeight;
        }

    }
}
