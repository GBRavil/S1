Console.WriteLine("Введите число");
string s = Console.ReadLine();
int number = Convert.ToInt32(s);
for(int i = number*-2; i < number * 2+1; i++) {
    Console.WriteLine(i);
}