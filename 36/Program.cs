void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}
void Release(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
        sum += array[i];
    Console.WriteLine($"Сумма нечетных позиций: {sum}");
}
int[] array = new int[10];
InputArray(array);
Console.WriteLine($"Массив [{string.Join(", ", array)}]");
Release(array);
