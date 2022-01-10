using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class CashRegister
    {

        public double TotalAmount;
        public Currency Currency;
        public static int TotalSalesCount = 0;
        public PaymentType PaymentType;

        public CashRegister(double totalAmount, Currency currency)
        {
            TotalAmount = totalAmount;
            Currency = currency;
        }

        #region Ancaq If istifade ederek AddSale metodu
        public void AddNewSaleM1(double price, Currency currency, PaymentType paymentType)
        {
            if (Currency == Currency.AZN)
            {
                if (currency == Currency.USD)
                {
                    TotalAmount += price * 1.7;
                }
                else
                if (currency == Currency.EURO)
                {
                    TotalAmount += price * 1.92;
                }
                else
                {
                    TotalAmount += price;
                }

            }
            else
            if (Currency == Currency.USD)
            {
                if (currency == Currency.AZN)
                {
                    TotalAmount += price * 0.59;
                }
                else
                if (currency == Currency.EURO)
                {
                    TotalAmount += price * 1.13;
                }
                else
                if (currency == Currency.USD)
                {
                    TotalAmount += price;
                }
            }
            else
            if (Currency == Currency.EURO)
            {
                if (currency == Currency.AZN)
                {
                    TotalAmount += price * 0.52;
                }
                else
               if (currency == Currency.USD)
                {
                    TotalAmount += price * 0.89;
                }
                else
               if (currency == Currency.EURO)
                {
                    TotalAmount += price;
                }
            }
            TotalSalesCount++;
        }
        #endregion

        #region Ancaq Switch Case isdifade ederek AddSale metodu
        public void AddNewSale_M2(double price, Currency currency, PaymentType paymentType)
        {
            switch (Currency)
            {
                case Currency.AZN:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount += price;
                            break;
                        case Currency.USD:
                            TotalAmount += price * 1.7;
                            break;
                        case Currency.EURO:
                            TotalAmount += price * 1.92;
                            break;
                        default:
                            break;
                    }
                    break;
                case Currency.USD:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount += price * 0.59;
                            break;
                        case Currency.USD:
                            TotalAmount += price;
                            break;
                        case Currency.EURO:
                            TotalAmount += price * 1.13;
                            break;
                        default:
                            break;
                    }
                    break;
                case Currency.EURO:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount += price * 0.52;
                            break;
                        case Currency.USD:
                            TotalAmount += price * 0.88;
                            break;
                        case Currency.EURO:
                            TotalAmount += price;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            TotalSalesCount++;
        }
        #endregion

        #region Ancaq Switch Case isdifade ederek RemoveSle metodu
        public void RemoveSale_M2(double price, Currency currency)
        {
            switch (Currency)
            {
                case Currency.AZN:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount -= price;
                            break;
                        case Currency.USD:
                            TotalAmount -= price * 1.7;
                            break;
                        case Currency.EURO:
                            TotalAmount -= price * 1.92;
                            break;
                        default:
                            break;
                    }
                    break;
                case Currency.USD:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount -= price * 0.59;
                            break;
                        case Currency.USD:
                            TotalAmount -= price;
                            break;
                        case Currency.EURO:
                            TotalAmount -= price * 1.13;
                            break;
                        default:
                            break;
                    }
                    break;
                case Currency.EURO:
                    switch (currency)
                    {
                        case Currency.AZN:
                            TotalAmount -= price * 0.52;
                            break;
                        case Currency.USD:
                            TotalAmount -= price * 0.88;
                            break;
                        case Currency.EURO:
                            TotalAmount -= price;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            TotalSalesCount--;
        }
        #endregion

        public override string ToString()
        {
            return $"      TotalAmount: {TotalAmount}\n " +
                $"        Currency: {Currency}\n " +
                $" TotalSalesCount: {TotalSalesCount}\n ";
        }



    }
}
