// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

Console.WriteLine("Введите пятизначное число: ");
String inputnumber = Console.ReadLine();
int size = inputnumber.Length;

int[] array = new int[size];
int currentindex = size - 1;
while (currentindex > 0)
array[size-1] = index(number);
currentindex = currentindex-1;

int index(int number)
{
    int units = dec % 10;
    int dec = number / 10;
    return units;
}
