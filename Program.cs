using System;
using System.Diagnostics.Contracts;

class Program{

    static void Main(){
        
        Console.Write("How long should it be collected? :");
        
        int number = Convert.ToInt32(Console.ReadLine());  // Veri girişi
        int toplam = 0;

        /*
        for(int i=1; i<number; i++){  // Sayıların kendisinden önceki 1 dahil bütün sayıların toplayan döngü
            toplam += i;
        }
        */
        
        int i = 1;
        while(i<number){  // i değeri istediğimiz değerden düşük oduğu sürece çalışacak
            toplam += i;
            i++;
        }

        Console.WriteLine($"Totals {toplam}"); // Toplamı yazdıran kod
    }

}