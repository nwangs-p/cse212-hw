public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        List<int> result = new List<int>();
        int index1 = 0, index2 = 0;

        // Iterate through the selector array
        foreach (var selector in select)
        {
            // Selection based on selector value
            if (selector == 1)
            {
                result.Add(list1[index1]);
                index1++;
            }
            else if (selector == 2)
            {
                result.Add(list2[index2]);
                index2++;
            }
        }

        // Handle remaining elements
        while (index1 < list1.Length)
        {
            result.Add(list1[index1]);
            index1++;
        }

        while (index2 < list2.Length)
        {
            result.Add(list2[index2]);
            index2++;
        }

        // Convert result list to array
        return result.ToArray();
    }
}