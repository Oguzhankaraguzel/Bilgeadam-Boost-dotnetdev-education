// See https://aka.ms/new-console-template for more information
IEnumerable<int> numbers = Enumerable.Range(1, 10);
IEnumerable<string> stringNumbers = numbers.MySelect(x => x);

foreach (string number in stringNumbers)
{
    Console.WriteLine(number);
}

public static class MyExtensions
{
    public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
    {
        foreach (TSource item in source)
        {
            yield return selector(item);
        }
    }
}


