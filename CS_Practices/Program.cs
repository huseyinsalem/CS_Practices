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
            Console.Write("Ürünün fiyatı: ");
            double Price = Convert.ToDouble(Console.ReadLine());

            double KdvRate = 0.20;

            double KdvPrice = Price * KdvRate;

            double TotalPrice = Price + KdvPrice;

            Console.WriteLine("Kdv oranı: " + KdvPrice);
            Console.WriteLine("Kdv'li fiyat: " + TotalPrice);
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


            #region Ucak bilet fiyatı


            Console.Write("Mil giriniz: ");
            int Mil = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yaşınız: ");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yolculuk tipi: ");
            int TravelType = Convert.ToInt32(Console.ReadLine());



            if (Mil <= 0 || Age <= 0 || (TravelType != 1 && TravelType!= 2))
            {
                Console.WriteLine("hatalı giriş Yaptınız");
            }
            else
            {

                double Price1 = Mil * 0.10;
                double AgeDisCountRate = 0;

                if ( Age < 12)
                {
                    AgeDisCountRate = 0.50;
                }
                else if( Age >= 12 && Age <= 24)
                {
                    AgeDisCountRate = 0.10;
                }
                else if (Age < 65)
                {
                    AgeDisCountRate = 0.30;
                }

                Price -=  (Price * AgeDisCountRate);

                if ( TravelType == 2 )
                {
                    Price1 -= (Price1 * 0.20);
                    Price1 *= 2;

                }

                Console.WriteLine("Bilet tutarı: " + Price1 );
            }

            #endregion



            Console.Read();
        }
    }
}
