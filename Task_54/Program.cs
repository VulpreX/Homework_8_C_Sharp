int[,] array = new int [ReadInt(" number of lines"), ReadInt( " column number" )];

AddDigitalToArray1(array);
Sorting(array);

Console.WriteLine();
PritnArray(array);

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
void Sorting(int[,] digital)
{
   for ( int i=0 ;  i < digital.GetLength(0); i++)
    {
        for (int j = 0; j < digital.GetLength(1); j++)
        {
            if(j >= 1)
            {
                while ( digital[i,j] > digital[i,j-1] && j >1)
                {
                    digital[i,j-1] = digital[i,j] + digital[i,j-1];
                    digital[i,j] = digital[i,j-1]- digital[i,j];
                    digital[i,j-1] = digital[i,j-1] - digital[i,j];
                    j--;
                }  
            }
            if(j >= 0)
            {
                if(digital[i,j] > digital[i,0])
                {
                    digital[i,0] = digital[i,j] + digital[i,0];
                    digital[i,j] = digital[i,0]- digital[i,j];
                    digital[i,0] = digital[i,0] - digital[i,j];
                }
            }
        }
    }
}
