using System;
using System.Collections.Generic;
using System.Text;

namespace BuisnessLogic
{
    /// <summary>
    /// Хранит список со всеми категориями роста
    /// </summary>
    public class HeightCategories
    {
        public const int MinHeight = 90;
        public const int MiddleHeight = 110;
        public const int HighHeight = 125;
        public const int MaxHeight = 140;
        public static readonly List<HeightCategory> categories = new List<HeightCategory>
    {
        new("Низкий",   MinHeight,   MiddleHeight),
        new("Средний",  MiddleHeight, HighHeight),
        new("Высокий",  HighHeight,  MaxHeight+1)
    };
    }
}
