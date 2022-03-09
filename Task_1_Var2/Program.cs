// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

Console.WriteLine("Введите пятизначное число: ");
String inputnumber = Console.ReadLine();
int size = inputnumber.Length;

int index(int number)
{
    int units = dec % 10;
    int dec = number / 10;
    return units;
}
int[] array = new int[size];
int currentindex = size - 1;
while (currentindex > 0)
{
    array[currentindex] = index(number);
    currentindex = currentindex-1;
}

array[currentindex] = 0;
while (currentindex < size/2)
{
    if (array[currentindex] == array[size - currentindex - 1])
}

//int index(int number)
//{
    //int units = dec % 10;
    //int dec = number / 10;
    //return units;
//}
