 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Миньон
    /// </summary>
    public class Minion
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public bool HasTwoEyes { get; set; }   
        public Minion(int id, string name, int height, bool hastwoeyes)
        {
            ID = id;
            Name = name;
            Height = height;
            HasTwoEyes = hastwoeyes;
        }
        public override string ToString()
        {
            return $"{ID} - {Name}, рост: {Height}, количество глаз: {(HasTwoEyes ? 2 : 1)}";
        }
    }
}
