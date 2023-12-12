public class Solution
{
    public int[] TwoSum(int[] nums, int target) {
        foreach(var item in nums)
        {
            var temp=nums.ToList();
            temp.Remove(item);
            if(temp.Contains(target - item))
            {
                List<int> result=new List<int>();
                int[] targets=new int[]{item,target-item};
                //遍历找到这两个数的下标
                for(var index=0;index<nums.Length;index++)
                {
                    if(targets.Contains(nums[index]))
                    {
                        result.Add(index);
                    }
                }
                return result.ToArray();
            }
        }
        return new int[]{};
    }
}