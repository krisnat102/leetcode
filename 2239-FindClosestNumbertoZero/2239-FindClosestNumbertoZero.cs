public class Solution {
    public int FindClosestNumber(int[] nums) {
        int small = 100001;
        foreach(int n in nums){
            if(Math.Abs(n) < Math.Abs(small)){
                small = n;
            }
            else if(Math.Abs(n) == Math.Abs(small) && n > small){
                small = n;
            }
        }
        return small;
    }
}