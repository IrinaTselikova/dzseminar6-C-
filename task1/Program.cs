/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */


Console.WriteLine("Введите числа через запятую:");
string str = Console.ReadLine();
string[] strArray = str.Split(',');

int [] numArray = new int[strArray.Length];

for (int i = 0; i < strArray.Length; i++)
{
numArray[i] = int.Parse(strArray[i]);
}

Console.WriteLine("Вывод полученного массива:");


for (int i = 0; i < numArray.Length; i++)
{
if(i < numArray.Length - 1)
Console.Write($"{numArray[i]}, ");
else
Console.Write($"{numArray[i]}");
}

int NumberOfDigitsGreaterThanZero(int[] numArray)
{
    int count = 0;

    for (int i = 0; i < numArray.Length; i++)
    {
        if (numArray[i]>0)
        count += 1;
    }
    return count;
}

int count = NumberOfDigitsGreaterThanZero(numArray);
Console.WriteLine();
Console.WriteLine($"Вы ввели {count} чисел больше 0");