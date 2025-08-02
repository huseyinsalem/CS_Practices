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



            if (Mil <= 0 || Age <= 0 || (TravelType != 1 && TravelType != 2))
            {
                Console.WriteLine("hatalı giriş Yaptınız");
            }
            else
            {

                double Price1 = Mil * 0.10;
                double AgeDisCountRate = 0;

                if (Age < 12)
                {
                    AgeDisCountRate = 0.50;
                }
                else if (Age >= 12 && Age <= 24)
                {
                    AgeDisCountRate = 0.10;
                }
                else if (Age < 65)
                {
                    AgeDisCountRate = 0.30;
                }

                Price -= (Price * AgeDisCountRate);

                if (TravelType == 2)
                {
                    Price1 -= (Price1 * 0.20);
                    Price1 *= 2;

                }

                Console.WriteLine("Bilet tutarı: " + Price1);
            }

            #endregion





            #region Hava sıcaklıgı


            Console.Write("Enter the temperature: ");
            int temperature = Convert.ToInt32(Console.ReadLine());

            string events = "";

            if (temperature < 5)
            {
                events = "Skiing";
            }
            else if (temperature >= 5 && temperature < 15)
            {
                events = "Cinema";
            }
            else if (temperature >= 15 && temperature < 25)
            {
                events = "Picnic";
            }
            else
            {
                events = "Swimming";
            }

            Console.WriteLine("Suggested activity: " + events);


            #endregion




            #region cift sayılar


            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int counterLoop = 0;

            for (int i = 2; i <= n; i += 2)
            {
                counterLoop++;
                Console.WriteLine(i);
            }

            Console.WriteLine("Loop count: " + counterLoop);

            Console.WriteLine("--------");
            #endregion


            #region tek sayılar

            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int counterLoop1 = 0;

            for (int i = 0; i <= x; i += 3)
            {
                counterLoop1++;
                Console.WriteLine(i);
            }
            Console.WriteLine("Loop count: " + counterLoop1);

            Console.WriteLine("=================");
            #endregion


                 //ATM PROJECT

            #region atm projesi



            string username, password;
            int rigt = 3;
            int balance = 100;

            while (rigt>0)
            {
                Console.Write("Your username: ");
                username= Console.ReadLine();
                Console.Write("Your password: ");
                password= Console.ReadLine();

                if(username == "test" && password == "123")
                {
                    Console.WriteLine("Hello, welcome to our bank");
                    int select;
                    do
                    {
                        Console.WriteLine("1-Deposit money");
                        Console.WriteLine("2-Make a withdrawal ");
                        Console.WriteLine("3-Perform a balance inquiry");
                        Console.WriteLine("4-Please log out");
                        Console.Write("Please select the operation you want to perform (1-4): ");
                        select = Convert.ToInt32(Console.ReadLine());


                        if (select == 1)
                        {
                            Console.Write("Amount of money: ");
                            int price=Convert.ToInt32(Console.ReadLine());
                            balance += price;
                            Console.WriteLine($"{price} TL Money has been deposited");
                        }
                        else if (select == 2)
                        {
                            Console.Write("Amount of money: ");
                            int price=Convert.ToInt32(Console.ReadLine());

                            if(price>balance)
                            {
                                Console.WriteLine("here is insufficient balance in your account !");
                            }
                            else
                            {
                                balance -= price;
                                Console.WriteLine($"{price} TL Money has been withdrawn");
                            }
                           

                        }
                        else if (select == 3)
                        {
                            Console.WriteLine("Your balance: " + balance + "TL");
                        }

                    } while(select !=4);
                    Console.WriteLine("You have logged out !");
                    break;
                }
                else
                {
                    rigt--;
                    Console.WriteLine("Invalid login attempt, please try again.");

                    if(rigt == 0)
                    {
                        Console.WriteLine("Your account has been blocked, please contact the bank.");
                    }
                    else
                    {
                        Console.WriteLine("Attempts left: " + rigt);
                    }

                    Console.WriteLine("==================");

                }

            }






            #endregion




            Console.Read();
        }
    }
}
