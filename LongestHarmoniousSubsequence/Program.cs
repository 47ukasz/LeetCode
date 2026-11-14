using LeetCode.Solution;

var solution = new Solution();
var examples = new (int[] Nums, int Expected)[]
{
    ([1, 3, 2, 2, 5, 2, 3, 7], 5),
    ([1, 2, 3, 4], 2),
    ([1, 1, 1, 1], 0),
    ([1,3,5,7,9,11,13,15,17], 0),
    ([1,1,1,1,1,1,3,5,5,6],3)
};

foreach (var (nums, expected) in examples)
{
    var actual = solution.FindLHS(nums);
    Console.WriteLine($"[{string.Join(", ", nums)}]: wynik = {actual}, oczekiwano = {expected} — {(actual == expected ? "OK" : "BŁĄD")}");
}
