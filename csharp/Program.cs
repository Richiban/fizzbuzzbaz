using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

var fizzbuzz = new NumberGame()
{
    { 3, "Fizz" },
    { 5, "Buzz" }
};

foreach (var x in fizzbuzz.Play(1,100))
{
    Console.WriteLine(x);
}

class NumberGame : IEnumerable<KeyValuePair<int, string>>
{
    private readonly Dictionary<int, string> _numbers = new();

    public void Add(int number, string word)
    {
        _numbers.Add(number, word);
    }

    public IEnumerable<string> Play(int start, int end)
    {
        for (var i = start; i <= end; i++)
        {
            var result = _numbers
                .Where(x => i % x.Key == 0)
                .Select(x => x.Value)
                .Aggregate((a, b) => a + b);

            yield return string.IsNullOrEmpty(result) ? i.ToString() : result;
        }
    }

    public IEnumerator<KeyValuePair<int, string>> GetEnumerator() =>
        _numbers.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}