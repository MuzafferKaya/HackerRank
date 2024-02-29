public static List<int> compareTriplets(List<int> a, List<int> b)
{
    List<int> result = new List<int>();
    result.Add(0);
    result.Add(0);
    for (int i = 0; i <= 2; i++)
    {
        if (a[i] > b[i])
        {
            result[0]++;
        }
        else if (a[i] < b[i])
        {
            result[1]++;
        }
    }

    return result;
}