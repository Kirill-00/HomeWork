using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TASK_2
{
    class Website
    {
        public string _website_name;
        public string _link;
        public string _description;
        public string _ip;

        public Website(string website_name, string link, string description, string ip)
        {
            _website_name = website_name;
            _link = link;
            _description = description;
            _ip = ip;
        }
        public virtual void Print()
        {
            WriteLine($"Название сайта: {_website_name}\nПути к сайту: {_link}\nОписание: {_description}\nIP: {_ip}");
        }
    }
    internal class Program
    {
        static void palindrome()
        {
            Write("Введите чмсло: ");
            string a = Convert.ToString(ReadLine());
            string b = new string(a.Reverse().ToArray());
            WriteLine(b == a ? "Это палиндром" : "Это не палиндром");
        }
        static void filter()
        {
            WriteLine("Введите строку:");
            string[] arr = ReadLine().Split();
            WriteLine("Введите символы которые хотите удалить из строки:");
            string[] brr = ReadLine().Split();
            arr = arr.Except(new string[] { "brr" }).ToArray();
            WriteLine(String.Join("", arr));
        }

        static void Main(string[] args)
        {
            //palindrome();
            //filter();
            Website website = new Website("Youtube", "https://www.youtube.com", "Видеохостинг, предоставляющий пользователям услуги хранения, доставки и показа видео", "142.250.185.174");
            website.Print();
        }
    }
}
