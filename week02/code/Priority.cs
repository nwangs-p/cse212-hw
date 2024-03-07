public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add values with different priorities and dequeue
        // Expected Result: Items should be dequeued based on their priorities
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Item1", 2);
        priorityQueue.Enqueue("Item2", 1);
        priorityQueue.Enqueue("Item3", 3);
        Console.WriteLine($"Dequeued: {priorityQueue.Dequeue()}");  // Expected: Item3
        Console.WriteLine($"Dequeued: {priorityQueue.Dequeue()}");  // Expected: Item1
        Console.WriteLine($"Dequeued: {priorityQueue.Dequeue()}");  // Expected: Item2

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Try to dequeue from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 2");
        Console.WriteLine($"Dequeued: {priorityQueue.Dequeue()}");  // Expected: Error message

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Add values with the same priority and dequeue
        // Expected Result: Items should be dequeued in FIFO order when priorities are equal
        Console.WriteLine("Test 3");
        priorityQueue.Enqueue("ItemA", 1);
        priorityQueue.Enqueue("ItemB", 1);
        priorityQueue.Enqueue("ItemC", 1);
        Console.WriteLine($"Dequeued: {priorityQueue.Dequeue()}");  // Expected: ItemC
        Console.WriteLine($"Dequeued: {priorityQueue.Dequeue()}");  // Expected: ItemB
        Console.WriteLine($"Dequeued: {priorityQueue.Dequeue()}");  // Expected: ItemA

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}