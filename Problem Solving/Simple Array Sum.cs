public static int simpleArraySum(List<int> ar)
{
    int sum = 0;
    foreach (var num in ar)
    {
        sum += num;
    }
        
    return sum;
}
