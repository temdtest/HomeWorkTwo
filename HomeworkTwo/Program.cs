using System;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;

namespace HomeworkTwo
{
    class Program
    {
        // TASK: Three parameters: Nominal of the transaction, Trade price, Transaction Type (Buy, sell), Sign (1 for buy, -1 for sell)
        enum Transactiontype
        {
            Buy = 1,
            Sell = -1
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the amount of securities you would like to trade: ");
            string userInput = Console.ReadLine();
            int nominal = Int32.Parse(userInput);

            Console.WriteLine("\nPlease enter the trade price: ");
            string tradeInput = Console.ReadLine();
            int tradePrice = Int32.Parse(tradeInput);

            Console.WriteLine("\nWould you like to buy or sell the securities?: ");
            Transactiontype trcType;
            userInput = Console.ReadLine();
            trcType = (Transactiontype) Enum.Parse(typeof(Transactiontype), userInput,true);

            switch (trcType)
            {
                case Transactiontype.Buy:
                    var currentValue = (int)trcType * nominal * tradePrice;
                    Console.WriteLine($"\nThe current value based on your wish to {trcType} is {currentValue}");
                    break;
                
                case Transactiontype.Sell:
                    Console.WriteLine("\nPlease input the original purchase price of the security: ");
                    string originalInput = Console.ReadLine();
                    int originalPrice = Int32.Parse(originalInput);
                    var profitAndLoss = (tradePrice - originalPrice) * nominal;
                    Console.WriteLine(profitAndLoss == 0
                        ? $"\nThe P/L is {profitAndLoss} for the chosen security"
                        : $"\nBased on your wish to {trcType} the P/L has been calculated to: {profitAndLoss}");
                    break;
                
            }
            Console.ReadKey();
        }
    }
}
