void InputArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 101);
}
void Release(int[] array)
{
    int min = array[0];
    int max = array[1];
    if (min > max)
    {
        min = array[1];
        max = array[0];
    }
    int dif = 0;
    for(int i = 2; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    Console.WriteLine($"Минимальное: {min}");
    Console.WriteLine($"Максимальное: {max}");
    Console.WriteLine($"Разница: {dif = max - min}");
}
int[] array = new int[10];
InputArray(array);
Console.WriteLine($"Массив [{string.Join(", ", array)}]");
Release(array);