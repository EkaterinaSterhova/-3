// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Clear();
Console.Write("Введите пятизначное число: ");
string s = Console.ReadLine()!;
while (s.Length>5)
{     
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    s=Console.ReadLine()!;
}
while (s.Length<5)
{     
    Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
    s=Console.ReadLine()!;
}
if (s[0]==s[4] && s[1]==s[3])
    Console.WriteLine("pallendrom");
else
     Console.WriteLine( "no pallendrom");