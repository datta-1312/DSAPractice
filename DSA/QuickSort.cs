using System.Collections.Concurrent;

public class QuickSort
{
    public void Sort(int[] inputArray,int low,int high)
    {
        if(low>=high) return;
        int pivot = Partition(inputArray,low,high);

        Sort(inputArray,low,pivot-1);
        Sort(inputArray,pivot+1,high);
    }

    private int Partition(int[] inputArray,int low,int high)
    {
        int pivot = inputArray[high];
        int l = low - 1;

        for(int i=low;i<high;i++)
        {
            if(inputArray[i] <= pivot)
            {
                l++;
                (inputArray[i],inputArray[l]) = (inputArray[l],inputArray[i]);
            }
        }
        l++;
        (inputArray[l],inputArray[high]) = (inputArray[high],inputArray[l]);
        return l;
    }
}