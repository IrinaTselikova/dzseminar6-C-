/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


double GetNumber (string message)
{
    Console.WriteLine(message);
    double result = double.Parse(Console.ReadLine());
    return result;
}

double b1 = GetNumber("Введите значение b1");
double k1 = GetNumber("Введите значение k1");
double b2 = GetNumber("Введите значение b2");
double k2 = GetNumber("Введите значение k2");

void CheckNumber (double k1, double k2)
{
    if (k1 == k2)
    {
        Console.WriteLine("k1 не может быть равно k2, введите другое значение");
    }
}


(double, double) IntersectionPoint (double b1, double k1, double b2, double k2)
{
    double coordinateX;
    double coordinateY;

    coordinateX = (double) (b2-b1) / (k1-k2);
    coordinateY = (double) (b1*k2-b2*k1) / (k2-k1);

    return (coordinateX, coordinateY);
}


CheckNumber(k1, k2);

(double coorX, double coorY) = IntersectionPoint(b1, k1, b2, k2);

Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> ({coorX}; {coorY})");

