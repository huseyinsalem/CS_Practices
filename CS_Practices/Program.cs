using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ürünün fiyatı: ");
            double price = Convert.ToDouble(Console.ReadLine());


            double KdvRate = 0.20;

            double KdvPrice = price * KdvRate;

            double TotalPrice = price + KdvPrice;

            Console.WriteLine("Kdv tutarı: " + KdvPrice);
            Console.WriteLine("Kdv'li Tutar: " + TotalPrice);

            Console.Read();
        }
    }
}
