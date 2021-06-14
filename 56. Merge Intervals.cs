public class Solution {
    public int[][] Merge(int[][] intervals) {
        
        if (intervals == null || intervals.Length == 0)
            return new int[][] { };
        
        List<int[]> result = new List<int[]>();
        
        foreach (var item in intervals.OrderBy(x => x[0]).ToArray())
            if (result.Count == 0 || result[result.Count - 1][1] < item[0])
                result.Add(item);
            else
                result[result.Count - 1][1] = Math.Max(result[result.Count - 1][1], item[1]);
        
        return result.ToArray();
    }
}