public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int counter = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == val){
                nums[i] = 255;
                counter++;
            }
        }
        Array.Sort(nums);
        return nums.Length - counter;
    }
}