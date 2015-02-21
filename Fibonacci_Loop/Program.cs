using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace Fibonacci_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch(); // stopwacth nesnesi olusturarak kullanarak süreyi hesaplamaya çalıstım.
            Console.WriteLine("istediğiniz Fibonacci sayisini giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            stopwatch.Start();

            Console.WriteLine("Fibonacci değeri:" + Fibonacci_Loop(sayi));

            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed; //stopwatch fonksiyonunun elapsed özelliğini kullanarak süre hesaplamaya çalıştım.
            string elapsedTime = String.Format("{0}:{1}:{2}.{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.TotalMilliseconds * 1000000);
            
            Console.WriteLine("Calisma Suresi:" + elapsedTime); // çalısma süresini ekrana yazdırıyor.
            Console.ReadLine(); // sürenin ekranda görünmesini  saglıyor.
 }

        public static int Fibonacci_Loop(int sayi)
        {
            int a = 0;
            int b = 1;
           
            for (int i = 0; i < sayi; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        
    }
}
