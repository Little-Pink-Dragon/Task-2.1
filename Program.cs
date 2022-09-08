{
    Console.WriteLine("Введите первое число: ");
 int a = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите второе число: ");
 int b = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите третье число: ");
 int c = int.Parse(Console.ReadLine());
 
  if (a > b)
    {
        if (a > c)
        {
            Console.Write("{0} Наибольшее число", a);
        }
        else
        {
            Console.Write("{0} Наибольшее число", c);
        }
    }
    else if (b > c)
        Console.Write("{0} Наибольшее число", b);
    else
        Console.Write("{0} Наибольшее число", c);
}