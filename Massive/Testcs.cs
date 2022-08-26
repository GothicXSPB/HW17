int[] array = new int[] { -5, 3, 18, 44, -500, -4, 52 };

int min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (min > array[i])
    {
        min = array[i];
    }
}

Console.WriteLine(min);