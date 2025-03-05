public class BestTimeToBuyAndSellAStock{
    public int BruteForceApproach(int[] nums){ //0(n2) runtime
        int maximumProfit = 0;
        for (int i = 0; i < nums.Length-1; i++){
            for(int j = 0; j < nums.Length; j++){
                int profit = nums[j]- nums[i];
                maximumProfit = Math.Max(maximumProfit, profit);
            }
        }
        return maximumProfit;
    }

    public int OptimalApproach(int[] nums){ //0(n) runtime
        int minimumPrice = int.maxValue;
        int maximumProfit = 0;

        for (int i = 0; i < nums.length; i++){
             minimumPrice = Math.Min(minimumPrice,nums[i]);
             maximumProfit = Math.Max(maximumProfit. nums[i] - minimumPrice);
        }
        return maximumProfit;

    }
}