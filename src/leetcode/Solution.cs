public class Solution
{
    /// <summary>
    /// 给定一个整数数组 nums 和一个整数目标值 target，在该数组中找出和为目标值 target的那两个整数
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns>返回它们的数组下标</returns>
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
    /// <summary>
    /// 求m和n的最大公约数
    /// </summary>
    /// <param name="m"></param>
    /// <param name="n"></param>
    /// <returns>如果返回0，说明没有最大公约数</returns>
    public int GetGcd(int m,int n)
    {
        if(n==0)return m;
        int[] result=ComputeGcd(m,n);
        m=result[0];
        n=result[1];
        while(n!=0)
        {
            result=ComputeGcd(m,n);
            m=result[0];
            n=result[1];
        }
        return m;
    }
    //公约数一次计算
    private int[] ComputeGcd(int m,int n)
    {
        return new int[]{n,m%n};
    }
}