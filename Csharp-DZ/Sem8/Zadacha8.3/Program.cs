// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
void FillArray(int[,,] array)
{
    int EL = 10;
    int El = -100;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
         for (int k = 0; k < array.GetLength(2); k++)
            {   if (EL >= 99 && El<-9)
                {  
                   array[i, j, k] = El++;
                }
                if (EL>=10 && EL<100)
                {
                    array[i, j, k] = EL++;
                }
                
            }
        

}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
                
            }
            Console.WriteLine();
        }
        
    }
}

int[,,] Array = new int[5,6,6];
FillArray(Array);
PrintArray(Array);
