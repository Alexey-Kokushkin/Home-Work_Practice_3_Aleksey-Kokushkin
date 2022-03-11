// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

Console.WriteLine("Введите пятизначное число: ");
String inputnumber = Console.ReadLine();
int size = inputnumber.Length;
int number = int.Parse(inputnumber);

int[] array = new int[size];
int currentindex = 0;
while (currentindex < size)
{
    array[currentindex] = number%10;
    number = number/10;
    currentindex++;
}

currentindex = 0;
if (array[currentindex] != array[size - currentindex - 1])
{
    Console.WriteLine("Данное число " + inputnumber + " не является палиндромом ");
}
else
{
    currentindex = 0;
    while (currentindex < size/2)
    {
        if (array[currentindex] == array[size - currentindex - 1])
        {
            currentindex++;
        }
    }
    Console.WriteLine("Данное число " + inputnumber + " является палиндромом ");
}


