void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}
void Release(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i]%2 == 0)
            count++;
    Console.WriteLine($"Количество четных чисел: {count}");
}
int[] array = new int[10];
InputArray(array);
Console.WriteLine($"Массив [{string.Join(", ", array)}]");
Release(array);