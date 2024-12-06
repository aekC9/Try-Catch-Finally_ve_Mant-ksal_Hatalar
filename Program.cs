using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace TryCatchFinallyVEMantiksalHatalar
{
    class Program{
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Sayi 1 giriniz: ");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.Write("Sayi 2 giriniz: ");
                int sayi2 = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Yapmak istediğiniz işlemi seçiniz { 1. *,2. /,3. +,4. - }");
                double islem=Convert.ToDouble(Console.ReadLine());
                switch(islem)
                {
                    case 1:
                        Console.WriteLine($"Sonuç: {sayi1*sayi2}");
                        break;
                    case 2:
                        System.Console.WriteLine($"Sonuç: {sayi1/sayi2}");
                        break;
                    case 3:
                        System.Console.WriteLine($"Sonuç: {sayi1+sayi2}");
                        break;
                    case 4:
                        System.Console.WriteLine($"Sonuç: {sayi1-sayi2}");
                        break;
                    default:
                        System.Console.WriteLine("Böyle bir işlem seçeneği bulunmamaktadır lütfen 1-4 arası işlem seçiniz");
                        break;
                }
            }
            catch(Exception ex)
            {
                System.Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }
            finally
            {
                System.Console.WriteLine("İşlem tamamlandı.");
            }
        }
    }
}