namespace b17
{
    using System;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static IEnumerable<T> Each<T>(this IEnumerable<T> collection, Action<T> action) { foreach (T item in collection) action(item); return collection; }
    }
}