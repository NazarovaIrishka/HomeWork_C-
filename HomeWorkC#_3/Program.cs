// Задача 1.

/*
void PalindromeNumber (int num)
{
 if (num/10000 == num % 10)
 {
    if ((num / 10) % 10 == (num / 1000) % 10)
    {
        Console.WriteLine($"The {num} is a palindrome. ");
    }
    else
    {
        Console.WriteLine($"The {num} is not a palindrome. ");
    }
 }
else
{
    Console.WriteLine($"The {num} is not a palindrome. ");
}
} 

int N;
Console.Write("Enter a five-digit number : ");
N = Convert.ToInt32 (Console.ReadLine());

PalindromeNumber (N);

*/


// Задача 2.


/*
double LengthIn3D (double xa, double ya, double za, double xb, double yb, double zb)
{
   return Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2) );
}


Console.Write("Enter Xa : ");
int Xa = Convert.ToInt32 (Console.ReadLine());

Console.Write("Enter Ya : ");
int Ya = Convert.ToInt32 (Console.ReadLine());

Console.Write("Enter Za : ");
int Za = Convert.ToInt32 (Console.ReadLine());

Console.Write("Enter Xb : ");
int Xb = Convert.ToInt32 (Console.ReadLine());

Console.Write("Enter Yb : ");
int Yb = Convert.ToInt32 (Console.ReadLine());

Console.Write("Enter Zb : ");
int Zb = Convert.ToInt32 (Console.ReadLine());


Console.WriteLine( LengthIn3D(Xa, Ya, Za, Xb, Yb, Zb) );

*/


// Задача 3.
/*
void CubeNumber (int num)
{
    int carrent = 1;
    while (carrent <= num)
    {
        Console.Write(Math.Pow(carrent,3) + " ");
        carrent++;
    }

}

void CubeNumberBack (int num)
{
    int carrent = 1;
    while (carrent >= num)
    {
        Console.Write(Math.Pow(num,3) + " ");
        num++;
    }

}
 
 Console.Write("Enter number: ");
 int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
    CubeNumber (N);
}
else
{
    CubeNumberBack (N);
}
*/