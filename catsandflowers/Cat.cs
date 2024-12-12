using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace catsandflowers
{
    public abstract class Cat
    {
        public abstract int Id { get; set; }
        public abstract string Type { get; set; } //Тип выполняемой работы котом 
        public abstract string SkillLevel { get; set; } //Уровень квалификации
        public abstract int Price { get; set; }
        public abstract int WorkSpeed { get; set; } //Скорость
        public abstract int QuantityBoost { get; set; } //Количество

        public abstract void GetInfo();
    }
}
