int number = new Random().Next(10, 500);
Console.WriteLine("Число: " + number);
if(number>99){
    int b = (number - number % 100) / 100;
    Console.WriteLine("Третья цифра числа "+b);
} else {
    Console.WriteLine("Число двухзначное");
}
