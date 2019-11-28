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
            double mod, payim,paydam; //mod ve pay�n ve paydan�n i�lem sonucu


            if (pay < payda) // payda paydan k���kse yap�lacaklar
            {
                mod = payda % pay; // payda ve pay�n modu al�n�r
                if (mod != 0) //mod 0 a e�it de�ilse
                {
                    payim = pay / mod; // pay mod ile b�l�n�r
                    paydam = payda / mod; // payda mod ile b�l�n�r

                    Console.WriteLine(pay + "/" + mod + "=" + payim); // form�l�n mant��� ��kt�s�
                    Console.WriteLine(payda + "/" + mod + "=" + paydam); // form�l�n mant��� ��kt�s�

                    Console.WriteLine("��kt�:"+payim + "/" + paydam); //pay ile payda ��kt�
                }
                else  //mod 0 a e�itse 
                {
                    payim = pay / pay; // pay pay ile b�l�n�r
                    paydam = payda / pay; // payda pay ile b�l�n�r
                    Console.Write(pay + "/" + payda + "="); // form�l�n mant��� ��kt�s�
                    Console.WriteLine(payim + "/" + paydam); //payim ile paydam ��kt�
                }
            }
            else
            { // pay b�y�k veya e�itse yap�lacaklar
                mod = pay % payda; // pay ve payda modu al�n�r
                if (mod!=0) //mod 0 a e�it de�ilse
                {
                    payim = pay / mod; // pay mod ile b�l�n�r
                    paydam = payda / mod; // payda mod ile b�l�n�r

                    Console.WriteLine(pay + "/" + mod + "=" + payim); // form�l�n mant��� ��kt�s�
                    Console.WriteLine(payda + "/" + mod + "=" + paydam); // form�l�n mant��� ��kt�s�
                    Console.WriteLine("��kt�:" + payim + "/" + paydam); //pay ile payda ��kt�
                }
                else
                { //mod 0 a e�itse
                    Console.Write(pay + "/" + payda + "="); // form�l�n mant��� ��kt�s�
                    Console.WriteLine(pay / payda); // i�lem tam say�d�r ve sadece b�l�n�r
                }
            
            }
           

            Console.ReadKey(); // program kapanmas�n diye imle� yazd�r�l�r
        }
    }
}
