Console.WriteLine("Введите число");
string s = Console.ReadLine();
int number = Convert.ToInt32(s);
if (number % 2==1) {
    Console.WriteLine("Число нечетное");
}else{
    Console.WriteLine("Число четное");
}