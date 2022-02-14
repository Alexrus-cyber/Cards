using System;
using System.Collections.Generic;
using System.Linq;


namespace Cards
{
    public static class Extensions
    {
        public static bool SequenceEquals<T>
    (this IEnumerable<T> first, IEnumerable<T> second)
        {
            var firstIter = first.GetEnumerator();
            var secondIter = second.GetEnumerator();

            while (firstIter.MoveNext() && secondIter.MoveNext())
            {
                if (!firstIter.Current.Equals(secondIter.Current))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
