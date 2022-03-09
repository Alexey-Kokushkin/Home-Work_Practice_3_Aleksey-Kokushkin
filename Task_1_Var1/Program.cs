// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

Console.WriteLine("Введите пятизначное число => ");
String inputnumber = Console.ReadLine();
int size = inputnumber.Length;
if (size < 5 || size > 5)
{
    Console.WriteLine("Вы ввели не пятизначное число  " + inputnumber);
}
else
{
    if (inputnumber[0] == inputnumber[4])
    {
        if (inputnumber[1] == inputnumber[3])
        {
            Console.WriteLine(" Данное число " + inputnumber + " является палиндромом ");
        }
    }
    else
    Console.WriteLine(" Данное число " + inputnumber + " не является палиндромом ");
}

