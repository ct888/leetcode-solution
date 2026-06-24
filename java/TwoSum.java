class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.length; i++){

            for(int j = i + 1; j < nums.length; j++){
                int needs = nums[i] + nums[j];
                int complete = target;
                if(needs == complete){
                    return new int[]{i, j};
                }
            }
        }
        return new int[]{};
    }
}