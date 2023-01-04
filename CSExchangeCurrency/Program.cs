using System;


namespace CSExchangeCurrency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float rublesInWallet;
            float dollarsInWallet;
            int rubToUsd = 64, usdToRub = 66;
            float exchangeCurrencyCount;
            string desiredOperation;

            Console.WriteLine("Добро пожаловать в обменник!");

            Console.Write("Введите баланс рублей: ");
            rublesInWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс доллара: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите необходимую операцию");
            Console.WriteLine("1 - обменять рубли на доллары");
            Console.WriteLine("2 - обменять доллары на рубли");
            desiredOperation = Console.ReadLine();

            switch (desiredOperation)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары.");
                    Console.Write("Сколько вы хотите обменять? ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (rublesInWallet >= exchangeCurrencyCount)
                    {
                        rublesInWallet -= exchangeCurrencyCount;
                        dollarsInWallet += exchangeCurrencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимая количество рублей!");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен на доллары.");
                    Console.Write("Сколько вы хотите обменять? ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollarsInWallet >= exchangeCurrencyCount)
                    {
                        dollarsInWallet -= exchangeCurrencyCount;
                        rublesInWallet += exchangeCurrencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопустимая количество долларов!");
                    }
                    break;
                default:
                    Console.WriteLine("Недопустимая операция!");
                    break;
            }


            Console.WriteLine($"Ваш баланс {rublesInWallet} рублей, {dollarsInWallet} долларов.");


        }
    }
}
