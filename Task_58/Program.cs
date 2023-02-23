int[,] array1 = new int [ReadInt(" number of lines in matrix № 1"), ReadInt( " column number in matrix № 1" )];
int[,] array2 = new int [ReadInt(" number of lines in matrix № 2"), ReadInt( " column number in matrix № 2" )];

AddDigitalToArray1(array1);
AddDigitalToArray1(array2);
Console.WriteLine();

PritnArray(array1);
Console.WriteLine();

PritnArray(array2);
Console.WriteLine();

PritnArray(MatrixMultiplication(array1,array2));

void AddDigitalToArray1 (int[,] digital)
{   
   for ( int i=0 ;  i < digital.GetLength(0); i++)
    {
        for (int j = 0; j < digital.GetLength(1); j++)
        {
            digital[i,j] = new Random().Next(-100,100);                                      
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
int[,] MatrixMultiplication ( int[,] array1 , int[,] array2 )
{   
    int[,] multiplmatrix = new int[array1.GetLength(0) , array2.GetLength(1)];
    if( array1.GetLength(1) != array2.GetLength(0) )
    {
        Console.WriteLine("multiplication of such matrices is impossible");
        return multiplmatrix;
    }    

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            multiplmatrix[i,j] = 0;
            for (int p = 0; p < array1.GetLength(1); p++)
            {
                multiplmatrix[i,j]+= array1[i,p]+ array2[p,j];
            }
        }
    }

    return multiplmatrix;
}