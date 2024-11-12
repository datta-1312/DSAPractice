public class MergeArrays
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
       
       int i = 0,j = 0,k=m+n;
        int y = 0;

        int[] outputArray = new int[k];
        
        while(i < m && j < n)
        {
            if(nums1[i] <= nums2[j])
            {
                outputArray[y++] = nums1[i++];
                continue;
            }
            outputArray[y++] = nums2[j++];
        }

        while(i < m)
        {
            outputArray[y++] = nums1[i++];
        }

        while(j < n)
        {
            outputArray[y++] = nums2[j++];
        }
        nums1 = new int[outputArray.Length];
        for(int z = 0; z < outputArray.Length; z++)
        {
            nums1[z] = outputArray[z];
        }
    }
    //     int i = m-1,j = n-1,k=m+n-1;
        
    //     while(i >= 0 && j >= 0)
    //     {
    //         if(nums1[i] < nums2[j])
    //         {
    //             nums1[k--] = nums1[i--];
    //             continue;
    //         }
    //         nums1[k--] = nums2[j--];
    //     }

    //     while(i < m)
    //     {
    //         nums1[k--] = nums1[i--];
    //     }

    //     while(j < n)
    //     {
    //         nums1[k--] = nums2[j--];
    //     }
    // }
}

/*
int[] temp = new int[m+n];
        int i = 0,j = 0,k = 0;
        
        while(i < m && j < n)
        {
            if(nums1[i] <= nums2[j])
            {
                temp[k++] = nums1[i++];
                continue;
            }
            temp[k++] = nums2[j++];
        }

        while(i < m)
        {
            temp[k++] = nums1[i++];
        }

        while(j < n)
        {
            temp[k++] = nums2[j++];
        }

        nums1 = new int[temp.Length];
        for(int z = 0; z < temp.Length; z++)
        {
            nums1[z] = temp[z];
        }
*/