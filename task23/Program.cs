/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
void Cube (int number)
{
    int count = 1;
    if (number > 0)
    {
        while (count <= number)
            {
                Console.Write ($"{count*count*count} ");
                count++;
            }
    }
    else
    {
        while (count >= number)
            {
                Console.Write ($"{count*count*count} ");
                count--;
            }
    }
}
Console.Write ("Input your number: ");
int num = Convert.ToInt32 (Console.ReadLine ());

Cube (num);