public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if(target < nums[0]) return 0;
        if(nums.Length == 1 && target > nums[0]) return 1;
        else if(nums.Length == 1 && target < nums[0]) return 0;
        for(int i = 0; i < nums.Length; i++){
            int j = i + 1;
            if(nums[i] == target){
                return i;
            }
            else if(j != nums.Length && nums[i] < target && target < nums[j]){
                return j;
            }
            else if(j == nums.Length) return j;
        }
        return 0;
    }
}