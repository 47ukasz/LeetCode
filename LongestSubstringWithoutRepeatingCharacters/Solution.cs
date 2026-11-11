namespace LeetCode.Solution;

public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        int r = 0;
        string sb = "";

        for (int i = 0; i <= s.Length - 1; i++)
        {
            int j = i;

            while (j <= s.Length - 1 && !sb.Contains(s[j]))
            {
                sb += s[j];
                j++;
            }

            r = sb.Length > r ? sb.Length : r;
            sb = "";
        }

        return r;
    }

    public int LengthOfLongestSubstringV2(string s)
    {
        throw new NotImplementedException();
    }
}