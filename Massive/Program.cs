using System.Globalization;

namespace Massive;
public class AMassive
{
    //1) Найти минимальный элемент массива.
    public static int MinUnit(int[] array)
    {
        int min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
        return min;
    }
    //2) Найти максимальный элемент массива.

    public static int MaxUnit(int[] array)
    {
        int max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max;
    }

    //3) Найти индекс минимального элемента массива.

    public static int MinIndex(int[] array)
    {
        int min = array[0];
        int indexMin = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
                indexMin = i;
            }
        }
        return indexMin;
    }

    //4) Найти индекс максимального элемента массива.
    public static int MaxIndex(int[] array)
    {
        int max = array[0];
        int indexMax = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
                indexMax = i;
            }
        }
        return indexMax;
    }

    //5) Посчитать сумму элементов массива с нечетными индексами.

    public static int SumOfOddElements(int[] array)
    {
        int sum = 0;


        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum += array[i];
            }
        }
        return sum;
    }

    //6) Сделать реверс массива(массив в обратном направлении).

    public static int[] Reverse(int[] array)
    {
        int temp = 0;
        for (int i = 0; i <= array.Length/2; i++)
        {
            temp = array[i];
            array[i] = array[array.Length - (i+1)] ;
            array[array.Length - (i+1)] = temp;
        }
        return array;
    }

    //7) Посчитать количество нечетных элементов массива.

    public static int AmountOfOddElements(int[] array)
    {
        int sum = 0;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                sum++;
            }
        }
        return sum;
    }

    //8) Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2.

    public static int[] SwapHalf(int[] array)
    {
        int temp = 0;
        int x = 0;
        int d = (array.Length/2-1);
        for (int i = d; i >= 0; i--)
        {
            temp = array[i];
            array[i] = array[array.Length - (x+1)];
            array[array.Length - (x+1)] = temp;
            x++;
        }
        return array;
    }

    public static void Show(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
}


