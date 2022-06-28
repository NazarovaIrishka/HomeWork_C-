
// Задача 1.

// Проблема при конвертации. Не уверена, что правильно написано. 
// Программу можно запуститьчерез конвертацию, но высвечивается предупреждение "Разыменование вероятной пустой ссылки". Не понимаю как исправить.


/*
int NumberOfPositiveNumbers (int [] array)
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
    }
    return counter;
    
}
*/

//Проверка программы через конвертацию.
/*
Console.Write ("Enter array elements using a spaces: ");
int[] myArray = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int result = NumberOfPositiveNumbers (myArray);
Console.WriteLine("Number of positive numbers = " + result);
*/

//Проверка программы через "Магические числа".
/*
int [] myArray = new int [] {-1, 2, 3, -7, -9, 0, -100, 1000};
Console.WriteLine ("Number of positive numbers = " + NumberOfPositiveNumbers(myArray)); 
*/







//Задача 2.
// Вопрос: как проверить, что выводится "копированный" массив, а не заданный.

int [] CopyArray (int [] array)
{
    int [] NewArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++ )

    {
        NewArray [i]  = array [i];
    }
    return NewArray;

} 

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
        Console.Write (array[i] + " ");
    }
    Console.WriteLine();
}



// Проверка программы через конвертацию.
/*
Console.Write ("Enter array elements using a spaces: ");
int[] A = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

PrintArray (A);
CopyArray (A);
PrintArray (A);
*/

/* Проверка программы через "Магические числа".
int [] myArray = {1, -2, 3, 5, -6, 7};
PrintArray (myArray);
CopyArray (myArray);
PrintArray (myArray);
*/

