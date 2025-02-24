public class searchInRotatedArray{
    public int Search(int[] nums, int target){
        int leftIndex = 0;
        int rightIndex = nums.length - 1;
        while(leftIndex < rightIndex){
        int midIndex = leftIndex + (rightIndex -leftIndex)/2;
        if(target == nums[midIndex])return midIndex;

        if(nums[leftIndex] <= nums[midIndex]){ // sorted half of the array
           if(nums[leftIndex] <= target && target <= nums[midIndex] ){
            rightIndex = midIndex - 1;
           }
           leftIndex = midIndex + 1;
        }
        else{
            if(nums[midIndex]<= target && target<== nums[rightIndex]){
                leftIndex = midIndex +1;
            }
            rightIndex = midIndex -1;
        }
    }
    return -1;
}
}