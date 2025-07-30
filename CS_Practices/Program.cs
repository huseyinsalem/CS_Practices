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


            #region kdv oranı 
            //Console.Write("Ürünün fiyatı: ");
            //double Price = Convert.ToDouble(Console.ReadLine());

            //double KdvRate = 0.20;

            //double KdvPrice = Price * KdvRate;

            //double TotalPrice = Price + KdvPrice;

            //Console.WriteLine("Kdv oranı: " + KdvPrice);
            //Console.WriteLine("Kdv'li fiyat: " + TotalPrice);
            #endregion


            #region Taksimetre hesaplama
            double StartPrice = 25;
            double PerKmPrice = 15.20;
            double MinPrice = 150;

            Console.Write("Mesafeyi giriniz: ");
            double Km = Convert.ToDouble(Console.ReadLine());

            double PayPrice = StartPrice + (Km * PerKmPrice);

            PayPrice = PayPrice < MinPrice ? MinPrice : PayPrice;

            Console.WriteLine("Taksi ücreti: " + PayPrice);

            #endregion

          




            Console.Read();
        }
    }
}
