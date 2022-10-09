int number = new Random().Next(10, 99);
Console.WriteLine("Число: " + number);
int a = (number % 10);
int b = (number - number % 10) / 10;
if(a>b){
   Console.WriteLine("Наибольшая цифра в числе " + a); 
} else {
    Console.WriteLine("Наибольшая цифра в числе " + b); 
}
