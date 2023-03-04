// найти точку пересечения двух прямых с заданными уравнениями y=xk1+b1 и y=xk2+b2, где коэффициенты вводятся пользователем
int ReadNumber (string message)
{
    Console.WriteLine (message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.WriteLine ("Первая прямая задана уравнением y=xk1+b1");
int k1 = ReadNumber ("Введите коэффициент k1:");
int b1 = ReadNumber ("Введите коэффициент b1:");
Console.WriteLine ("Первая прямая задана уравнением y=xk2+b2");
int k2 = ReadNumber ("Введите коэффициент k2:");
int b2 = ReadNumber ("Введите коэффициент b2:");
float b = b2-b1;
float k = k1-k2;
float x = b/k;
float y1 = x*k1+b1;
float y2 = x*k2+b2;
if (y1 == y2)
{
    Console.WriteLine ("Прямые пересекаются в точке ( " + x + " ; " + y1 + " )");
}
else
{
     Console.WriteLine ("Прямые не пересекаются");
}


