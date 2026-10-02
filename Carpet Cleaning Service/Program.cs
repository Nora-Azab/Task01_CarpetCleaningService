namespace Carpet_Cleaning_Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *     Islam's Carpet Cleaning Service Charges:
                        $25 per small
                        $35 per large
                    Sales tax rate is 6%
                    Estimates are valid for 30 days

                    Prompt the user for the number of small and large rooms they would like cleaned
                    and provide an estimate such as:
     
                        Estimate for carpet cleaning service
                        Number of small carpets: 3 <--
                        Number of large carpets: 1 <--
                        Price per small carpet : $25
                        Price per large carpet : $35
                        Cost : $110
                        Tax: $6.6
                        ===============================
                        Total estimate: $116.6 
                        This estimate is valid for 30 days


             */
            

            const decimal PricePerSmall = 25m;
            const decimal PricePerLarge = 35m;
            const decimal TaxRate = 6m; //6%
            const int OfferDays = 30;

            Console.WriteLine("Estimate for carpet cleaning service");
            Console.WriteLine("===============================");

            Console.Write("Number of small carpets: ");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of large carpets: ");
            int largeCarpets = Convert.ToInt32(Console.ReadLine());

            ///Console.WriteLine($"Price per small carpet : {PricePerSmall:C}");//$25.00
            ///$ :       أضمن عشان اعدادات اللغة في الجهاز .. use the computer's culture settings,
            ///           to force dollars, add using System.Globalization; and use {cost.ToString("C", CultureInfo.GetCultureInfo("en-US"))}.
            ///          and when i don't use format specifier with "decimal" number -> هيتعرض زي ما هو بدون تقريب وبدون خانات أصفار ذيادة على اليمين  
            ///          أما لو كنت عاوزة الرقم فيه تقريب لأول رقمين عشريين -> will use C [by default do this]
            ///          

            Console.WriteLine($"Price per small carpet : {PricePerSmall:c}");
            Console.WriteLine($"Price per large carpet : {PricePerLarge:c}");

            decimal cost = (smallCarpets * PricePerSmall) + (largeCarpets * PricePerLarge);
            Console.WriteLine($"Cost : {cost:c}");

            decimal tax = cost * (TaxRate / 100);//110 * (6m/100) = 6.6
            Console.WriteLine($"Tax: {tax:c}");

            decimal total = cost + tax;
            Console.WriteLine($"===============================");
            Console.WriteLine($"Total estimate: {total:c}");
            Console.WriteLine($"This estimate is valid for {OfferDays} days");











        }
    }
}
