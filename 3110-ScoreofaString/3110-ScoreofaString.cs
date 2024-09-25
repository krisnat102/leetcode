public class Solution {
    public int ScoreOfString(string s) {
        int sum = 0;
        char prev = ' ';
        foreach (char letter in s)
        {
            if(prev != ' '){
                sum += Math.Abs((int)prev - (int)letter);
            }
            prev = letter;
        }
        return sum;
    }
}