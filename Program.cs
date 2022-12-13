int InsertNum(int m){

int count = 0;
for (int i = 1; i <= m; i++ ){
    Console.Write($"Введите число {i}: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a > 0){
        count ++;
    }
}
return count;
}
Console.WriteLine("Введите количество чисел");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"{InsertNum(m)}");

