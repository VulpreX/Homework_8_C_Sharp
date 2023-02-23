int[] array = new int [5];


PritnArray(array);
Console.WriteLine();

void AddDigitalToArray1 (int[,] digital)
{   
  for (int i = 0; i < digital.GetLength(0); i++)
    {
        for (int j = 0; j < digital.GetLength(1); j++) Console.Write("{0,3} ", digital[i, j]);
        Console.WriteLine();
    }
}
void PritnArray (int [] array)
{
    while (true)
    {
        int n= ReadInt(" numbers of lines and column(square table)");        
        Console.WriteLine();      
        int[,] a = new int[n, n];
        int i = 0, j = 0;
        int v = 1;

        while (n != 0)
        {
            int k = 0;
            do 
            { 
                a[i, j++] = v++;
            }
            while (++k < n - 1);
            {
                for (k = 0; k < n - 1; k++)
                { 
                    a[i++, j] = v++;
                }

                for (k = 0; k < n - 1; k++)
                {
                     a[i, j--] = v++;
                }

                for (k = 0; k < n - 1; k++)
                {
                    a[i--, j] = v++;
                }

                ++i; ++j; n = n < 2 ? 0 : n - 2;
            }        
        }
        AddDigitalToArray1(a);
        Console.WriteLine();

        break;
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
