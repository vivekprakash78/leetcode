public class Solution {
    public bool IsMatch(string s, string p) {
        
        int start = -1, end = -1;
        int i = 0,j = 0;
        
        while(j < s.Length)
        {
            if(i < p.Length && (p[i] == s[j] || p[i] == '?'))
            {
                i++;
                j++;
            }
            else if(i < p.Length && p[i] == '*')
            {
                i++;
                start = i;
                end = j;
            }
            else if(start != -1)
            {
                j = end++;
                i = start;
            }
            else
            {
                return false;
            }
        }
        
        while(i < p.Length && p[i] == '*')
        {
            i++;
        }
        
        return (i == p.Length);
    }
}