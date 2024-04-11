System.Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
    if (num % 7 == 0 && num % 23 == 0)
    {
        System.Console.WriteLine($"{num}, multiple of 7 and 23");
    }
       else System.Console.WriteLine($"{num}, not multiple of 7 and 23");
