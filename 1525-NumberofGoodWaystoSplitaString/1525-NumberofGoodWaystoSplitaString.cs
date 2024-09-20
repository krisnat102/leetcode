public class Solution {
    public int NumSplits(string s) {
        int n = s.Length;
        if (n == 1) return 0;

        int[] prefixUnique = new int[n];
        int[] suffixUnique = new int[n];
        HashSet<char> seen = new HashSet<char>();

        for (int i = 0; i < n; i++) {
            seen.Add(s[i]);
            prefixUnique[i] = seen.Count;
        }

        seen.Clear();

        for (int i = n - 1; i >= 0; i--) {
            seen.Add(s[i]);
            suffixUnique[i] = seen.Count;
        }

        int goodSplits = 0;

        for (int i = 0; i < n - 1; i++) {
            if (prefixUnique[i] == suffixUnique[i + 1]) {
                goodSplits++;
            }
        }

        return goodSplits;
    }
}
