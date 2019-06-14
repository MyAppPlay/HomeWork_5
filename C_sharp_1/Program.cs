using System;
using System.Text.RegularExpressions;
//Гаврилов Владимир
namespace C_sharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
            //а) без использования регулярных выражений;
            //б) **с использованием регулярных выражений.


            string login = "логин";
            bool correct = false;

            while (correct == false)
            {
                Console.WriteLine("Введите логин");

                login = Console.ReadLine();
                // Проверка на длину
                if (login.Length < 2 || login.Length > 10)
                {

                    Console.WriteLine("Некорректный логин");
                    break;
                }

                // Проверка первого символа на цифру
                else if (char.IsDigit(login[0]))
                {
                    Console.WriteLine("Некорректный логин");
                    break;
                }


                for (int i = 0; i < login.Length; i++) // прверка являются ли символы цифрой или буквой
                {
                    if (!char.IsLetterOrDigit(login[i]))
                    {
                        Console.WriteLine("Некорректный логин");
                        break;
                    }
                   // как сделать проверку, введены ли символы кирилицей?(без использования регулярных выражений)
                }
            Regex regex = new Regex("[a-zA-Z][a-zA-Z0-9]{0,7}");
            Console.WriteLine (regex.IsMatch(login)+" Если ввести некорректный логин, работа программы завершится");
            }



            Console.WriteLine(login);

            Console.ReadKey();
        }
    }
}

