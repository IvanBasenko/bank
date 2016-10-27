using System;


namespace bankSD
{
    class Program
    {
        static void Main(string[] args)
        {
            IOptions b1 = new Bank1();
            IOptions b2 = new Bank2();
            IOptions b3 = new Bank3();
            IOptions[] arr = new IOptions[3];
            arr[0] = b1;
            arr[1] = b2;
            arr[2] = b3;

            for (int i=0; i < arr.Length; i++)
            {
                arr[i].addMoney(200);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].withdrowMoney(120);
            }
          
             foreach (var bank in arr)
             {
                   Console.WriteLine(bank);
             }
            Console.ReadLine();
        }
    }
}
