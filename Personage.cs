using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Dronov_IS_21_2
{
    public class Personage
    {
        public Weapon Weapon;
        public string Name; // Имя персонажа
        public int lvl; // Уровень персонажа
        public int Strength; // Сила персонажа
        public int Dexterity; // Ловкость персонажа
        public int Intellect; // Интеллект персонажа

        // Конструктор для создания объекта персонажа с заданными параметрами
        public Personage(string Name, Weapon Weapon, int lvl, int Strength, int Dexterity, int Intellect)
        {
            this.Name = Name;
            this.Weapon = Weapon;
            this.lvl = lvl;
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Intellect = Intellect;
        }

        // Статический метод для вычисления силы персонажа
        public static double Power(int Strength, int Dexterity, int Intellect, int lvl, int lvlWeapon, int Damage)
        {
            double power = (Strength + Dexterity + Intellect) * lvl + lvlWeapon * Damage;
            return power;
        }

        // Статический метод для определения звания персонажа на основе его силы
        public static string Title(double power, string weapon)
        {
            string title = " ";
            if (weapon == "Меч")
            {
                if (power < 50)
                {
                    title = "Просто мечник";
                }
                else if (power > 50 && power < 100)
                {
                    title = "Хороший мечник";
                }
                else if (power > 100 && power < 200)
                {
                    title = "Отличный мечник";
                }
                else if (power > 200 && power < 400)
                {
                    title = "Великолепный мечник";
                }
                else if (power > 400)
                {
                    title = "Безупречный мечник";
                }
            }
            else if (weapon == "Клинки")
            {
                if (power < 50)
                {
                    title = "Кадет";
                }
                else if (power > 50 && power < 100)
                {
                    title = "Рядовой";
                }
                else if (power > 100 && power < 200)
                {
                    title = "Ефрейтор";
                }
                else if (power > 200 && power < 400)
                {
                    title = "Младший капрал";
                }
                else if (power > 400)
                {
                    title = "Капрал";
                }
            }
            else if (weapon == "Щит")
            {
                if (power < 50)
                {
                    title = "Просто щитоносец";
                }
                else if (power > 50 && power < 100)
                {
                    title = "Хороший щитоносец";
                }
                else if (power > 100 && power < 200)
                {
                    title = "Отличный щитоносец";
                }
                else if (power > 200 && power < 400)
                {
                    title = "Великолепный щитоносец";
                }
                else if (power > 400)
                {
                    title = "Безупречный щитоносец";
                }
            }
            else if (weapon == "Лук")
            {
                if (power < 50)
                {
                    title = "Просто лучник";
                }
                else if (power > 50 && power < 100)
                {
                    title = "Хороший лучник";
                }
                else if (power > 100 && power < 200)
                {
                    title = "Отличный лучник";
                }
                else if (power > 200 && power < 400)
                {
                    title = "Великолепный лучник";
                }
                else if (power > 400)
                {
                    title = "Безупречный лучник";
                }
            }
            return title;
        }
    }
}
