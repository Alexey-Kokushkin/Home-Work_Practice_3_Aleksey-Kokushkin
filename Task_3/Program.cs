// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27.
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N: ");
String inputnumber = Console.ReadLine();
int number = int.Parse(inputnumber);
int i = 1;
while (i<=number)
{
    double result = Math.Pow(i, 3);
    Console.WriteLine("Таблица кубов числа " +number+ " => " + result);
    i++; 
}
//Console.Write("Таблица кубов чисел от 1 до N => "+result + " ");
