// Задача 1. 

/*
int [] FixedRandomArray (int size)
{
    int [] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random(). Next(100, 1000);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int FindEvenNumber (int [] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++ )
        if (array[i] % 2 == 0) counter++;
    return counter;
}


Console.Write ("Enter the number of array elements: ");
int elements = Convert.ToInt32(Console.ReadLine());

int [] CurrentArray = FixedRandomArray(elements);
Console.Write (CurrentArray);
Console.WriteLine();

int resulte = FindEvenNumber (CurrentArray);
Console.WriteLine (resulte);
*/












// Задача 2.

/*
int [] RandomArray (int size, int min, int max)
{
    int [] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random(). Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int NumberOddIndices (int [] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2) sum = sum + array[i];
    return sum;
}

Console.Write ("Enter the number of array elements: ");
int elements = Convert.ToInt32(Console.ReadLine());

Console.Write ("Enter the minimum value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write ("Enter the maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] CurrentArray = RandomArray(elements, min, max);
Console.Write (CurrentArray);
Console.WriteLine();

int resulte = NumberOddIndices (CurrentArray);
Console.WriteLine (resulte);
*/










//Задача 3.



double [] DoubleRandomArray (int size, int min, int max)
{
    double [] newArray = new double [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = Math.Round (new Random(). Next(min, max) + new Random().NextDouble(),10) ;
        Console.WriteLine(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

double MaximumValue (double [] array)
{
    double maximum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maximum) maximum = array [i];
    }

    return maximum;
    
}

double MinimumValue (double [] array)
{
    double minimum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minimum) minimum = array [i];
    }

    return minimum;
}



Console.Write ("Enter the number of array elements: ");
int elements = Convert.ToInt32(Console.ReadLine());

Console.Write ("Enter the minimum value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write ("Enter the maximum value: ");
int max = Convert.ToInt32(Console.ReadLine());


double [] CurrentArray = DoubleRandomArray(elements, min, max);
Console.Write (CurrentArray);
Console.WriteLine();


Console.WriteLine("Maximum value: " + MaximumValue(CurrentArray));
Console.WriteLine();

Console.WriteLine("Minimum value: " + MinimumValue(CurrentArray));
Console.WriteLine();

Console.WriteLine("Value difference: " +  (MaximumValue(CurrentArray) - MinimumValue(CurrentArray)));



