using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Dronov_IS_21_2
{
    public class Weapon
    {
        public string Name;// Название оружия
        public string Type_Weapon;// Тип оружия
        public int lvl;// Уровень оружия
        public int Damage;// Урон оружия

        // Конструктор для создания объекта оружия с заданными параметрами
        public Weapon(string Name, string Type_Weapon, int lvl, int Damage)
        {
            this.Name = Name;
            this.Type_Weapon = Type_Weapon;
            this.lvl = lvl;
            this.Damage = Damage;
        }
        // Перегрузка оператора + для объединения двух оружий
        public static Weapon operator +(Weapon w1, Weapon w2)
        {
            if (w1.lvl > w2.lvl)
            {
                return new Weapon(w1.Name + "+", w1.Type_Weapon, w1.lvl + w2.lvl, w1.Damage + w2.Damage);
            }
            else if (w1.lvl < w2.lvl)
            {
                return new Weapon(w2.Name + "+", w1.Type_Weapon, w1.lvl + w2.lvl, w1.Damage + w2.Damage);
            }
            else
            {
                return new Weapon(w1.Name + "+", w1.Type_Weapon, w1.lvl + 1, w1.Damage + w2.Damage);
            }
        }
    }
}
