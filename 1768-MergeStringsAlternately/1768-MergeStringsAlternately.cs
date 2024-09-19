public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string result = "";
        int j = 0;
        for(int i = 0; i < word1.Length; i++){
            result += word1[i];
            if(j != word2.Length){
                result += word2[j];
                j++;
            }
        }
        if(j < word2.Length){
            result += word2.Substring(j);
        }

        return result;
    }
}