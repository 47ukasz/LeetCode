namespace LeetCode.Solution;

public class Solution {
    public int FindLHS(int[] nums)
    {   
        if (nums.Length==0||nums.ToHashSet().Count()==1) return 0;
        int l=0,len=0;
        
        Array.Sort(nums);
        for(int r=0;r<nums.Length;r++)
        {
            while (nums[r]-nums[l]>1)
            {
                l++;
            }

            if (l!=r && nums[r]-nums[l]==1)
            {
                len=Math.Max(len,r-l+1);
            }
        }
        
        return len;
    }
}