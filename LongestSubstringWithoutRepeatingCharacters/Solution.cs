namespace LeetCode.Solution;

public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> sub = new();
        int longest = 0;
        int l = -1;

        for (int r = 0; r < s.Length; r++)
        {
            while (sub.Contains(s[r]))
            {
                l++;
                sub.Remove(s[l]);
            }

            sub.Add(s[r]);
            longest = Math.Max(longest, sub.Count);
        }

        return longest;
    }
}