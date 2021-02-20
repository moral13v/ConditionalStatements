using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //PriceList

            double puzzlePrice = 2.60;
            double dollPrice = 3;
            double teddyPrice = 4.10;
            double minnionPrice = 8.20;
            double truckPrice = 2;

            //Input

            double hollidayPrice = double.Parse(Console.ReadLine());
            int puzzleSales = int.Parse(Console.ReadLine());
            int dollSales = int.Parse(Console.ReadLine());
            int teddySales = int.Parse(Console.ReadLine());
            int minnionSales = int.Parse(Console.ReadLine());
            int truckSales = int.Parse(Console.ReadLine());

            //Calculations

            int sales = puzzleSales + dollSales + teddySales + minnionSales + truckSales;

            //Conditions

            if (sales >= 50)
            {
                double incomeBeforeDiscount = puzzleSales * puzzlePrice + dollSales * dollPrice +
                teddySales * teddyPrice + minnionSales * minnionPrice + truckSales * truckPrice;
                double incomeBeforeRent = incomeBeforeDiscount * 0.75;
                double income = incomeBeforeRent * 0.9;

                if (income >= hollidayPrice)
                {
                    double moneyLeft = income - hollidayPrice;
                    string format = "F2";
                    var moneyLeftFormat = moneyLeft.ToString(format);

                    Console.WriteLine($"Yes! {moneyLeftFormat} lv left.");
                }

                else
                {
                    double moneyNeeded = hollidayPrice - income;
                    string format = "F2";
                    var moneyNeededFormat = moneyNeeded.ToString(format);

                    Console.WriteLine($"Not enough money! {moneyNeededFormat} lv needed.");
                }

            }

            else
            {
                double incomeBeforeRent = puzzleSales * puzzlePrice + dollSales * dollPrice +
                teddySales * teddyPrice + minnionSales * minnionPrice + truckSales * truckPrice;
                double income = incomeBeforeRent * 0.9;

                if (income >= hollidayPrice)
                {
                    double moneyLeft = income - hollidayPrice;

                    string format = "F2";
                    var moneyLeftFormat = moneyLeft.ToString(format);

                    Console.WriteLine($"Yes! {moneyLeftFormat} lv left.");
                }

                else
                {
                    double moneyNeeded = hollidayPrice - income;

                    string format = "F2";
                    var moneyNeededFormat = moneyNeeded.ToString(format);

                    Console.WriteLine($"Not enough money! {moneyNeededFormat} lv needed.");
                }
            }
        }
    }
}
