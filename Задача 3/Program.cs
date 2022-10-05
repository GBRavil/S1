int [] number = {2, 7, 5};
int max=0;
for(int i = 0; i<number.Length; i++) {
    if(number[i]>max){
        max = number[i];
    }
}
Console.WriteLine(max);