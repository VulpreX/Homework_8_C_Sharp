int[,,] array1 = new int [ReadInt(" number of 1D lenght"),ReadInt(" number of 2D lenght "),ReadInt(" number of 3D lenght")];
int[] array= new int [array1.GetLength(0)*array1.GetLength(0)*array1.GetLength(0)];

AddDigitalToArray1(array);

PritnArray1(array);
Console.WriteLine();

PritnArray(array1,array);
Console.WriteLine();

int[] AddDigitalToArray1 (int[] digital)//этот метод просто взорвал мой мозг. зато теперь знаю bool
{   
   var random = new Random();
    {
        for (int i = 0; i < digital.Length; ++i)
        {
            bool Unique;
            do
            {
                digital[i] = random.Next(-100, 100);
                Unique = true;
                for (int j = 0; j < i; ++j)
                {
                    if (digital[i] == digital[j])
                    {
                        Unique = false;
                        break;
                    }
                }
            }
            while (!Unique);
        }
        return digital;
    }          
}
void PritnArray1 (int [] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
        Console.Write($"{array[i]}  ");
    }
}
void PritnArray (int [,,] array, int[] array1)
{
    int u=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {  
            for (int l = 0; l < array.GetLength(2); l++)
            {
                array[i,j,l]= array1[u];
                Console.Write($"{array[i,j,l]}({i},{j},{l})  ");
                u++;
            }
            Console.WriteLine();
        }
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