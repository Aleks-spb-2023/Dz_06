/*  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

-1, -7, 567, 89, 223-> 3 */
Console.WriteLine("Введите количество чисел :");
int M = Convert.ToInt32(Console.ReadLine());
int total = 0;
string numbers = " ";
while (M > 0)
{
    Console.WriteLine("Введите число ");
    int usernumber = Convert.ToInt32(Console.ReadLine());
    if(usernumber > 0)
    {
        total++;
    }
    numbers += usernumber + " ";
    
    M = M - 1;

}
Console.WriteLine(numbers + "--> " + total);

