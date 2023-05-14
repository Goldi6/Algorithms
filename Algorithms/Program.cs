using Algorithms;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;


//--------  PRIORITY QUEUE--------

//PriorityQueue_custom pq = new PriorityQueue_custom();

//pq.Encueue("task1", 3);
//pq.Encueue("task2", 4);
//pq.Encueue("task3", 1);
//pq.Encueue("task4", 6);
//pq.Encueue("task5", 2);
//pq.Encueue("task6", 1);
//pq.Print();
//Console.WriteLine("decueue:");

//pq.Decueue().Print();
//pq.Decueue().Print();

//pq.Decueue().Print();


//pq.Print();



////C# has a PriorityQueue Class built in:

//PriorityQueue<string, int> cpq = new PriorityQueue<string, int>();
//cpq.Enqueue("t1", 5);
//cpq.Enqueue("t2", 3);
//cpq.Enqueue("t3", 6);
//cpq.Enqueue("t4", 1);
//cpq.Enqueue("t5", 2);
//cpq.Enqueue("t6", 4);

//Console.WriteLine(cpq.Peek());
//cpq.Dequeue();
//Console.WriteLine(cpq.Peek());




//--------QUICK SORT--------


void printArray(int[] arr)
{

    string[] sArr = Array.ConvertAll(arr, ( el) => el.ToString());


    Console.WriteLine(string.Join(", ", sArr));

};

int[] arr = { 5, 7, 3, 1, 8, 34, 23, 4, 22 };
int[] arr2 = { 5, 7, 3 };

printArray(QuickSort.Sort(arr));
