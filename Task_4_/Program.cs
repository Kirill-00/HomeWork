using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_
{
    internal class Program
    {
        class Journal
        {
            private string _journal_name;
            private string _year_of_foundation;
            private string _description;
            private string _phone_number;
            private string _email;
            private int _number_employees;

            public string journal_name
            {
                get { return _journal_name; }
                set { _journal_name = value; }
            }
            public string year_of_foundation
            {
                get { return _year_of_foundation; }
                set { _year_of_foundation = value; }
            }
            public string descriptio
            {
                get { return _description; }
                set { _description = value; }
            }
            public string phone_number
            {
                get { return _phone_number; }
                set { _phone_number = value; }
            }
            public string mail
            {
                get { return _email; }
                set { _email = value; }
            }
            public int number_employees
            {
                get { return _number_employees; }
                set { _number_employees = value; }
            }
            public Journal(string name, string year, string description, string number, string email, int n)
            {
                journal_name = name;
                year_of_foundation = year;
                descriptio = description;
                phone_number = number;
                mail = email;
                number_employees = n;
            }
            public override string ToString()
            {
                return $"Название журнала: {_journal_name}\nГод основания: {_year_of_foundation}\nОписание: {_description}\nКонтактный телефон: {_phone_number}\nКонтактный e-mail: {_email}\nКоличество сотрудников: {_number_employees}\n";
            }

            public static Journal operator +(Journal answer, int area)
            {
                answer.number_employees += area;
                return answer;
            }
            public static Journal operator -(Journal answer, int area)
            {
                answer.number_employees -= area;
                return answer;
            }
            public static bool operator ==(Journal left, Journal right)
            {
                return left.number_employees == right.number_employees;
            }
            public static bool operator !=(Journal left, Journal right)
            {
                return left.number_employees != right.number_employees;
            }
            public static bool operator <(Journal left, Journal right)
            {
                return left.number_employees < right.number_employees;
            }
            public static bool operator >(Journal left, Journal right)
            {
                return left.number_employees > right.number_employees;
            }
        }
        static void Main(string[] args)
        {
            Journal journal = new Journal("Gardener", "1999", "Что то на садоводском", "100 200 30 40", "https://github.com", 10);
            Console.WriteLine(journal);
            journal = journal + 20;
            Console.WriteLine(journal);
            journal -= 10;
            Console.WriteLine(journal);
            Journal journal1 = new Journal("Gardener", "1999", "Что то на садоводском", "100 200 30 40", "https://github.com", 50);
            Console.WriteLine(journal1);
            Console.WriteLine(journal);
            Console.WriteLine(journal == journal1);
            if (journal > journal1) Console.WriteLine("shop1>shop2"); 
            else Console.WriteLine("shop1<shop2");
            if (journal == journal1) Console.WriteLine("The shops is Equal!");
            else Console.WriteLine("Isn't Equal");
        }
    }
}