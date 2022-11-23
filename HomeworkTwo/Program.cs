using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTwo
{
    class Program
    {
        /// TASK: Three parameters: Nominal of the transaction, Trade price, Transaction Type (Buy, sell), Sign (1 for buy, -1 for sell)
       
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
            int price = Int32.Parse(tradeInput);

            Console.WriteLine("\nWould you like to buy or sell the securities?: ");
            Transactiontype trcType;
            userInput = Console.ReadLine();
            trcType = (Transactiontype) Enum.Parse(typeof(Transactiontype), userInput,true);

            var currencyValue = (int)trcType * nominal * price;
            Console.WriteLine($"\nThe current value based on your wish to {trcType} is {currencyValue}");
            Console.ReadKey();
        }
    }
}
