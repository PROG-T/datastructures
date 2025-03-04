public class TwoSum{
    // Bruteforce approach
    public int[] BruteforceTwosum(int[] arr, int target){

      for (int i = 0; i < arr.Length; i++){
       for(int j = i+1; j<arr.Length; j++){
        if(arr[i] + arr[j]== target){
            return new int[] {i, j};
        }
       }
      }
         return new int[0];
    }

    public int[] OptimalTwoSum(int[] nums, int target){
        Dictionary<int, int> indices = new Dictionary<int, int>();
        for(int i = 0; i < nums.length; i++){
            int complement =  target - nums[i];
            if(indices.ContainsKey(complement)){
                return new int[]{i,indices[complement]};
            }
            indices[nums[i]] = i;
        }
        return new int[0];
    } 
}