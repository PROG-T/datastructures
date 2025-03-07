package Arrays;

public class BestTimeToBuyAndSellAStock {
    //You are given an array prices where prices[i] is the price of a given stock on the ith day.
    //You want to maximize your  profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
    //Return the maximum profit you can make from this transaction.If you cannot achieve any profit, return  0.

    public static int BuyAndSellStockMaxProfit(int[] prices){
        int minPrice = Integer.MAX_VALUE;
        int maximumProfit = 0;
         for(int index = 0; index < prices.length; index++){
            if(prices[index]< minPrice){
                minPrice = prices[index];
            }
            else{
                int profit = prices[index] - minPrice;
                maximumProfit = Math.max(maximumProfit,profit);
            } 
         }
         return maximumProfit;

    }
    public static void main(String[] args) {
        int[] arr = {1,4,7,0};
        int maxProfit = BuyAndSellStockMaxProfit(arr);
        System.out.println(maxProfit);
    }
}
