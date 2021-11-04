using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Validator
{
    public class Validator2
    {
        /// <summary>
        /// Mətndə telefon nömrəsinin olub olmadığını yoxlayır
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns>bool</returns>
        public static bool PhoneValidator(string phoneNumber)  /* telefon nomresini gosterir*/
        {
            string Pattern = @"^(\+?994)(5[015]|7[07]|12)([2-9][0-9]{2})([0-9]{2})([0-9]{2})$";  
            bool result = Regex.IsMatch(phoneNumber, Pattern);
            if (result)
            {
                return result;
            }
            else
            {
                throw new Exception();
            }
        }
        /// <summary>
        /// parol olub olmadigini yoxluyur
        /// </summary>
        /// <param name="password"></param>
        /// <returns>bool</returns>
        public static bool PassswordValidator(string password)
        {
            string Pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,10}$";  /*min8, max 63 simvol olmali, ən azı bir böyük hərf, kiçik hərf və xüsusi simvol olmalıdır*/
            bool result = Regex.IsMatch(password, Pattern);
            if (result)
            {
                return result;
            }
            else
            {
                throw new Exception();
            }
        }
        /// <summary>
        /// tarix olub olmadigini yoxluyur
        /// </summary>
        /// <param name="password"></param>
        /// <returns>bool</returns>
        public static bool DateValidator(string date)
        {
            string Pattern = @"^([0]?[1-9]|[1|2][0-9]|[3][0|1])[.\/-]([0]?[1-9]|[1][0-2])[.\/]([0-9]{4}|[0-9]{2})$";  
            bool result = Regex.IsMatch(date, Pattern);
            if (result)
            {
                return result;
            }
            else
            {
                throw new Exception();
            }
        }
        /// <summary>
        /// maşın nömrəsi olub olmadığını yoxluyur
        /// </summary>
        /// <param name="autoNumber"></param>
        /// <returns>bool</returns>
        public static bool AutoNumberValidator(string autoNumber)
        {
            string Pattern = @"^[0-9]{2}-[A-Z]{2}-[0-9]{3}$";  /*Azərbaycan avtomobil nömrəsinin olub olmadigini gosterir*/
            bool result = Regex.IsMatch(autoNumber, Pattern);
            if (result)
            {
                return result;
            }
            else
            {
                throw new Exception();
            }
        }
        /// <summary>
        /// saatı göstərir
        /// </summary>
        /// <param name="clock"></param>
        /// <returns>bool</returns>
        public static bool ClockValidator(string clock)
        {
            string Pattern = @"^([0-1]\d|2[0-3])(:[0-5]\d){2}$";    /*saatı göstərir*/
            bool result = Regex.IsMatch(clock, Pattern);
            if (result)
            {
                return result;
            }
            else
            {
                throw new Exception();
            }
        }
        /// <summary>
        /// mətndə mac adress olub olmadiginin yoxluyur
        /// </summary>
        /// <param name="macAdress"></param>
        /// <returns>bool</returns>
        public static bool MacAdressValidator(string macAdress)
        {
            string Pattern = @"^([0-9a-fA-F]{2}([:-]|$)){6}$|([0-9a-fA-F]{4}([.]|$)){3}$";
            bool result = Regex.IsMatch(macAdress, Pattern);
            if (result)
            {
                return result;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
