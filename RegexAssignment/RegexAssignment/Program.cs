using System;
using System.Text.RegularExpressions;

namespace RegexAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "My credit card number is 1234-5678-9012-3456";
            string input2 = "My social security number is 123-45-6789";
            string input3 = "My credit card number is 1234-5678-9012-3456 and my social security number is 123-45-6789";


            Console.WriteLine(MaskCreditCard(input1));
            Console.WriteLine(MaskSocialSecurity(input2));
            Console.WriteLine(MaskData(input3));
            Console.ReadKey();
        }

        static string MaskCreditCard(string input)
        {
            return Regex.Replace(input, @"\b(\d{4})-(\d{4})-(\d{4})-(\d{4})\b", "XXXX-XXXX-XXXX-$4");
        }

        static string MaskSocialSecurity(string input)
        {
            return Regex.Replace(input, @"\b(\d{3})-(\d{2})-(\d{4})\b", "XXX-$2-XXXX");
        }

        static string MaskData(string input)
        {
            string maskedCreditCard = MaskCreditCard(input);
            string maskedSocialSecurity = MaskSocialSecurity(maskedCreditCard);
            return maskedSocialSecurity;
        }
    }
}