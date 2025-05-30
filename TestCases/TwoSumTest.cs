using LeetCodeProblems.Problems;

namespace LeetCodeProblems.TestCases
{
    public class TwoSumTest
    {
        public void Run()
        {
            var solver = new TwoSumProblem();

            int[] nums = { 3, 2, 4 };
            int target = 6;
            int[] result = solver.TwoSum(nums, target);

            Console.WriteLine($"Resultado: [{result[0]}, {result[1]}]");
        }
    }
}
