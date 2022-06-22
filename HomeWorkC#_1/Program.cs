
// Задвача 1.
/*
int num1, num2;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 < num2)
{
    Console.WriteLine("max = " + num2 + " , " + "min = " + num1 );
}
else
{
    Console.WriteLine("max = " + num1 + " , " + "min = " + num2 );
}
*/






/*
//Задача 2

int num1, num2, num3, max;

Console.Write("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;

if(max<num2)
{
    max = num2;
}
if(max<num3)
{
    max = num3;
}
Console.WriteLine("max = " + max);

*/






/*
// Задача 3

int num;
Console.Write("Введите число");
num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.Write ("Число, " + num + ", " + " является чётным. " );
}
else
{
    Console.Write ("Число, " + num + ", " + "является нечётным. " );
}
*/







// Задача 4

int N, current = 2;
Console.Write("Введите число ");
N = Convert.ToInt32(Console.ReadLine());

while(current <= N)
{
    
    
    Console.Write ( current + " " );
    current = current+=2;

}

Console.WriteLine(" ");
