void InsertNum(double b1, double b2, double k1, double k2){
/*if (b1 > b2){
    double temp = b2;
    b2 = b1;
    b1 = temp;
}
else if (k1 > k2){
    double temp = k2;
    k2 = k1;
    k1 = temp;
}
*/
    double x = (b2-b1) / (k1-k2);
    double y = (k1*(b2-b1))/(k1-k2)+b1;
    Console.Write($"[{x};{y}]");






}

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
InsertNum(b1,b2,k1,k2);