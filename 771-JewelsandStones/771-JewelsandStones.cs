public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int gems = 0;
        char[] jewelsChar = jewels.ToCharArray(0, jewels.Length);
        foreach(var stone in stones){
            if(jewelsChar.Contains(stone)) gems++;
        }

        return gems;
    }
}