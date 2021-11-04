using Validator;
using System;

namespace _04._11._2021
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Validator2.PhoneValidator("+994709855333"));  /*istənilən Azərbaycan nömrəsini ödüyür*/
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            {
                try
                {
                    Console.WriteLine(Validator2.PassswordValidator("Admin123@")); /*Minimum səkkiz və maksimum 63 simvol, ən azı bir böyük hərf, bir kiçik hərf, bir rəqəm və bir xüsusi simvol*/
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            {
                try
                {
                    Console.WriteLine(Validator2.DateValidator("28.10.2002")); 
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            try
            {
                Console.WriteLine(Validator2.AutoNumberValidator("10-OE-931"));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine(Validator2.ClockValidator("10:56:12"));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine(Validator2.MacAdressValidator("01:23:45:67:89:A4"));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }

    
}
