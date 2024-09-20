public class Solution {
    public bool CheckIfPangram(string sentence) {
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        foreach(char i in alphabet){
            if(!sentence.Contains(i)){
                return false;
            }
        }
        return true;
    }
}