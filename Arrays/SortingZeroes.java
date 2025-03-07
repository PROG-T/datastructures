package Arrays;

import java.util.Arrays;

public class SortingZeroes {
    //Given an integer array nums, move all zeroes to the end of it while maintaining the relative order of the non-zero elements.
    //You must do this without making a copy of the array

    public static void main(String[] args) {
        SortingZeroes obj = new SortingZeroes();
        int[] nums = {0,4,2,0,9};
        System.out.println(Arrays.toString(obj.MoveZeros(nums)));
    }

    public int[] MoveZeros(int[] nums){
        int trackNoneZeroIndex = 0;// this index tracks every number apart from 0

        for (int i = 0; i < nums.length; i++){
            if(nums[i] != 0){
                nums[trackNoneZeroIndex] = nums[i];
                trackNoneZeroIndex++;
            }
        }

        for(int i = trackNoneZeroIndex; i < nums.length; i++){
            nums[i] = 0;
        }
         return nums;
    }
}
