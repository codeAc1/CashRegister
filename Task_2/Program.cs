using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AZN kassa ucun
            CashRegister cashRegister_AZN = new CashRegister(0, Currency.AZN);

            cashRegister_AZN.AddNewSale_M2(100, Currency.AZN, PaymentType.Cash);
            cashRegister_AZN.AddNewSale_M2(100, Currency.USD, PaymentType.Cash);
            cashRegister_AZN.AddNewSale_M2(100, Currency.EURO, PaymentType.Cash);

            Console.WriteLine(cashRegister_AZN);

            cashRegister_AZN.RemoveSale_M2(100, Currency.AZN);
            cashRegister_AZN.RemoveSale_M2(100, Currency.USD);
            cashRegister_AZN.RemoveSale_M2(100, Currency.EURO);

            Console.WriteLine(cashRegister_AZN);
            #endregion

            #region USD kassa ucun
            CashRegister cashRegister_USD = new CashRegister(0, Currency.USD);

            cashRegister_USD.AddNewSale_M2(100, Currency.AZN, PaymentType.Cash);
            cashRegister_USD.AddNewSale_M2(100, Currency.USD, PaymentType.Cash);
            cashRegister_USD.AddNewSale_M2(100, Currency.EURO, PaymentType.Cash);

            Console.WriteLine(cashRegister_USD);

            cashRegister_USD.RemoveSale_M2(100, Currency.AZN);
            cashRegister_USD.RemoveSale_M2(100, Currency.USD);
            cashRegister_USD.RemoveSale_M2(100, Currency.EURO);

            Console.WriteLine(cashRegister_USD);

            #endregion

            #region Euro kassa ucun
            CashRegister cashRegister_EURO = new CashRegister(0, Currency.EURO);

            cashRegister_EURO.AddNewSale_M2(100, Currency.AZN, PaymentType.Cash);
            cashRegister_EURO.AddNewSale_M2(100, Currency.USD, PaymentType.Cash);
            cashRegister_EURO.AddNewSale_M2(100, Currency.EURO, PaymentType.Cash);

            Console.WriteLine(cashRegister_EURO);

            cashRegister_EURO.RemoveSale_M2(100, Currency.AZN);
            cashRegister_EURO.RemoveSale_M2(100, Currency.USD);
            cashRegister_EURO.RemoveSale_M2(100, Currency.EURO);

            Console.WriteLine(cashRegister_EURO);
            #endregion


        }
    }
}
