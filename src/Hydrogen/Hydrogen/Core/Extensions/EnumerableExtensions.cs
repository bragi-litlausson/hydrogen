using System;
using System.Collections.Generic;

namespace Hydrogen.Core.Extensions;

public static class EnumerableExtensions
{
    public static void Foreach<T>(this IEnumerable<T> enumerable, Action<T> action)
    {
        foreach (var element in enumerable)
        {
            action?.Invoke(element);
        }
    }
}