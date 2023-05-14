using Algorithms;
using System.Collections.Generic;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {


        PriorityQueue_custom pq = new PriorityQueue_custom();

        pq.Encueue("task1", 3);
        pq.Encueue("task2", 4);
        pq.Encueue("task3", 1);
        pq.Encueue("task4", 6);
        pq.Encueue("task5", 2);
        pq.Encueue("task6", 1);
        pq.Print();
        Console.WriteLine("decueue:");

        pq.Decueue().Print();
        pq.Decueue().Print();

        pq.Decueue().Print();


        pq.Print();



        //C# has a PriorityQueue Class built in:

        PriorityQueue<string, int> cpq = new PriorityQueue<string, int>();
        cpq.Enqueue("t1", 5);
        cpq.Enqueue("t2", 3);
        cpq.Enqueue("t3", 6);
        cpq.Enqueue("t4", 1);
        cpq.Enqueue("t5", 2);
        cpq.Enqueue("t6", 4);

        Console.WriteLine(cpq.Peek());
        cpq.Dequeue();
        Console.WriteLine(cpq.Peek());
    }
}