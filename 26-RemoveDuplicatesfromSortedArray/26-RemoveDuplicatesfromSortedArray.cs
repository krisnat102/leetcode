public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int counter = 0;
        for(int i = 0; i < nums.Length; i++){
            if(i != nums.Length - 1 && nums[i] == nums[i+1]){
                nums[i] = 255;
            }
            if(nums[i] != 255) counter++;
        }
        Array.Sort(nums);
        return counter;
    }
}