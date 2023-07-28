using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, last;
            string calc;

            Console.WriteLine("Yapacağınız işlemi seçin!");
            Console.WriteLine("");
            Console.WriteLine("Toplama    [+]");
            Console.WriteLine("Çıkarma    [-]");
            Console.WriteLine("Çarpma     [*]");
            Console.WriteLine("Bölme      [/]");
            Console.WriteLine("Ortalama   [ort]");
            Console.WriteLine("");
            Console.Write("Seçilen işlem: ");
            calc = Console.ReadLine();

            if (calc == "+")
            {
                Console.Clear();
                Console.Write("İlk Sayıyı giriniz: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Clear();
                Console.Write("İkinci sayıyı giriniz: ");
                num2 = double.Parse(Console.ReadLine());

                last = num1 + num2;

                Console.Clear();
                Console.Write("İşlem: " + num1 + " + " + num2 + " = " + last);
              
            }
            else if (calc == "-")
            {   
                Console.Clear();
                Console.Write("İlk Sayıyı giriniz: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Clear();
                Console.Write("İkinci sayıyı giriniz: ");
                num2 = double.Parse(Console.ReadLine());

                last = num1 - num2;

                Console.Clear();
                Console.Write("İşlem: "+ num1 +" - "+num2+" = "+ last);
            }
            else if (calc == "*")
            {   
                Console.Clear();
                Console.Write("İlk Sayıyı giriniz: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Clear();
                Console.Write("İkinci sayıyı giriniz: ");
                num2 = double.Parse(Console.ReadLine());

                last = num1 * num2;

                Console.Clear();
                Console.Write("İşlem: "+ num1 +" * "+num2+" = "+ last);
            }
            else if (calc == "/")
            {   
                Console.Clear();
                Console.Write("İlk Sayıyı giriniz: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Clear();
                Console.Write("İkinci sayıyı giriniz: ");
                num2 = double.Parse(Console.ReadLine());

                last = num1 / num2;

                Console.Clear();
                Console.Write("İşlem: "+ num1 +" / "+num2+" = "+ last);
            }
            else if (calc == "ort")
            {
                Console.Clear();
                Console.Write("İlk Sayıyı giriniz: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Clear();
                Console.Write("İkinci sayıyı giriniz: ");
                num2 = double.Parse(Console.ReadLine());

                last = (num1 + num2) / 2;

                Console.Clear();
                Console.Write("İşlem: " + num1 + " + " + num2 + " / 2 = " + last);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Hatalı işlem!");
            }
            Console.ReadKey();
        }
    }
}
