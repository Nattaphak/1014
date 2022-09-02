using System;

class Program
{
    static void Main(string[] args)
    {
        int[] number = new int[3];
        int sum = 0;

        for(int i = 0 ; i < 3 ; i ++)
        {
            Console.WriteLine("Please input number {0} : ",i+1);
            int.TryParse(Console.ReadLine(), out number[i]);
            sum = sum + number[i];
        }
        Console.WriteLine(sum);
    }
}
