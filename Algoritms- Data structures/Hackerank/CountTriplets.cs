using System.Numerics;

namespace Training;

public class CountTriplets
{
    static long countTriplets(List<long> arr, long r)
    {
        long count = 0;
        Dictionary<long, long> dictionary = new Dictionary<long, long>();

        foreach (var element in arr)
        {
            if (dictionary.TryGetValue(element, out long currentValue))
            {
                currentValue++;
                dictionary[element] = currentValue;
            }
            else
            {
                dictionary.Add(element, 1);
            }
        }

        HashSet<long> proccesedValues = new HashSet<long>();

        foreach (var test in arr)
        {
            if (proccesedValues.Contains(test))
            {
                continue;
            }

            long target = test * r;

            if (dictionary.TryGetValue(target, out long value))
            {
                if (target == test)
                {
                    BigInteger bigPart = Factorial(value - 3);


                    BigInteger abovePart = bigPart * (value - 2) * (value - 1) * value;
                    BigInteger belowPart = Factorial(3) * bigPart;

                    long result = (long)(abovePart / belowPart);


                    count += result;
                    proccesedValues.Add(test);
                    continue;
                }

                long secondTarget = test * r * r;
                if (dictionary.TryGetValue(secondTarget, out long secondValue))
                {
                    count += value * secondValue;
                }
            }
        }


        return count;
        
    }


    public static BigInteger Factorial(long f)
    {
        if (f == 0)
        {
            return 1;
        }


        return f * Factorial(f - 1);
    }

    /*public static void Main(string[] args)
    {
        countTriplets(
            new List<long>()
            {
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            }, 1);
    }*/
}