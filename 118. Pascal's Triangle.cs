public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> list = new List<IList<int>>();
        for (int i = 1; i <= numRows; i++)
        {
            var lineList = new List<int>();
            int n = 1;
            for (int j = 1; j <= i; j++)
            {
                lineList.Add(n);
                n = n * (i - j)/j;
            }
            list.Add(lineList);
        }
        return list;
    }
}