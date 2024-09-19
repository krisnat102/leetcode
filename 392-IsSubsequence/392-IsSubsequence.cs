public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(string.IsNullOrEmpty(t) && string.IsNullOrEmpty(s) ) {
            return true;
        }
        else if(string.IsNullOrEmpty(t)){
            return false;
        }
        else if(s.Length > t.Length){
            return false;
        }
        int tracker = 0;
        foreach(char c in s){
            if(c != t[tracker] && s.Length == t.Length) return false;
            while(c != t[tracker] && tracker <= t.Length - 2){
                tracker++;
            }
            if(c != t[tracker]) return false;

            if(tracker <= t.Length - 2) tracker++;
        }
        return true;
    }
}