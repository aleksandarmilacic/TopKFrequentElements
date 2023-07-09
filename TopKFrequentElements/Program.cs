using System;
using System.Collections.Generic;
using System.Linq;
namespace TopKFrequentElements
{
    public class TopKFrequentElements
    {
        public IList<int> TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count[num] = 1;
                }
            }

            List<(int Frequency, int Num)> freqList = count.Select(x => (Frequency: x.Value, Num: x.Key)).ToList();
            freqList.Sort((x, y) => y.Frequency.CompareTo(x.Frequency));  // Sort by frequency in descending order

            return freqList.Take(k).Select(x => x.Num).ToList();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TopKFrequentElements topKFrequent = new TopKFrequentElements();
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2;
            IList<int> result = topKFrequent.TopKFrequent(nums, k);
            Console.WriteLine(string.Join(", ", result)); // Output: 1, 2
        }
    }

}