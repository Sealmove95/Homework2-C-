int num = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
if (num < 100)
  {
    Console.WriteLine("ERROR! Please enter num > 99!");
  }
num2 = num / 10 % 10;
Console.WriteLine(num2);