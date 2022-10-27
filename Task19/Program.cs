/*Задача 19
Напишите программу, 
которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */


Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine() ??"");
Console.WriteLine();
if(number < 100000 && number > 9999)
    {
        Console.WriteLine($"Введенное число {number}");
    }
else
    {
        Console.WriteLine("Введено не пятизначное число. Попробуйте еще раз))");
        return;
    }   
string numberAsString = number.ToString();
int index0 = int.Parse(numberAsString[0].ToString());
int index1 = int.Parse(numberAsString[1].ToString());
int index3 = int.Parse(numberAsString[3].ToString());
int index4 = int.Parse(numberAsString[4].ToString());
if (index0 ==  index4 && index1 == index3)
    {
        Console.WriteLine("Является палиндромом");
    }
else
    {
        Console.WriteLine("Не является палиндромом");
        return;
    }
    