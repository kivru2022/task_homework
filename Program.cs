//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и возврещает значение этого элемента 
int rows = new Random().Next(10);

int columns = new Random().Next(10);


int[,] GetArray(int m, int n)
{
  int[,] matrix = new int[m, n];
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
          matrix[i, j] = new Random().Next(11);
       }
   }
   return matrix;
}

void PrintArray(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
  {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        Console.Write(matrix[i, j] + "\t");
      }
    Console.WriteLine();
  }
}

void CheckPosition(int[,] matrix, int a, int b )
{
    for (int i = 0; i < matrix.GetLength(0); i++)
 {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(i == a && j == b) 
        {
            Console.WriteLine("Данная позиция соответствует числу " + matrix[i,j]);
            
            break;
        } 
        else
        {
            Console.WriteLine("Данной позиции нет");
            break;
        }
    }  
    
 } 

}

int[,] resultArray = GetArray(rows,columns);
PrintArray(resultArray);

Console.WriteLine("Введите позиции");
int positionOne = Convert.ToInt32(Console.ReadLine());
int positionTwo = Convert.ToInt32(Console.ReadLine());
CheckPosition(resultArray, positionOne, positionTwo);

