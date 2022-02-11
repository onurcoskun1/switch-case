using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int ay = DateTime.Now.Month;
            
            //Expression 
            switch (ay)
            {
                case 1:
                    Console.WriteLine("Ocak Ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("Şubat Ayındasınız");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girişi");
                break;
            }

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Ayındasınız");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkBahar Ayındasınız");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Ayındasınız");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Ayındasınız");
                    break;
                default:
                break;
            }
        }   
    }
}
