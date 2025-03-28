using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_калькулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите оператор (+, -, *, /): ");
                    char op = Convert.ToChar(Console.ReadLine());

                    Console.Write("Введите второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;

                    switch (op)
                    {
                        case '+':
                            result = num1 + num2;
                            break;
                        case '-':
                            result = num1 - num2;
                            break;
                        case '*':
                            result = num1 * num2;
                            break;
                        case '/':
                            if (num2 == 0)
                            {
                                Console.WriteLine("Ошибка: деление на ноль!");
                                continue;
                            }
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Неверный оператор!");
                            continue;
                    }

                    Console.WriteLine($"Результат: {num1} {op} {num2} = {result}\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введены некорректные данные!\n");
                }

                Console.Write("Хотите продолжить? ");

            }
        }
    }
}
