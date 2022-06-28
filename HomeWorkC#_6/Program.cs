
int NumberOfPositiveNumbers (int [] array)
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
    }
    return counter;
}

Console.Write ("Enter array elements using a spaces: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int result = NumberOfPositiveNumbers (array);
Console.WriteLine("Number of positive numbers = " + result);








//Задача 2.
/*
int [] CopyArray (int [] array)
{
    int [] NewArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++ )
    {
        NewArray [i] = array [i];
    }
    return NewArray;
} 

Console.Write ("Enter array elements using a spaces: ");
int[] A = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

Console.Write (CopyArray(A));
*/
