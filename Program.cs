using System;
using System.Diagnostics.Contracts;

class Program{

    static void Main(){
        
        Console.Write("How long should it be collected? :");
        
        int number = Convert.ToInt32(Console.ReadLine());
        int toplam = 0;

        for(int i=1; i<number; i++){
            toplam += i;
        }

        Console.WriteLine($"Totals {toplam}");
    }

}