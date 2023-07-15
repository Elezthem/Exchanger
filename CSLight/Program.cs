using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rubleshInWallet;
            float dollarInWellet;

            int rubToUsd = 64, usdToRub = 66;

            float exchangeCurrencyCount;

            string desiredOperation;

            Console.WriteLine("Добро пожаловать в обменник валют!");

            Console.Write("Введите баланс рублей: ");
            rubleshInWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс доллара: ");
            dollarInWellet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите необходимую операцию.");
            Console.WriteLine("1 - обменять рубли на доллары");
            Console.WriteLine("2 - обменять доллары на рубли");
            Console.Write("Ваш выбор: ");
            desiredOperation = Console.ReadLine();

            switch (desiredOperation)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары");
                    Console.Write("Сколько вы хотите обменять?");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rubleshInWallet >= exchangeCurrencyCount)
                    {
                        rubleshInWallet -= exchangeCurrencyCount;
                        dollarInWellet += exchangeCurrencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество рублей.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен долларов на рубли");
                    Console.Write("Сколько вы хотите обменять? ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollarInWellet >= exchangeCurrencyCount)
                    {
                        dollarInWellet -= exchangeCurrencyCount;
                        rubleshInWallet += exchangeCurrencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимое количество долларов!");
                    }
                    break;
                default:
                    Console.WriteLine("Выбрана неверная форма операции");
                    break;
            }

            Console.WriteLine($"Ваш баланс: {rubleshInWallet} рублей, " + $" {dollarInWellet} долларов.");
        }
    }
}
