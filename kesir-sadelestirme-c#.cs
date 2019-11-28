using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formuller
{
    class Program
    {
        static void Main(string[] args)
        {
            int pay= 150; //pay
            int payda = 17000; //payda
            double mod, payim,paydam; //mod ve payýn ve paydanýn iþlem sonucu


            if (pay < payda) // payda paydan küçükse yapýlacaklar
            {
                mod = payda % pay; // payda ve payýn modu alýnýr
                if (mod != 0) //mod 0 a eþit deðilse
                {
                    payim = pay / mod; // pay mod ile bölünür
                    paydam = payda / mod; // payda mod ile bölünür

                    Console.WriteLine(pay + "/" + mod + "=" + payim); // formülün mantýðý çýktýsý
                    Console.WriteLine(payda + "/" + mod + "=" + paydam); // formülün mantýðý çýktýsý

                    Console.WriteLine("Çýktý:"+payim + "/" + paydam); //pay ile payda çýktý
                }
                else  //mod 0 a eþitse 
                {
                    payim = pay / pay; // pay pay ile bölünür
                    paydam = payda / pay; // payda pay ile bölünür
                    Console.Write(pay + "/" + payda + "="); // formülün mantýðý çýktýsý
                    Console.WriteLine(payim + "/" + paydam); //payim ile paydam çýktý
                }
            }
            else
            { // pay büyük veya eþitse yapýlacaklar
                mod = pay % payda; // pay ve payda modu alýnýr
                if (mod!=0) //mod 0 a eþit deðilse
                {
                    payim = pay / mod; // pay mod ile bölünür
                    paydam = payda / mod; // payda mod ile bölünür

                    Console.WriteLine(pay + "/" + mod + "=" + payim); // formülün mantýðý çýktýsý
                    Console.WriteLine(payda + "/" + mod + "=" + paydam); // formülün mantýðý çýktýsý
                    Console.WriteLine("Çýktý:" + payim + "/" + paydam); //pay ile payda çýktý
                }
                else
                { //mod 0 a eþitse
                    Console.Write(pay + "/" + payda + "="); // formülün mantýðý çýktýsý
                    Console.WriteLine(pay / payda); // iþlem tam sayýdýr ve sadece bölünür
                }
            
            }
           

            Console.ReadKey(); // program kapanmasýn diye imleç yazdýrýlýr
        }
    }
}
