//Задача 1.

/*
double Exponentiation (int A, int B)
{
   return Math.Pow((A),B);
}

Console.Write("Enter number A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a natural number B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B > 0)
{
double resulte = Exponentiation(A, B);

Console.Write(resulte);
Console.WriteLine();
}
else
{
    Console.WriteLine($"The number {B} is not natural. Check, please.");
}

*/




//Задача 2.


/*
Console.Write("Enter the number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [ size ];

if (size > 0)
{
Array (arr);
PrintArray (arr);
}
else
{
    Console.WriteLine("Chek the number of elements. ");
}




void PrintArray(int [] array) 
{
    
    for (int i = 0; i < size; i++) 
    {
        Console.Write( array[i] + " " );
    }
    Console.WriteLine();
}

void Array (int [] array )
{
    for(int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0, 101); 
}
}


*/
// Выбор случайных чисел сделала до 100, т.к. в примере больше чем двузначных чисел нет. 