using LeetCode.Solution;

var solution = new Solution();
var testCases = new (string Input, int Expected)[]
{
    ("abcabcbb", 3),
    ("bbbbb", 1),
    ("pwwkew", 3),
    ("S", 1),
    ("mq", 2),
    ("eea", 2),
    ("OSo@", 4),
    ("1R1T7", 4),
    ("mjvhmi", 5)
};

var failedTests = 0;

foreach (var (input, expected) in testCases)
{
    var actual = solution.LengthOfLongestSubstring(input);
    var passed = actual == expected;

    Console.WriteLine(
        $"{(passed ? "PASS" : "FAIL")}: s = \"{input}\", oczekiwano: {expected}, otrzymano: {actual}");

    if (!passed)
    {
        failedTests++;
    }
}

Console.WriteLine($"Zaliczone testy: {testCases.Length - failedTests}/{testCases.Length}");
Environment.ExitCode = failedTests == 0 ? 0 : 1;
