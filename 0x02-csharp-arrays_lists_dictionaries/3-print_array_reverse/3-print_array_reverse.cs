using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("");
            return;
        }
        int y = array.Length - 1;
        for (int x = 0; x < array.Length / 2; x++)
        {
            int tmp = array[x];
            array[x] = array[y];
            array[y] = tmp;
            y--;
        }
        for (int z = 0; z < array.Length; z++)
        {
            if (z < array.Length - 1)
            {
                Console.Write(array[z] + " ");
            }
            else
            {
                Console.WriteLine(array[z]);
            }
        }
    }
}