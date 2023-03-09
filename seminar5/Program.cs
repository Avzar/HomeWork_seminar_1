int[] GetRandomArray()
{
    int[] array = new int[12];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }

    return array;
}

int SumNegativeElements(int[ array])
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
}