using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicsAssignment
{
     public  class Order
    {
         public int OrderId;
        public string CustomerName;
         public int Quantity;
         public decimal UnitPrice;
        public decimal TotalPrice;
        public bool IsPaid;
        public double DiscountPercent;
        public string ShippingCity;
        public char Priority;
        public long ItemCode;


        public void caluclatetotal()
        {
            TotalPrice = Quantity * UnitPrice * (1 - (decimal)DiscountPercent / 100); ;
        }

        public void PrintSummary()
        {
            Console.WriteLine($"Order ID: {OrderId}, Customer: {CustomerName} , TotalPrice : {TotalPrice} ,  IsPaid  , {IsPaid} ");
        }

    }
}
