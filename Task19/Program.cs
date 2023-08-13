// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number *= -1;
}
if (number >= 10000 && number <= 99999)
{

    CheckPalindrome(number);
}
else
{
    Console.Write("Ошибка ввода");
}

bool CheckPalindrome(int num)
{
    int firstDigit = num / 10000;
    int secondDigit = num / 1000 % 10;
    int penultimateDigit = num / 10 % 10;
    int lastDigit = num % 10;
    if (firstDigit == lastDigit && secondDigit == penultimateDigit)
    {
        Console.WriteLine("Да");
        return true;
        
    }
    Console.WriteLine("Нет");
    return false;
    

}
