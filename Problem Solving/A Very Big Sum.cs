public static long aVeryBigSum(List<long> ar)
{
    long sum = 0;
    foreach (var num in ar)
    {
        sum += num;
    }

    return sum;
}