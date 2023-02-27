int[] array = {15, 72, 39, 74, 55, 46, 97, 28,};

int n = array.Length;
int find = 28;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
index = index + 1;
}