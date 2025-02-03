namespace LeetCodeSolutions.Easy
{
    public class TwoSums
    {
        /// <summary>
        /// 1. Two Sum
        /// 
        /// Given an array of integers nums and an integer target, 
        /// return indices of the two numbers such that they add up to target.
        /// 
        /// You may assume that each input would have exactly one solution, 
        /// and you may not use the same element twice.
        /// 
        /// Example :
        /// Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        /// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSumwWithBruteForce(int[] nums, int target)
        {
            var result = new[] { 0, 0 };
            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }


            }

            return result;
        }

        public int[] TwoSumWithDictionary(int[] nums, int target)
        {
            var numsByDictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                numsByDictionary[nums[i]] = i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var y = target - nums[i];
                if (numsByDictionary.ContainsKey(y) && numsByDictionary[y] != i)
                    return new int[] { i, numsByDictionary[y] };
            }

            return new int[2];

        }
    }
}
