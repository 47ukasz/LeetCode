using LeetCode.Solution;

var solution = new Solution();

Check(solution.FindMaxAverage([1, 12, -5, -6, 50, 3], 4), 12.75);
Check(solution.FindMaxAverage([5], 1), 5);

static void Check(double actual, double expected)
{
    string status = Math.Abs(actual - expected) < 1e-5 ? "PASS" : "FAIL";
    Console.WriteLine($"{status} — wynik: {actual}, oczekiwano: {expected}");
}
