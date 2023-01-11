int num = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
if (num < 100)
  {
    Console.WriteLine("We don't have number 3!");
  }
num2 = num % 10;
Console.WriteLine(num2);