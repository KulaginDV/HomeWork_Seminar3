/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

void CheckPalindrome(int num)
{
    if(num > 9999 && num < 100000)
    {
        int div1 = num / 10000;
        int rem1 = num % 10;
 
            if(div1 == rem1)
            {
                num = num / 10;
                int div2 = (num / 100) % 10;
                int rem2 = num % 10;
                if(div2 == rem2)
                    Console.WriteLine("Number is a palindrome");
            }
            else 
            Console.WriteLine("Number is NOT a palindrome");
            
    }
    else
    Console.WriteLine("Incorrect number!");
}
 
Console.WriteLine("Input five-digit number:");
int number = Convert.ToInt32 (Console.ReadLine());
CheckPalindrome(number);