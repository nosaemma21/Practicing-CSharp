
var numbers = new[] { 1, 4, 2, -5, 6, -2, 1 };
foreach (var number in GetBeforeFirstNegative(numbers))
{
    Console.WriteLine(number);
}

Console.ReadKey();

IEnumerable<int> GetBeforeFirstNegative(IEnumerable<int> input)
{
    foreach (var number in input)
    {
        if (number >= 0)
        {
            yield return number;
        }
    }
}
