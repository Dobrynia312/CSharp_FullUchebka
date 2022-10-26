int[] massiv = { 1, 4, 2, 6, 8, 9, 10, 5, 1 };
void PrintMass(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
     System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count-1; i++)
    {
        int minPos = i;
        for (int j = i+1; j < count; j++)
        {
            if (array[j]<array[minPos]) minPos = j;
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;

    }
}

void SelectionSort2(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count-1; i++)
    {
        int minPos = i;
        for (int j = i+1; j < count; j++)
        {
            if (array[j]>array[minPos]) minPos = j;
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;

    }
}
SelectionSort(massiv);
PrintMass(massiv);
SelectionSort2(massiv);
PrintMass(massiv);