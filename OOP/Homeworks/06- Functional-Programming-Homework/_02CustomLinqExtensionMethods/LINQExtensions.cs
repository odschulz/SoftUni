using System;
using System.Collections.Generic;
using System.Linq;

public static class LINQExtensions
{
    public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate) 
    {
        return collection.Where(e => !predicate(e));
    }

    public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
    {
        List<T> result = new List<T>();
        for (int i = 0; i < count; i++)
        {
            result.AddRange(collection);
        }

        return result as IEnumerable<T>;
    }

    public static IEnumerable<string> WhereEndsWith(
        this IEnumerable<string> collection, IEnumerable<string> suffixes)
    {
        List<string> result = new List<string>();
        foreach (var item in collection)
        {
            foreach (var suffix in suffixes)
            {
                // second parameter ignores case, third defines to use current CultureInfo
                if (item.EndsWith(suffix, true, null)) 
                {
                    result.Add(item);
                    break; // break the operation so that we don't get word repetition in same-suffix cases
                }
            }
        }

        return result as IEnumerable<string>;
    }
}