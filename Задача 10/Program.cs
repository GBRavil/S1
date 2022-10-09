int number = new Random().Next(100, 1000);
Console.WriteLine("Число: " + number);
// int b = (number % 100-number % 10); обнуляет вторую цифру в числе
// int c = number - b;
int b = (number - number % 100) / 100 * 10 +(number % 10); // удаляет вторую цифру в числе
Console.WriteLine(b);