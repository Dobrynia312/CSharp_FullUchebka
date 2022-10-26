int[] numbers = {2, 3, 13, 7, 6, 4};
int size = numbers.Length;
int sum = 0;
int avg = 0;
int index = 0;
while (index < size) {
    sum = sum + numbers[index];
    index++;
}
avg = sum/size;
Console.WriteLine (avg);