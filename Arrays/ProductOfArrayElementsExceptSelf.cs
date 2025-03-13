public class ProductOfArrayElementsExceptSelf{
    public int[] BruteForceApproach((int[] arr)){
        int[] multiples = new int[arr.Length];
        int tracker = 1;
         for (int i = 0; i < arr.Length; i++){
            for(int j = 0; j< arr.Length; j++){
                if(j!=i){
                   tracker = tracker * arr[j];
                }
            }
            multiples[i] = tracker;
         }
         return multiples;
    }

    public int[] OptimalApproach(int[] nums){

        int[] result = new int[nums.Length]

        //move from left to right, to get total value before each index
         int prefix = 1;

        for(int i = 0; i<nums.Length; i++){
            result[i] = prefix;
            prefix = prefix * nums[i];
        }

        int suffix = 1;
        
        for(int i = nums.Length - 1; i>=0; i--){
            result[i] = result[i]* suffix;
            suffix = suffix * nums[i];
        }
        return result;
    }
}