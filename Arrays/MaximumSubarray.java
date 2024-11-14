package Arrays;

public class MaximumSubarray {

    public static void main(String[] args) {

        MaximumSubarray obj = new MaximumSubarray();
        int [] arr = {2, -8, 7, 9};
        int sum = obj.MaxSubarrayTotal(arr);
        System.out.println(sum);
    }


   //Given an integer array nums, find the subarray with the largest sum and return its sum 
   //This uses the Kadane's algorithm. This algorithm works based on choosing the maximum subarray ending at each position/index in the array and updating a global maximum as you go.
   
   public int MaxSubarrayTotal(int[] nums){
            int maximumSum = nums[0];
            int currentSum = nums[0];

            for(int index = 1; index < nums.length; index++)
            {
            currentSum = Math.max( nums[index] , currentSum + nums[index]);
            maximumSum = Math.max(maximumSum, currentSum);
            };
            return maximumSum;

            }
}
