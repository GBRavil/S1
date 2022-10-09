int number = new Random().Next(100, 1000);
Console.WriteLine("Число: " + number);
int b = (number % 100-number % 10) / 10;
Console.WriteLine("Десятки: " + b);