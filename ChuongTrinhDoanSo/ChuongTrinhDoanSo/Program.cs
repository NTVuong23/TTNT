using System;
namespace ChuongTrinhDoanSo

internal static class Program
{
   static void Main(string[] args)
    {
        Random random = new Random();
        int number = random.Next(100, 1000);
        Console.WriteLine(number);
        
    }
}