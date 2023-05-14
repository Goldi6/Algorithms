using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class PQNode
    {
        public string val;
        public int priority;
        public PQNode(string val, int priority)
        {

            this.val = val;
            this.priority = priority;
             

        }
        public void Print()
        {
            
            Console.WriteLine("val: "+val+" p: "+priority);

        }

    }



    /// <summary>
    /// binary min heap is used to create the priority queue.
    /// binary min heap always has the lowest value at the top (0 index),
    /// when we add a value to the binary heap (if the value is grater) we start adding it to the left side of the parent and then to the right:
    /// ex: if we have 3 nodes, 1 at the base, 1 at the left side and one to the right side the fourth will go to the left side of the left child node, 
    /// the 5th will go to the left side of the right child node.


    /// </summary>
    internal class PriorityQueue_custom
    {


        public List<PQNode> values = new List<PQNode>();

        /// <summary>
        /// to encueue we first insert the new node to the and of the list then we bubble it up according to the priority value;
        /// to find the parent index we apply the folowing formula : Math.floor(nodeIndex / 2) then we compare the priority value for the current node and it's parent.
        /// if the parent is lower in priority we switch between the 2 nodes and check the next parent node.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="priority"></param>
        /// <returns>list of the queue</returns>
        public List<PQNode> Encueue(string val, int priority) {


            PQNode newNode = new PQNode(val, priority);


            values.Add(newNode);
            if (values.Count == 1) { return values; }

            int nodeIndex = values.Count - 1;
            int parentIndex = nodeIndex / 2;

            while (parentIndex >= 0 && values[parentIndex].priority > values[nodeIndex].priority)
            {

                values[nodeIndex] = values[parentIndex];
                values[parentIndex] = newNode;

                nodeIndex = parentIndex;
                parentIndex = nodeIndex / 2;

            }


            return values;

        }

        /// <summary>
        /// to decueue we take out the top priority value ( index 0 ) , then we must reorganize the queue, to do so:
        /// take out the last node and insert it to the 0 index, afterwards bubble it down to its proper place.
        /// to do so you compare the left and the right children of the current node then switch places with the lower value  that way the highest priority node will be at the top(higher in priority)
        /// </summary>
        /// <returns>highest priority value</returns>
        public PQNode? Decueue(){

            
            if (values.Count == 0) return null;


            PQNode highestPriority = values[0];


            if (values.Count == 1 || values.Count == 2)
            {
                values.Remove(highestPriority);
                return highestPriority;
            }

            


            PQNode lastNode = values[values.Count - 1];
            values.Remove(highestPriority);
            values.Remove(lastNode);
            values.Insert(0, lastNode);

            int leftPointer , rightPointer ;
            PQNode? leftNode , rightNode;

            void updatePointers (int index)
            {

                leftPointer = index * 2 + 1;
                rightPointer = index * 2 + 2;

                 leftNode = leftPointer<values.Count ? values[leftPointer] : null;
                 rightNode = rightPointer<values.Count ? values[rightPointer] : null;
            }

            int index = 0;
            updatePointers(index);

            while (leftNode !=null && (lastNode.priority >= leftNode.priority || (rightNode != null && lastNode.priority >= rightNode.priority)))
            {


                if (rightNode != null && rightNode.priority < leftNode.priority) {
                    values[index] = rightNode;
                    values[rightPointer] = lastNode;
                    index = rightPointer;

                }
                else
                {
                    values[index] = leftNode;
                    values[leftPointer] = lastNode;
                    index = leftPointer;
                }
                updatePointers(index);
            }






            return highestPriority;
        }

        public void Print()
        {
            string arrString="";

            foreach (PQNode node in values) {
            arrString += "[ p: " + node.priority +" , val: " + node.val + " ] ," ; 
            
            }


            Console.WriteLine(arrString);
        }
        
    }
}
