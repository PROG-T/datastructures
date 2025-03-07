public class ContainsDuplicate{
    public bool BruteForceMethod(int[] nums){
        for(int i = 0; i < nums.Length -1, i++){
            for(int j = i+1; j< nums.Length; j++){
                if (num[i] = nums[j])
                return true;
            }
        }
        return false;
    }

        public bool HashmapApproach(int[] nums){
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++){
                if(numbers.ContainsKey(nums[i]))
               { return true;}
               numbers[nums[i]] = i;
            }
            return false;
        }

        //using has hashset
        public bool HashSetApproach(int[] nums){
            HashSet<int> numbers = new HashSet<int>;
            foreach int num in nums{
                if(numbers.Add(num) == false){
                    return true;
                }
            }
            return false;
        }

}