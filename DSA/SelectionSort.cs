public class SelectionSort
{
    public void Sort(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            int minIndex = i;
            for(int j = i+1; j < array.Length; j++)
            {
                if(array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            if(minIndex != i)
            {
                (array[minIndex],array[i]) = (array[i],array[minIndex]);
            }
        }
    }
}