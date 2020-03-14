using System;
namespace Calculator
{
class calculator
{
public static int a=0,b=0;
    static void Main(string[] args)
	   {
		   
        Console.Title = "Aplikasi Calculator";
        Console.WriteLine("Menu Aplikasi\n");
        Console.WriteLine("1. Penjumlahan \n2. Pengurangan \n3. Perkalian \n4. Pembagian");
        Console.Write("\nPilihan Menu: ");
        int pilihan = int.Parse(Console.ReadLine());

        switch(pilihan)
        {
            case 1 :
            input();
            Console.WriteLine("\nHasil Penambahan {0} + {1} = {2}", a, b, penambahan(a,b));
            break;
            case 2 :
            input();
            Console.WriteLine("\nHasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a,b));
            break;
            case 3 :
            input();
            Console.WriteLine("\nHasil Pengurangan {0} x {1} = {2}", a, b, perkalian(a,b));
            break;
            case 4 :
            input();
            Console.WriteLine("\nHasil Pengurangan {0} : {1} = {2}", a, b, pembagian(a,b));
            break;
            default:
            Console.WriteLine("\nMaaf, menu yang anda pilih tidak tersedia");
            break;
        }

        Console.WriteLine("\nTekan Sembarang Tombol Untuk Keluar");
        Console.ReadKey();
	   }
	   
	   static int penambahan(int a, int b)
        {
            return a + b;
        }
		static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a * b;
        }

        static void input(){
        Console.Write("\nNilai a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Nilai b: ");
        b = int.Parse(Console.ReadLine());
}
}
}