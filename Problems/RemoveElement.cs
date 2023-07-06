namespace Problems
{
    internal class RemoveElement
    {
        public static int Remove_Element(int[] nums, int val)
        {
            // Solution #1
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    k++;
                }
            }
            if (k != 0)
            {
                int j = nums.Length - 1;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == val && j > i)
                    {
                        while (nums[j] == val && j > i)
                        {
                            j--;
                        }
                        nums[i] = nums[j];
                        nums[j] = val;
                    }
                }
            }
            return k;




            // Soluion #2
            //int k = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] != val)
            //    {
            //        nums[k++] = nums[i];
            //    }
            //}
            //return k;
        }
    }
}
