public class HouseRobber{
    public HouseRobber(Parameters)
    {
        
    }

public int MaxAmount(int[] arr){
if(arr.Length == 0) return 0;
if(arr.Length == 1) return arr[0];
int prev1 = 0;
int prev2 = 0;
foreach(int money in arr){
    int maxAmount = Math.Max(prev1, prev2 + money);
    prev2 = prev1;
    prev1 = maxAmount;
}
return MaxAmount;

    }
}