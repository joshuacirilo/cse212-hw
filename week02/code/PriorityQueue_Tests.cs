using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Adding elements to the equeue 
    // Expected Result: all the items are add A,B,C
    // Defect(s) Found: I didnt find problems with this one 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 10);
        priorityQueue.Enqueue("C", 1);

        var expected = "[A (Pri:5), B (Pri:10), C (Pri:1)]";
        Assert.AreEqual(expected, priorityQueue.ToString());


    }

    [TestMethod]
    // Scenario: The Dequeue function shall remove the item with the highest priority and return its value.
    // Expected Result: B(Pri:10)
    // Defect(s) Found: The index start with 1 in the for but the index will always start in 0 also the program is not removing the priorty tasks, I needed to change that
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 10);
        priorityQueue.Enqueue("C", 1);

        var result = priorityQueue.Dequeue();


        Assert.AreEqual("B", result);


        var expected = "[A (Pri:5), C (Pri:1)]";
        Assert.AreEqual(expected, priorityQueue.ToString());

    }
    


       [TestMethod]
    // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
    // Expected Result: B(Pri:10)
    // Defect(s) Found: The index start with 1 in the for but the index will always start in 0 also the program is not removing the priorty tasks
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 10);
        priorityQueue.Enqueue("B", 10);
        priorityQueue.Enqueue("C", 10);

        var result = priorityQueue.Dequeue();


        Assert.AreEqual("A", result);


        var expected = "[B (Pri:10), C (Pri:10)]";
        Assert.AreEqual(expected, priorityQueue.ToString());
        
    }


}