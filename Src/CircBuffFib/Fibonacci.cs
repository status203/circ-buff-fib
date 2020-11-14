using System.Collections.Generic;

namespace CircBuffFib
{
    public static class Fibonacci
    {
        public static IEnumerable<int> Sequence(int first, int second) {
            yield return first;
            yield return second;

            var buffer = new int[4];
            var mask = 0_11;
            buffer[0] = first;
            buffer[1] = second;

            var firstIndex = 0;

            while(true) {
                var index = firstIndex;
                var total = buffer[index];
                firstIndex = index = ++index & mask;
                total += buffer[index];
                index = ++index & mask;
                buffer[index] = total;
                yield return total;
            }
        }
    }
}