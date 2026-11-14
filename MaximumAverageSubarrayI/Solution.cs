namespace LeetCode.Solution;

public class Solution {
    public double FindMaxAverage(int[] nums, int k)
    {
        double max = Double.NegativeInfinity;
        int l = 0, sum = 0;

        if (nums.Length == 1) return (double)nums[0] / k;
        if (nums.Length == k) return (double)nums.Sum() / k;

        for (int r = 0; r < nums.Length; r++)
        {
            if (r - l + 1 > k)
            {
                sum-=nums[l];
                l++;
            }

            sum+=nums[r];

            if (r - l + 1 == k)
            {
                max = Math.Max(max, (double)sum / k);
            }
            
        }

        return max;
    }
}