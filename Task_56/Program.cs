int[,] array = new int [ReadInt(" number of lines"), ReadInt( " column number" )];

AddDigitalToArray1(array);
Console.WriteLine();

PritnArray(array);
Console.WriteLine();

MinSum(SumNumbersInLines(array));

void AddDigitalToArray1 (int[,] digital)
{
   for ( int i=0 ;  i < digital.GetLength(0); i++)
    {
        for (int j = 0; j < digital.GetLength(1); j++)
        {
            digital[i,j] = new Random().Next(-10,100);
        }
    }
}
void PritnArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
       Console.WriteLine();
    }
}
int ReadInt(string argument1)
{
    Console.Write($"Enter {argument1} ");
    int number;

    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine(" You entered an invalid number, try again!");
    }
    
    return number; 
}
int[] SumNumbersInLines( int [,] array)
{
    
    int [] NewArraySumLines = new int [array.GetLength(0)]; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            NewArraySumLines[i] += array[i,j];
            if( i == array.GetLength(0) && j == array.GetLength(1))
            {
                return NewArraySumLines;
            }

        }
        Console.WriteLine($"Sum numbers in line {i} = {NewArraySumLines[i]}");
    }
    return NewArraySumLines;
}
void MinSum(int[]array)
{
    int minsum = array[0];
    int maxsum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if( minsum > array[i])
        {
            minsum = array[i];
        }
        if( maxsum < array[i])
        {
            maxsum = array[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine($"minimal sum in Lines ={minsum} and maximal ={maxsum}");    
}
