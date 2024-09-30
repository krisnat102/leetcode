public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> numsDict = new Dictionary<int, int>(); 
        if(nums.Length == 1) return nums[0];

        foreach(int num in nums) {
            if(numsDict.ContainsKey(num)){
                numsDict[num]++;

                if(numsDict[num] > nums.Length / 2){
                    return num;
                }
            }
            else numsDict.Add(num, 1);
        }
        return 0;
    }
}