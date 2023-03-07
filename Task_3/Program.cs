using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_3
{
        public abstract class Device
        {
            string _show;
            string _description;
        string _sound;
            public Device(string name, string description, string sound)
            {
                _show = name;
                _description = description;
                _sound = sound;
            }
            public void Print()
            {
                WriteLine($"Название: {_show}\nОписание: {_description}");
                Write($"Какой звук издает предмет: ");
                _sound = ReadLine();
                WriteLine();
            }
        }
        class Teapot : Device
        {
            public Teapot(string name, string description, string sound) : base(name, description, sound)
            {
                Print();
            }
        }
    class Microwave_oven : Device
    {
        public Microwave_oven(string name, string description, string sound) : base(name, description, sound)
        {
            Print();
        }
    }
    class Car : Device
    {
        public Car(string name, string description, string sound) : base(name, description, sound)
        {
            Print();
        }
    }
    class Steamboat : Device
    {
        public Steamboat(string name, string description, string sound) : base(name, description, sound)
        {
            Print();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Device teapot = new Teapot("Чайник", "Полое изделие (сосуд), предназначенное для кипячения воды.", null);

            Device microwave_oven = new Microwave_oven("Мткроволновка", "электроприбор, позволяющий совершать разогрев водосодержащих веществ благодаря электромагнитному излучению.", null);

            Device car = new Car("Машина", "моторное безрельсовое дорожное и/или внедорожное, чаще всего автономное, транспортное средство, используемое для перевозки людей и/или грузов, имеющее от четырёх колёс.", null);

            Device steamboat = new Steamboat("Пароход", "судно, оснащённое поршневой паровой машиной или паровой турбиной в качестве тягового двигателя.", null);
        }
    }
}
