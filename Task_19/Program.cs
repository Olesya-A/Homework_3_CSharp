// 19 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());

int digit1 = number / 10000;
int digit2 = number / 1000 % 10;
int digit4 = number / 10 % 10;
int digit5 = number % 10;

if (digit1 == digit5 && digit2 == digit4)
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Число НЕ является полиндромом");
}

// Альтернативное решение

// Console.WriteLine("Введите пятизначное число");
// string input = Console.ReadLine();

// if (input[0]==input[4] && input[1]==input[3])
// {
// Console.WriteLine("Число является полиндромом");
// }
// else
// {
// Console.WriteLine("Число НЕ является полиндромом");
// }

// ФУНКЦИЯ, КОТОРАЯ ПРОВЕРЯЕТ, ЯВЛЯЕТСЯ ЛИ ЧИСЛО ПОЛИНДРОМОМ

// bool Polindrom(string number)
// {
// for (int i = 0; i < number.Length / 2; i++)
// {
// // check = check & number[i] == number[number.Length - i - 1];
// if (number[i] != number[number.Length - i - 1])
// return false;
// }

// return true;
// }