using Leetcode.Solution;

var solver = new Solution();

Run(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, "[7,0,8]");
Run(new[] { 0 }, new[] { 0 }, "[0]");
Run(new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 }, "[8,9,9,9,0,0,0,1]");

void Run(int[] first, int[] second, string expected)
{
    var result = solver.AddTwoNumbers(BuildList(first), BuildList(second));

    Console.WriteLine($"Wynik: {FormatList(result)}");
    Console.WriteLine($"Oczekiwany: {expected}");
    Console.WriteLine();
}

ListNode BuildList(int[] values)
{
    ListNode? head = null;

    for (int i = values.Length - 1; i >= 0; i--)
    {
        head = new ListNode { val = values[i], next = head };
    }

    return head!;
}

string FormatList(ListNode? node)
{
    var values = new List<int>();

    while (node is not null)
    {
        values.Add(node.val);
        node = node.next;
    }

    return $"[{string.Join(",", values)}]";
}