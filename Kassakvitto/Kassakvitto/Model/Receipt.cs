using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kassakvitto.Model
{
    public class Receipt
    {
        // Field
        private double _subtotal;

        // Properties
        public double Subtotal
        {
            get
            {
                return _subtotal;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _subtotal = value;
            }

        }

        public double DiscountRate { get; set; }

        public double MoneyOff { get; set; }

        public double Total { get; set; }

        // Constructor
        public Receipt(double subtotal)
        {
            Calculate(subtotal);
        }

        // Methods
        public void Calculate(double subtotal)
        {
            /*
             * 0-499 0 % 
             * 500-999 5 % 
             * 1000-4999 10 % 
             * 5000- 15 %
             */

            int zeroProcent = 499;
            int fiveProcent = 999;
            int tenProcent = 4999;

            Subtotal = subtotal;

            // Set the DiscountRate.
            if (Subtotal <= zeroProcent)
            {
                DiscountRate = 0.00;
            }
            else if (Subtotal <= fiveProcent)
            {
                DiscountRate = 0.05;
            }
            else if (Subtotal <= tenProcent)
            {
                DiscountRate = 0.10;
            }
            else
            {
                DiscountRate = 0.15;
            }

            // Calculate the MoneyOff.
            MoneyOff = DiscountRate * Subtotal;

            // Calcualte the Total.
            Total = Subtotal - MoneyOff;
        }
    }
}