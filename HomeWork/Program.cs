using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson1_pw223
{
    class Program
    {
        static void startQuiz()
        {
            WriteLine();
            string[] questions =
            {
                "Зимой и летом одним цветом?",
                "Самая высокая гора?",
                "Самая длинная река?",
                "Самый большой океан?",
                "Самая большая планета?"
            };
            string[] answers1 =
            {
                "ёлка",
                "эверест",
                "амазонка",
                "тихий",
                "юпитер"
            };
            string[] answers2 =
            {
                "елка",
                "everest",
                "amazonka",
                "тихий океан",
                "jupiter"
            };
            string userAnswer;
            int counterOfRightAnswers = 0;

            for (int i = 0; i < questions.Length; i++)
            {
                WriteLine(questions[i]);
                userAnswer = ReadLine();
                if (userAnswer == answers1[i])
                {
                    WriteLine("Ответ верный!");
                    counterOfRightAnswers++;
                }
                else if (userAnswer == answers2[i])
                {
                    WriteLine("Ответ верный!");
                    counterOfRightAnswers++;
                }
                else
                {
                    WriteLine($"Ответ неверный!\nПодсказка. В слове {answers1[i].Length} букв");

                }
            }

            WriteLine("Правильных ответов: " + counterOfRightAnswers);
            if (counterOfRightAnswers < 3) { WriteLine($"Вы не справились даже с половыной. Ваша оценка 2"); }
            else if (counterOfRightAnswers == 3) { WriteLine($"Ваша оценка 3"); }
            else if (counterOfRightAnswers == 4) { WriteLine($"Ваша оценка 4"); }
            else if (counterOfRightAnswers == 5) { WriteLine($"Вы ответили на все вопросы! Ваша оценка 5"); }
            WriteLine("Если хотите попробовать ещё раз нажмите Enter");
            WriteLine("Если хотите выйти в меню нажмите Space");
            if (ReadKey().Key == ConsoleKey.Enter) startQuiz();
            else menu();
        }

        static void guessNumber()
        {
            WriteLine();
            Random rand = new Random();
            int magicNumber = rand.Next(0, 100);
            int userNumber = 0;
            int count = 0;
            int attempts = 5;

            do
            {
                Write("Введи число: ");
                userNumber = Int32.Parse(ReadLine());
                count++;
                if (attempts == 0)
                {
                    WriteLine("У тебя закончились попытки.");
                    WriteLine("Если хотите попробовать ещё раз нажмите Enter");
                    WriteLine("Если хотите выйти в меню нажмите Space");
                    if (ReadKey().Key == ConsoleKey.Enter) guessNumber();
                    else menu();
                }
                else if (userNumber < magicNumber)
                {
                    WriteLine("Загаданное число больше!");
                    WriteLine($"Осталось {attempts--} попыток");
                }
                else if (userNumber > magicNumber)
                {
                    WriteLine("Загаданное число меньше!");
                    WriteLine($"Осталось {attempts--} попыток");
                }
                else if (userNumber == magicNumber)
                {
                    WriteLine("Ты угадал! Тебе понадобилось " + count + " попыток");
                    break;
                }
            } while (userNumber != magicNumber);
        }

        static void menu()
        {
            WriteLine();
            WriteLine("Нажмите 1 чтобы сыграть в Викторину\n" +
                "Нажмите 2 чтобы сыграть в Угадай число");
            ConsoleKeyInfo PressedKey = ReadKey();
            if (PressedKey.KeyChar == '1') startQuiz();
            else if (PressedKey.KeyChar == '2') guessNumber();
        }

        static void Main(string[] args)
        {
            menu();
        }
    }
}