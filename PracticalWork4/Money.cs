using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWork4
{
    public class Money
    {
        private double parValue;
        private int quantityOfBanknotes;


        public Money() { }

        public Money(double parValue, int quantityOfBanknotes)
        {
            this.parValue = parValue;
            this.quantityOfBanknotes = quantityOfBanknotes;
        }


        public double ParValue
        {
            get
            {
                return parValue;
            }

            set
            {
                parValue = value;
            }
        }

        public int QuantityOfBanknotes
        {
            get
            {
                return quantityOfBanknotes;
            }

            set
            {   
                quantityOfBanknotes = value;
            }
        }

        public double Summa
        {
            get
            {
                return quantityOfBanknotes* parValue;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Номинал {parValue}   | Количество купюр  {quantityOfBanknotes}");
        }


        public void EnoughBanknotes(double someSumm)
        {
            double summa = quantityOfBanknotes * parValue;
            if (summa >= someSumm)
            {
                Console.WriteLine("Суммы достаточно");
            }
            else
            {
                Console.WriteLine("У вас недостаточно средств");
            }
        }

        public void QuantityOfGoodsForTheSum(double goodsPrice)
        {
            double summ = quantityOfBanknotes * parValue;
            double quantityOfGoodsForTheSum = summ / goodsPrice;
            quantityOfGoodsForTheSum = (int)Math.Round(quantityOfGoodsForTheSum);
            Console.WriteLine($"Количество товара который вы можете преобрести на сумму {summ} = {quantityOfGoodsForTheSum}");
        }
    }
}
