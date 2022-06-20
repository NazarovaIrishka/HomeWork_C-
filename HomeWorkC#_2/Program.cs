// Задача 1.
/*
int SecondDigit (int num)
{ 
    if (num >= 100 && num <= 1000 )
    {
    int SotDec = num / 10;
    int dec = SotDec % 10;

    return dec;
    }
else
{
    return - 1;
} 
}

int num;
Console.Write("Enter a three-digit number: ");
num = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit (num);

if(result == -1)
{
    Console.WriteLine("Check number. ");
}
else
    Console.WriteLine(result);
*/



// Задача 2.

/*
int ThirdNamber (int num)
{
        int ed = num % 10;
        return ed;
}

int a;

Console.Write("Введите число: ");
a = Convert.ToInt32(Console.ReadLine());

if (a < 100)
{
    Console.WriteLine ("Is not a three digit namber.");
}
else
{ 
    while (a > 999)
{
    a = a / 10;
}
    int result = ThirdNamber (a);
    Console.WriteLine (result);
}
*/



// Задача 3.

/*string DaysOfTheWeek(int num)

{
    if(num >= 1 && num <= 5 ) 
    {
        return "Is not a weekend.";
    }
    else 
        return "Day off. ";

}
int A;

Console.Write("Введите число соответсвующее дню недели: ");
A= Convert.ToInt32(Console.ReadLine());
    if (A > 0 && A < 8)
    {
        string result = DaysOfTheWeek(A);

        Console.WriteLine(result);
    }

    else
    {
        Console.WriteLine("Check day. ");
    }

*/