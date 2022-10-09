Console.WriteLine("Задайте число");
String s1 = Console.ReadLine();
int i1 = Convert.ToInt32(s1);
Console.WriteLine("Кратно ли числу");
String s2 = Console.ReadLine();
int i2 = Convert.ToInt32(s2);
if(i1%i2==0) {
    Console.WriteLine(i1 + " кратно " + i2);
} else {
    int i3 = i1%i2;
    Console.WriteLine(i1 + " не кратно " + i2 + " остаток " + i3);
}